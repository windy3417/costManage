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

namespace 成本管理.UI.cost
{
    public partial class frm_bomMaterial_unitPrice : Form

    {  
        //初化控件
        public frm_bomMaterial_unitPrice()
        {
            InitializeComponent();
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.colseParentForm);

            //因后台查询进度暂无法计算衡量,故放弃后台进程完成进度报告，采用主线程的timer模拟后台进程的完成进度
            backgroundWorker1.WorkerReportsProgress = false;
            //执行设置默认日期的方法
            this.setDefautDate();
            progressBar1.Visible = false;

        }

        
        bool finishedFlag = false;
        //需要返回的数据
        DataTable dataTable;

  
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
            this.dtp_startDate.Value = DateTime.Now.AddMonths(-1).AddDays(- DateTime.Now.Day+1);
            //上月底
            this.dtp_endDate.Value = DateTime.Now.AddDays( - DateTime.Now.Day);
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

            //Thread thread = new Thread(new ThreadStart(callProgressBar));
            //thread.Start();
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
                if (progressBar1.Value==progressBar1.Maximum)
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

            //不能访问主线程的对象，会报错
            //parameters[0].Value = this.cmb_year.Text;
            //parameters[1].Value = this.dtp_startDate.Value.Date.ToString("yyyy-MM-dd");
            //parameters[2].Value = this.dtp_endDate.Value.Date.ToString("yyyy-MM-dd");

            //却能访问主线程的变量？以下语句能正确执行不会报错
            
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

      
    }
    
}
