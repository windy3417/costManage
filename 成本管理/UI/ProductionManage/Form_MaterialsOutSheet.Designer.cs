namespace 成本管理.UI
{
    partial class Form_MaterialsOutSheet
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
            this.label_wareHouseCode = new System.Windows.Forms.Label();
            this.textBox_warehouseCode = new System.Windows.Forms.TextBox();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click_1);
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(156, 20);
            this.textBox_startDate.Size = new System.Drawing.Size(90, 21);
            this.textBox_startDate.Text = "2018-06-01";
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(463, 20);
            this.textBox_endDate.Size = new System.Drawing.Size(90, 21);
            this.textBox_endDate.Text = "2018-06-05";
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.textBox_warehouseCode);
            this.groupBox_Filter.Controls.Add(this.label_wareHouseCode);
            this.groupBox_Filter.Controls.SetChildIndex(this.textBox_endDate, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.textBox_startDate, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.button_confirm, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.label_wareHouseCode, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.textBox_warehouseCode, 0);
            // 
            // label_wareHouseCode
            // 
            this.label_wareHouseCode.AutoSize = true;
            this.label_wareHouseCode.Location = new System.Drawing.Point(658, 22);
            this.label_wareHouseCode.Name = "label_wareHouseCode";
            this.label_wareHouseCode.Size = new System.Drawing.Size(53, 12);
            this.label_wareHouseCode.TabIndex = 7;
            this.label_wareHouseCode.Text = "仓库编码";
            // 
            // textBox_warehouseCode
            // 
            this.textBox_warehouseCode.Location = new System.Drawing.Point(754, 19);
            this.textBox_warehouseCode.Name = "textBox_warehouseCode";
            this.textBox_warehouseCode.Size = new System.Drawing.Size(100, 21);
            this.textBox_warehouseCode.TabIndex = 8;
            this.textBox_warehouseCode.Tag = "p.cWhCode";
            // 
            // Form_MaterialsOutSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 726);
            this.Name = "Form_MaterialsOutSheet";
            this.Text = "材料出库单列表";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wareHouseCode;
        private System.Windows.Forms.TextBox textBox_warehouseCode;
    }
}