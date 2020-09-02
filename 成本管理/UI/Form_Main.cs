using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

using 成本管理.DAL;
using 成本管理.DAL.sheets;
using 成本管理.UI;
using 成本管理.UI.saleManage;

using System.Configuration;

using 成本管理.Model;
using 成本管理.UI.cost;
using Utility;

namespace 成本管理.UI
{

    public partial class Form_Main : Form
    {
        /// <summary>
        /// 初始化窗体控件
        /// </summary>
        public Form_Main()
        {
            InitializeComponent();
            //初始化数据库连接状态栏
            brushtStateStrip();
            //初始化tabControl

            this.tc.Dock = DockStyle.Fill;
            this.tc.Visible = false;
            this.tc.Parent = this.splitContainer1.Panel2;

            //初始化treeView
            treeView1.Dock = DockStyle.Fill;
            //最大化主窗体
            this.WindowState = FormWindowState.Maximized;

            //DataBaseInfo db = new DataBaseInfo();
            //db.dataBaseName = this.Label_accountIDtext.Text;
            //db.DataBaseNameChanged +=new EventHandler(this.brushtStateStrip);






        }

        /// <summary>
        /// 窗体加载时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromMainLoad(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//清空导航菜单
                                    //调用GetMenu方法，将menuStrip1控件的子菜单添加到treeView1控件中
            GetMenu(treeView1, menuStrip1);
            this.treeView1.ExpandAll();
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ImageIndex = 2;
            this.treeView1.SelectedImageIndex = 2;


        }

