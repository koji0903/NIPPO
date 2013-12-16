namespace NIPPO
{
    partial class DailyReportWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIPPODBContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoritiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workreportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holidaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businesssegmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businesstypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessdetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultContainerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metadataWorkspaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectStateManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandTimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextOptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIPPODBContainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersDataGridViewTextBoxColumn,
            this.authoritiesDataGridViewTextBoxColumn,
            this.sectionsDataGridViewTextBoxColumn,
            this.workreportsDataGridViewTextBoxColumn,
            this.workdetailDataGridViewTextBoxColumn,
            this.projectsDataGridViewTextBoxColumn,
            this.tasksDataGridViewTextBoxColumn,
            this.customersDataGridViewTextBoxColumn,
            this.holidaysDataGridViewTextBoxColumn,
            this.businesssegmentsDataGridViewTextBoxColumn,
            this.businesstypeDataGridViewTextBoxColumn,
            this.businessdetailDataGridViewTextBoxColumn,
            this.connectionDataGridViewTextBoxColumn,
            this.defaultContainerNameDataGridViewTextBoxColumn,
            this.metadataWorkspaceDataGridViewTextBoxColumn,
            this.objectStateManagerDataGridViewTextBoxColumn,
            this.commandTimeoutDataGridViewTextBoxColumn,
            this.contextOptionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nIPPODBContainerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(865, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // nIPPODBContainerBindingSource
            // 
            this.nIPPODBContainerBindingSource.DataSource = typeof(NIPPO.NIPPO_DBContainer);
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "users";
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authoritiesDataGridViewTextBoxColumn
            // 
            this.authoritiesDataGridViewTextBoxColumn.DataPropertyName = "authorities";
            this.authoritiesDataGridViewTextBoxColumn.HeaderText = "authorities";
            this.authoritiesDataGridViewTextBoxColumn.Name = "authoritiesDataGridViewTextBoxColumn";
            this.authoritiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionsDataGridViewTextBoxColumn
            // 
            this.sectionsDataGridViewTextBoxColumn.DataPropertyName = "sections";
            this.sectionsDataGridViewTextBoxColumn.HeaderText = "sections";
            this.sectionsDataGridViewTextBoxColumn.Name = "sectionsDataGridViewTextBoxColumn";
            this.sectionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workreportsDataGridViewTextBoxColumn
            // 
            this.workreportsDataGridViewTextBoxColumn.DataPropertyName = "work_reports";
            this.workreportsDataGridViewTextBoxColumn.HeaderText = "work_reports";
            this.workreportsDataGridViewTextBoxColumn.Name = "workreportsDataGridViewTextBoxColumn";
            this.workreportsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workdetailDataGridViewTextBoxColumn
            // 
            this.workdetailDataGridViewTextBoxColumn.DataPropertyName = "work_detail";
            this.workdetailDataGridViewTextBoxColumn.HeaderText = "work_detail";
            this.workdetailDataGridViewTextBoxColumn.Name = "workdetailDataGridViewTextBoxColumn";
            this.workdetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectsDataGridViewTextBoxColumn
            // 
            this.projectsDataGridViewTextBoxColumn.DataPropertyName = "projects";
            this.projectsDataGridViewTextBoxColumn.HeaderText = "projects";
            this.projectsDataGridViewTextBoxColumn.Name = "projectsDataGridViewTextBoxColumn";
            this.projectsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tasksDataGridViewTextBoxColumn
            // 
            this.tasksDataGridViewTextBoxColumn.DataPropertyName = "tasks";
            this.tasksDataGridViewTextBoxColumn.HeaderText = "tasks";
            this.tasksDataGridViewTextBoxColumn.Name = "tasksDataGridViewTextBoxColumn";
            this.tasksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersDataGridViewTextBoxColumn
            // 
            this.customersDataGridViewTextBoxColumn.DataPropertyName = "customers";
            this.customersDataGridViewTextBoxColumn.HeaderText = "customers";
            this.customersDataGridViewTextBoxColumn.Name = "customersDataGridViewTextBoxColumn";
            this.customersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holidaysDataGridViewTextBoxColumn
            // 
            this.holidaysDataGridViewTextBoxColumn.DataPropertyName = "holidays";
            this.holidaysDataGridViewTextBoxColumn.HeaderText = "holidays";
            this.holidaysDataGridViewTextBoxColumn.Name = "holidaysDataGridViewTextBoxColumn";
            this.holidaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businesssegmentsDataGridViewTextBoxColumn
            // 
            this.businesssegmentsDataGridViewTextBoxColumn.DataPropertyName = "business_segments";
            this.businesssegmentsDataGridViewTextBoxColumn.HeaderText = "business_segments";
            this.businesssegmentsDataGridViewTextBoxColumn.Name = "businesssegmentsDataGridViewTextBoxColumn";
            this.businesssegmentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businesstypeDataGridViewTextBoxColumn
            // 
            this.businesstypeDataGridViewTextBoxColumn.DataPropertyName = "business_type";
            this.businesstypeDataGridViewTextBoxColumn.HeaderText = "business_type";
            this.businesstypeDataGridViewTextBoxColumn.Name = "businesstypeDataGridViewTextBoxColumn";
            this.businesstypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessdetailDataGridViewTextBoxColumn
            // 
            this.businessdetailDataGridViewTextBoxColumn.DataPropertyName = "business_detail";
            this.businessdetailDataGridViewTextBoxColumn.HeaderText = "business_detail";
            this.businessdetailDataGridViewTextBoxColumn.Name = "businessdetailDataGridViewTextBoxColumn";
            this.businessdetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionDataGridViewTextBoxColumn
            // 
            this.connectionDataGridViewTextBoxColumn.DataPropertyName = "Connection";
            this.connectionDataGridViewTextBoxColumn.HeaderText = "Connection";
            this.connectionDataGridViewTextBoxColumn.Name = "connectionDataGridViewTextBoxColumn";
            this.connectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultContainerNameDataGridViewTextBoxColumn
            // 
            this.defaultContainerNameDataGridViewTextBoxColumn.DataPropertyName = "DefaultContainerName";
            this.defaultContainerNameDataGridViewTextBoxColumn.HeaderText = "DefaultContainerName";
            this.defaultContainerNameDataGridViewTextBoxColumn.Name = "defaultContainerNameDataGridViewTextBoxColumn";
            // 
            // metadataWorkspaceDataGridViewTextBoxColumn
            // 
            this.metadataWorkspaceDataGridViewTextBoxColumn.DataPropertyName = "MetadataWorkspace";
            this.metadataWorkspaceDataGridViewTextBoxColumn.HeaderText = "MetadataWorkspace";
            this.metadataWorkspaceDataGridViewTextBoxColumn.Name = "metadataWorkspaceDataGridViewTextBoxColumn";
            this.metadataWorkspaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectStateManagerDataGridViewTextBoxColumn
            // 
            this.objectStateManagerDataGridViewTextBoxColumn.DataPropertyName = "ObjectStateManager";
            this.objectStateManagerDataGridViewTextBoxColumn.HeaderText = "ObjectStateManager";
            this.objectStateManagerDataGridViewTextBoxColumn.Name = "objectStateManagerDataGridViewTextBoxColumn";
            this.objectStateManagerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandTimeoutDataGridViewTextBoxColumn
            // 
            this.commandTimeoutDataGridViewTextBoxColumn.DataPropertyName = "CommandTimeout";
            this.commandTimeoutDataGridViewTextBoxColumn.HeaderText = "CommandTimeout";
            this.commandTimeoutDataGridViewTextBoxColumn.Name = "commandTimeoutDataGridViewTextBoxColumn";
            // 
            // contextOptionsDataGridViewTextBoxColumn
            // 
            this.contextOptionsDataGridViewTextBoxColumn.DataPropertyName = "ContextOptions";
            this.contextOptionsDataGridViewTextBoxColumn.HeaderText = "ContextOptions";
            this.contextOptionsDataGridViewTextBoxColumn.Name = "contextOptionsDataGridViewTextBoxColumn";
            this.contextOptionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DailyReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 332);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DailyReportWindow";
            this.Text = "日報入力";
            this.Load += new System.EventHandler(this.DailyReportWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIPPODBContainerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoritiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workreportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holidaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businesssegmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businesstypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessdetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultContainerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metadataWorkspaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectStateManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandTimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextOptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nIPPODBContainerBindingSource;
    }
}