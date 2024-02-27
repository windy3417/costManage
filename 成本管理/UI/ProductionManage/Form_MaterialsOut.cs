using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 成本管理;
using U8common;
using 成本管理.DAL;
using System.Data.SqlClient;
using 成本管理.DAL.sheets;

namespace 成本管理.UI
{/// <summary>
/// 材料出库单
/// </summary>
    public partial class Form_MaterialsOut : Form
    {
        #region 字段
        BindingSource bs = new BindingSource();

        private DataTable dt;//用于返回材料出库单数据
        private DataTable dt1 = new WareHouseService().GetWareHouse();//用于返回仓库档案数据

        int pageSize = 0;     //每页显示行数
        int totalCount = 0;   //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int CurrentPageNO = 0;   //当前页号
        int CurrentRowNO = 0;      //当前记录行

        #endregion


        /// <summary>
        /// 初始化窗体
        /// </summary>
        public Form_MaterialsOut()
        {
            InitializeComponent();
            dataGridView_MaterialsOut.TopLeftHeaderCell.Value = "序号";
            dataGridView_MaterialsOut.RowHeadersWidth = 60;
            dataGridView_MaterialsOut.ScrollBars = ScrollBars.Both;
            DoubleBufferedDataGridView.DoubleBuffered(this.dataGridView_MaterialsOut, true);//解决该控件滚动条移动时，数据刷新过慢的问题

            this.comboBox_WareHouseCode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_WareHouseCode.DataSource = dt1;
            this.comboBox_WareHouseCode.DisplayMember = "cWhName";
            this.comboBox_WareHouseCode.ValueMember = "cWhCode";
            this.comboBox_WareHouseCode.SelectedIndex = -1;

        }

