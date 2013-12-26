using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NIPPO
{
    public partial class SearchTasksWindow : Form
    {

        private DataSet _ds;
        public int _taskid;
        public string _taskcode;
        public string _taskname;

        public SearchTasksWindow()
        {
            InitializeComponent();
            _taskid = 0;
            _taskcode = "";
            _taskname = "";
        }

        private void SearchTasksWindow_Load(object sender, EventArgs e)
        {

        }

        private void TasksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTasksWindow_Load_1(object sender, EventArgs e)
        {
            string _command;
            _command = "SELECT ID,code,name,alias FROM tasks;";
            this._ds = DataAccess.ReadData( _command );
            TasksGridView.DataSource = this._ds.Tables[0];
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this._taskid =   (int)TasksGridView.SelectedRows[0].Cells["ID"].Value;
            this._taskcode = TasksGridView.SelectedRows[0].Cells[1].Value.ToString();
            this._taskname = TasksGridView.SelectedRows[0].Cells[2].Value.ToString();
            this.Close();

        }
    }
}
