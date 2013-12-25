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
    public partial class SearchProjectsWindow : Form
    {

        private int _fy;
        private DataSet _ds;
        public int _project_id;
        public string _project_code;
        public string _project_name;


        public SearchProjectsWindow( int _fy )
        {
            InitializeComponent();
            this._project_id = 0;
            this._project_code = "";
            this._project_name = "";
            this._fy = _fy;
            this.fy_NumericUpDown.Value = _fy;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchProjectsWindow_Load(object sender, EventArgs e)
        {
            string _command;
            _command = "SELECT ID,FY,num,name,start_date,end_date FROM projects WHERE FY = '" + _fy + "';";
            this._ds = DataAccess.ReadData(_command);
            ProjectsGridView.DataSource = this._ds.Tables[0];
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            this._project_id = (int)ProjectsGridView.SelectedRows[0].Cells["ID"].Value;
            this._project_code = ProjectsGridView.SelectedRows[0].Cells["num"].Value.ToString();
            this._project_name = ProjectsGridView.SelectedRows[0].Cells["name"].Value.ToString();
            this.Close();
        }

    }
}
