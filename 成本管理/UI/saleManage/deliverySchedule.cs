using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 成本管理.UI.saleManage
{
    public partial class deliverySchedule : Form
    {
        public deliverySchedule()
        {

            InitializeComponent();
           
            
        }

        private void deliverySchedule_Load(object sender, EventArgs e)
        {
            this.listBoxYear.SelectedItem = DateTime.Now.Year.ToString();
            this.listBoxMonth.SelectedItem = DateTime.Now.Month.ToString();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            this.DGVdeliverySchedule.AllowUserToAddRows = true;
            this.DGVdeliverySchedule.AllowUserToDeleteRows = true;
            this.DGVdeliverySchedule.ReadOnly = false;//相当于设计页面中的“启用编辑”功能，此时是针对整个dataGridView对象
            this.DGVdeliverySchedule.Columns["cinvName"].ReadOnly = true;
            this.DGVdeliverySchedule.Columns["cinvStd"].ReadOnly = true;
            //单元格自动折行
            this.DGVdeliverySchedule.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;



        }
        /// <summary>
        /// 关闭窗体,同时关闭母窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.FormClosed += DeliverySchedule_FormClosed;
            this.Close();
            

            
        }

        

        private void DeliverySchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void DGVdeliverySchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.DGVdeliverySchedule.BeginEdit(true);
        }
    }
}
