using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NIPPO
{
    class DailyReport : IDisposable
    {
        internal String GetCalender(int year, int month, int day)
        {
            return "AAA";
        }

        // IDisposable対応（ガベージコレクション対策みたい）
        #region IDisposable メンバー
        public void Dispose(){}
        #endregion
    }
}
