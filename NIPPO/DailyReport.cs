using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace NIPPO
{
    public class DailyReport : IDisposable
    {
        // 前のウィンドウからの引き付き情報
        public int fy  { 
            get; 
            private set;
        }
        public int year { 
            get; 
            private set;
        }
        public int month { 
            get; 
            private set;
        }
        public int day { 
            get; 
            private set;
        }
        public int userID { 
            get; 
            private set;
        }
        // 時間比較用のデータ
        public double work_time {
            get;
            set;
        }
        public double regist_time{
            get;
            set;
        }
        // 上部表示用
        public Double[] time{
            get;
            private set;
        }
        // 業務詳細に表示されているプロジェクト、業務のデータベースID
        public int project_ID
        {
            get;
            set;
        }
        public int task_ID
        {
            get;
            set;
        }
        // work_detailテーブル情報
        public DataSet ds
        {
            get;
            set;
        }
        private DataSet ds_org;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DailyReport(int fy, int userID, int year, int month, int day)
        {
            this.fy = year;
            this.userID = userID;
            this.year = year;
            this.month = month;
            this.day = day;

            // 勤務時間（比較用）
            this.work_time = 7.75;
            // 作業登録時間（比較用）
            this.regist_time = 0.0;
            time = new Double[] { 0.00, 0.00, 0.00, 0.00 };
            this.project_ID = 0;
            this.task_ID = 0;
            DataSet ds = new DataSet();
        }

        public DataSet makeDataSet()
        {
            // データベースへのアクセス
            using (DataAccessClass data_access = new DataAccessClass())
            {
                // work_detailテーブルの作成
                this.ds = data_access.GetWorkDetailDs(this.userID, this.year, this.month, this.day);
                // work_reportsテーブルの作成
                this.ds.Merge(data_access.GetWorkReportsDS(this.userID, this.year, this.month, this.day));
                // 更新時の比較用に初期時のデータをコピー
                this.ds_org = this.ds.Copy();
            }
            return this.ds;
        }

        
        /// <summary>
        /// 表示用の年月日曜日文字列を作成
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>YYYY年MM月DD日(曜日)</returns>
        public String GetDateStr()
        {
            string str;
            // 無効な数値が入力された場合の例外処理対策
            try
            {
                DateTime dateValue = new DateTime(this.year, this.month, this.day);
                str = String.Format("{0:D4}年{1:D2}月{2:D2}日({3})", this.year, this.month, this.day, dateValue.ToString("ddd"));
            }
            catch
            {
                str = String.Format("{0:D4}年{1:D2}月{2:D2}日({3})", this.year, this.month, this.day, "無効な年月日");
            }
            return str;
        }

        /// <summary>
        /// DateTime用の文字列を作成
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="hour">時</param>
        /// <param name="second">分</param>
        /// <returns>DateTime指定用の文字列</returns>
        public String getTime(int year, int month, int day, int hour, int second)
        {
            if (hour < 24)
            {
                // 24時まで
                return String.Format("{0:D4}/{1:D2}/{2:D2} {3:D2}:{4:D2}:00", year, month, day, hour, second);
            }
            else
            {
                // 24時以降（次の日）
                return String.Format("{0:D4}/{1:D2}/{2:D2} {3:D2}:{4:D2}:00", year, month, day+1, hour-24, second);
            }
        }

        /// <summary>
        /// work_detail/work_reportsテーブルの更新
        /// </summary>
        /// <param name="ds">データセット　</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <param name="time">管理時間</param>
        /// <param name="sh">開始時</param>
        /// <param name="ss">開始分</param>
        /// <param name="eh">終了時</param>
        /// <param name="es">終了分</param>
        public void updateDailyWork(String sh, String ss, String eh, String es)
        {
            using (DataAccessClass data_access = new DataAccessClass())
            {
                data_access.Update(this.ds, "work_detail");
                // データベース（work_report）更新作業
                try
                {
                    // データテーブルの作成
                    DataTable dt = this.ds.Tables["work_reports"];
                    DataRow dr = dt.Rows[0];
                    dr["start_time"] = this.getTime(year, month, day, int.Parse(sh), int.Parse(ss));
                    dr["end_time"] = this.getTime(year, month, day, int.Parse(eh), int.Parse(es));
                    dr["work_times"] = this.time[0];
                    dr["overtime125"] = this.time[2];
                    dr["overtime150"] = this.time[3];
                    dr["rest_time"] = this.time[1];
                    // データベースへの更新作業
                    data_access.Update(this.ds, "work_reports");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// 日報入力ウィンドウの上部右（勤務時間、休憩時間、通常残業、深夜残業）
        /// に表示する値を計算するメソッド
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="sh"></param>
        /// <param name="ss"></param>
        /// <param name="eh"></param>
        /// <param name="es"></param>
        /// <returns></returns>
        public Double[] GetWorkTime_str(String sh, String ss, String eh, String es)
        {
            // 勤務時間の計算
            return this.GetWorkTime(
                int.Parse(sh),
                int.Parse(ss),
                int.Parse(eh),
                int.Parse(es)
            );
        }


        /// <summary>
        /// 有効な次の日の文字列を返す
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public String getValidNextDate( int year, int month, int day )
        {
            String str = "";
            if (this.IsDate(year, month, day + 1))
            {
                // 次の日
                str = String.Format("{0:D4}/{1:D2}/{2:D2}", year, month, day + 1);
            }
            else
            {
                // 翌月の1日
                if (this.IsDate(year, month + 1, 1))
                {
                    str = String.Format("{0:D4}/{1:D2}/{2:D2}", year, month + 1, 1);
                }
                else
                {
                    str = String.Format("{0:D4}/{1:D2}/{2:D2}", year+1, 1, 1);
                }
            }
            return str;
        }

        /// <summary>
        /// 有効な日であるかどうかの判定
        /// </summary>
        /// <param name="iYear"></param>
        /// <param name="iMonth"></param>
        /// <param name="iDay"></param>
        /// <returns></returns>
        private bool IsDate(int iYear, int iMonth, int iDay)
        {
            if ((DateTime.MinValue.Year > iYear) || (iYear > DateTime.MaxValue.Year))
            {
                return false;
            }

            if ((DateTime.MinValue.Month > iMonth) || (iMonth > DateTime.MaxValue.Month))
            {
                return false;
            }

            int iLastDay = DateTime.DaysInMonth(iYear, iMonth);

            if ((DateTime.MinValue.Day > iDay) || (iDay > iLastDay))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 開始時間・終了時間から勤務時間を計算する
        /// </summary>
        /// <param name="start_hour"></param>
        /// <param name="start_second"></param>
        /// <param name="end_hour"></param>
        /// <param name="end_second"></param>
        /// <returns></returns>
        public Double[] GetWorkTime(int start_hour, int start_second, int end_hour, int end_second)
        {
            string str;

            // [0] : 勤務時間（（勤務終了時間-勤務開始時間）- 休憩時間）
            // [1] : 休憩時間（12:00～13:00, 17:30～18:00）
            // [2] : 普通残業時間 (05:00～08:45, 18:00～22:00)
            // [3] : 深夜残業時間 (22:00～05:00)
            double[] times = new double[4];
            string base_day = String.Format("{0:D4}/{1:D2}/{2:D2}", this.year, this.month, this.day);
            string target_day = String.Format("{0:D4}/{1:D2}/{2:D2}", this.year, this.month, this.day);
            string next_day_start = String.Format("{0} 00:00:00", this.getValidNextDate(this.year,this.month,this.day));

            // 残業が次の日まで持ち越した場合は、日にち、時間調整
            if (end_hour >= 24)
            {
                target_day = this.getValidNextDate(this.year, this.month, this.day);
                end_hour -= 24;
            }

            // ユーザ入力の勤務時間
            str = String.Format("{0} {1:D2}:{2:D2}:00", base_day, start_hour, start_second);
            DateTime start_time = DateTime.Parse(str);
            str = String.Format("{0} {1:D2}:{2:D2}:00", target_day, end_hour, end_second);
            DateTime end_time = DateTime.Parse(str);

            // 休憩時間の計算(2つあるのでまずは分で計算する)
            TimeSpan rt = cal_rest_time(start_time, end_time, DateTime.Parse(base_day + " 12:00:00"), DateTime.Parse(base_day + " 13:00:00"));
            rt += cal_rest_time(start_time, end_time, DateTime.Parse(base_day + " 17:30:00"), DateTime.Parse(base_day + " 18:00:00"));

            // 勤務時間
            TimeSpan wt = end_time - start_time - rt;

            // Lost Time (通常勤務の8:45以降から勤務をスタートした場合）
            TimeSpan lost_time = new TimeSpan(0,0,0);
            if (start_time > DateTime.Parse(base_day + " 08:45:00"))
            {
                // 12時前出社
                if (start_time < DateTime.Parse(base_day + " 12:00:00"))
                {
                    lost_time = start_time - DateTime.Parse(base_day + " 08:45:00");
                }
                // 12時～13時出社
                else
                {
                    lost_time =  DateTime.Parse(base_day + " 12:00:00")　- DateTime.Parse(base_day + " 08:45:00");
                }
            }

            // 普通・深夜残業時間
            TimeSpan[] early_ot = cal_early_overtime(start_time, end_time, DateTime.Parse(base_day + " 05:00:00"), DateTime.Parse(base_day + " 08:45:00"));
            TimeSpan[] late_ot = cal_late_overtime(start_time, end_time, DateTime.Parse(base_day + " 18:00:00"), DateTime.Parse(base_day + " 22:00:00"), DateTime.Parse(next_day_start), wt, lost_time);

            // 深夜残業時間
//            TimeSpan night_ot = cal_target_time(start_time, end_time, DateTime.Parse("05:00:00"), DateTime.Parse("22:00:00"));

            // 各項目の時間を配列にセット
            double work_time, rest_time, normal_overtime, night_overtime;
            work_time = cal_second_to_hour(wt);
            rest_time = cal_second_to_hour(rt);
            normal_overtime = cal_second_to_hour(early_ot[0] + late_ot[0]);
            night_overtime = cal_second_to_hour(early_ot[1] + late_ot[1]);

            times[0] = work_time;
            times[1] = rest_time;
            times[2] = normal_overtime;
            times[3] = night_overtime;
            return times;
        }

        /// <summary>
        /// 分の数値から時間の割合を求める
        /// </summary>
        /// <param name="time">分情報</param>
        /// <returns>時間の割合</returns>
        private double cal_second_to_hour( TimeSpan ts )
        {
            String hour = ts.ToString("%h");
            String second = ts.ToString(@"mm");
            return double.Parse(hour) + double.Parse(second) / 60;
        }

        /// <summary>
        /// 特定区分（8:45より前の普通残業、深夜残業）の時間の計算。（区分の割り当て時間定義されており、その範囲に入っていた場合はカウント）
        /// </summary>
        /// <param name="start_time">勤務開始時間</param>
        /// <param name="end_time">勤務終了時間</param>
        /// <param name="rest_start_time">休憩開始時間</param>
        /// <param name="rest_end_time">休憩終了時間</param>
        /// <returns>時間範囲</returns>
        private TimeSpan[] cal_early_overtime(DateTime start_time, DateTime end_time, DateTime target_start_time, DateTime target_end_time)
        {
            TimeSpan[] ts = new TimeSpan[2];

            TimeSpan normal_ts = new TimeSpan();
            TimeSpan night_ts = new TimeSpan();

            if (start_time < target_start_time)
            {
                // 深夜残業(出勤開始時刻から普通残業開始時刻(05:00)まで)
                if (end_time <= target_end_time)
                {
                    // 深夜残業中に帰宅した場合
                    night_ts = start_time - end_time;                    
                }
                else
                {
                    // 通常残業以降まで業務継続
                    night_ts = target_start_time - start_time;
                }

                // 普通残業（05:00以降の業務）
                if (end_time <= target_end_time)
                {
                    // 終了時刻 - 普通残業開始時刻(18:00)
                    normal_ts = end_time - target_start_time;
                }
            }
            else if ( start_time < target_end_time )
            {
                // 普通残業
                if (end_time <= target_end_time)
                {
                    // 通常勤務前に終了
                    normal_ts = end_time - start_time;
                }
                else
                {
                    // 通常勤務まで
                    normal_ts = target_end_time - start_time;
                }
            }

            ts[0] = normal_ts;
            ts[1] = night_ts;
            return ts;
        }

        /// <summary>
        /// 特定区分（普通残業、深夜残業）の時間の計算。（区分の割り当て時間定義されており、その範囲に入っていた場合はカウント）
        /// </summary>
        /// <param name="start_time">勤務開始時間</param>
        /// <param name="end_time">勤務終了時間</param>
        /// <param name="rest_start_time">休憩開始時間</param>
        /// <param name="rest_end_time">休憩終了時間</param>
        /// <returns>時間範囲</returns>
        private TimeSpan[] cal_late_overtime(DateTime start_time, DateTime end_time, DateTime target_start_time, DateTime target_end_time, DateTime next_day_start, TimeSpan wt, TimeSpan lost_time)
        {
            TimeSpan[] ts = new TimeSpan[2];

            TimeSpan normal_ts = new TimeSpan();
            TimeSpan night_ts = new TimeSpan();

            //TimeSpan offset = new TimeSpan(1, 15, 0); // 1:15
            //TimeSpan zero_time = new TimeSpan(0, 0, 0);
            TimeSpan work_base = new TimeSpan(7, 45, 0); // 7:45時間

            // 普通残業だけで終了
            if (end_time <= target_end_time)
            {
                if (end_time >= target_start_time)
                {
                    // 終了時刻 - 普通残業開始時刻(18:00)
                    // 勤務時間が7時間45分より多い場合のみカウント
                    int result = TimeSpan.Compare(wt, work_base);
                    if (result > 0)
                    {
                        normal_ts = wt - work_base;
                    }
                }
            }
            else // 深夜残業まで
            {
                // 普通残業と深夜残業
                normal_ts = target_end_time - target_start_time - lost_time;
                // 深夜残業は、22:00 以降＋0時から終わりまで。
                TimeSpan night_time = new TimeSpan(2, 0, 0); // 2時間
                night_ts = night_time + (end_time - next_day_start);
            }

            ts[0] = normal_ts;
            ts[1] = night_ts;
            return ts;
        }

        /// <summary>
        /// 特定区分（休憩、普通残業、深夜残業）の時間の計算。（区分の割り当て時間定義されており、その範囲に入っていた場合はカウント）
        /// </summary>
        /// <param name="start_time">勤務開始時間</param>
        /// <param name="end_time">勤務終了時間</param>
        /// <param name="rest_start_time">休憩開始時間</param>
        /// <param name="rest_end_time">休憩終了時間</param>
        /// <returns>時間範囲</returns>
        private TimeSpan cal_rest_time(DateTime start_time, DateTime end_time, DateTime target_start_time, DateTime target_end_time)
        {
            TimeSpan ts = new TimeSpan();

            if ((start_time <= target_start_time) && (target_end_time <= end_time))
            {
                ts = target_end_time - target_start_time;
            }
            else if (( start_time  > target_start_time ) && ( start_time < target_end_time ))
            {
                // 午後休
                ts = target_end_time - start_time;
            }
            else if ((end_time > target_start_time) && (end_time < target_end_time))
            {
                // 午前休
                ts = end_time - target_start_time;
            }

            return ts;
        }

        /// <summary>
        /// 業務詳細に設定された集合時間の合計時間を計算する
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public double getTotalWorkTime()
        {
            Double total_work_time;
            total_work_time = 0;
            DataTable work_detail = this.ds.Tables["work_detail"];
            if (work_detail == null)
            {
                // 初期登録時は何も登録されていないので0を返す。
                return 0;
            }
            foreach (DataRow drCurrent in work_detail.Rows)
            {
                object tmp = drCurrent["times"];
                if (tmp != null && tmp.GetType() == typeof(Double))
                {
                    total_work_time += (double)drCurrent["times"];
                }
            }
            this.regist_time = total_work_time;
            return regist_time;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="delete_num"></param>
        /// <returns></returns>
        public DataSet deleteRow(int delete_num )
        {
            int j = 0;
            for (int i = 0; i < this.ds.Tables["work_detail"].Rows.Count; i++)
            {
                // Deletedフラグが立っていない列をサーチ。立っているものは既に削除済みであるのでカウントスキップ
                if (this.ds.Tables["work_detail"].Rows[i].RowState != DataRowState.Deleted)
                {
                    // 削除されていない
                    if (delete_num == j)
                    {
                        // データ削除（実際はデータが消えるのではなくて、Deletedフラグがセットされる）
                        this.ds.Tables["work_detail"].Rows[i].Delete();
                        return this.ds;
                    }
                    j++;
                }
            }
            return this.ds;
        }

        /// <summary>
        /// DataSetの比較を行います。
        /// </summary>
        /// <param name="ds1"> DataSet1</param>
        /// <param name="ds2"> DataSet2</param>
        /// < returns> true:同じ false:異なる</returns>
        public bool DataSetCompare(String table_name)
        {
            DataTable dt1, dt2;
            dt1 = ds.Tables[table_name];
            dt2 = ds_org.Tables[table_name];

            if (dt1 == null && dt2 != null) { return false; }
            if (dt1 != null && dt2 == null) { return false; }
            if (dt1 == null && dt2 == null) { return true; }
            if (dt1.Rows.Count != dt2.Rows.Count) { return false; }

            for (int row = 0; row < dt2.Rows.Count; row++)
            {
                for (int col = 0; col < dt2.Columns.Count; col++)
                {
                    // 削除ライン
                    if (dt1.Rows[row].RowState == DataRowState.Deleted)
                    {
                        return false;
                    }

                    if (!dt1.Rows[row][col].Equals(dt2.Rows[row][col]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String timeCompare()
        {
            double t1 = this.work_time;
            double t2 = this.regist_time;

            String message = "";
            if (t1 > t2)
            {
                return "作業時間の割り当てが不足しています";
            }
            else if (t2 > t1)
            {
                return "作業時間が勤務時間を超えています";
            }
            else
            {
                return message;
            }
        }

        /// <summary>
        /// Double変数を表示用の文字列に変換(2.00 -> 2.00h)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public String setHourText(double s)
        {
            return s.ToString("F2") + "h";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sh"></param>
        /// <param name="ss"></param>
        /// <param name="eh"></param>
        /// <param name="es"></param>
        /// <returns></returns>
        public bool judgementTime(int sh, int ss, int eh, int es)
        {
            double start_time = (double)(sh + ((double)ss / 60));
            double end_time = (double)(eh + ((double)es / 60));
            if (start_time < end_time)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// 日報ウィンドウに表示する時間（勤務時間、休憩時間、通常残業、深夜残業）
        /// の初期値を決定するメソッド。初期値は全て０。既に登録済みの場合は、その値を使用
        /// </summary>
        /// <returns></returns>
        public String[] initialWorkTime()
        {
            DataSet ds = this.makeDataSet();
            String[] work_time = new String[4] { "8", "45", "17", "30" };

            // 勤務情報の初期値設定
            if (ds.Tables["work_reports"].Rows.Count == 1)
            {
                object tmp = ds.Tables["work_reports"].Rows[0]["start_time"];
                if (tmp != null && tmp.GetType() == typeof(DateTime))
                {
                    DateTime start_time = (DateTime)ds.Tables["work_reports"].Rows[0]["start_time"];
                    work_time[0] = start_time.ToString("%H");
                    work_time[1] = start_time.ToString("%m");

                }
                tmp = ds.Tables["work_reports"].Rows[0]["end_time"];
                if (tmp != null && tmp.GetType() == typeof(DateTime))
                {
                    DateTime end_time = (DateTime)ds.Tables["work_reports"].Rows[0]["end_time"];
                    work_time[2] = end_time.ToString("%H");
                    work_time[3] = end_time.ToString("%m");

                }
            }
            return work_time;
        }

        /// <summary>
        /// ADDボタンが押された時のアクション
        /// </summary>
        /// <param name="project_name"></param>
        /// <param name="task_name"></param>
        /// <param name="description"></param>
        /// <param name="worktime"></param>
        public void add_action(String project_name, String task_name, String description, String worktime )
        {
            bool same_data = false;
            // 業務詳細の枠から必要な情報を取得して、データセットを更新
            DataTable dt = this.ds.Tables["work_detail"];
            // 既存に同じデータがないかどうかをチェック
            foreach (DataRow drCurrent in dt.Rows)
            {
                if ((project_name == (string)drCurrent["name"])
                    && (task_name == (string)drCurrent["name1"])
                    )
                {
                    same_data = true;
                }
            }

            if (same_data)
            {
                // メッセージウィンドウを表示してアクションキャンセル
                DialogResult result = MessageBox.Show(
                    "既に同等の業務詳細(同じプロジェクト、業務）が登録されています。異なる業務詳細を指定してください。",
                    "メッセージ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);

            }
            else
            {
                // 新規データテーブル作成
                DataRow dr = dt.NewRow();
                dr["name"] = project_name;
                dr["name1"] = task_name;
                dr["note"] = description;
                dr["times"] = work_time;
                dr["projects_ID"] = this.project_ID;
                dr["tasks_ID"] = this.task_ID;
                using (DataAccessClass data_access = new DataAccessClass())
                {
                    dr["work_reports_ID"] = data_access.GetWorkReportID(this.userID, this.year, this.month, this.day);
                }

                if ((double)dr["times"] % 0.25 != 0.00)
                {
                    // メッセージウィンドウを表示してアクションキャンセル
                    DialogResult result = MessageBox.Show(
                        "業務詳細の時間には0.25刻みの値しか入力することができません",
                        "メッセージ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2);
                }
                else if ((string)dr["name"] != "" && (string)dr["name1"] != "" && (double)dr["times"] > 0.0)
                {
                    // データセット更新
                    dt.Rows.Add(dr);
                }
                else
                {
                    // 入力情報不足の場合のワーニングメッセージ出力
                    // 動作としては”OK”ボタンを押して、元の画面に戻る
                    DialogResult result = MessageBox.Show(
                        "入力情報が不足しています。",
                        "ワーニング",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);
                }
            }
        }

        public DialogResult regist_action(String start_hour, String start_second, String end_hour, String end_second)
        {
            // データベースへの更新作業
            DialogResult time_cmp = DialogResult.OK;
            DialogResult result = DialogResult.None;

            // 勤務時間と、作業割り当て時間の割り振りチェック
            String ret = this.timeCompare();
            if (ret != "")
            {
                // 割り振り不十分なときは、確認ウィンドウ表示（OK/Cancel）
                // OK -> 先に進む、　Cancel：元の画面に戻る
                time_cmp = MessageBox.Show(
                    ret,
                    "メッセージ",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }


            if (time_cmp != DialogResult.Cancel)
            {
                // データベース更新
                this.updateDailyWork(
                    start_hour,
                    start_second,
                    end_hour,
                    end_second
                    );

                // 更新確認用ウィンドウ出力
                result = MessageBox.Show(
                    "日報情報を更新しました。",
                    "実行完了",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
            }
            return result;
        }

        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}