        /// <summary>
        /// 窗体加载时，再次调整控件属性
        /// </summary>
        private void report_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)//如果当前的窗体是最大化
            {
                this.WindowState = FormWindowState.Normal;//把当前窗体还原默认大小
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;//将该窗体设置为最大化
            }
            //初始化结束时间控件
            dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_startDate.Format = DateTimePickerFormat.Custom;
            textBox_endDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);
        }

        /// <summary>
        /// 查询确认，绑定数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_confirm_Click(object sender, EventArgs e)
        {

            string sql = "select * from xm_v_MaterialsOut where 1=1";
            if (this.textBox_startDate.Text != "")
            { sql = sql + " and 出库日期>=" + "'" + this.textBox_startDate.Text + "'"; }

            if (this.dateTimePicker_endDate.Value != null)
            {
                { sql = sql + " and 出库日期<=" + "'" + this.textBox_endDate.Text + "'"; }
            }
            if (this.comboBox_WareHouseCode.SelectedIndex != -1)
            {
                { sql = sql + " and 仓库编码=" + "'" + comboBox_WareHouseCode.SelectedValue + "'"; }//text属性是取的displayMember的值
            }
            sql = sql + "order by 出库日期";

            //绑定外挂数据库
            this.dt = sqlHelper.GetDataTable(sql,DBName.plug);
            //判断数据源是否为空
            if (dt.Rows.Count > 0)
            {

                //计算总记录数
                this.totalCount = dt.Rows.Count;
                this.toolStripLabel_totalCount.Text = "共" + this.totalCount.ToString() + "条数记录";
                //bindingNavigatorCountItem.Text =toolStripTextBoxCountPerPage.Text;

                //bs.DataSource =dt;
                //dataGridView_MaterialsOut.DataSource = null;
                //dataGridView_MaterialsOut.DataSource = bs;//如把数据源直接邦定为reader,则数据显示不了
                //bindingNavigator_pageUp.BindingSource = bs;//与dataGridView邦定为同一数据源
                this.InitDataSet();
            }
            else
            {
                MessageBox.Show("查询数据为空，请重新指定查询条件");
            }

        }

        #region 分页处理

        /// <summary>
        /// 分页菜单响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdnInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            if (e.ClickedItem.Text == "上一页")
            {
                this.CurrentPageNO--;
                if (this.CurrentPageNO <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                    return;

                }
                else
                {
                    this.CurrentRowNO = pageSize * (this.CurrentRowNO - 1);
                }
                LoadData();
            }
            if (e.ClickedItem.Text == "下一页")
            {
                this.CurrentPageNO++;
                if (this.CurrentPageNO > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                    return;
                }
                else
                {
                    this.CurrentRowNO = pageSize * (this.CurrentPageNO - 1);
                }
                LoadData();
            }
        }

        /// <summary>
        /// 初始化DataGridView数据源默认分页参数
        /// </summary>
        private void InitDataSet()
        {
            //分页初始值
            this.pageSize = 100;      //设置页面行数
            this.CurrentPageNO = 1;    //当前页数从1开始
            this.CurrentRowNO = 0;     //当前记录数从0开始
                                       //计算出总页数
            this.pageCount = (totalCount / pageSize);
            if ((totalCount % pageSize) > 0) pageCount++;
            LoadData();
        }

        /// <summary>
        /// 邦定数据，根据分页参数
        /// </summary>
        private void LoadData()
        {

            this.toolStripLabel_totalPageCount.Text = this.pageCount.ToString();

            int nStartPosition = 0;   //当前页面开始记录行
            int nEndPosition = 0;     //当前页面结束记录行
            DataTable dtTemp = dt.Clone();   //克隆DataTable结构框架

            //计算起始行
            if (this.CurrentPageNO - 1 == 0)
            {
                nStartPosition = 0;
            }
            else
            {
                nStartPosition = pageSize * (this.CurrentPageNO - 1);
            }


            //计算结束行
            if (this.CurrentRowNO == totalCount)
            {
                nEndPosition = this.totalCount;
            }
            else
            {
                if (this.CurrentPageNO == this.pageCount)
                {
                    nEndPosition = this.totalCount;

                }

                else

                {
                    nEndPosition = pageSize * this.CurrentPageNO;
                }
            }


            this.toolStripLabel_totalPageCount.Text = "/" + this.pageCount.ToString();
            this.toolStripTextBox_CurrentPage.Text = Convert.ToString(this.CurrentPageNO);


            //从元数据源复制记录行
            for (int i = nStartPosition; i < nEndPosition; i++)
            {
                dtTemp.ImportRow(dt.Rows[i]);
                this.CurrentRowNO++;
            }
            bs.DataSource = dtTemp;
            this.bindingNavigator_pageUp.BindingSource = bs;
            this.dataGridView_MaterialsOut.DataSource = bs;
        }

        /// <summary>
        /// 改变当前页码，重载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBox_CurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.CurrentPageNO = Convert.ToInt32(toolStripTextBox_CurrentPage.Text);
                this.LoadData();
            }


        }

        /// <summary>
        /// 改变当前页显示行数，重载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBoxCountPerPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.pageSize = Convert.ToInt32(toolStripTextBox_CountPerPage.Text);
                //计算出总页数
                this.pageCount = (totalCount / pageSize);
                if ((totalCount % pageSize) > 0) pageCount++;
                //重置当前页
                this.CurrentPageNO = 1;
                this.LoadData();
            }
        }

        #endregion


        #region 查询条件
        /// <summary>
        /// 时间输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_startDate.Format = DateTimePickerFormat.Custom;
            textBox_startDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);

        }

        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_endDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_endDate.Format = DateTimePickerFormat.Custom;
            textBox_endDate.Text = dateTimePicker_endDate.Value.ToString().Substring(0, 10);
        }
        #endregion

        #region  窗体关闭


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 关闭父窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();

        }
        #endregion

        private void dataGridView_MaterialsOut_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StyleDataGridView.DisplayRowHeader(e, this.dataGridView_MaterialsOut);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 导出到Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_Export_Click(object sender, EventArgs e)
        {
            U8common.ExportExcel.ExportExcelWithOffice(dt,"材料出库单列表");
            MessageBox.Show("数据导出成功！", "导出提示");
        }
    }

}
