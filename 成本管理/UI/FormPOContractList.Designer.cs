namespace 成本管理.UI
{
    partial class FormPOContractList
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(777, 20);
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Text = "2019-11-01";
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Text = "2019-11-13";
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.button1);
            this.groupBox_Filter.Size = new System.Drawing.Size(1735, 57);
            this.groupBox_Filter.Controls.SetChildIndex(this.textBox_endDate, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.textBox_startDate, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.button_confirm, 0);
            this.groupBox_Filter.Controls.SetChildIndex(this.button1, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPOContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 534);
            this.Name = "FormPOContractList";
            this.Text = "采购合同清单";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}