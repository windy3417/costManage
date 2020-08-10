namespace 成本管理.UI
{
    partial class Form_WriteCostObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WriteCostObject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.label_endDate = new System.Windows.Forms.Label();
            this.helpProvider_writeCostObejet = new System.Windows.Forms.HelpProvider();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_periodInspect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_writeForOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_writeForOutsourcing = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_resultQuery = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_writeResult = new System.Windows.Forms.DataGridView();
            this.toolStripButton_quit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_writeResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(211, 30);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(16, 21);
            this.dateTimePicker_startDate.TabIndex = 6;
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(12, 30);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(53, 12);
            this.label_startDate.TabIndex = 5;
            this.label_startDate.Text = "开始日期";
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(114, 30);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.Size = new System.Drawing.Size(114, 21);
            this.textBox_startDate.TabIndex = 7;
            this.textBox_startDate.TextChanged += new System.EventHandler(this.textBox_startDate_TextChanged);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(539, 27);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(16, 21);
            this.dateTimePicker_endDate.TabIndex = 9;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(439, 27);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.Size = new System.Drawing.Size(117, 21);
            this.textBox_endDate.TabIndex = 10;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(342, 30);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(53, 12);
            this.label_endDate.TabIndex = 8;
            this.label_endDate.Text = "结束日期";
            // 
            // helpProvider_writeCostObejet
            // 
            this.helpProvider_writeCostObejet.HelpNamespace = "C:\\Users\\windy\\OneDrive\\K开发代码\\程序帮助文件.CHM";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_periodInspect,
            this.toolStripButton_writeForOrder,
            this.toolStripButton_writeForOutsourcing,
            this.toolStripButton_resultQuery,
            this.toolStripButton_quit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1465, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_periodInspect
            // 
            this.toolStripButton_periodInspect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_periodInspect.Image")));
            this.toolStripButton_periodInspect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_periodInspect.Name = "toolStripButton_periodInspect";
            this.toolStripButton_periodInspect.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_periodInspect.Text = "期间检查";
            this.toolStripButton_periodInspect.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // toolStripButton_writeForOrder
            // 
            this.toolStripButton_writeForOrder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_writeForOrder.Image")));
            this.toolStripButton_writeForOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_writeForOrder.Name = "toolStripButton_writeForOrder";
            this.toolStripButton_writeForOrder.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton_writeForOrder.Text = "写入生产订单仓";
            this.toolStripButton_writeForOrder.Click += new System.EventHandler(this.button_writeForWithOrder_Click);
            // 
            // toolStripButton_writeForOutsourcing
            // 
            this.toolStripButton_writeForOutsourcing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_writeForOutsourcing.Image")));
            this.toolStripButton_writeForOutsourcing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_writeForOutsourcing.Name = "toolStripButton_writeForOutsourcing";
            this.toolStripButton_writeForOutsourcing.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton_writeForOutsourcing.Text = "写入委外件仓";
            this.toolStripButton_writeForOutsourcing.Click += new System.EventHandler(this.button_writeForOutsousing_Click);
            // 
            // toolStripButton_resultQuery
            // 
            this.toolStripButton_resultQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_resultQuery.Image")));
            this.toolStripButton_resultQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_resultQuery.Name = "toolStripButton_resultQuery";
            this.toolStripButton_resultQuery.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton_resultQuery.Text = "写入结果查询";
            this.toolStripButton_resultQuery.Click += new System.EventHandler(this.toolStripButton_QueryResult_Click);
            // 
            // dataGridView_writeResult
            // 
            this.dataGridView_writeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_writeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_writeResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_writeResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_writeResult.EnableHeadersVisualStyles = false;
            this.dataGridView_writeResult.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_writeResult.Location = new System.Drawing.Point(0, 92);
            this.dataGridView_writeResult.Name = "dataGridView_writeResult";
            this.dataGridView_writeResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_writeResult.RowTemplate.Height = 23;
            this.dataGridView_writeResult.Size = new System.Drawing.Size(1465, 449);
            this.dataGridView_writeResult.TabIndex = 14;
            this.dataGridView_writeResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_writeResult_RowPostPaint);
            // 
            // toolStripButton_quit
            // 
            this.toolStripButton_quit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_quit.Image = global::成本管理.Properties.Resources.icon_quit;
            this.toolStripButton_quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_quit.Name = "toolStripButton_quit";
            this.toolStripButton_quit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_quit.Text = "退出";
            this.toolStripButton_quit.Click += new System.EventHandler(this.toolStripButton_quit_Click);
            // 
            // FormWriteCostObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1465, 541);
            this.Controls.Add(this.dataGridView_writeResult);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.textBox_endDate);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.textBox_startDate);
            this.HelpButton = true;
            this.helpProvider_writeCostObejet.SetHelpKeyword(this, "F1");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWriteCostObject";
            this.helpProvider_writeCostObejet.SetShowHelp(this, true);
            this.Text = "写入成本对象";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWriteCostObject_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_writeResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.TextBox textBox_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.TextBox textBox_endDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.HelpProvider helpProvider_writeCostObejet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_periodInspect;
        private System.Windows.Forms.ToolStripButton toolStripButton_writeForOrder;
        private System.Windows.Forms.ToolStripButton toolStripButton_writeForOutsourcing;
        private System.Windows.Forms.ToolStripButton toolStripButton_resultQuery;
        private System.Windows.Forms.DataGridView dataGridView_writeResult;
        private System.Windows.Forms.ToolStripButton toolStripButton_quit;
    }
}