﻿using System;
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
        public Double[] GetWorkTime(int year, int month, int day, int start_hour, int start_second, int end_hour, int end_second)
        {
            string str;

            // [0] : 勤務時間（（勤務終了時間-勤務開始時間）- 休憩時間）
            // [1] : 休憩時間（12:00～13:00, 17:30～18:00）
            // [2] : 普通残業時間 (05:00～08:45, 18:00～22:00)
            // [3] : 深夜残業時間 (22:00～05:00)
            double[] time = new double[4];
            string base_day = String.Format("{0:D4}/{1:D2}/{2:D2}", year, month, day);
            string target_day = String.Format("{0:D4}/{1:D2}/{2:D2}", year, month, day);
            string next_day_start = String.Format("{0:D4}/{1:D2}/{2:D2} 00:00:00", year, month, day + 1);
            // 残業が次の日まで持ち越した場合
            if (end_hour >= 24)
            {
                target_day = String.Format("{0:D4}/{1:D2}/{2:D2}", year, month, day + 1);
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
            TimeSpan ts = end_time - start_time - rt;

            // Lost Time (通常勤務の8:45以降から勤務をスタートした場合）
            TimeSpan lost_time = new TimeSpan(0,0,0);
            if (start_time > DateTime.Parse(base_day + " 08:45:00"))
            {
                if (start_time < DateTime.Parse(base_day + " 12:00:00"))
                {
                    // 12時前出社
                    lost_time = start_time - DateTime.Parse(base_day + " 08:45:00");
                }
                else
                {
                    // 12時～13時出社
                    lost_time =  DateTime.Parse(base_day + " 12:00:00")　- DateTime.Parse(base_day + " 08:45:00");
                }
            }

            // 普通・深夜残業時間
            TimeSpan[] early_ot = cal_early_overtime(start_time, end_time, DateTime.Parse(base_day + " 05:00:00"), DateTime.Parse(base_day + " 08:45:00"));
            TimeSpan[] late_ot = cal_late_overtime(start_time, end_time, DateTime.Parse(base_day + " 18:00:00"), DateTime.Parse(base_day + " 22:00:00"), DateTime.Parse(next_day_start), lost_time);

            // 深夜残業時間
//            TimeSpan night_ot = cal_target_time(start_time, end_time, DateTime.Parse("05:00:00"), DateTime.Parse("22:00:00"));

            // 各項目の時間を配列にセット
            float work_time, rest_time, normal_overtime, night_overtime;
            work_time = cal_second_to_hour(ts);
            rest_time = cal_second_to_hour(rt);
            normal_overtime = cal_second_to_hour(early_ot[0] + late_ot[0]);
            night_overtime = cal_second_to_hour(early_ot[1] + late_ot[1]);

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
        private float cal_second_to_hour( TimeSpan ts )
        {
            String hour = ts.ToString("%h");
            String second = ts.ToString(@"mm");
            return float.Parse(hour) + float.Parse(second) / 60;
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
                else
                {
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
        /// 特定区分（休憩、普通残業、深夜残業）の時間の計算。（区分の割り当て時間定義されており、その範囲に入っていた場合はカウント）
        /// </summary>
        /// <param name="start_time">勤務開始時間</param>
        /// <param name="end_time">勤務終了時間</param>
        /// <param name="rest_start_time">休憩開始時間</param>
        /// <param name="rest_end_time">休憩終了時間</param>
        /// <returns>時間範囲</returns>
        private TimeSpan[] cal_late_overtime(DateTime start_time, DateTime end_time, DateTime target_start_time, DateTime target_end_time, DateTime next_day_start, TimeSpan lost_time)
        {
            TimeSpan[] ts = new TimeSpan[2];

            TimeSpan normal_ts = new TimeSpan();
            TimeSpan night_ts = new TimeSpan();

            if (end_time <= target_end_time)
            {
                // 普通残業だけで終了
                if (target_start_time <= end_time)
                {
                    // 終了時刻 - 普通残業開始時刻(18:00)
                    normal_ts = end_time - target_start_time - lost_time;
                }
            }
            else
            {
                // 次の日まで残業
                // 普通残業は、夜すべて
                normal_ts = target_end_time - target_start_time - lost_time;
                // 深夜残業は、22:00 以降＋０時から終わりまで。
                TimeSpan night_time = new TimeSpan(22,0,0);
                night_ts = night_time + (end_time - next_day_start) - lost_time;
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


        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}