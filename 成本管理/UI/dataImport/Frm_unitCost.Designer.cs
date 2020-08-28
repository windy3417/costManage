namespace 成本管理.UI
{
    partial class frm_unitCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_unitCost));
            this.dataGridViewDisplayExcel = new System.Windows.Forms.DataGridView();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_importTemplate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuit = new System.Windows.Forms.ToolStripButton();
            this.lbl_no = new System.Windows.Forms.Label();
            this.tex_no = new System.Windows.Forms.TextBox();
            this.BW_import = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayExcel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayExcel
            // 
            this.dataGridViewDisplayExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisplayExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayExcel.Location = new System.Drawing.Point(0, 142);
            this.dataGridViewDisplayExcel.Name = "dataGridViewDisplayExcel";
            this.dataGridViewDisplayExcel.RowTemplate.Height = 23;
            this.dataGridViewDisplayExcel.Size = new System.Drawing.Size(827, 350);
            this.dataGridViewDisplayExcel.TabIndex = 1;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(319, 40);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(53, 12);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "会计年度";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(530, 40);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(53, 12);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "会计期间";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBox1.Location = new System.Drawing.Point(389, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(599, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_importTemplate,
            this.toolStripButton1,
            this.toolStripButtonSave,
            this.tsb_delete,
            this.toolStripButtonQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_importTemplate
            // 
            this.tsb_importTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsb_importTemplate.Image")));
            this.tsb_importTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_importTemplate.Name = "tsb_importTemplate";
            this.tsb_importTemplate.Size = new System.Drawing.Size(52, 22);
            this.tsb_importTemplate.Text = "模板";
            this.tsb_importTemplate.ToolTipText = "导入模板";
            this.tsb_importTemplate.Click += new System.EventHandler(this.tsb_importTemplate_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::成本管理.Properties.Resources.importdir_wiz;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "导入";
            this.toolStripButton1.Click += new System.EventHandler(this.ImportExcelData);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::成本管理.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.Click += new System.EventHandler(this.SaveToDatabase);
            // 
            // tsb_delete
            // 
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(23, 22);
            this.tsb_delete.Text = "toolStripButton2";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // toolStripButtonQuit
            // 
            this.toolStripButtonQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuit.Image = global::成本管理.Properties.Resources.icon_quit;
            this.toolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuit.Name = "toolStripButtonQuit";
            this.toolStripButtonQuit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQuit.Text = "退出";
            this.toolStripButtonQuit.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Location = new System.Drawing.Point(88, 40);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(53, 12);
            this.lbl_no.TabIndex = 2;
            this.lbl_no.Text = "单据编号";
            // 
            // tex_no
            // 
            this.tex_no.Location = new System.Drawing.Point(148, 35);
            this.tex_no.Name = "tex_no";
            this.tex_no.Size = new System.Drawing.Size(123, 21);
            this.tex_no.TabIndex = 5;
            // 
            // frm_unitCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.tex_no);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.dataGridViewDisplayExcel);
            this.Name = "frm_unitCost";
            this.Text = "成本结构表导入";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayExcel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDisplayExcel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuit;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.TextBox tex_no;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_importTemplate;
        private System.ComponentModel.BackgroundWorker BW_import;
    }
}