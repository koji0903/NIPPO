using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NIPPO
{
    public class DailyReport : IDisposable
    {
        public String GetCalender(int year, int month, int day)
        {
            DateTime dateValue = new DateTime(year,month,day);
            string str = String.Format("{0}年{1:D2}月{2:D2}日({3})", year, month, day, dateValue.ToString("ddd"));
            return str;
        }

        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}
