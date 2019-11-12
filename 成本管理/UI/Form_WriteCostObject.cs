using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Configuration;

using U8common;


using 成本管理.DAL;
using 成本管理.DAL.sheets;
using 成本管理.Model;
using 成本管理.DAL.Reports;


namespace 成本管理.UI
{
    public partial class Form_WriteCostObject : Form
    {
        #region 环境初始化
        /// <summary>
        /// 初始化控件，成本写入菜单不可见
        /// </summary>
        public Form_WriteCostObject()
        {
            InitializeComponent();
            toolStripButton_writeForOrder.Enabled = false;
            toolStripButton_writeForOrder.Visible = false;
            toolStripButton_writeForOutsourcing.Enabled = false;
            toolStripButton_writeForOutsourcing.Visible = false;
            toolStripButton_resultQuery.Visible = false;
            textBox_startDate.Text = "";
            textBox_endDate.Text = "";
            dataGridView_writeResult.Dock = DockStyle.None;
            dataGridView_writeResult.TopLeftHeaderCell.Value = "序号";
            dataGridView_writeResult.RowHeadersWidth = 60;
            dataGridView_writeResult.ScrollBars = ScrollBars.Both;
            DoubleBufferedDataGridView.DoubleBuffered(this.dataGridView_writeResult, true);//解决该控件滚动条移动时，数据刷新过慢的问题




        }

        #endregion


        #region 封装SQLparmameter
            /// <summary>
            /// 封装会计期间SQL参数用于期间检查
            /// </summary>
            /// <param name="string_iperiodStart">起始会计期间</param>
            /// <param name="string_iperiodEnd">结束会计期间</param>
            /// <returns>返回SqlParameter[]数组</returns>
            private SqlParameter[] sealedPrameters(string string_iperiodStart, string string_iperiodEnd)
            {
                SqlParameter[] parameters =
                   {
              
                    new SqlParameter("@string_iperiodStart",SqlDbType.NChar, 6, string_iperiodStart),//string_iperiodStar该值是构造函数中的源列，而非参数值。
                        new SqlParameter("@string_iperiodEnd", SqlDbType.NChar, 6,string_iperiodEnd)
                       };
                parameters[0].Value = string_iperiodStart;
                parameters[1].Value = string_iperiodEnd;
                return parameters;
            }

            /// <summary>
            /// 封装数据库及起始日期SQL参数用于查询成本对象写入结果
            /// </summary>
            /// <param name="string_iperiodStart">起始会计期间</param>
            /// <param name="string_iperiodEnd">结束会计期间</param>
            /// <returns>返回SqlParameter[]数组</returns>
            private SqlParameter[] SealedPrametersThree()
            {
                SqlParameter[] parameters =
                   {
                        new SqlParameter("@Database",SqlDbType.NVarChar,30),
                        new SqlParameter("@StartDate",SqlDbType.Date ),//string_iperiodStar该值是构造函数中的源列，而非参数值。
                        new SqlParameter("@EndDate", SqlDbType.Date )
                       };
                parameters[0].Value = DataBaseInfo.dataBaseName;
                parameters[1].Value = textBox_startDate.Text;
                parameters[2].Value = textBox_endDate.Text;
                return parameters;
            }

        #endregion


        #region 会计期间输入及检查
        /// <summary>
        /// 时间输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_startDate.Format = DateTimePickerFormat.Custom;

            if (dateTimePicker_startDate.Value > DateTime.Now)
            {
                MessageBox.Show("输入日期超过当前日期，请重新输入", "日期提示");
                return;
            }

