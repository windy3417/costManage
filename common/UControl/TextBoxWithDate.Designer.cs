namespace U8Common.UControl
{
    partial class TextBoxWithDate
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_startDate.Location = new System.Drawing.Point(0, 0);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.Size = new System.Drawing.Size(107, 21);
            this.textBox_startDate.TabIndex = 0;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker_startDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(107, 0);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(18, 21);
            this.dateTimePicker_startDate.TabIndex = 1;
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // TextBoxWithDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.textBox_startDate);
            this.Name = "TextBoxWithDate";
            this.Size = new System.Drawing.Size(125, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
    }
}
