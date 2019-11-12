using U8common.UIbase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 成本管理.DAL.Reports;
using 成本管理.Model;
using U8Common.Tools;


namespace 成本管理.UI
{
    public partial class Form_SaleOrders : Form_ReportBase
    {

        public Form_SaleOrders()
        {
            InitializeComponent();
            this.Text = "销售订单列表";
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

            this.DateGridViewSource = new SaleOrdersService().SaleOrders(parameters);

            this.InitDataSet();
            //格式化数字格式
            foreach (DataGridViewTextBoxColumn c in dataGridView_Report.Columns)
            {
                
                if (c.Name.ToString().Contains("量")|| c.Name.ToString().Contains("价"))
                {
                    dataGridView_Report.Columns[c.Name].DefaultCellStyle.Format = "###,###.00";
                    dataGridView_Report.Columns[c.Name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

            }
            dataGridView_Report.Columns[14].DefaultCellStyle.Format= "###,###.00";
            dataGridView_Report.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
