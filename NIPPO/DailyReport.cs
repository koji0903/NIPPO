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
        public String[] GetWorkTime(int year, int month, int day, int start_hour, int start_second, int end_hour, int end_second)
        {
            // [0] : 勤務時間（（勤務終了時間-勤務開始時間）- 休憩時間）
            // [1] : 休憩時間（12:00～13:00, 17:30～18:00）
            // [2] : 普通残業時間 (05:00～08:45, 18:00～22:00)
            // [3] : 深夜残業時間 (22:00～05:00)
            String[] time = new String[4];

            // ユーザ入力の勤務時間
            DateTime start_time = new DateTime(year, month, day, start_hour, start_second, 0);
            DateTime end_time = new DateTime(year, month, day, end_hour, end_second, 0);

            // 休憩時間1(12:00-13:00)
            DateTime rest1_start_time = new DateTime(year, month, day, 12, 0, 0);
            DateTime rest1_end_time = new DateTime(year, month, day, 13, 0, 0);

            // 休憩時間2(17:30-18:00)
            DateTime rest2_start_time = new DateTime(year, month, day, 17, 30, 0);
            DateTime rest2_end_time = new DateTime(year, month, day, 18, 0, 0);

            // 休憩時間の計算(2つあるのでまずは分で計算する)
            TimeSpan rt = cal_rest_time(start_time, end_time,rest1_start_time,rest1_end_time);
            rt += cal_rest_time(start_time, end_time, rest2_start_time, rest2_end_time);

            // 勤務時間
            TimeSpan ts = end_time - start_time - rt;


            // 各項目の時間を配列にセット
            string work_time, rest_time, normal_overtime, night_overtime;
            work_time = cal_second_to_hour(ts);
            rest_time = cal_second_to_hour(rt);
            normal_overtime = cal_second_to_hour(ts);
            night_overtime = cal_second_to_hour(ts);


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
        /// 
        /// </summary>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        /// <param name="rest_start_time"></param>
        /// <param name="rest_end_time"></param>
        /// <returns></returns>
        private TimeSpan cal_rest_time(DateTime start_time, DateTime end_time, DateTime rest_start_time, DateTime rest_end_time)
        {
            TimeSpan ts = new TimeSpan();

            if ((start_time < rest_start_time) && ( rest_end_time < end_time ))
            {
                ts = rest_end_time - rest_start_time;
            }

            return ts;
        }


        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}
