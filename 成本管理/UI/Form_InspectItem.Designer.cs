namespace 成本管理.UI
{
    partial class Form_InspectItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InspectItem));
            this.label_inspectResult = new System.Windows.Forms.Label();
            this.dataGridView_inspect = new System.Windows.Forms.DataGridView();
            this.label_inspectResultText = new System.Windows.Forms.Label();
            this.button_inspect = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStripButton_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_printView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_export = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inspect)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_inspectResult
            // 
            this.label_inspectResult.AutoSize = true;
            this.label_inspectResult.Location = new System.Drawing.Point(0, 35);
            this.label_inspectResult.Name = "label_inspectResult";
            this.label_inspectResult.Size = new System.Drawing.Size(65, 12);
            this.label_inspectResult.TabIndex = 0;
            this.label_inspectResult.Text = "检查结果：";
            // 
            // dataGridView_inspect
            // 
            this.dataGridView_inspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_inspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inspect.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_inspect.Name = "dataGridView_inspect";
            this.dataGridView_inspect.RowTemplate.Height = 23;
            this.dataGridView_inspect.Size = new System.Drawing.Size(915, 443);
            this.dataGridView_inspect.TabIndex = 1;
            // 
            // label_inspectResultText
            // 
            this.label_inspectResultText.AutoSize = true;
            this.label_inspectResultText.Location = new System.Drawing.Point(0, 65);
            this.label_inspectResultText.Name = "label_inspectResultText";
            this.label_inspectResultText.Size = new System.Drawing.Size(251, 12);
            this.label_inspectResultText.TabIndex = 2;
            this.label_inspectResultText.Text = "项目目录与BOM一级母件信息一致，检查通过。";
            // 
            // button_inspect
            // 
            this.button_inspect.Location = new System.Drawing.Point(516, 30);
            this.button_inspect.Name = "button_inspect";
            this.button_inspect.Size = new System.Drawing.Size(75, 23);
            this.button_inspect.TabIndex = 3;
            this.button_inspect.Text = "检查";
            this.button_inspect.UseVisualStyleBackColor = true;
            this.button_inspect.Click += new System.EventHandler(this.button_inspect_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_print,
            this.toolStripButton_printView,
            this.toolStripButton_export,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // toolStripButton_print
            // 
            this.toolStripButton_print.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_print.Image")));
            this.toolStripButton_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_print.Name = "toolStripButton_print";
            this.toolStripButton_print.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_print.Text = "打印";
            this.toolStripButton_print.Click += new System.EventHandler(this.toolStripButton_print_Click);
            // 
            // toolStripButton_printView
            // 
            this.toolStripButton_printView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_printView.Image")));
            this.toolStripButton_printView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_printView.Name = "toolStripButton_printView";
            this.toolStripButton_printView.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_printView.Text = "预览";
            this.toolStripButton_printView.Click += new System.EventHandler(this.toolStripButton_printView_Click);
            // 
            // toolStripButton_export
            // 
            this.toolStripButton_export.Image = global::成本管理.Properties.Resources.icon_export;
            this.toolStripButton_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_export.Name = "toolStripButton_export";
            this.toolStripButton_export.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_export.Text = "导出";
            this.toolStripButton_export.Click += new System.EventHandler(this.toolStripButton_export_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::成本管理.Properties.Resources.icon_quit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "退出";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // Form_InspectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 523);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_inspect);
            this.Controls.Add(this.label_inspectResultText);
            this.Controls.Add(this.dataGridView_inspect);
            this.Controls.Add(this.label_inspectResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_InspectItem";
            this.Text = "项目目录检查";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_inspectItem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inspect)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_inspectResult;
        private System.Windows.Forms.DataGridView dataGridView_inspect;
        private System.Windows.Forms.Label label_inspectResultText;
        private System.Windows.Forms.Button button_inspect;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton_printView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton_export;
    }
}