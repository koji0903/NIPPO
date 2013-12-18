using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NIPPO
{
    public class DailyReport : IDisposable
    {
        /// <summary>
        /// 表示用の年月日曜日文字列を作成
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>YYYY年MM月DD日(曜日)</returns>
        public String GetDateStr(int year, int month, int day)
        {
            string str;
            // 無効な数値が入力された場合の例外処理対策
            try
            {
                DateTime dateValue = new DateTime(year, month, day);
                str = String.Format("{0:D4}年{1:D2}月{2:D2}日({3})", year, month, day, dateValue.ToString("ddd"));
            }
            catch
            {
                str = String.Format("{0:D4}年{1:D2}月{2:D2}日({3})", year, month, day, "無効な年月日");
            }
            return str;
        }

        /// <summary>
        /// 開始時間・終了時間から勤務時間を計算する
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="start_hour"></param>
        /// <param name="start_second"></param>
        /// <param name="end_hour"></param>
        /// <param name="end_second"></param>
        /// <returns></returns>
        public String[] GetWorkTime(int start_hour, int start_second, int end_hour, int end_second)
        {
            string str;

            // [0] : 勤務時間（（勤務終了時間-勤務開始時間）- 休憩時間）
            // [1] : 休憩時間（12:00～13:00, 17:30～18:00）
            // [2] : 普通残業時間 (05:00～08:45, 18:00～22:00)
            // [3] : 深夜残業時間 (22:00～05:00)
            String[] time = new String[4];

            // ユーザ入力の勤務時間
            str = String.Format("{0:D2}:{1:D2}:00", start_hour, start_second);
            DateTime start_time = DateTime.Parse(str);
            str = String.Format("{0:D2}:{1:D2}:00", end_hour, end_second);
            DateTime end_time = DateTime.Parse(str);


            // 休憩時間の計算(2つあるのでまずは分で計算する)
            TimeSpan rt = cal_target_time(start_time, end_time, DateTime.Parse("12:00:00"), DateTime.Parse("13:00:00"));
            rt += cal_target_time(start_time, end_time, DateTime.Parse("17:30:00"), DateTime.Parse("18:00:00"));

            // 勤務時間
            TimeSpan ts = end_time - start_time - rt;

            // 普通残業時間
            TimeSpan normal_ot = cal_target_time(start_time, end_time, DateTime.Parse("05:00:00"), DateTime.Parse("08:45:00"));
            normal_ot += cal_target_time(start_time, end_time, DateTime.Parse("18:00:00"), DateTime.Parse("22:00:00"));

            // 深夜残業時間
            TimeSpan night_ot = cal_target_time(start_time, end_time, DateTime.Parse("22:00:00"), DateTime.Parse("05:00:00"));

            // 各項目の時間を配列にセット
            string work_time, rest_time, normal_overtime, night_overtime;
            work_time = cal_second_to_hour(ts);
            rest_time = cal_second_to_hour(rt);
            normal_overtime = cal_second_to_hour(normal_ot);
            night_overtime = cal_second_to_hour(night_ot);


            time[0] = work_time;
            time[1] = rest_time;
            time[2] = normal_overtime;
            time[3] = night_overtime;
            return time;
        }

        /// <summary>
        /// 分の数値から時間の割合を求める
        /// </summary>
        /// <param name="time">分情報</param>
        /// <returns>時間の割合</returns>
        private String cal_second_to_hour( TimeSpan ts )
        {
            String hour = ts.ToString("%h");
            String second = ts.ToString(@"mm");
            String rate;
            switch (second)
            {
                case "00":
                    rate = "00";
                    break;
                case "15":
                    rate = "25";
                    break;
                case "30":
                    rate = "50";
                    break;
                case "45":
                    rate = "75";
                    break;
                default:
                    rate = "00";
                    break;
            }
            return hour + "." + rate + "h";
        }

        /// <summary>
        /// 特定区分（休憩、普通残業、深夜残業）の時間の計算。（区分の割り当て時間定義されており、その範囲に入っていた場合はカウント）
        /// </summary>
        /// <param name="start_time">勤務開始時間</param>
        /// <param name="end_time">勤務終了時間</param>
        /// <param name="rest_start_time">休憩開始時間</param>
        /// <param name="rest_end_time">休憩終了時間</param>
        /// <returns>時間範囲</returns>
        private TimeSpan cal_target_time(DateTime start_time, DateTime end_time, DateTime target_start_time, DateTime target_end_time)
        {
            TimeSpan ts = new TimeSpan();

            if ((start_time <= target_start_time) && ( target_end_time <= end_time ))
            {
                ts = target_end_time - target_start_time;
            }

            return ts;
        }


        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}
