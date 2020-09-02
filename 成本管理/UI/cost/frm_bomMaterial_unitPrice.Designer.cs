namespace 成本管理.UI.cost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bomMaterial_unitPrice));
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.tsb_caculate = new System.Windows.Forms.ToolStripButton();
            this.tbd_startDate = new U8Common.UControl.TextBoxWithDate();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_caculater = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.dgv_bomMaterialUnit = new System.Windows.Forms.DataGridView();
            this.tbd_endDate = new U8Common.UControl.TextBoxWithDate();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomMaterialUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.cmb_year.Location = new System.Drawing.Point(101, 50);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 20);
            this.cmb_year.TabIndex = 2;
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(301, 53);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_startDate.TabIndex = 4;
            this.lbl_startDate.Text = "开始日期：";
            // 
            // tsb_caculate
            // 
            this.tsb_caculate.Image = ((System.Drawing.Image)(resources.GetObject("tsb_caculate.Image")));
            this.tsb_caculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_caculate.Name = "tsb_caculate";
            this.tsb_caculate.Size = new System.Drawing.Size(52, 22);
            this.tsb_caculate.Text = "计算";
            // 
            // tbd_startDate
            // 
            this.tbd_startDate.Location = new System.Drawing.Point(372, 48);
            this.tbd_startDate.Name = "tbd_startDate";
            this.tbd_startDate.Size = new System.Drawing.Size(125, 21);
            this.tbd_startDate.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_caculater,
            this.tsb_save,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_caculater
            // 
            this.tsb_caculater.Image = global::成本管理.Properties.Resources.account;
            this.tsb_caculater.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_caculater.Name = "tsb_caculater";
            this.tsb_caculater.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsb_caculater.Size = new System.Drawing.Size(52, 22);
            this.tsb_caculater.Text = "计算";
            this.tsb_caculater.Click += new System.EventHandler(this.Tsb_caculater_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = global::成本管理.Properties.Resources.save;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
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
            // tbd_endDate
            // 
            this.tbd_endDate.Location = new System.Drawing.Point(681, 48);
            this.tbd_endDate.Name = "tbd_endDate";
            this.tbd_endDate.Size = new System.Drawing.Size(125, 21);
            this.tbd_endDate.TabIndex = 5;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(610, 53);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_endDate.TabIndex = 4;
            this.lbl_endDate.Text = "结束日期：";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(30, 53);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(65, 12);
            this.lbl_year.TabIndex = 4;
            this.lbl_year.Text = "会计年度：";
            // 
            // frm_bomMaterial_unitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.dgv_bomMaterialUnit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbd_endDate);
            this.Controls.Add(this.tbd_startDate);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.cmb_year);
            this.Name = "frm_bomMaterial_unitPrice";
            this.Text = "BOM材料单价";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomMaterialUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.ToolStripButton tsb_caculate;
        private U8Common.UControl.TextBoxWithDate tbd_startDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_caculater;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.DataGridView dgv_bomMaterialUnit;
        private U8Common.UControl.TextBoxWithDate tbd_endDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_year;
    }
}