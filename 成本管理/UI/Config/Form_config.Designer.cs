namespace 成本管理.UI
{
    partial class Form_config
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_databaseConfigRead = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb_plug = new System.Windows.Forms.RadioButton();
            this.rb_u8 = new System.Windows.Forms.RadioButton();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_testConect = new System.Windows.Forms.Button();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.label_server = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_database = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_plugConfig = new System.Windows.Forms.RadioButton();
            this.rb_U8config = new System.Windows.Forms.RadioButton();
            this.button_deleteConfig = new System.Windows.Forms.Button();
            this.textBox_configedDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageQuit = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuit = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl_databaseConfigRead.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageQuit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_databaseConfigRead
            // 
            this.tabControl_databaseConfigRead.Controls.Add(this.tabPage1);
            this.tabControl_databaseConfigRead.Controls.Add(this.tabPage2);
            this.tabControl_databaseConfigRead.Controls.Add(this.tabPageQuit);
            this.tabControl_databaseConfigRead.Location = new System.Drawing.Point(0, 0);
            this.tabControl_databaseConfigRead.Name = "tabControl_databaseConfigRead";
            this.tabControl_databaseConfigRead.SelectedIndex = 0;
            this.tabControl_databaseConfigRead.Size = new System.Drawing.Size(747, 421);
            this.tabControl_databaseConfigRead.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl_databaseConfigRead.TabIndex = 0;
            this.tabControl_databaseConfigRead.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_databaseConfigRead_Selecting);
            this.tabControl_databaseConfigRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rb_plug);
            this.tabPage1.Controls.Add(this.rb_u8);
            this.tabPage1.Controls.Add(this.button_confirm);
            this.tabPage1.Controls.Add(this.button_testConect);
            this.tabPage1.Controls.Add(this.textBox_server);
            this.tabPage1.Controls.Add(this.label_server);
            this.tabPage1.Controls.Add(this.textBox_password);
            this.tabPage1.Controls.Add(this.label_password);
            this.tabPage1.Controls.Add(this.label_database);
            this.tabPage1.Controls.Add(this.label_user);
            this.tabPage1.Controls.Add(this.textBox_user);
            this.tabPage1.Controls.Add(this.textBox_database);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据库连接";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rb_plug
            // 
            this.rb_plug.AutoSize = true;
            this.rb_plug.Location = new System.Drawing.Point(222, 24);
            this.rb_plug.Name = "rb_plug";
            this.rb_plug.Size = new System.Drawing.Size(83, 16);
            this.rb_plug.TabIndex = 12;
            this.rb_plug.TabStop = true;
            this.rb_plug.Text = "外挂数据库";
            this.rb_plug.UseVisualStyleBackColor = true;
            // 
            // rb_u8
            // 
            this.rb_u8.AutoSize = true;
            this.rb_u8.Checked = true;
            this.rb_u8.Location = new System.Drawing.Point(83, 24);
            this.rb_u8.Name = "rb_u8";
            this.rb_u8.Size = new System.Drawing.Size(71, 16);
            this.rb_u8.TabIndex = 12;
            this.rb_u8.TabStop = true;
            this.rb_u8.Text = "U8数据库";
            this.rb_u8.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(242, 219);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click_1);
            // 
            // button_testConect
            // 
            this.button_testConect.Location = new System.Drawing.Point(129, 219);
            this.button_testConect.Name = "button_testConect";
            this.button_testConect.Size = new System.Drawing.Size(75, 23);
            this.button_testConect.TabIndex = 5;
            this.button_testConect.Text = "测试连接";
            this.button_testConect.UseVisualStyleBackColor = true;
            this.button_testConect.Click += new System.EventHandler(this.button_testConect_Click);
            // 
            // textBox_server
            // 
            this.textBox_server.Location = new System.Drawing.Point(187, 59);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(100, 21);
            this.textBox_server.TabIndex = 1;
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Location = new System.Drawing.Point(127, 68);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(41, 12);
            this.label_server.TabIndex = 11;
            this.label_server.Text = "服务器";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(187, 162);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 21);
            this.textBox_password.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(127, 162);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(29, 12);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "密码";
            // 
            // label_database
            // 
            this.label_database.AutoSize = true;
            this.label_database.Location = new System.Drawing.Point(127, 95);
            this.label_database.Name = "label_database";
            this.label_database.Size = new System.Drawing.Size(41, 12);
            this.label_database.TabIndex = 10;
            this.label_database.Text = "数据库";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(127, 131);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(41, 12);
            this.label_user.TabIndex = 9;
            this.label_user.Text = "用户名";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(187, 128);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(100, 21);
            this.textBox_user.TabIndex = 3;
            // 
            // textBox_database
            // 
            this.textBox_database.Location = new System.Drawing.Point(187, 92);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(100, 21);
            this.textBox_database.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rb_plugConfig);
            this.tabPage2.Controls.Add(this.rb_U8config);
            this.tabPage2.Controls.Add(this.button_deleteConfig);
            this.tabPage2.Controls.Add(this.textBox_configedDatabase);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配置信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_plugConfig
            // 
            this.rb_plugConfig.AutoSize = true;
            this.rb_plugConfig.Location = new System.Drawing.Point(183, 43);
            this.rb_plugConfig.Name = "rb_plugConfig";
            this.rb_plugConfig.Size = new System.Drawing.Size(107, 16);
            this.rb_plugConfig.TabIndex = 5;
            this.rb_plugConfig.Text = "外挂数据库配置";
            this.rb_plugConfig.UseVisualStyleBackColor = true;
            this.rb_plugConfig.Click += new System.EventHandler(this.Rb_plugConfig_Click);
            // 
            // rb_U8config
            // 
            this.rb_U8config.AutoSize = true;
            this.rb_U8config.Checked = true;
            this.rb_U8config.Location = new System.Drawing.Point(41, 43);
            this.rb_U8config.Name = "rb_U8config";
            this.rb_U8config.Size = new System.Drawing.Size(119, 16);
            this.rb_U8config.TabIndex = 5;
            this.rb_U8config.TabStop = true;
            this.rb_U8config.Text = "U8数据库配置信息";
            this.rb_U8config.UseVisualStyleBackColor = true;
            this.rb_U8config.Click += new System.EventHandler(this.Rb_U8config_Click);
            // 
            // button_deleteConfig
            // 
            this.button_deleteConfig.Location = new System.Drawing.Point(116, 158);
            this.button_deleteConfig.Name = "button_deleteConfig";
            this.button_deleteConfig.Size = new System.Drawing.Size(75, 23);
            this.button_deleteConfig.TabIndex = 2;
            this.button_deleteConfig.Text = "删除配置";
            this.button_deleteConfig.UseVisualStyleBackColor = true;
            this.button_deleteConfig.Click += new System.EventHandler(this.button_deleteConfig_Click);
            // 
            // textBox_configedDatabase
            // 
            this.textBox_configedDatabase.Location = new System.Drawing.Point(154, 93);
            this.textBox_configedDatabase.Name = "textBox_configedDatabase";
            this.textBox_configedDatabase.Size = new System.Drawing.Size(100, 21);
            this.textBox_configedDatabase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库名：";
            // 
            // tabPageQuit
            // 
            this.tabPageQuit.Controls.Add(this.toolStrip1);
            this.tabPageQuit.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuit.Name = "tabPageQuit";
            this.tabPageQuit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuit.Size = new System.Drawing.Size(739, 395);
            this.tabPageQuit.TabIndex = 2;
            this.tabPageQuit.Text = "退出";
            this.tabPageQuit.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonQuit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonQuit
            // 
            this.toolStripButtonQuit.Image = global::成本管理.Properties.Resources.icon_quit;
            this.toolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuit.Name = "toolStripButtonQuit";
            this.toolStripButtonQuit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonQuit.Text = "退出";
            this.toolStripButtonQuit.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 419);
            this.Controls.Add(this.tabControl_databaseConfigRead);
            this.Name = "Form_config";
            this.Text = "数据库连接";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_config_FormClosed);
            this.Load += new System.EventHandler(this.Form_config_Load);
            this.tabControl_databaseConfigRead.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPageQuit.ResumeLayout(false);
            this.tabPageQuit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_databaseConfigRead;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.Label label_database;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_testConect;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_configedDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_deleteConfig;
        private System.Windows.Forms.TabPage tabPageQuit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuit;
        private System.Windows.Forms.RadioButton rb_plug;
        private System.Windows.Forms.RadioButton rb_u8;
        private System.Windows.Forms.RadioButton rb_plugConfig;
        private System.Windows.Forms.RadioButton rb_U8config;
    }
}