using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 成本管理.DAL;

namespace 成本管理.UI
{
    public partial class FormPOContractList : Form
    {
        public FormPOContractList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "select b.FileContent from manage..ximai_v_SOattachment as a inner join ufdata_017_2017..so_somain as c  on a.销售订单号 = c.csocode inner join UFDATA_017_2017..VoucherAccessories as b  on c.id = b.VoucherID";
            SqlDataReader rd= sqlHelper.GetSqlDataReader(sql);
            rd.Read();
            byte[] contractFiles = (byte[]) rd["FileContent"];
            int filelength = contractFiles.Length;
            string contractName = "1.pdf";
            string myUrl = Environment.CurrentDirectory + "\\" + contractName;
            FileStream fs = new FileStream(myUrl, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter BW = new BinaryWriter(fs);
            BW.BaseStream.Write(contractFiles, 0, filelength);
            BW.Flush();
            BW.Close();
            MessageBox.Show("文化读取成功");
        }
    }
}
