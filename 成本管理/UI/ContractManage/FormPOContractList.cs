﻿using System;
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
using U8Common;
using U8common.UIbase;

namespace 成本管理.UI
{
    public partial class FormPOContractList : Form_ReportBase
    {
        public FormPOContractList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "select b.[filename] , b.FileContent from manage..ximai_v_SOattachment as a inner join ufdata_017_2017..so_somain as c  on a.销售订单号 = c.csocode inner join UFDATA_017_2017..VoucherAccessories as b  on c.id = b.VoucherID";
            SqlDataReader rd= sqlHelper.GetSqlDataReader(sql);
            rd.Read();
            string contractName = (string)rd["Filename"];
            byte[] contractFiles = (byte[]) rd["FileContent"];
            rd.Close();
            int filelength = contractFiles.Length;
            
            string myUrl = Environment.CurrentDirectory + "\\" + contractName;
            FileStream fs = new FileStream(myUrl, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter BW = new BinaryWriter(fs);
            BW.BaseStream.Write(contractFiles, 0, filelength);
            BW.Flush();
            BW.Close();
            MessageBox.Show("文件读取成功");
            System.Diagnostics.Process.Start(myUrl);
        }
    }
}