        /// <summary>
        /// 选择树形菜单节点同步触发主菜单相应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "U8数据库配置":
                    {
                        this.数据库配置ToolStripMenuItem1_Click(sender, e);
                        break;
                    }
                case "成本结构表导入":
                    {
                        this.成本结构表导入ToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "BOM材料单价":
                    {
                        this.BOM材料单价ToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "材料出库单":
                    {
                        this.材料出库单ToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "项目目录检查":
                    {
                        if (this.成本对象写入ToolStripMenuItem1.Enabled == false)
                        {
                            break;
                        }
                        this.项目目录检查ToolStripMenuItem1_Click(sender, e);
                        break;
                    }

                case "写入成本对象":
                    {
                        if (this.成本对象写入ToolStripMenuItem1.Enabled == false)
                        {
                            break;
                        }
                        this.写入成本对象ToolStripMenuItem1_Click(sender, e);
                        break;
                    }

                case "成本计算":
                    {
                        this.成本计算ToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "u8任务清除":
                    {
                        this.u8任务清除ToolStripMenuItem_Click(sender, e);
                        break;
                    }

                case "产成品单价导入":
                    {
                        this.产成品单价导入ToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "图片格式转换":
                    {
                        this.图片格式转换ToolStripMenuItem_Click(sender, e);
                        break;
                    }

            }




            //Type t = this.GetType();
            //MethodInfo[] mi=  t.GetMethods();
            //if (treeView1.SelectedNode != null)
            //{
            //    foreach (MethodInfo item in mi)
            //    {
            //        List<string> lt = new List<string>();
            //        lt.Add(item.Name);
            //        logWrite(lt);
            //        if (item.Name==treeView1.SelectedNode.Text+ "ToolStripMenuItem_Click")
            //        {

            //            item.Invoke(this, null);


            //        }


            //    }
            //}
        }

        /// <summary>
        /// 释放选择节点，否则第二次选中时无法触发afterSelect事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            this.treeView1.SelectedNode = null;
        }

        #region 将MenuStrip控件中的信息添加到TreeView控件中
        /// <summary>
        /// 将MenuStrip控件中的信息添加到TreeView控件中
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="MenuS">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {

            List<string> lt = new List<string>();
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);//变量newNode1仅仅为精减代码，因为它等价于TreeVies.Nodes
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //写日志用
                lt.Add(MenuS.Items[i].Text);
                lt.Add(MenuS.Items[i].GetType().ToString());

                //判断当前菜单项中是否有二级菜单项,因容器TreeNode无法分级，故即便有变量ToolStripDropDownItem存在，也无法采用递归算法
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++) //遍历二级菜单项
                    {
                        //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        lt.Add(newmenu.DropDownItems[j].Text);
                        lt.Add(newmenu.DropDownItems[j].GetType().ToString());

                        //判断二级菜单项中是否有三级菜单项
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++) //遍历三级菜单项
                                                                                   //将三级菜单名称添加到TreeView组件的子节点newNode2中
                            {
                                newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                                lt.Add(newmenu2.DropDownItems[p].Text);
                                lt.Add(newmenu2.DropDownItems[p].GetType().ToString());
                            }
                    }
            }
            logWrite(lt);
        }


        #endregion


        /// <summary>
        /// 刷新状态栏
        /// </summary>
        public void brushtStateStrip()
        {

            if (ConfigurationManager.ConnectionStrings["myConcetionU8数据库"] != null)
            {

                string conString = ConfigurationManager.ConnectionStrings["myConcetionU8数据库"].ToString();
                string deConString = utility.Encrypt.Decode(conString);
                int dataBaseIndex = deConString.IndexOf("Catalog=");
                int UserIndex = deConString.IndexOf(";User");

                Label_accountIDtext.Text = deConString.Substring(dataBaseIndex + 8, UserIndex - (dataBaseIndex + 8));
                DataBaseInfo.dataBaseName = Label_accountIDtext.Text;

            }
            else
            {
                Label_accountIDtext.Text = "还未设置操作数据库，请设置数据库连接信息";
            }
        }

        /// <summary>
        /// 无数据库配置信息时，成本计算菜单置灰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 成本计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["myConcetion"] != null)
            {
                成本对象写入ToolStripMenuItem1.Enabled = true;


            }
            else
            {
                成本对象写入ToolStripMenuItem1.Enabled = false;

            }
        }

        #region 打开工具类窗体
        /// <summary>
        /// 清除U8任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void u8任务清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ua_taskService deleteTask = new ua_taskService();
            deleteTask.deleteUa_task();
            MessageBox.Show("任务删除任务成功", "删除结果");

        }

        /// <summary>
        /// 图片格式转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 图片格式转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_imageFormatConvert imf = new Form_imageFormatConvert();
            string tabPageText = imf.Text;
            openForm(imf, tabPageText);
        }

        #endregion


        /// <summary>
        /// 打开写入成本对象窗体,并提示警示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 写入成本对象ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("请确认项目目录检查是否通过，未通过而继续写入成本对象，结果将产生差错！",
                "成本对象写入前提示",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No || result == DialogResult.None)
            {
                return;

            }
            else
            {
                Form_WriteCostObject writeCostObject = new Form_WriteCostObject();
                string tabPageText = writeCostObject.Text;
                openForm(writeCostObject, tabPageText);
            }

        }


        /// <summary>
        /// 打开项目目录检查窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 项目目录检查ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form_InspectItem inspectItem = new Form_InspectItem();

            string tabPageText = inspectItem.Text;

            this.openForm(inspectItem, tabPageText);



        }

   

        #region 子窗体嵌入打开与关闭

        /// <summary>
        /// 实现嵌入式窗体
        /// </summary>
        /// <param name="formName">窗体名称</param>
        /// <param name="tabPageText">窗体在TabPage上显示的名称</param>
        private void openForm(Form formName, string tabPageText)
        {

            TabPage tp = new TabPage();
            tp.Text = tabPageText;
            tp.Name = tabPageText;


            //设置tabPage布局
            this.tc.Visible = true;
            this.tc.Controls.Add(tp);
            this.tc.Parent = this.splitContainer1.Panel2;
            //设置窗体布局
            formName.TopLevel = false;
            tp.Controls.Add(formName);

            formName.Dock = DockStyle.Fill;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Parent = tp;
            formName.Show();
            //以代码形式选择选项卡
            tc.SelectedTab = tc.TabPages[tabPageText];//使用tabPage的Focus与Select方法均不能实现以代码形式选择选项卡
        }

        /// <summary>
        /// 关闭嵌入式窗体
        /// </summary>
        /// <param name="tabPageText">要关闭的TabPage页,由子窗体的.text属性传入</param>
        public void closeTabPage(string tabPageText)
        {
            int tp = tc.Controls.IndexOfKey(tabPageText);
            this.tc.Controls.RemoveAt(tp);
        }



        #endregion

       


       


        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="lt">日志数据的List<String>集合</param>
        private static void logWrite(List<string> lt)
        {
            string path = @"MyTest2.txt";

            //Create the file.
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (String LT in lt)

                        sw.WriteLine("{0}\t,{1}", DateTime.Now.ToString(), LT);

                }
            }
        }

        #region 打开表单窗体

        private void 月度发货计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deliverySchedule ds = new deliverySchedule();
            string tabPageText = ds.Text;
            openForm(ds, tabPageText);
        }

        /// <summary>
        /// 打开产成品单价导入窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 产成品单价导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductionUnitPriceImport import = new formProductionUnitPriceImport();
            string tabPageText = import.Text;
            openForm(import, tabPageText);
        }

        /// <summary>
        /// 打开数据库配置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void 数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //初始化嵌入式窗体组件
        //    Form_config config = new Form_config();
        //    string tabPageText = config.Text;
        //    openForm(config, tabPageText);

        //    DataBaseInfo.DataBaseChangedEventHandle += brushtStateStrip;
        //}


        #region 打开报表窗体
        /// <summary>
        /// 打开材料出库单报表窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 材料出库单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_MaterialsOut report_materialsOut = new Form_MaterialsOut();
            string tabPageText = report_materialsOut.Text;
            openForm(report_materialsOut, tabPageText);

        }

        /// <summary>
        /// 打开生产订单窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 生产订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ProductionOrders po = new Form_ProductionOrders();
            string tabPageText = po.Text;
            openForm(po, tabPageText);
        }

        /// <summary>
        /// 打开销售订单窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 销售订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SaleOrders sa = new Form_SaleOrders();
            string tabPageText = sa.Text;
            openForm(sa, tabPageText);
        }

        /// <summary>
        /// 打开采购订单列表窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 采购订单列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PurchsingOrders pu = new Form_PurchsingOrders();
            string tabPageText = pu.Text;
            openForm(pu, tabPageText);
        }

        private void 材料出库单列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MaterialsOutSheet mos = new Form_MaterialsOutSheet();
            string tabPageText = mos.Text;
            openForm(mos, tabPageText);
        }

        private void testSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SheetTest ts = new Form_SheetTest();
            string tabPageText = ts.Text;
            openForm(ts, tabPageText);
        }

        private void POContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPOContractList po = new FormPOContractList();
            string tabPageText = po.Text;
            openForm(po, tabPageText);
        }

        private void 成本结构表导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_unitCost uc = new frm_unitCost();
            string tabPageText = uc.Text;
            openForm(uc, tabPageText);

        }

        private void BOM材料单价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bomMaterial_unitPrice fbu = new frm_bomMaterial_unitPrice();
            string tabPageText = fbu.Text;
            openForm(fbu, tabPageText);
        }

        private void 数据库配置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //初始化嵌入式窗体组件
            Form_config config = new Form_config();
            string tabPageText = config.Text;
            openForm(config, tabPageText);

            DataBaseInfo.DataBaseChangedEventHandle += brushtStateStrip;
        }

       
    }

    #endregion


    #region 打开成本计算系列窗体



    #endregion

    /// <summary>
    /// 打开产成品单价导入窗体
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>



    

    #endregion



}









    
