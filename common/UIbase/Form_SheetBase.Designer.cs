namespace common.UIbase
{
    partial class Form_SheetBase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipmentNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionQuanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_reportDate = new System.Windows.Forms.Label();
            this.label_Shift = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_productionLine = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label_director = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxWithDate1 = new U8Common.UControl.TextBoxWithDate();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentNO,
            this.staffNO,
            this.ProductNO,
            this.productionQuanlity});
            this.dataGridView1.Location = new System.Drawing.Point(1, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1412, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // equipmentNO
            // 
            this.equipmentNO.HeaderText = "设备编号";
            this.equipmentNO.Name = "equipmentNO";
            // 
            // staffNO
            // 
            this.staffNO.HeaderText = "员工编号";
            this.staffNO.Name = "staffNO";
            // 
            // ProductNO
            // 
            this.ProductNO.HeaderText = "产品编号";
            this.ProductNO.Name = "ProductNO";
            // 
            // productionQuanlity
            // 
            this.productionQuanlity.HeaderText = "生产数量";
            this.productionQuanlity.Name = "productionQuanlity";
            // 
            // label_reportDate
            // 
            this.label_reportDate.AutoSize = true;
            this.label_reportDate.Location = new System.Drawing.Point(12, 79);
            this.label_reportDate.Name = "label_reportDate";
            this.label_reportDate.Size = new System.Drawing.Size(53, 12);
            this.label_reportDate.TabIndex = 0;
            this.label_reportDate.Text = "报工日期";
            // 
            // label_Shift
            // 
            this.label_Shift.AutoSize = true;
            this.label_Shift.Location = new System.Drawing.Point(213, 79);
            this.label_Shift.Name = "label_Shift";
            this.label_Shift.Size = new System.Drawing.Size(29, 12);
            this.label_Shift.TabIndex = 0;
            this.label_Shift.Text = "班次";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "早班 07:40-15:40",
            "中班 15:40-23:40",
            "晚班 23:40-07:40"});
            this.comboBox1.Location = new System.Drawing.Point(248, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label_productionLine
            // 
            this.label_productionLine.AutoSize = true;
            this.label_productionLine.Location = new System.Drawing.Point(389, 79);
            this.label_productionLine.Name = "label_productionLine";
            this.label_productionLine.Size = new System.Drawing.Size(29, 12);
            this.label_productionLine.TabIndex = 0;
            this.label_productionLine.Text = "产线";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "缸体",
            "大缸体",
            "缸盖",
            "飞轮壳",
            "样件"});
            this.comboBox3.Location = new System.Drawing.Point(424, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 3;
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(573, 79);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(53, 12);
            this.label_director.TabIndex = 0;
            this.label_director.Text = "产线主管";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "吴水清",
            "黄为",
            "邓林超",
            "彭雄军",
            "陈小用"});
            this.comboBox2.Location = new System.Drawing.Point(632, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 3;
            // 
            // textBoxWithDate1
            // 
            this.textBoxWithDate1.Location = new System.Drawing.Point(71, 76);
            this.textBoxWithDate1.Name = "textBoxWithDate1";
            this.textBoxWithDate1.Size = new System.Drawing.Size(122, 19);
            this.textBoxWithDate1.TabIndex = 2;
            // 
            // Form_SheetBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 639);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_productionLine);
            this.Controls.Add(this.label_Shift);
            this.Controls.Add(this.textBoxWithDate1);
            this.Controls.Add(this.label_reportDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_SheetBase";
            this.Text = "表单模板";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionQuanlity;
        private System.Windows.Forms.Label label_reportDate;
        private System.Windows.Forms.Label label_Shift;
        private System.Windows.Forms.Label label_productionLine;
        private System.Windows.Forms.Label label_director;
        private U8Common.UControl.TextBoxWithDate textBoxWithDate1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}