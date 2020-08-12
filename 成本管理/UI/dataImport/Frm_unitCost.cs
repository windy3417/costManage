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
using System.IO;
using Microsoft.Office.Interop;
using Microsoft.Vbe.Interop;
using System.Threading;

namespace 成本管理.UI
{
    public partial class frm_unitCost : Form
    {

        public frm_unitCost()
        {
            InitializeComponent();
            //窗体的事件传送在构造函数中写明
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parentForm_Closed);
            BW_import.WorkerReportsProgress = true;
            BW_import.WorkerSupportsCancellation = true;
        }

        //作为dataGrid的数据源，也作为导入到数据库的数据源，故作为该类的字段用于多方共享
        DataTable dt_excel = new DataTable();
        DataTable dt_productUnitHeader = new DataTable();
        string excelFileName;
        Frm_progressBar progressBar=new Frm_progressBar();

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
          
                       
            //获取excel文件名
            excelFileName = openExcel();
            if (BW_import.IsBusy != true)
            {
                // Start the asynchronous operation.执行数据导入工作
                //该方法对应的后台dowork事件绑定了excuteDataImport方法
                BW_import.RunWorkerAsync();
                progressBar.Show();
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
        /// 数据导入到数据库
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
            new SqlParameter ("@Unit_Variable_PowerCost",SqlDbType.Float ),
            new SqlParameter ("@Unit_fixed_rentCost",SqlDbType.Float),
            new SqlParameter ("@Unit_Variable_MaintenancCost",SqlDbType.Float ),
            new SqlParameter ("@Unit_TransportationCost",SqlDbType.Float  ),
            new SqlParameter ("@Unit_Variable_installCost",SqlDbType.Float ),
            new SqlParameter ("@Unit_Variable_testService_Cost",SqlDbType.Float ),
            new SqlParameter ("@Unit_Variable_Subcontracting_Cost",SqlDbType.Float  ),
            new SqlParameter ("@Unit_CustomDuty_cost",SqlDbType.Float ),
            new SqlParameter ("@Unit_Variable_meteringCost",SqlDbType.Float ),
            new SqlParameter ("@Unit_MoldCost",SqlDbType.Float ),
            new SqlParameter ("@FID",SqlDbType.NVarChar,10  )
   };
                    command.CommandText =
                      "INSERT INTO xm_plug_t_unitCosts (FID, ProductCode, Unit_BOMCost, " +
                      "Unit_Variable_AUXCost, Unit_Variable_toolsCost," +
                      " Unit_packagecost, Unit_Variable_DirectLabour_Cost, Unit_fixed_IndirectLabour_Cost, " +
                      "Unit_fixed_DepreciationCost ,[Unit_Variable_PowerCost], [Unit_fixed_rentCost], [Unit_Variable_MaintenancCost]," +
                      " [Unit_TransportationCost], [Unit_Variable_installCost], [Unit_Variable_testService_Cost], [Unit_Variable_Subcontracting_Cost]," +
                      " [Unit_CustomDuty_cost], [Unit_Variable_meteringCost], [Unit_MoldCost])" +
                      " VALUES(@FID,@ProductCode,@Unit_BOMCost,@Unit_Variable_AUXCost," +
                      "@Unit_Variable_toolsCost,@Unit_packagecost,@Unit_Variable_DirectLabour_Cost,@Unit_fixed_IndirectLabour_Cost," +
                      "@Unit_fixed_DepreciationCost,@Unit_Variable_PowerCost, @Unit_fixed_rentCost, @Unit_Variable_MaintenancCost, " +
                      "@Unit_TransportationCost, @Unit_Variable_installCost, @Unit_Variable_testService_Cost, @Unit_Variable_Subcontracting_Cost, " +
                      "@Unit_CustomDuty_cost, @Unit_Variable_meteringCost, @Unit_MoldCost)";
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
                            paras[8].Value = dr[8];
                            paras[9].Value = dr[9];
                            paras[10].Value = dr[10];
                            paras[11].Value = dr[11];
                            paras[12].Value = dr[12];
                            paras[13].Value = dr[13];
                            paras[14].Value = dr[14];
                            paras[15].Value = dr[15];
                            paras[16].Value = dr[16];
                            paras[17].Value = dr[17];
                            paras[18].Value = tex_no.Text;
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
        /// <summary>
        /// 生成单据编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //若不判断SelectedIndex!=-1，则置空命令也会触发提示框
            if (this.comboBox1.Text=="" & comboBox2.SelectedIndex!=-1 )

