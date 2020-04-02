namespace 成本管理.UI.saleManage
{
    partial class deliverySchedule
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
            this.DGVdeliverySchedule = new System.Windows.Forms.DataGridView();
            this.labelYear = new System.Windows.Forms.Label();
            this.listBoxYear = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMonth = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SCdeliverySchedule = new System.Windows.Forms.SplitContainer();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.cinvCode = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cinvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramDeliveryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeliverySchedule)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCdeliverySchedule)).BeginInit();
            this.SCdeliverySchedule.Panel1.SuspendLayout();
            this.SCdeliverySchedule.Panel2.SuspendLayout();
            this.SCdeliverySchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVdeliverySchedule
            // 
            this.DGVdeliverySchedule.AllowUserToAddRows = false;
            this.DGVdeliverySchedule.AllowUserToDeleteRows = false;
            this.DGVdeliverySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdeliverySchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinvCode,
            this.cinvName,
            this.cinvStd,
            this.ProgramDeliveryQuantity});
            this.DGVdeliverySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVdeliverySchedule.Location = new System.Drawing.Point(0, 0);
            this.DGVdeliverySchedule.Name = "DGVdeliverySchedule";
            this.DGVdeliverySchedule.ReadOnly = true;
            this.DGVdeliverySchedule.RowTemplate.Height = 23;
            this.DGVdeliverySchedule.Size = new System.Drawing.Size(958, 445);
            this.DGVdeliverySchedule.TabIndex = 0;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(125, 35);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 12);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "年度";
            // 
            // listBoxYear
            // 
            this.listBoxYear.FormattingEnabled = true;
            this.listBoxYear.ItemHeight = 12;
            this.listBoxYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.listBoxYear.Location = new System.Drawing.Point(160, 31);
            this.listBoxYear.Name = "listBoxYear";
            this.listBoxYear.Size = new System.Drawing.Size(120, 16);
            this.listBoxYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "月份";
            // 
            // listBoxMonth
            // 
            this.listBoxMonth.FormattingEnabled = true;
            this.listBoxMonth.ItemHeight = 12;
            this.listBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listBoxMonth.Location = new System.Drawing.Point(432, 31);
            this.listBoxMonth.Name = "listBoxMonth";
            this.listBoxMonth.Size = new System.Drawing.Size(120, 16);
            this.listBoxMonth.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonSave,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SCdeliverySchedule
            // 
            this.SCdeliverySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCdeliverySchedule.Location = new System.Drawing.Point(0, 25);
            this.SCdeliverySchedule.Name = "SCdeliverySchedule";
            this.SCdeliverySchedule.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCdeliverySchedule.Panel1
            // 
            this.SCdeliverySchedule.Panel1.Controls.Add(this.label1);
            this.SCdeliverySchedule.Panel1.Controls.Add(this.labelYear);
            this.SCdeliverySchedule.Panel1.Controls.Add(this.listBoxMonth);
            this.SCdeliverySchedule.Panel1.Controls.Add(this.listBoxYear);
            // 
            // SCdeliverySchedule.Panel2
            // 
            this.SCdeliverySchedule.Panel2.Controls.Add(this.DGVdeliverySchedule);
            this.SCdeliverySchedule.Size = new System.Drawing.Size(958, 539);
            this.SCdeliverySchedule.SplitterDistance = 90;
            this.SCdeliverySchedule.TabIndex = 4;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::成本管理.Properties.Resources.add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonAdd.Text = "新增";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = global::成本管理.Properties.Resources.icon_edit2;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonEdit.Text = "修改";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::成本管理.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonSave.Text = "保存";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::成本管理.Properties.Resources.abandon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "放弃";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::成本管理.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "删除";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::成本管理.Properties.Resources.icon_quit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "退出";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // cinvCode
            // 
            this.cinvCode.HeaderText = "存货编码";
            this.cinvCode.Name = "cinvCode";
            this.cinvCode.ReadOnly = true;
            this.cinvCode.UseColumnTextForButtonValue = true;
            // 
            // cinvName
            // 
            this.cinvName.HeaderText = "存货名称";
            this.cinvName.Name = "cinvName";
            this.cinvName.ReadOnly = true;
            this.cinvName.Width = 200;
            // 
            // cinvStd
            // 
            this.cinvStd.HeaderText = "规格型号";
            this.cinvStd.Name = "cinvStd";
            this.cinvStd.ReadOnly = true;
            this.cinvStd.Width = 200;
            // 
            // ProgramDeliveryQuantity
            // 
            this.ProgramDeliveryQuantity.HeaderText = "计划发货数量";
            this.ProgramDeliveryQuantity.Name = "ProgramDeliveryQuantity";
            this.ProgramDeliveryQuantity.ReadOnly = true;
            // 
            // deliverySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 564);
            this.Controls.Add(this.SCdeliverySchedule);
            this.Controls.Add(this.toolStrip1);
            this.Name = "deliverySchedule";
            this.Text = "月度发货计划";
            this.Load += new System.EventHandler(this.deliverySchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeliverySchedule)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SCdeliverySchedule.Panel1.ResumeLayout(false);
            this.SCdeliverySchedule.Panel1.PerformLayout();
            this.SCdeliverySchedule.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCdeliverySchedule)).EndInit();
            this.SCdeliverySchedule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdeliverySchedule;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ListBox listBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMonth;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer SCdeliverySchedule;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewButtonColumn cinvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinvStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramDeliveryQuantity;
    }
}