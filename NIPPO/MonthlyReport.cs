﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.SqlClient;
//
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace NIPPO
{
    public class MonthlyReport
    {
        // 変数
        private int _FY; // 年度
        private int _month; // 月
        private int _userID; // ユーザID
        private DataSet _monthDs;
        private DataSet _holidayDs;
        // 定数
        private string listTableName = "MonthlyReport";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="FY"></param>
        /// <param name="userID"></param>
        public MonthlyReport(int FY, int userID)
        {
            _FY = FY;
            this._month = DateTime.Now.Month;
            _userID = userID;
            _monthDs = new DataSet();
        }

        public string getListTableName()
        {
            return this.listTableName;
        }

        /// <summary>
        /// 設定値の「月」を強制的に指定する。テスト用。
        /// </summary>
        /// <param name="month"></param>
        public void setMonth(int month)
        {
            _month = month;
        }

        /// <summary>
        /// 設定値の「月」を返す。
        /// </summary>
        /// <returns></returns>
        public int getMonth()
        {
            return _month;
        }

        /// <summary>
        /// 設定値の「カレンダーイヤー」を返す。
        /// </summary>
        /// <returns></returns>
        public int getCalYear()
        {
            if (this._month >= 1 &&
                this._month <= 3)
                return this._FY + 1;
            else
                return this._FY;
        }

        /// <summary>
        /// 設定値の「カレンダーイヤー/月」を"YYYY年MM年"形式で返す
        /// </summary>
        /// <returns>String "YYYY年MM月"</returns>
        public string getStringYearMonth()
        {
            return this.getCalYear() + "年" +
                   this._month.ToString("D2") + "月";
        }
        /// <summary>
        /// 月をカウントアップする。年度なので12の次は1で、3が最大値。
        /// </summary>
        public void incrMonth()
        {
            if (this._month == 12)
                this._month = 1;
            else if (this._month == 3)
                this._month = 3;
            else
                this._month++;
        }

        /// <summary>
        /// 月をカウントダウンする。年度なので1の前は12で、4が最小値。
        /// </summary>
        public void decrMonth()
        {
            if (this._month == 1)
                this._month = 12;
            else if (this._month == 4)
                this._month = 4;
            else
                this._month--;
        }

        /// <summary>
        /// 年度内に次の月があるか
        /// </summary>
        /// <returns></returns>
        public bool existsNextMonth()
        {
            if (this._month == 3)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 年度内に前の月があるか
        /// </summary>
        /// <returns></returns>
        public bool existsPrevMonth()
        {
            if (this._month == 4)
                return false;
            else
                return true;
        }

        public string getUserName()
        {
            string str = "不明なユーザ";
            DataSet ds = getUserNameOnStatusBarDs(this._userID);
            if (ds.Tables["user"] != null &&
                ds.Tables["user"].Rows.Count > 0)
            {
                string lastname = (ds.Tables["user"].Rows[0]["lastname"] != null)
                    ? ds.Tables["user"].Rows[0]["lastname"].ToString() : "";
                string firstname = (ds.Tables["user"].Rows[0]["firstname"] != null)
                    ? ds.Tables["user"].Rows[0]["firstname"].ToString() : "";
                string name = (ds.Tables["user"].Rows[0]["name"] != null)
                    ? ds.Tables["user"].Rows[0]["name"].ToString() : "";
                str = lastname + " " + firstname + "(" + name + ")";
            }            
            return str;
        }

        public DataSet getUserNameOnStatusBarDs(int userID)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT lastname,firstname,name"
                        + " FROM users LEFT JOIN sections"
                        + " ON users.sections_ID = sections.ID"
                        + " WHERE users.ID='"
                        + userID + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                }
                catch
                {
                    return ds;
                }
            }
            return ds;
        }

        public DataSet getMonthlyWorkReport()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet _ds_tmp = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT day,start_time,end_time,work_times,"
                        + " overtime125,overtime150,holiday_work_times,note"
                        + " FROM work_reports"
                        + " WHERE users_ID='" + this._userID + "'"
                        + " AND FY='" + this._FY + "'"
                        + " AND month='" + this._month + "'"
                        + ";";
                    adapter.SelectCommand = command;
                    adapter.Fill(_ds_tmp, "MonthlyReport_tmp");
                }
                catch
                {
                    return null;
                }
            }
            // データテーブル作成
            //DataTable _dt = new DataTable(dataMember);
            // カラムをコピーするやり方
            System.Data.DataTable _dt = _ds_tmp.Tables["MonthlyReport_tmp"].Copy();
            _dt.TableName = this.listTableName;
            _dt.Rows.Clear();
            // 1～31までの配列に格納する
            _dt.Columns.Add("week", Type.GetType("System.String"));
            for (int i = 0;
                i < DateTime.DaysInMonth(this.getCalYear(), this._month);
                i++)
            {
                DataRow _dr = _dt.NewRow();
                // 日
                int day = i + 1;
                _dr["day"] = day;
                // 曜日
                DateTime _date = new DateTime(this.getCalYear(), this._month, day);
                _dr["week"] = _date.ToString("ddd");
                // 
                _dt.Rows.Add(_dr);
            }
            // SQLに入ってた情報を取り込む
            for (int i = 0; i < _ds_tmp.Tables["MonthlyReport_tmp"].Rows.Count; i++)
            {
                DataRow _dr_from = _ds_tmp.Tables["MonthlyReport_tmp"].Rows[i];
                int index = int.Parse(_dr_from["day"].ToString()) - 1;
                _dt.Rows[index].ItemArray = _dr_from.ItemArray;
            }
            // データセットに入れる
            this._monthDs = new DataSet();
            this._monthDs.Tables.Add(_dt);
            return this._monthDs;
        }
        public double getTotalTimeCommon(string columnName)
        {
            double sum = 0.0;
            for (int i = 0; i < this._monthDs.Tables[this.listTableName].Rows.Count; i++)
            {
                object workTimes = this._monthDs.Tables[this.listTableName].Rows[i][columnName];
                if (workTimes != null && workTimes.ToString() != "")
                {
                    sum += double.Parse(workTimes.ToString());
                }
            }
            return sum;
        }

        public string getTotalTimeText()
        {
            return(this.getTotalTime().ToString() + " h");
        }

        public double getTotalTime()
        {
            return(this.getTotalTimeCommon("work_times"));
        }

        public string getTotalOverTime125Text()
        {
            return (this.getTotalOverTime125().ToString() + " h");
        }

        public double getTotalOverTime125()
        {
            return (this.getTotalTimeCommon("overtime125"));
        }

        public string getTotalOverTime150Text()
        {
            return (this.getTotalOverTime150().ToString() + " h");
        }

        public double getTotalOverTime150()
        {
            return (this.getTotalTimeCommon("overtime150"));
        }

        public DataSet getHolidayListDs()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            this._holidayDs = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT day FROM holidays"
                        + " WHERE year='" + this.getCalYear() + "'"
                        + " AND month='" + this._month + "'"
                        + " ;";
                    adapter.SelectCommand = command;
                    adapter.Fill(this._holidayDs, "holidays");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return this._holidayDs;
        }

        public void outputExcel()
        {
            string excelTempletePath = NIPPO.Properties.Settings.Default.ExcelTempletePath;
            int _sheetNo = 1;                        // シートNo.
            int _col = 2;                            // データ書き込みカラム
            int _line = 2;                           // データ書き込み開始行
            Microsoft.Office.Interop.Excel.Application oXls = null;
            Microsoft.Office.Interop.Excel.Workbooks oBooks = null;
            Microsoft.Office.Interop.Excel.Workbook oWBook = null;
            //Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Worksheet oSheet = null;
            Microsoft.Office.Interop.Excel.Range oRange = null;
            object objCell = null;

            try
            {
                // EXCEL開始処理
                try
                {
                    oXls = new Microsoft.Office.Interop.Excel.Application();
                }
                catch
                {
                    throw new Exception(
                        "Microsoft Office Excelがインストールされていないため\n" +
                        "印刷できません。");
                }

                if (System.IO.File.Exists(excelTempletePath) == false)
                {
                    throw new Exception(
                        "エクセルファイルが見つかりませんでした。\n" + excelTempletePath);
                }

                oXls.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMinimized;
                oXls.Visible = false;
                oXls.DisplayAlerts = false;

                oBooks = oXls.Workbooks;
                oWBook = oBooks.Open(excelTempletePath,
                    Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing, Type.Missing, 
                    Type.Missing, Type.Missing);

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWBook.Sheets[_sheetNo];

                this.excelWriteYear(oSheet);    // A1
                this.excelWriteMonth(oSheet);   // A2
                this.excelWriteUser(oSheet);    // B3
                this.excelWriteRowAll(oSheet);    // A8～A38

                //objCell = oSheet.Cells[_line + 0, _col];
                //oRange = oSheet.get_Range(objCell, objCell);
                //oRange.Value2 = "100";
                //Marshal.ReleaseComObject(oRange); 
                //Marshal.ReleaseComObject(objCell);

                //objCell = oSheet.Cells[_line + 1, _col];
                //oRange = oSheet.get_Range(objCell, objCell);
                //oRange.Value2 = "200";
                //Marshal.ReleaseComObject(oRange); 
                //Marshal.ReleaseComObject(objCell);

                // ファイル保存
                Microsoft.Office.Core.FileDialog foDlg;
                foDlg = oXls.get_FileDialog(
                    Microsoft.Office.Core.MsoFileDialogType.msoFileDialogSaveAs);
                foDlg.InitialFileName = "test.xls";
                if (foDlg.Show() != 0)
                {
                    foDlg.Execute();
                }
            }
            catch (COMException ex)
            {
                Console.WriteLine("A COM error occurred: 0x{0} {1}",
                    ex.ErrorCode.ToString("x"),
                    ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // EXCEL終了処理
                if (oSheet != null)
                {
                    Marshal.ReleaseComObject(oSheet);     // オブジェクト参照を解放
                    oSheet = null;                        // オブジェクト解放
                }
                if (oWBook != null)
                {
                    oWBook.Close(false,
                        Type.Missing, Type.Missing);       //ファイルを閉じる
                    Marshal.ReleaseComObject(oWBook);      // オブジェクト参照を解放
                    oWBook = null;                         // オブジェクト解放
                }
                if (oBooks != null)
                {
                    Marshal.ReleaseComObject(oBooks);     // オブジェクト参照を解放
                    oBooks = null;                        // オブジェクト解放
                }
                if (oXls != null)
                {
                    oXls.Quit();                            // EXCELを閉じる
                    Marshal.ReleaseComObject(oXls);
                    oXls = null;                            // オブジェクト解放
                }
                System.GC.Collect();                            // オブジェクトを確実に削除
            }
        }

        private void excelWriteCommon(Microsoft.Office.Interop.Excel.Worksheet oSheet,
            int _row, int _col, string _val)
        {
            Microsoft.Office.Interop.Excel.Range oRange = null;
            object objCell = null;

            objCell = oSheet.Cells[_row, _col];
            oRange = oSheet.get_Range(objCell, objCell);
            oRange.Value2 = _val;
            Marshal.ReleaseComObject(oRange);
            Marshal.ReleaseComObject(objCell);
            return;
        }

        private void excelWriteYear(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            string str = this.getCalYear() + "年";
            excelWriteCommon(oSheet, 1, 1, str);
            return;
        }

        private void excelWriteMonth(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            string str = this._month + "月";
            excelWriteCommon(oSheet, 2, 1, str);
            return;
        }

        private void excelWriteUser(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            try
            {
                string str = excelGetUserName(this._userID);
                excelWriteCommon(oSheet, 3, 2, str);
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string excelGetUserName(int userID)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataSet ds = new DataSet();

            connection.ConnectionString = NIPPO.Properties.Settings.Default.ConnectionString;

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT lastname,firstname"
                        + " FROM users"
                        + " WHERE users.ID='"
                        + userID + "';";
                    adapter.SelectCommand = command;
                    adapter.Fill(ds, "user");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ds.Tables["user"].Rows[0]["lastname"] +  " "
                + ds.Tables["user"].Rows[0]["firstname"];
        }

        private void excelWriteRowAll(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            for (int i = 0;
                i < DateTime.DaysInMonth(this.getCalYear(), this._month);
                i++)
            {
                excelWriteDay(oSheet,i);
                excelWriteWeek(oSheet, i);
                excelWriteHoliday(oSheet, i);
            }
            return;
        }

        private void excelWriteDay(Microsoft.Office.Interop.Excel.Worksheet oSheet, int index)
        {
            string str = this.getCalYear() + "/" + this._month + "/" + (index + 1).ToString();
            excelWriteCommon(oSheet, 8 + index, 1, str);
            return;
        }

        private void excelWriteWeek(Microsoft.Office.Interop.Excel.Worksheet oSheet, int index)
        {
            DateTime _date = new DateTime(this.getCalYear(), this._month, index + 1);
            excelWriteCommon(oSheet, 8 + index, 2, _date.ToString("ddd"));
            return;
        }

        private void excelWriteHoliday(Microsoft.Office.Interop.Excel.Worksheet oSheet, int index)
        {
            if (this._holidayDs == null)
                this._holidayDs = getHolidayListDs();
            Boolean isHoliday = false;
            for (int i = 0; i < this._holidayDs.Tables[0].Rows.Count; i++)
            {
                if (int.Parse(this._holidayDs.Tables[0].Rows[i]["day"].ToString()) == (index + 1))
                    isHoliday = true;
            }
            string str = (isHoliday) ? "*" : "";
            excelWriteCommon(oSheet, 8 + index, 3, str);
            return;
        }
    }
}
