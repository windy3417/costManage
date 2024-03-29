﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Utility;
using 成本管理.Model;
using 成本管理.DAL;

namespace 成本管理.UI
{
    public partial class Form_config : Form
    {
       
        public Form_config()
        {
            InitializeComponent();
        }

        private void Form_config_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 鼠标按键事件。
        /// 如果检查到按下的是回车键，则发一个消息，模拟键盘按以下Tab键，以使输入焦点转移到下一个文本框（或其他焦点可停留的控件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_testConect_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 本地数据库连接是否成功
            /// </summary>
            /// <returns></returns>
       
        
            
            //获取数据库连接字符串
            string con = "Data Source=" + textBox_server.Text+ ";Initial Catalog="+textBox_database.Text+";User ID= "+ textBox_user.Text + ";Password="+
                textBox_password.Text + ";Pooling=False";
            
            //创建连接对象
            SqlConnection mySqlConnection = new SqlConnection(con);
            try
            {
                mySqlConnection.Open();
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("连接成功！","连接提示");
                  
                }
                else
                {
                    MessageBox.Show("连接失败！","连接提示");
                }
            }
            catch 
            {
                MessageBox.Show("连接失败！" , "连接提示");
            }
            finally
            {
                mySqlConnection.Close();
            }
          
        }

         /// <summary>
        /// 更改数据库连接
        /// </summary>
        /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button_confirm_Click_1(object sender, EventArgs e)
        {
            bool isModified = false;    //记录该连接串是否已经存在
            string dataBaseType;
            
            string conString = "Data Source=" + textBox_server.Text + ";Initial Catalog=" + textBox_database.Text + ";" +
                "User ID=" + textBox_user.Text + ";Password="
                + textBox_password.Text + ";Pooling=False;";
            //加密码连接字符串
            string encryptConString = Encrypt.Encode(conString);
            

            if (rb_u8.Checked)
            {
                dataBaseType = rb_u8.Text;
                
               
            }
            else
            {
                dataBaseType = rb_plug.Text;
            }

            if (ConfigurationManager.ConnectionStrings["myConcetion" + dataBaseType] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例 

            ConnectionStringSettings mySettings = new ConnectionStringSettings("myConcetion"+dataBaseType, encryptConString);

            // 打开可执行的配置文件*.exe.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 如果连接串已存在，首先删除它 
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove("myConcetion"+dataBaseType);
            }
            // 将新的连接串添加到配置文件中. 
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改 
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节  
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("数据库配置成功", "数据库配置");
            
            //刷新主窗体状态栏
              DataBaseInfo.dataBaseName = this.textBox_database.Text;

            //清空配置信息
            foreach (Control item in tlp_config.Controls)
            {
                item.Text = "";
            }
        }

        /// <summary>
        /// 默认读取数据库连接信息中的数据库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   
        private void tabControl_databaseConfigRead_Selecting(object sender, TabControlCancelEventArgs e)
        {
            this.readDataBase(DBName.u8.ToString());
        }


        /// <summary>
        /// 选择外挂数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rb_plugConfig_Click(object sender, EventArgs e)
        {
            this.readDataBase(DBName.plug.ToString());
        }


        /// <summary>
        /// 选择U8数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rb_U8config_Click(object sender, EventArgs e)
        {
            this.readDataBase(DBName.u8.ToString());
        }

        /// <summary>
        /// 读取数据库连接信息中的数据库信息
        /// </summary>
        /// <param name="dataBaseType">选定U8或外挂数据库，接受DBname的枚举值</param>
        private void readDataBase(string dataBaseType)
        {
             string conectDataBase;
            if (dataBaseType==DBName.u8.ToString())
            {
                conectDataBase = "myConcetionU8数据库";
            }
            else
            {
                conectDataBase = "myConcetion外挂数据库";
            }
            if (ConfigurationManager.ConnectionStrings[conectDataBase] != null)
            {
                string conString = ConfigurationManager.ConnectionStrings[conectDataBase].ToString();
                string deConString = Encrypt.Decode(conString);
                int dataBaseIndex = deConString.IndexOf("Catalog=");
                int UserIndex = deConString.IndexOf(";User");

                textBox_configedDatabase.Text = deConString.Substring(dataBaseIndex + 8, UserIndex - (dataBaseIndex + 8));

            }
            else
            {
                textBox_configedDatabase.Text = "";
            }
        }

        /// <summary>
        /// 删除数据库配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_deleteConfig_Click(object sender, EventArgs e)
        {
            if(textBox_configedDatabase.Text!="")
            {
                string conectionInformation;
                if (rb_plugConfig.Checked)
                {
                    conectionInformation = "myConcetion外挂数据库";
                }
                else
                {
                    conectionInformation = "myConcetionU8数据库";
                }
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Remove(conectionInformation);
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("数据库配置删除成功", "删除提示");
                ConfigurationManager.RefreshSection("connectionStrings");
                textBox_configedDatabase.Text = "";
                //刷新主窗体状态栏


                DataBaseInfo.dataBaseName = this.textBox_database.Text;

            }
            else
            {
                MessageBox.Show("没有可删除的数据库连接", "删除提示");
            }
        }

        private void Form_config_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    
}
