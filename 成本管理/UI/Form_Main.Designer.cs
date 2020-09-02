namespace 成本管理.UI
{
    partial class Form_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成本结构表导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产成品单价导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成本计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM材料单价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成本对象写入ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.项目目录检查ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.写入成本对象ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.成本结构表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生产管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生产报工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_materialOutList = new System.Windows.Forms.ToolStripMenuItem();
            this.合同管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售合同清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月度发货计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料出库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生产订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购订单列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.材料出库单列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.u8任务清除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.图片格式转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库配置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider_mainForm = new System.Windows.Forms.HelpProvider();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip_dbInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label_accountIDtext = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip_dbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据录入ToolStripMenuItem,
            this.成本计算ToolStripMenuItem,
            this.生产管理ToolStripMenuItem,
            this.合同管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.报表toolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据录入ToolStripMenuItem
            // 
            this.数据录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成本结构表导入ToolStripMenuItem,
            this.产成品单价导入ToolStripMenuItem});
            this.数据录入ToolStripMenuItem.Name = "数据录入ToolStripMenuItem";
            this.数据录入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据录入ToolStripMenuItem.Text = "数据录入";
            // 
            // 成本结构表导入ToolStripMenuItem
            // 
            this.成本结构表导入ToolStripMenuItem.Name = "成本结构表导入ToolStripMenuItem";
            this.成本结构表导入ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.成本结构表导入ToolStripMenuItem.Text = "成本结构表导入";
            this.成本结构表导入ToolStripMenuItem.Click += new System.EventHandler(this.成本结构表导入ToolStripMenuItem_Click);
            // 
            // 产成品单价导入ToolStripMenuItem
            // 
            this.产成品单价导入ToolStripMenuItem.Name = "产成品单价导入ToolStripMenuItem";
            this.产成品单价导入ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.产成品单价导入ToolStripMenuItem.Text = "产成品单价导入";
            this.产成品单价导入ToolStripMenuItem.Click += new System.EventHandler(this.产成品单价导入ToolStripMenuItem_Click);
            // 
            // 成本计算ToolStripMenuItem
            // 
            this.成本计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOM材料单价ToolStripMenuItem,
            this.成本对象写入ToolStripMenuItem1,
            this.成本结构表查询ToolStripMenuItem});
            this.成本计算ToolStripMenuItem.Name = "成本计算ToolStripMenuItem";
            this.成本计算ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成本计算ToolStripMenuItem.Text = "成本管理";
            this.成本计算ToolStripMenuItem.Click += new System.EventHandler(this.成本计算ToolStripMenuItem_Click);
            // 
            // bOM材料单价ToolStripMenuItem
            // 
            this.bOM材料单价ToolStripMenuItem.Name = "bOM材料单价ToolStripMenuItem";
            this.bOM材料单价ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bOM材料单价ToolStripMenuItem.Text = "BOM材料单价";
            this.bOM材料单价ToolStripMenuItem.Click += new System.EventHandler(this.BOM材料单价ToolStripMenuItem_Click);
            // 
            // 成本对象写入ToolStripMenuItem1
            // 
            this.成本对象写入ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目目录检查ToolStripMenuItem1,
            this.写入成本对象ToolStripMenuItem1});
            this.成本对象写入ToolStripMenuItem1.Name = "成本对象写入ToolStripMenuItem1";
            this.成本对象写入ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.成本对象写入ToolStripMenuItem1.Text = "成本对象写入";
            // 
            // 项目目录检查ToolStripMenuItem1
            // 
            this.项目目录检查ToolStripMenuItem1.Name = "项目目录检查ToolStripMenuItem1";
            this.项目目录检查ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.项目目录检查ToolStripMenuItem1.Text = "项目目录检查";
            this.项目目录检查ToolStripMenuItem1.Click += new System.EventHandler(this.项目目录检查ToolStripMenuItem1_Click);
            // 
            // 写入成本对象ToolStripMenuItem1
            // 
            this.写入成本对象ToolStripMenuItem1.Name = "写入成本对象ToolStripMenuItem1";
            this.写入成本对象ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.写入成本对象ToolStripMenuItem1.Text = "写入成本对象";
            this.写入成本对象ToolStripMenuItem1.Click += new System.EventHandler(this.写入成本对象ToolStripMenuItem1_Click);
            // 
            // 成本结构表查询ToolStripMenuItem
            // 
            this.成本结构表查询ToolStripMenuItem.Name = "成本结构表查询ToolStripMenuItem";
            this.成本结构表查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.成本结构表查询ToolStripMenuItem.Text = "成本结构表查询";
            // 
            // 生产管理ToolStripMenuItem
            // 
            this.生产管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生产报工ToolStripMenuItem,
            this.tsmi_materialOutList});
            this.生产管理ToolStripMenuItem.Name = "生产管理ToolStripMenuItem";
            this.生产管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.生产管理ToolStripMenuItem.Text = "生产管理";
            // 
            // 生产报工ToolStripMenuItem
            // 
            this.生产报工ToolStripMenuItem.Name = "生产报工ToolStripMenuItem";
            this.生产报工ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.生产报工ToolStripMenuItem.Text = "生产报工";
            // 
            // tsmi_materialOutList
            // 
            this.tsmi_materialOutList.Name = "tsmi_materialOutList";
            this.tsmi_materialOutList.Size = new System.Drawing.Size(180, 22);
            this.tsmi_materialOutList.Text = "材料出库单";
            this.tsmi_materialOutList.Click += new System.EventHandler(this.Tsmi_materialOutList_Click);
            // 
            // 合同管理ToolStripMenuItem
            // 
            this.合同管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POContractToolStripMenuItem,
            this.销售合同清单ToolStripMenuItem});
            this.合同管理ToolStripMenuItem.Name = "合同管理ToolStripMenuItem";
            this.合同管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.合同管理ToolStripMenuItem.Text = "合同管理";
            // 
            // POContractToolStripMenuItem
            // 
            this.POContractToolStripMenuItem.Name = "POContractToolStripMenuItem";
            this.POContractToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.POContractToolStripMenuItem.Text = "采购合同清单";
            this.POContractToolStripMenuItem.Click += new System.EventHandler(this.POContractToolStripMenuItem_Click);
            // 
            // 销售合同清单ToolStripMenuItem
            // 
            this.销售合同清单ToolStripMenuItem.Name = "销售合同清单ToolStripMenuItem";
            this.销售合同清单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.销售合同清单ToolStripMenuItem.Text = "销售合同清单";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.月度发货计划ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 月度发货计划ToolStripMenuItem
            // 
            this.月度发货计划ToolStripMenuItem.Name = "月度发货计划ToolStripMenuItem";
            this.月度发货计划ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.月度发货计划ToolStripMenuItem.Text = "月度发货计划";
            this.月度发货计划ToolStripMenuItem.Click += new System.EventHandler(this.月度发货计划ToolStripMenuItem_Click);
            // 
            // 报表toolStripMenuItem
            // 
            this.报表toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.材料出库单ToolStripMenuItem,
            this.生产订单ToolStripMenuItem,
            this.销售订单ToolStripMenuItem,
            this.采购订单列表ToolStripMenuItem,
            this.材料出库单列表ToolStripMenuItem});
            this.报表toolStripMenuItem.Name = "报表toolStripMenuItem";
            this.报表toolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表toolStripMenuItem.Text = "报表";
            // 
            // 材料出库单ToolStripMenuItem
            // 
            this.材料出库单ToolStripMenuItem.Name = "材料出库单ToolStripMenuItem";
            this.材料出库单ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.材料出库单ToolStripMenuItem.Text = "材料出库单";
            this.材料出库单ToolStripMenuItem.Click += new System.EventHandler(this.材料出库单ToolStripMenuItem_Click);
            // 
            // 生产订单ToolStripMenuItem
            // 
            this.生产订单ToolStripMenuItem.Name = "生产订单ToolStripMenuItem";
            this.生产订单ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.生产订单ToolStripMenuItem.Text = "生产订单";
            this.生产订单ToolStripMenuItem.Click += new System.EventHandler(this.生产订单ToolStripMenuItem_Click);
            // 
            // 销售订单ToolStripMenuItem
            // 
            this.销售订单ToolStripMenuItem.Name = "销售订单ToolStripMenuItem";
            this.销售订单ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.销售订单ToolStripMenuItem.Text = "销售订单";
            this.销售订单ToolStripMenuItem.Click += new System.EventHandler(this.销售订单ToolStripMenuItem_Click);
            // 
            // 采购订单列表ToolStripMenuItem
            // 
            this.采购订单列表ToolStripMenuItem.Name = "采购订单列表ToolStripMenuItem";
            this.采购订单列表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.采购订单列表ToolStripMenuItem.Text = "采购订单列表";
            this.采购订单列表ToolStripMenuItem.Click += new System.EventHandler(this.采购订单列表ToolStripMenuItem_Click);
            // 
            // 材料出库单列表ToolStripMenuItem
            // 
            this.材料出库单列表ToolStripMenuItem.Name = "材料出库单列表ToolStripMenuItem";
            this.材料出库单列表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.材料出库单列表ToolStripMenuItem.Text = "材料出库单列表";
            this.材料出库单列表ToolStripMenuItem.Click += new System.EventHandler(this.材料出库单列表ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.u8任务清除ToolStripMenuItem1,
            this.图片格式转换ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // u8任务清除ToolStripMenuItem1
            // 
            this.u8任务清除ToolStripMenuItem1.Name = "u8任务清除ToolStripMenuItem1";
            this.u8任务清除ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.u8任务清除ToolStripMenuItem1.Text = "U8任务清除";
            this.u8任务清除ToolStripMenuItem1.Click += new System.EventHandler(this.u8任务清除ToolStripMenuItem_Click);
            // 
            // 图片格式转换ToolStripMenuItem
            // 
            this.图片格式转换ToolStripMenuItem.Name = "图片格式转换ToolStripMenuItem";
            this.图片格式转换ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图片格式转换ToolStripMenuItem.Text = "图片格式转换";
            this.图片格式转换ToolStripMenuItem.Click += new System.EventHandler(this.图片格式转换ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem1});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 数据库配置ToolStripMenuItem1
            // 
            this.数据库配置ToolStripMenuItem1.Name = "数据库配置ToolStripMenuItem1";
            this.数据库配置ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.数据库配置ToolStripMenuItem1.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem1.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Size = new System.Drawing.Size(936, 503);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(177, 298);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "008.gif");
            this.imageList1.Images.SetKeyName(1, "arrow-1.gif");
            this.imageList1.Images.SetKeyName(2, "defultsetting.gif");
            this.imageList1.Images.SetKeyName(3, "arrow-2.gif");
            // 
            // statusStrip_dbInfo
            // 
            this.statusStrip_dbInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Label_accountIDtext});
            this.statusStrip_dbInfo.Location = new System.Drawing.Point(0, 528);
            this.statusStrip_dbInfo.Name = "statusStrip_dbInfo";
            this.statusStrip_dbInfo.Size = new System.Drawing.Size(948, 22);
            this.statusStrip_dbInfo.TabIndex = 3;
            this.statusStrip_dbInfo.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "当前U8账套:";
            // 
            // Label_accountIDtext
            // 
            this.Label_accountIDtext.Name = "Label_accountIDtext";
            this.Label_accountIDtext.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.statusStrip_dbInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "成本管理";
            this.Load += new System.EventHandler(this.FromMainLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip_dbInfo.ResumeLayout(false);
            this.statusStrip_dbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产成品单价导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成本计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料出库单ToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider_mainForm;
        private System.Windows.Forms.ToolStripMenuItem 成本对象写入ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 写入成本对象ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 项目目录检查ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem u8任务清除ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 图片格式转换ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tc = new System.Windows.Forms.TabControl();
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 生产订单ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_dbInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Label_accountIDtext;
        private System.Windows.Forms.ToolStripMenuItem 销售订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购订单列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 材料出库单列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生产管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生产报工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_materialOutList;
        private System.Windows.Forms.ToolStripMenuItem 合同管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem POContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售合同清单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月度发货计划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成本结构表导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 成本结构表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM材料单价ToolStripMenuItem;
    }
}

