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
using 成本管理.DAL;
using 成本管理.Model;

namespace 成本管理.UI
{
    public partial class frm_unitCost : Form
    {

        public frm_unitCost()
        {
            InitializeComponent();
            //窗体的事件传送在构造函数中写明
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parentForm_Closed);

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
            if (excelFileName.Length > 0)
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


            comm.Connection = conectiongString.creatConection_manage();
            comm.CommandText = "SELECT  [year],[month]  FROM xm_plug_t_unitCost where [year]=" + "'" + 
                comboBox1.Text + "'" + "and [month]=" + "'" + comboBox2.Text + "'";

                                 

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
                MessageBox.Show("会计年度不能为空", "错误提示");
                return;

            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("会计月份不能为空", "错误提示");
                return;
            }
            else if (this.dt_excel.Rows.Count == 0)
            {
                MessageBox.Show("存货单价数据据不能为空", "错误提示");
                return;
            }
            else if (this.dt_productUnitHeader.Rows.Count != 0)
            {
                MessageBox.Show("已存在相同会计期间的成本结构表，请正确输入会计年度与会计月份", "错误提示");
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
            
            
            

            using (SqlConnection connection = conectiongString.creatConection_manage())
            {
                connection.Open();

                // Start a local transaction.
                SqlTransaction sqlTran = connection.BeginTransaction();

                // Enlist a command in the current transaction.
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    // Execute two separate commands.
                    //插入主表
                    command.Parameters.AddWithValue("@no", tex_no.Text);
                    command.Parameters.AddWithValue("@y", comboBox1.Text);
                    command.Parameters.AddWithValue("@m", comboBox2.Text);
                    command.CommandText =
                      "INSERT INTO xm_plug_t_unitCost (ID,[year],[month]) VALUES(@no,@y,@m)";

                    command.ExecuteNonQuery();
                                                                         
                    command.Parameters.Clear();

                    //插入子表
                    SqlParameter[] paras = new SqlParameter[]
   {        
            new SqlParameter ("@ProductCode",SqlDbType.NVarChar ,50 ),
            new SqlParameter ("@Unit_BOMCost",SqlDbType.Float  ),
            
            new SqlParameter ("@Unit_Variable_AUXCost",SqlDbType.Float ),
            new SqlParameter ("@Unit_Variable_toolsCost",SqlDbType.Float),
            new SqlParameter ("@Unit_packagecost",SqlDbType.Float ),
            new SqlParameter ("@Unit_Variable_DirectLabour_Cost",SqlDbType.Float  ),
            new SqlParameter ("@Unit_fixed_IndirectLabour_Cost",SqlDbType.Float ),
            new SqlParameter ("@Unit_fixed_DepreciationCost",SqlDbType.Float ),
            new SqlParameter ("@FID",SqlDbType.NVarChar,10  )
   };
                    command.CommandText =
                      "INSERT INTO xm_plug_t_unitCosts (FID, ProductCode, Unit_BOMCost, " +
                      "Unit_Variable_AUXCost, Unit_Variable_toolsCost," +
                      " Unit_packagecost, Unit_Variable_DirectLabour_Cost, Unit_fixed_IndirectLabour_Cost, " +
                      "Unit_fixed_DepreciationCost)" +
                      " VALUES(@FID,@ProductCode,@Unit_BOMCost,@Unit_Variable_AUXCost," +
                      "@Unit_Variable_toolsCost,@Unit_packagecost,@Unit_Variable_DirectLabour_Cost,@Unit_fixed_IndirectLabour_Cost," +
                      "@Unit_fixed_DepreciationCost)";
                    if (dataGridViewDisplayExcel.Rows.Count > 0)
                    {
                        DataRow dr = null;
                        for (int i = 0; i < dt_excel.Rows.Count; i++)
                        {
                            dr = dt_excel.Rows[i];
                            paras[0].Value = dr[0];
                            paras[1].Value = dr[1];
                            paras[2].Value = dr[2];
                            paras[3].Value = dr[3];
                            paras[4].Value = dr[4];
                            paras[5].Value = dr[5];
                            paras[6].Value = dr[6];
                            paras[7].Value = dr[7];
                            paras[8].Value = tex_no.Text;
                            //paras[9].Value = dr[9];
                            command.Parameters.AddRange(paras);
                            Console.Write(command.CommandText);
                            Console.Write(paras);
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }


                    // Commit the transaction.
                    sqlTran.Commit();
                    MessageBox.Show("数据导入成功！", "数据导入提示");

                }
                catch (Exception ex)
                {
                    // Handle the exception if the transaction fails to commit.
                    Console.WriteLine(ex.Message);

                    try
                    {
                        // Attempt to roll back the transaction.
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        // Throws an InvalidOperationException if the connection
                        // is closed or the transaction has already been rolled
                        // back on the server.
                        Console.WriteLine(exRollback.Message);
                    }
                }
            }
           
        }

        #endregion



        private void toolStripButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void parentForm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tex_no.Text = this.comboBox1.Text + this.comboBox2.Text;
        }
    }
}
