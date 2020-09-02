using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 成本管理.DAL;

namespace 成本管理.UI.cost
{
    public partial class frm_bomMaterial_unitPrice : Form

    {
        public frm_bomMaterial_unitPrice()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.colseParentForm);

        }

      
        private void colseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

       

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 计算BOM材料清单的单价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_caculater_Click(object sender, EventArgs e)
        {

            SqlParameter[] parameters =
          {
                                                                  
                        new SqlParameter("@iyear",SqlDbType.Int ),
                        new SqlParameter("@startDate",SqlDbType.Date ),
                        new SqlParameter("@endDate",SqlDbType.Date)
                       
                       };
            parameters[0].Value = this.cmb_year.Text;
            parameters[1].Value = this.tbd_startDate.Controls[1].Text;
            parameters[2].Value = this.tbd_endDate.Controls[1].Text;
            DataTable dataTable = sqlHelper.ExecuteProc("xm_plug_sp_BOMmaterial_Variety_UnitPrice", parameters, DBName.u8);
            this.dgv_bomMaterialUnit.DataSource = dataTable;
        }
    }
}
