using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using U8common.UIbase;
using U8Common.Tools;
using 成本管理.DAL.Reports;
using 成本管理.Model;

namespace 成本管理.UI
{
    public partial class Form_MaterialsOutSheet : Form_ReportBase
    {
        public Form_MaterialsOutSheet()
        {
                
        
            InitializeComponent();
            this.Text = "材料出库单列表";
            this.button_confirm.Click += Button_confirm_Click;

        }

        private void Button_confirm_Click(object sender, EventArgs e)
        {
            StringBuilder whereConditon = new StringBuilder();
            List<TextBox> ls = new List<TextBox>();
            foreach (var item in base.groupBox_Filter.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")

                {
                    logs.LogWriteWtihString(item.GetType().ToString());
                    ls.Add((TextBox)item);
                }
            }

            foreach (TextBox item in ls )
            {
                if (item.Text!="" && item.Tag!=null)
                {
                    whereConditon.Append(" and " + item.Tag.ToString() + " = " + item.Text);
                }
            }

            SqlParameter[] parameters =
            {
                        new SqlParameter("@Database",SqlDbType.NVarChar,30),
                        new SqlParameter("@StartDate",SqlDbType.Date ),//string_iperiodStar该值是构造函数中的源列，而非参数值。
                        new SqlParameter("@EndDate", SqlDbType.Date ),
                        new SqlParameter("@WhereConditon",SqlDbType.NVarChar,1000)
                       };
            parameters[0].Value = DataBaseInfo.dataBaseName;
            parameters[1].Value = this.textBox_startDate.Text;
            parameters[2].Value = textBox_endDate.Text;
            parameters[3].Value = whereConditon.ToString();

            this.DateGridViewSource = new MaterialsOutSheetService().MaterialsOutSheet(parameters);

            this.InitDataSet();
        }

        private void button_confirm_Click_1(object sender, EventArgs e)
        {

        }
    }
}
