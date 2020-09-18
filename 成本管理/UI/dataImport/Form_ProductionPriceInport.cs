using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using 成本管理.DAL ;
using 成本管理.Model;

namespace 成本管理.UI
{
    public partial class formProductionUnitPriceImport : Form
    {

        public formProductionUnitPriceImport()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.parentForm_Closed);

        }
        
        DataTable dt_excel = new DataTable();
        DataTable dt_productUnitHeader = new DataTable();

        #region 读取Excel数据
        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <returns></returns>
        private string openExcel()
        {
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();
            openFileDialogExcel.Filter = "excel files (*.xls;*xlsx)|*.xls;*.xlsx";
            openFileDialogExcel.ShowDialog();
            return openFileDialogExcel.FileName;
       }

        /// <summary>
        /// 读取Excel数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void ImportExcelData(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand comm = new OleDbCommand();

           //获取excel文件名
            string excelFileName = openExcel();
            if (excelFileName.Length>0)
            {
                string stringConectExcel = "Provider=Microsoft.ace.OLEDB.12.0;" + "Data Source=" + excelFileName + ";" +
               "Extended Properties='Excel 12.0 xml;HDR=YES'";
                conn.ConnectionString = stringConectExcel;
                comm.CommandText = "select * from [sheet1$]";
                comm.Connection = conn;
                conn.Open();
                comm.ExecuteNonQuery();
                da.SelectCommand = comm;
                da.Fill(dt_excel);

                dataGridViewDisplayExcel.DataSource = dt_excel;

                conn.Close();
            }
           
        }
        #endregion


        #region 保存到数据库
        ///<summary>
        ///读取已经存在的存货单价数据
        ///</summary>
        public void existeProductUnit()
        {

            SqlCommand comm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
           

            comm.Connection = ConectiongString.creatConection_manage();
            comm.CommandText = "SELECT CH001_0001_E001_F010,CH001_0001_E001_F011 FROM CH001_0001_E001 where CH001_0001_E001_F010=" + "'" + comboBox1.Text + "'" + "and CH001_0001_E001_F011=" + "'" + comboBox2.Text + "'";
                
            comm.Connection.Open();
            da.SelectCommand = comm;
            da.Fill(dt_productUnitHeader);
           
        }

        /// <summary>
        /// 数据导入前检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     
        private void SaveToDatabase(object sender, EventArgs e)
        {
            this.existeProductUnit();
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("会计年度不能为空","错误提示");
                return;
                
            }
            else if(string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("会计月份不能为空","错误提示");
                return;
             }
            else if(this.dt_excel.Rows.Count==0)
            {
                MessageBox.Show("存货单价数据据不能为空","错误提示");
                return;
            }
            else if(this.dt_productUnitHeader.Rows.Count!=0)
            {
                MessageBox.Show("已存在相同会计期间的存货单价数据，请正确输入会计年度与会计月份", "错误提示");
                dt_productUnitHeader.Clear();
                return;
            }
            this.dataImport();   
                 
        }
        
        /// <summary>
/// 数据导入
/// </summary>
        private void dataImport()
        {

            SqlCommand comm = new SqlCommand();

            comm.Connection = ConectiongString.creatConection_manage();
            comm.Connection.Open();
            //
            //表头数据导入
            //
            
            string sql_header = "productUnit";//后台存储过程 

            SqlParameter[] paras_header = new SqlParameter[]
         {
            new SqlParameter ("@y",SqlDbType.NChar ,10 ),
            new SqlParameter ("@m",SqlDbType.NChar  ,10)
         };


            //
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = sql_header;

            comm.Parameters.AddWithValue("@y",comboBox1.Text) ;
            comm.Parameters.AddWithValue("@m", comboBox2.Text);
            comm.ExecuteNonQuery();
            comm.Parameters.Clear();

            //明细数据导入
            //
            string sql = "insert into productionUnitPrice values (@cinvcode,@unitPrice)";

           


            SqlParameter[] paras = new SqlParameter[]
             {
            new SqlParameter ("@cinvcode",SqlDbType.NChar ,10 ),
            new SqlParameter ("@unitPrice",SqlDbType.NChar  ,10)
             };
           
         



            comm.CommandText = sql;
            comm.CommandType = CommandType.Text;
            if (dataGridViewDisplayExcel.Rows.Count > 0)
            {   DataRow dr=null;
                for(int i=0;i<dt_excel.Rows.Count;i++)
                {
                    dr=dt_excel.Rows[i];
                     paras[0].Value =dr[0] ;
                     paras[1].Value =dr[1] ;
                     comm.Parameters.AddRange (paras);
                    Console.Write(paras);
                     comm.ExecuteNonQuery();
                     comm.Parameters.Clear();
                }

            }
                      
            comm.Connection.Close();
            MessageBox.Show ("数据导入成功！","数据导入提示");
        }

        #endregion

        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗体关闭后母窗体也关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parentForm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();

        }
    }
}
