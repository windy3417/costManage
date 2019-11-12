using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using U8common.UIbase;
using 成本管理.DAL.Reports;
using System.Data.SqlClient;
using 成本管理.Model;

namespace 成本管理.UI
{
    public partial class Form_ProductionOrders : Form_ReportBase
    {


        public Form_ProductionOrders()
        {
            InitializeComponent();
            this.Text = "生产订单列表";
            this.button_confirm.Click += Button_confirm_Click;

        }

        private void Button_confirm_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters =
            {
                        new SqlParameter("@Database",SqlDbType.NVarChar,30),
                        new SqlParameter("@StartDate",SqlDbType.Date ),//string_iperiodStar该值是构造函数中的源列，而非参数值。
                        new SqlParameter("@EndDate", SqlDbType.Date )
                       };
            parameters[0].Value = DataBaseInfo.dataBaseName;
            parameters[1].Value = this.textBox_startDate.Text;
            parameters[2].Value = textBox_endDate.Text;

            this.DateGridViewSource = new ProductionOrdersService().ProductionOrders(parameters);

            this.InitDataSet();
           








        }

        private void button_confirm_Click_1(object sender, EventArgs e)
        {

        }
    }
}
