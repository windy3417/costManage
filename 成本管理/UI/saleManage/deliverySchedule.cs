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
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
