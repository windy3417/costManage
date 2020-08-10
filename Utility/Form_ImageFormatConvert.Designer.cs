namespace utility

{
    partial class Form_imageFormatConvert
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_imageFormatConvert));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_openFile = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripButton_convertFomat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_openFile,
            this.toolStripButton_convertFomat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_openFile
            // 
            this.toolStripButton_openFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openFile.Image")));
            this.toolStripButton_openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openFile.Name = "toolStripButton_openFile";
            this.toolStripButton_openFile.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_openFile.Text = "打开文件";
            this.toolStripButton_openFile.Click += new System.EventHandler(this.toolStripButton_openFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 438);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripButton_convertFomat
            // 
            this.toolStripButton_convertFomat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_convertFomat.Image")));
            this.toolStripButton_convertFomat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_convertFomat.Name = "toolStripButton_convertFomat";
            this.toolStripButton_convertFomat.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_convertFomat.Text = "转换";
            this.toolStripButton_convertFomat.Click += new System.EventHandler(this.toolStripButton_convertFormat_Click);
            // 
            // Form_imageFormatConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_imageFormatConvert";
            this.Text = "图片格式转换工具";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_openFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_convertFomat;
    }
}

