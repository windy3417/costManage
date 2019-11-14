using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

using U8common;
using 成本管理.DAL;
using 成本管理.DAL.Reports;


namespace 成本管理.UI
{
    
    public partial class Form_InspectItem : Form
    {
        DataTable dt = new DataTable();

        /// <summary>
        /// 初始化窗体M
        /// </summary>
        public Form_InspectItem()
        {
            InitializeComponent();
            dataGridView_inspect.Visible = false;
            DoubleBufferedDataGridView.DoubleBuffered(this.dataGridView_inspect, true);
            label_inspectResultText.Visible = false;
        }

        /// <summary>
        /// 检查项目目录与BOM一级母件是否匹配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_inspect_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conectiongString.creatConection_myConcetion();
            comm.CommandText = "select a.InvCode as BOM母件编码 ,i.cInvName as BOM母件名称, i.cInvStd as BOM母件规格型号, f.citemcode as 成本对象编码 " +
"from bom_parent as o " +

   " inner join bas_part as a " +

        "on o.ParentId = a.PartId" +

    " inner join inventory as i" +

        " on a.InvCode = i.cInvCode" +

    " left join fitemss99 as f " +

        " on a.InvCode = f.citemcode" +
" where a.InvCode like '4%'  and f.citemcode is null";

            comm.Connection.Open();
            ConnectionState state = comm.Connection.State;
            SqlDataReader reader = comm.ExecuteReader();
            
            //判断数据源是否为空
            if (reader.HasRows)
            {
                
                BindingSource bs = new BindingSource();
                bs.DataSource = reader;
                dataGridView_inspect.DataSource = bs;

                dataGridView_inspect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_inspect.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               
                dataGridView_inspect.Visible = true;
            }
            else
            {
                MessageBox.Show("成本项目目录档案检查通过，\n 可以进行成本项目写入工作。","成本项目目录检查");
                label_inspectResultText.Visible = true;
                dataGridView_inspect.DataSource = null;
                dataGridView_inspect.Visible = false;
            }
            comm.Connection.Close();
            reader.Close();

          
            
        }

        #region 打印
            /// <summary>
            /// 传递打印数据
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
            {
                e.Graphics.DrawString(label_inspectResult.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(15.0F, 15.0F));
                int r = 40;//初始X坐标
                int c = 40;//初始Y坐标
                for (int i = 0; i < dataGridView_inspect.Rows.Count; i++)
                {

                    for (int j = 0; j < dataGridView_inspect.Columns.Count; j++)
                    {
                        //使用事件数据类PrintPageEventArgs中的Graphics属性获取打印数据
                        e.Graphics.DrawString(dataGridView_inspect.Rows[i].Cells[j].Value.ToString(), new Font("宋体", 10, FontStyle.Regular), Brushes.Black, r, c);
                        r = r + 300;//每读取一行中的一个单元格数据，X坐标右移300后再写第二个单元格

                    }
                    r = 40;// 每读取一行完毕，X坐标回到原处
                    c += 20;//每读取一行完毕，Y坐标下移20后再写第二行数据


                }
            }

            /// <summary>
            /// 打印预览
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param> 
            private void toolStripButton_printView_Click(object sender, EventArgs e)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            /// <summary>
            /// 打印项目检查结果
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void toolStripButton_print_Click(object sender, EventArgs e)
            {
                printDialog1.AllowSomePages = true;
                printDialog1.ShowHelp = true;
                printDialog1.Document = printDocument1;

                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }




            }

        #endregion

        /// <summary>
        /// 退出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 关闭父窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_inspectItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_export_Click(object sender, EventArgs e)
        {
            ExportExcel ee = new ExportExcel();
            InspectItemService ii = new InspectItemService();
            this.dt=ii.GetCostObejectItem();
            ee.ExportExcelWithNPOI(this.dt,"项目检查表");
            MessageBox.Show("数据输出成功！", "输出提示");


        }
}
}
