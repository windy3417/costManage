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

        //计算完成标志
        bool finishedFlag = false;
        //增删改查条件检标志
        bool conditionFlag = false;
        //需要返回的单价数据
        DataTable dataTable;
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
            this.tsb_save.Enabled = false;
            
        }

        /// <summary>
        /// 操作条件判断
        /// </summary>
        private bool  inspect()
        {
            for (int i = 0; i < this.gp_condition.Controls.Count; )
            {
                if (gp_condition.Controls[i].Text=="")
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

        /// <summary>
        /// 关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
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

        /// <summary>
        /// 计算BOM材料清单的单价
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_caculater_Click(object sender, EventArgs e)
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
                //开启后台查询线程

                this.backgroundWorker1.RunWorkerAsync(sqlparameters);

                //
                timer1.Interval = 1000;
                this.timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Start();
                this.tsb_save.Enabled = true;
            }



        }

        private void callProgressBar()
        {
            Frm_progressMemtion frm_ProgressMemtion = new Frm_progressMemtion();
            frm_ProgressMemtion.Show();
            frm_ProgressMemtion.progressBarValue();
        }

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
            this.progressBar1.Visible = false;
        }

        //显示行标
        private void RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StyleDataGridView.DisplayRowHeader(e, this.dgv_bomMaterialUnit);
        }

        ///<summary>
        ///数据保存前检查
        ///</summary>
        public bool existeMaterialUnit()
        {

            SqlCommand comm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            



            comm.Connection = conectiongString.creatConection_manage();
            comm.CommandText = "SELECT  voucherNo  FROM [xm_plug_t_materailUnitPrice_main] where [voucherNo]=" + "'" +
                this.lbl_vocherNO.Text + "'";

            SqlDataReader sqlDataReader = comm.ExecuteReader();

            while (sqlDataReader.Read())
            {
                MessageBox.Show("已经存在相同会计期间的材料单价清单", "保存前提示");
                return false;
            }

            // Call Close when done reading.
            sqlDataReader.Close();
            return true;


        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_save_Click(object sender, EventArgs e)
        {
            if (this.inspect())
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
                        unitPice.unitPice = (double)dr[5];
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

            }

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

        private void tsb_delete_Click(object sender, EventArgs e)
        {

        }
    }

}