            textBox_startDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);

        }

        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_endDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_endDate.Format = DateTimePickerFormat.Custom;

            if (dateTimePicker_endDate.Value > DateTime.Now)
            {
                MessageBox.Show("输入日期超过当前日期，请重新输入", "日期提示");
                return;
            }
            textBox_endDate.Text = dateTimePicker_endDate.Value.ToString().Substring(0, 10);

        }
        
        /// <summary>
        ///检查写入期间是否结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_confirm_Click(object sender, EventArgs e)

        {
            if (textBox_startDate.Text == "" || textBox_endDate.Text == "")
            {
                MessageBox.Show("请输入日期", "日期输入提示");
                return;
            }
            else
            {
                string string_iperiodStart = textBox_startDate.Text.Substring(0, 4) + textBox_startDate.Text.Substring(5, 2);
                string string_iperiodEnd = textBox_endDate.Text.Substring(0, 4) + textBox_endDate.Text.Substring(5, 2);

                 
                SqlParameter[] parameters = sealedPrameters(string_iperiodStart, string_iperiodEnd);

                bool result = new gl_mendService().QueryPeriodState(parameters);


                if (result == true)
                {
                    MessageBox.Show("所选择的会计期间已经结账，请重新选择！", "错误提示");
                    return;
                }
                else
                {
                    MessageBox.Show("会计期间检查通过", "检查通过");
                    toolStripButton_writeForOutsourcing.Enabled = true;
                    toolStripButton_writeForOutsourcing.Visible = true;
                    toolStripButton_writeForOrder.Enabled = true;
                    toolStripButton_writeForOrder.Visible = true;
                    toolStripButton_resultQuery.Visible = true;
                    return;
                }
            }


        }

       
        #endregion

        #region 写入成本对象
        /// <summary>
        /// 写入委外件仓成本对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_writeForOutsousing_Click(object sender, EventArgs e)
        {
            string string_iperiodStart = textBox_startDate.Text;
            string string_iperiodEnd = textBox_endDate.Text;


            SqlParameter sqlParameter_iperiodStart = new SqlParameter("@startDate", SqlDbType.DateTime, 6);
            sqlParameter_iperiodStart.Value = string_iperiodStart;

            SqlParameter sqlParameter_iperiodEnd = new SqlParameter("@endDate", SqlDbType.DateTime, 6);
            sqlParameter_iperiodEnd.Value = string_iperiodEnd;

            SqlConnection conn = conectiongString.creatConection_myConcetion();
            SqlCommand sqlCommand_comm = new SqlCommand();
            sqlCommand_comm.Connection = conn;
            sqlCommand_comm.Parameters.Add(sqlParameter_iperiodStart);
            sqlCommand_comm.Parameters.Add(sqlParameter_iperiodEnd);
            sqlCommand_comm.CommandText = "writeCostObeject_2";
            sqlCommand_comm.CommandType = CommandType.StoredProcedure;
            sqlCommand_comm.Connection.Open();
            sqlCommand_comm.ExecuteNonQuery();

            MessageBox.Show("委外件仓成本对象写入成功", "写入情况");

            sqlCommand_comm.Connection.Close();
        }

        /// <summary>
        /// 写带生产订单信息之《材料出库单》上的成本对象信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_writeForWithOrder_Click(object sender, EventArgs e)
        {
            string string_iperiodStart = textBox_startDate.Text;
            string string_iperiodEnd = textBox_endDate.Text;


            SqlParameter sqlParameter_iperiodStart = new SqlParameter("@startDate", SqlDbType.DateTime, 6);
            sqlParameter_iperiodStart.Value = string_iperiodStart;

            SqlParameter sqlParameter_iperiodEnd = new SqlParameter("@endDate", SqlDbType.DateTime, 6);
            sqlParameter_iperiodEnd.Value = string_iperiodEnd;

            SqlConnection conn = conectiongString.creatConection_myConcetion();
            SqlCommand sqlCommand_comm = new SqlCommand();
            sqlCommand_comm.Connection = conn;
            sqlCommand_comm.Parameters.Add(sqlParameter_iperiodStart);
            sqlCommand_comm.Parameters.Add(sqlParameter_iperiodEnd);
            sqlCommand_comm.CommandText = "writeCostObeject_1";
            sqlCommand_comm.CommandType = CommandType.StoredProcedure;
            sqlCommand_comm.Connection.Open();
            sqlCommand_comm.ExecuteNonQuery();

            MessageBox.Show("成本对象写入成功", "写入情况");

            sqlCommand_comm.Connection.Close();
        }

        #endregion

        /// <summary>
        /// 写入结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_QueryResult_Click(object sender, EventArgs e)
        {
            //string db = FormMain.Label_accountIDtext.Text;
            //string string_iperiodStart = textBox_startDate.Text.Substring(0, 4) + textBox_startDate.Text.Substring(5, 2);
            //string string_iperiodEnd = textBox_endDate.Text.Substring(0, 4) + textBox_endDate.Text.Substring(5, 2);


            SqlParameter[] parameters =this.SealedPrametersThree();
            dataGridView_writeResult.DataSource = new QueryWriteResultService().QueryWriteResult(parameters);
            MessageBox.Show("结果查询完成", "写入结果查询");
        }


        

        private void textBox_startDate_TextChanged(object sender, EventArgs e)
        {
            this.textBox_endDate.Text = textBox_startDate.Text;
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_writeResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //这个方法比RowsStateChange事件或RowsPostPaint事件引发更新headerCell值的方法快很多

            DisplayRowHeader(e,this.dataGridView_writeResult);

        }

        private void DisplayRowHeader(DataGridViewRowPostPaintEventArgs e,DataGridView D)
        {
            if ((e.RowIndex + 1) < D.Rows.Count)
            {
                Color color = D.RowHeadersDefaultCellStyle.ForeColor;
                if (D.Rows[e.RowIndex].Selected)
                    color = dataGridView_writeResult.RowHeadersDefaultCellStyle.SelectionForeColor;
                else
                    color = D.RowHeadersDefaultCellStyle.ForeColor;
                using (SolidBrush b = new SolidBrush(color))
                {
                    //在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 6);

                }

            }
        }

        private void toolStripButton_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWriteCostObject_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }
    }
    
    
  
    
}

