namespace 成本管理.UI
{
    partial class Form_SaleOrders
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
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Click += new System.EventHandler(this.Button_confirm_Click_1);
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Text = "2020-09-01";
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Text = "2020-09-02";
            // 
            // Form_SaleOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 738);
            this.Name = "Form_SaleOrders";
            this.Text = "Form_SaleOrders";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}