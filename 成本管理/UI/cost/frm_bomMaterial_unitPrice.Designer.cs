namespace 成本管理.UI.Cost
{
    partial class frm_bomMaterial_unitPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bomMaterial_unitPrice));
            this.tsb_caculate = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_fetch = new System.Windows.Forms.ToolStripButton();
            this.tsb_supplement = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_generate = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.dgv_bomMaterialUnit = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gp_condition = new System.Windows.Forms.GroupBox();
            this.txt_voucherNO = new System.Windows.Forms.TextBox();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_vocherNO = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.tsb_export = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomMaterialUnit)).BeginInit();
            this.gp_condition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsb_caculate
            // 
            this.tsb_caculate.Image = ((System.Drawing.Image)(resources.GetObject("tsb_caculate.Image")));
            this.tsb_caculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_caculate.Name = "tsb_caculate";
            this.tsb_caculate.Size = new System.Drawing.Size(52, 22);
            this.tsb_caculate.Text = "计算";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_fetch,
            this.tsb_supplement,
            this.tsb_save,
            this.tsb_delete,
            this.tsb_generate,
            this.tsb_export,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_fetch
            // 
            this.tsb_fetch.Image = ((System.Drawing.Image)(resources.GetObject("tsb_fetch.Image")));
            this.tsb_fetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_fetch.Name = "tsb_fetch";
            this.tsb_fetch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsb_fetch.Size = new System.Drawing.Size(52, 22);
            this.tsb_fetch.Text = "取价";
            this.tsb_fetch.Click += new System.EventHandler(this.Tsb_fetchPrice_Click);
            // 
            // tsb_supplement
            // 
            this.tsb_supplement.Image = ((System.Drawing.Image)(resources.GetObject("tsb_supplement.Image")));
            this.tsb_supplement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_supplement.Name = "tsb_supplement";
            this.tsb_supplement.Size = new System.Drawing.Size(52, 22);
            this.tsb_supplement.Text = "补价";
            this.tsb_supplement.Click += new System.EventHandler(this.Tsb_supplement_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = global::成本管理.Properties.Resources.save;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.Tsb_save_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = global::成本管理.Properties.Resources.delete;
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_generate
            // 
            this.tsb_generate.Image = global::成本管理.Properties.Resources.account;
            this.tsb_generate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_generate.Name = "tsb_generate";
            this.tsb_generate.Size = new System.Drawing.Size(52, 22);
            this.tsb_generate.Text = "计算";
            this.tsb_generate.Click += new System.EventHandler(this.Tsb_generate_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(23, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // dgv_bomMaterialUnit
            // 
            this.dgv_bomMaterialUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bomMaterialUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bomMaterialUnit.Location = new System.Drawing.Point(12, 129);
            this.dgv_bomMaterialUnit.Name = "dgv_bomMaterialUnit";
            this.dgv_bomMaterialUnit.RowTemplate.Height = 23;
            this.dgv_bomMaterialUnit.Size = new System.Drawing.Size(1041, 309);
            this.dgv_bomMaterialUnit.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(462, 256);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 9;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // gp_condition
            // 
            this.gp_condition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_condition.Controls.Add(this.txt_voucherNO);
            this.gp_condition.Controls.Add(this.dtp_endDate);
            this.gp_condition.Controls.Add(this.dtp_startDate);
            this.gp_condition.Controls.Add(this.lbl_vocherNO);
            this.gp_condition.Controls.Add(this.lbl_year);
            this.gp_condition.Controls.Add(this.lbl_endDate);
            this.gp_condition.Controls.Add(this.lbl_startDate);
            this.gp_condition.Controls.Add(this.cmb_year);
            this.gp_condition.Location = new System.Drawing.Point(12, 28);
            this.gp_condition.Name = "gp_condition";
            this.gp_condition.Size = new System.Drawing.Size(1041, 86);
            this.gp_condition.TabIndex = 11;
            this.gp_condition.TabStop = false;
            this.gp_condition.Text = "条件";
            // 
            // txt_voucherNO
            // 
            this.txt_voucherNO.Location = new System.Drawing.Point(159, 33);
            this.txt_voucherNO.Name = "txt_voucherNO";
            this.txt_voucherNO.Size = new System.Drawing.Size(100, 21);
            this.txt_voucherNO.TabIndex = 34;
            this.txt_voucherNO.Tag = "单据编号";
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Location = new System.Drawing.Point(828, 33);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(138, 21);
            this.dtp_endDate.TabIndex = 32;
            this.dtp_endDate.Tag = "结束日期";
            this.dtp_endDate.ValueChanged += new System.EventHandler(this.Dtp_endDate_ValueChanged);
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(599, 33);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(138, 21);
            this.dtp_startDate.TabIndex = 33;
            this.dtp_startDate.Tag = "开始日期";
            // 
            // lbl_vocherNO
            // 
            this.lbl_vocherNO.AutoSize = true;
            this.lbl_vocherNO.Location = new System.Drawing.Point(75, 36);
            this.lbl_vocherNO.Name = "lbl_vocherNO";
            this.lbl_vocherNO.Size = new System.Drawing.Size(65, 12);
            this.lbl_vocherNO.TabIndex = 28;
            this.lbl_vocherNO.Text = "单据编号：";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(316, 36);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(65, 12);
            this.lbl_year.TabIndex = 29;
            this.lbl_year.Text = "会计年度：";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(766, 36);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_endDate.TabIndex = 30;
            this.lbl_endDate.Text = "结束日期：";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(537, 36);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_startDate.TabIndex = 31;
            this.lbl_startDate.Text = "开始日期：";
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.cmb_year.Location = new System.Drawing.Point(387, 34);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(100, 20);
            this.cmb_year.TabIndex = 27;
            this.cmb_year.Tag = "会计年度";
            // 
            // tsb_export
            // 
            this.tsb_export.Image = ((System.Drawing.Image)(resources.GetObject("tsb_export.Image")));
            this.tsb_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_export.Name = "tsb_export";
            this.tsb_export.Size = new System.Drawing.Size(52, 22);
            this.tsb_export.Text = "导出";
            this.tsb_export.ToolTipText = "导出至EXCEL";
            this.tsb_export.Click += new System.EventHandler(this.Tsb_export_Click);
            // 
            // frm_bomMaterial_unitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.gp_condition);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgv_bomMaterialUnit);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_bomMaterial_unitPrice";
            this.Text = "BOM材料成本";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomMaterialUnit)).EndInit();
            this.gp_condition.ResumeLayout(false);
            this.gp_condition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsb_caculate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_fetch;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.DataGridView dgv_bomMaterialUnit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.GroupBox gp_condition;
        private System.Windows.Forms.TextBox txt_voucherNO;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label lbl_vocherNO;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ToolStripButton tsb_supplement;
        private System.Windows.Forms.ToolStripButton tsb_generate;
        private System.Windows.Forms.ToolStripButton tsb_export;
    }
}