            {
               
                MessageBox.Show("请先选择会计年度", "选择提示");

                //this.comboBox2.Text=""不能清空该组合框的内容
                this.comboBox2.SelectedIndex = -1;
                
            }
            else
            {
                this.tex_no.Text = this.comboBox1.Text + this.comboBox2.Text;
            }
            
        }

        /// <summary>
        /// 删除已经存在的成本明细结构表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            string no = this.tex_no.Text;
            using (SqlConnection connection = conectiongString.creatConection_manage())
            {
                connection.Open();

              

                // 删除前检查是否存在数据
                SqlCommand command = connection.CreateCommand();
                command.CommandText="select ID from xm_plug_t_unitCost where ID="+"'"+ no + "'";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   //一次连接只能处理一个事情，所以需要先关闭前次连接才能启用后面的事务
                    reader.Close();
                    // Start a local transaction.
                    SqlTransaction sqlTran = connection.BeginTransaction();
                    command.Transaction = sqlTran;

                    try
                    {
                        // Execute two separate commands.
                        //删除子表与主表
                        command.Parameters.AddWithValue("@no", tex_no.Text);

                        command.CommandText =
                          "delete  xm_plug_t_unitCosts where FID=@no";

                        command.ExecuteNonQuery();
                        command.CommandText =
                         "delete  xm_plug_t_unitCost where ID=@no";
                        command.ExecuteNonQuery();



                        // Commit the transaction.
                        sqlTran.Commit();
                        MessageBox.Show("数据删除成功！", "数据删除提示");

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
                else
                {
                    MessageBox.Show("你所删除的数据不存在！", "数据删除提示");
                }
               
            }


        }
        /// <summary>
        /// 直接调用EXCEL打开模板文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_importTemplate_Click(object sender, EventArgs e)
        {
            ////注意转义字符，\\两个反斜杠才能表示一个反斜杠\
            //string myUrl = Environment.CurrentDirectory + "\\" + "resources\\template\\成本结构表导入模板.xlsx";
            //Microsoft.Office.Interop.Excel.Application excel =new Microsoft.Office.Interop.Excel.Application(); //引用Excel对象
            //Microsoft.Office.Interop.Excel.Workbook book =excel.Application.Workbooks.Add(myUrl);
            ////引用Excel工作簿
            //excel.Visible = true; //使Excel可视

            ////以上代码在安装有office2016时正常,但office2007时无法打开工作簿
            string myUrl = Environment.CurrentDirectory + "\\" + "resources\\template\\成本结构表导入模板.xlsx";
            string saveDir;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            //指定存储的路径
            saveDir = fbd.SelectedPath+"\\成本结构表导入模板.xlsx";
            Console.WriteLine(saveDir);
           
           
            if (File.Exists(myUrl))//必须判断要复制的文件是否存在
            {
                File.Copy(myUrl, saveDir, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                MessageBox.Show("文件保存成功", "文件下载提示");
            }

        }

        private void excuteDataImport(object sender, DoWorkEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand comm = new OleDbCommand();
            if (excelFileName.Length > 0)
            {
                string stringConectExcel = "Provider=Microsoft.ace.OLEDB.12.0;" + "Data Source=" + excelFileName + ";" +
               "Extended Properties='Excel 12.0 xml;HDR=YES'";
                conn.ConnectionString = stringConectExcel;
                comm.CommandText = "select * from [sheet1$]";
                comm.Connection = conn;
                conn.Open();
                //comm.ExecuteNonQuery();该命令是多余的，严重影响速度
                da.SelectCommand = comm;


                da.Fill(dt_excel);

                dataGridViewDisplayExcel.DataSource = dt_excel;

                conn.Close();
            }
        }
    }
}
