using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 成本管理.UI.cost
{
    public partial class frm_bomMaterial_unitPrice : Form
    {
        public frm_bomMaterial_unitPrice()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.colseParentForm);

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void colseParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
