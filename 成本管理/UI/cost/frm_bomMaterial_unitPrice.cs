using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Utility;
using 成本管理.DAL;
using U8common;
using 成本管理.Model;

namespace 成本管理.UI.Cost
{
    public partial class frm_bomMaterial_unitPrice : Form

    {

        public frm_bomMaterial_unitPrice()
        {
            InitializeComponent();
            this.initiallize();


        }

        #region 变量
        //计算完成标志
        bool finishedFlag = false;
        //增删改查条件检标志
        bool conditionFlag = false;
        //需要返回的单价数据
        DataTable dataTable;
        #endregion

        //初化控件
        private void initiallize()
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.colseParentForm);
            this.dgv_bomMaterialUnit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.RowPostPaint);

            //因后台查询进度暂无法计算衡量,故放弃后台进程完成进度报告，采用主线程的timer模拟后台进程的完成进度
            backgroundWorker1.WorkerReportsProgress = false;
            //执行设置默认日期的方法
            this.setDefautDate();
            //执行默认单据编号

            progressBar1.Visible = false;
            this.tsb_supplement.Enabled = false;
            this.tsb_save.Enabled = false;
            this.tsb_generate.Enabled = false;
            this.tsb_export.Enabled = false;

        }

        /// <summary>
        /// 操作条件判断
        /// </summary>
        private bool inspect()
        {
            for (int i = 0; i < this.gp_condition.Controls.Count;)
            {
                if (gp_condition.Controls[i].Text == "")
                {
                    MessageBox.Show(gp_condition.Controls[i].Tag + "的值不能为空", "条件提示");

                    return conditionFlag;
                }
                else
                {
                    i++;
                }

            }


            conditionFlag = true;
            return conditionFlag;
        }

        #region 内部方法

        //设置默认起始日期
        private void setDefautDate()
        {


            //text值会默认在赋值给value,因value值无法按以下方式生成默认值，故手动赋值给text
            //其它变量取值时可限value值，此时它与text值是一致的，这是由dateTimePicker控件自身支持的
            //DateTime timer = new DateTime();
            //int month = DateTime.Now.Month-1;
            //int year = DateTime.Now.Year;
            //this.dtp_startDate.Text= year.ToString() + "-" + month.ToString() + "-01";

            //value 自带了日期加减运算的方法，故放弃以上对text属性的赋值算法

            //上月月初
            this.dtp_startDate.Value = DateTime.Now.AddMonths(-1).AddDays(-DateTime.Now.Day + 1);
            //上月底
            this.dtp_endDate.Value = DateTime.Now.AddDays(-DateTime.Now.Day);
            //设置默认年度
            this.cmb_year.Text = DateTime.Now.Year.ToString();


        }

        ///<summary>
        ///数据保存前检查
        ///</summary>
        public bool existeMaterialUnit()
        {

            SqlCommand comm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();




            comm.Connection = ConectiongString.creatConection_manage();
            comm.CommandText = comm.CommandText = "SELECT  [year],[month]  FROM [xm_plug_t_materailUnitPrice_main] where [year]=" + "'" +
                this.dtp_endDate.Value.Year + "'" + "and [month]=" + "'" + this.dtp_endDate.Value.Month + "'"; ;

            comm.Connection.Open();
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            while (sqlDataReader.Read())
            {
                MessageBox.Show("已经存在相同会计期间的材料单价清单", "错误提示");
                return false;
            }

            // Call Close when done reading.
            sqlDataReader.Close();
            return true;


        }


        #endregion



        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

                

        #region 抓取BOM材料当期价格清单单
        /// <summary>
        /// 开启取价事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_fetchPrice_Click(object sender, EventArgs e)
        {


            if (this.inspect())
            {
                this.progressBar1.Visible = true;

                //为后台线程准备传入的参数
                string year = this.cmb_year.Text;
                string startDate = this.dtp_startDate.Value.Date.ToString("yyyy-MM-dd");
                string endDate = this.dtp_endDate.Value.Date.ToString("yyyy-MM-dd");

                List<string> sqlparameters = new List<string>();
                sqlparameters.Add(year);
                sqlparameters.Add(startDate);
                sqlparameters.Add(endDate);
                
                //开启后台查询线程，即引发新线程的事件，同时提供事件参数
                //注意backgroundWork中的DoWork事件，并编写事件处理程序

                this.backgroundWorker1.RunWorkerAsync(sqlparameters);

                //
                timer1.Interval = 1000;
                this.timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();

            }



        }

        /// <summary>
        /// 调用进程提示
        /// </summary>


        /// <summary>
        /// 用计时器体现查询进度表，非真实进度，仅是对用户的提示，因后台查询进度暂无法计算衡量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (!finishedFlag)
            {
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progressBar1.Value = 1;
                }
                else
                {
                    this.progressBar1.Value++;
                }

            }
            else
            {
                this.timer1.Stop();

            }

        }

        /// <summary>
        /// 执行数据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlParameter[] parameters =
         {

                        new SqlParameter("@iyear",SqlDbType.Int ),
                        new SqlParameter("@startDate",SqlDbType.Date ),
                        new SqlParameter("@endDate",SqlDbType.Date)

                       };
            //在事件中已经传入查询参数，只不过事件参数是object类型
            List<string> sqlparametersValue = e.Argument as List<string>;
            parameters[0].Value = sqlparametersValue[0];
            parameters[1].Value = sqlparametersValue[1];
            parameters[2].Value = sqlparametersValue[2];

            //不能访问主线程的控件对象，会报错
            //parameters[0].Value = this.cmb_year.Text;
            //parameters[1].Value = this.dtp_startDate.Value.Date.ToString("yyyy-MM-dd");
            //parameters[2].Value = this.dtp_endDate.Value.Date.ToString("yyyy-MM-dd");

            //却能访问主线程的变量？以下语句能正确执行不会报错(主线程中的类变量是否是在进程中共享)

            dataTable = null;
            dataTable = sqlHelper.ExecuteProc("xm_plug_sp_BOMmaterial_Variety_UnitPrice", parameters, DBName.u8);


        }

        /// <summary>
        /// 数据查询完成时的事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            finishedFlag = true;
            this.dgv_bomMaterialUnit.DataSource = dataTable;
            //完成后进程条不可见
            this.progressBar1.Visible = false;
            this.tsb_save.Enabled = true;
            this.tsb_supplement.Enabled = true;
        }

        /// <summary>
        /// 未取到到价的采用历史价格库取价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_supplement_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())

            {

                List<xm_plug_v_historyPriceForFisrtRecord> r = db.xm_plug_v_historyPriceForFisrtRecord.ToList<xm_plug_v_historyPriceForFisrtRecord>();

                //var unitPrice = dataTable.AsEnumerable().Where(d =>d.Field<string>("unitPriceType")== "无法匹配单价");                          

                //关联历史最新价
                var query = from p in r
                            join u in dataTable.AsEnumerable().Where(d => d.Field<string>("unitPriceType") == "无法匹配单价")
                                 on p.cinvCode equals u.Field<string>("material_invcode")
                            select new xm_plug_t_materialUnitPice
                            {
                                cinvCode = p.cinvCode,
                                unitPrice = p.unitPrice
                            };

                foreach (var item in query)
                {

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i].Field<string>("material_invcode") == item.cinvCode)
                        {
                            dataTable.Rows[i].SetField<double>("unitPrice", item.unitPrice);
                        }
                    }

                    //log4net.ILog log = log4net.LogManager.GetLogger("testApp.Logging");//获取一个日志记录器

                    //log.Info(item.cinvCode + ": login success");//写入一条新log

                    this.dgv_bomMaterialUnit.DataSource = dataTable;

                }
            }

            MessageBox.Show("历史取价完成", "补价提示");



        }
        #endregion

                                     

        //显示行标
        private void RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StyleDataGridView.DisplayRowHeader(e, this.dgv_bomMaterialUnit);
        }

       
     

        /// <summary>
        /// 自动生成单据编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dtp_endDate_ValueChanged(object sender, EventArgs e)
        {
            this.txt_voucherNO.Text = this.dtp_endDate.Value.Year.ToString() + this.dtp_endDate.Value.Date.ToString().Substring(5, 2);
        }

        
        #region 菜单事件处理


        /// <summary>
        /// 保存当期BOM材料价格清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {
            if (this.inspect() & this.existeMaterialUnit())
            {
                this.inspect();
                //插入主表记录
                xm_plug_t_materailUnitPrice_main m = new xm_plug_t_materailUnitPrice_main();
                m.voucherNo = this.txt_voucherNO.Text;
                m.year = this.dtp_endDate.Value.Year;
                m.month = this.dtp_endDate.Value.Month;

                //插入子表记录
                List<xm_plug_t_materialUnitPice> lsUnitPice = new List<xm_plug_t_materialUnitPice>();
                DataRow dr = null;
                if (this.dataTable.Rows.Count > 0)
                {

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //必须声明在循环体当中，否则该实体最后的赋值会覆盖前面的赋值最终只保存最后一条数据，虽然泛型中会计数count
                        xm_plug_t_materialUnitPice unitPice = new xm_plug_t_materialUnitPice();
                        dr = dataTable.Rows[i];

                        unitPice.FID = this.txt_voucherNO.Text;
                        unitPice.cinvCode = (string)dr[2];
                        unitPice.unitPrice = (double)dr[5];
                        lsUnitPice.Add(unitPice);
                    }
                }
                using (var db = new Entities())
                {
                    db.xm_plug_t_materailUnitPrice_main.Add(m);
                    db.xm_plug_t_materialUnitPice.AddRange(lsUnitPice);

                    //只保存最后一次变化，所以在循环体中,如不要保存在循环体中可使用addrange方法而不用add方法
                    db.SaveChanges();


                }


                MessageBox.Show("数据保存成功", "保存提示");

                this.dgv_bomMaterialUnit.DataSource = "";
                this.tsb_generate.Enabled = true;

            }

        }

        /// <summary>
        /// 删除已存在BOM物料当期价格清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            string no = this.txt_voucherNO.Text;
            using (SqlConnection connection = ConectiongString.creatConection(DBName.plug))
            {
                connection.Open();


                // 删除前检查是否存在数据
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select ID from [xm_plug_t_materailUnitPrice_main] where [voucherNo]=" + "'" + no + "'";
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
                        command.Parameters.AddWithValue("@no", txt_voucherNO.Text);

                        command.CommandText =
                          "delete  [xm_plug_t_materialUnitPice] where FID=@no";

                        command.ExecuteNonQuery();
                        command.CommandText =
                         "delete  [xm_plug_t_materailUnitPrice_main] where [voucherNo]=@no";
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
        /// 导出Excel表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_export_Click(object sender, EventArgs e)
        {
            
            ExportExcel exportExcel = new ExportExcel();
            exportExcel.ExportExcelWithNPOI(dataTable, "BOM材料成本");
        }

        /// <summary>
        /// 计算出BOM材料成本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_generate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] parameters = {


                        new SqlParameter("@startDate",SqlDbType.Date ),
                        new SqlParameter("@endDate",SqlDbType.Date )


                       };

                parameters[0].Value = this.dtp_startDate.Text;
                parameters[1].Value = this.dtp_endDate.Text;


                dataTable = null;
                dataTable = sqlHelper.ExecuteProc("xm_plug_sp_BOMcost", parameters, DBName.u8);
                this.dgv_bomMaterialUnit.DataSource = dataTable;
                this.tsb_supplement.Enabled = false;
                this.tsb_save.Enabled = false;
                this.tsb_export.Enabled = true;
            }

            catch (Exception)
            {


            }


        }


        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion




    }
}





