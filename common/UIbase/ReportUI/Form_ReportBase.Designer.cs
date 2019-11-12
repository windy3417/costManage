namespace U8common.UIbase
{
    partial class Form_ReportBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportBase));
            this.dataGridView_Report = new System.Windows.Forms.DataGridView();
            this.label_startDate = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_endDate = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.bindingNavigator_pageUp = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_CountPerPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_PrePage = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_CurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_totalPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_totalCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Export = new System.Windows.Forms.ToolStripButton();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_pageUp)).BeginInit();
            this.bindingNavigator_pageUp.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Report
            // 
            this.dataGridView_Report.AllowUserToAddRows = false;
            this.dataGridView_Report.AllowUserToDeleteRows = false;
            this.dataGridView_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Report.Location = new System.Drawing.Point(0, 91);
            this.dataGridView_Report.Name = "dataGridView_Report";
            this.dataGridView_Report.ReadOnly = true;
            this.dataGridView_Report.RowTemplate.Height = 23;
            this.dataGridView_Report.Size = new System.Drawing.Size(1446, 610);
            this.dataGridView_Report.TabIndex = 0;
            this.dataGridView_Report.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_MaterialsOut_RowPostPaint);
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(66, 23);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(53, 12);
            this.label_startDate.TabIndex = 1;
            this.label_startDate.Text = "开始日期";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(246, 20);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(17, 21);
            this.dateTimePicker_startDate.TabIndex = 2;
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(335, 23);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(53, 12);
            this.label_endDate.TabIndex = 1;
            this.label_endDate.Text = "结束日期";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(992, 17);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(125, 20);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.Size = new System.Drawing.Size(121, 21);
            this.textBox_startDate.TabIndex = 4;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(553, 20);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(17, 21);
            this.dateTimePicker_endDate.TabIndex = 5;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(432, 20);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.Size = new System.Drawing.Size(121, 21);
            this.textBox_endDate.TabIndex = 6;
            // 
            // bindingNavigator_pageUp
            // 
            this.bindingNavigator_pageUp.AddNewItem = null;
            this.bindingNavigator_pageUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator_pageUp.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_pageUp.DeleteItem = null;
            this.bindingNavigator_pageUp.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator_pageUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox_CountPerPage,
            this.toolStripButton_PrePage,
            this.toolStripTextBox_CurrentPage,
            this.toolStripLabel_totalPageCount,
            this.toolStripButton2,
            this.toolStripLabel_totalCount});
            this.bindingNavigator_pageUp.Location = new System.Drawing.Point(821, 710);
            this.bindingNavigator_pageUp.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_pageUp.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_pageUp.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_pageUp.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_pageUp.Name = "bindingNavigator_pageUp";
            this.bindingNavigator_pageUp.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_pageUp.Size = new System.Drawing.Size(565, 25);
            this.bindingNavigator_pageUp.TabIndex = 7;
            this.bindingNavigator_pageUp.Text = "bindingNavigator1";
            this.bindingNavigator_pageUp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bdnInfo_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "每页显示";
            // 
            // toolStripTextBox_CountPerPage
            // 
            this.toolStripTextBox_CountPerPage.Name = "toolStripTextBox_CountPerPage";
            this.toolStripTextBox_CountPerPage.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox_CountPerPage.Text = "100";
            this.toolStripTextBox_CountPerPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxCountPerPage_KeyDown);
            // 
            // toolStripButton_PrePage
            // 
            this.toolStripButton_PrePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_PrePage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_PrePage.Image")));
            this.toolStripButton_PrePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_PrePage.Name = "toolStripButton_PrePage";
            this.toolStripButton_PrePage.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_PrePage.Text = "上一页";
            // 
            // toolStripTextBox_CurrentPage
            // 
            this.toolStripTextBox_CurrentPage.Name = "toolStripTextBox_CurrentPage";
            this.toolStripTextBox_CurrentPage.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox_CurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_CurrentPage_KeyDown);
            // 
            // toolStripLabel_totalPageCount
            // 
            this.toolStripLabel_totalPageCount.Name = "toolStripLabel_totalPageCount";
            this.toolStripLabel_totalPageCount.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel_totalPageCount.Text = "/ {0}";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton2.Text = "下一页";
            // 
            // toolStripLabel_totalCount
            // 
            this.toolStripLabel_totalCount.Name = "toolStripLabel_totalCount";
            this.toolStripLabel_totalCount.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel_totalCount.Text = "共{0}条记录";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_close,
            this.toolStripButton_Export});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1458, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_close
            // 
            this.toolStripButton_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_close.Name = "toolStripButton_close";
            this.toolStripButton_close.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton_close.Text = "关闭";
            this.toolStripButton_close.ToolTipText = "关闭";
            this.toolStripButton_close.Click += new System.EventHandler(this.toolStripButton_close_Click);
            // 
            // toolStripButton_Export
            // 
            this.toolStripButton_Export.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Export.Image")));
            this.toolStripButton_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Export.Name = "toolStripButton_Export";
            this.toolStripButton_Export.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_Export.Text = "导出";
            this.toolStripButton_Export.Click += new System.EventHandler(this.toolStrip_Export_Click);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_startDate);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_endDate);
            this.groupBox_Filter.Controls.Add(this.label_startDate);
            this.groupBox_Filter.Controls.Add(this.button_confirm);
            this.groupBox_Filter.Controls.Add(this.textBox_startDate);
            this.groupBox_Filter.Controls.Add(this.label_endDate);
            this.groupBox_Filter.Controls.Add(this.textBox_endDate);
            this.groupBox_Filter.Location = new System.Drawing.Point(0, 28);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(1446, 57);
            this.groupBox_Filter.TabIndex = 10;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "查询条件";
            // 
            // Form_ReportBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 738);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator_pageUp);
            this.Controls.Add(this.dataGridView_Report);
            this.Name = "Form_ReportBase";
            this.Text = "报表模板";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReport_FormClosed);
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_pageUp)).EndInit();
            this.bindingNavigator_pageUp.ResumeLayout(false);
            this.bindingNavigator_pageUp.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Report;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_endDate;
        public System.Windows.Forms.Button button_confirm;//开放给子类
        public System.Windows.Forms.TextBox textBox_startDate;//需要赋值
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        public System.Windows.Forms.TextBox textBox_endDate;//需要赋值
        private System.Windows.Forms.BindingNavigator bindingNavigator_pageUp;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;//总记录数
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_close;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_CountPerPage;
        public System.Windows.Forms.GroupBox groupBox_Filter;//需要添加其它过滤条件
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton toolStripButton_PrePage;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_CurrentPage;
        private  System.Windows.Forms.ToolStripLabel toolStripLabel_totalPageCount;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_totalCount;
        private System.Windows.Forms.ToolStripButton toolStripButton_Export;
    }
}