using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using U8common;
using U8Common.Tools;
using System.Data.SqlClient;

namespace U8common.UIbase
{/// <summary>
/// 报表模板,只需传入DataTable类型的DateGridViewSourc属性值做为报表数据源
/// </summary>
    public partial class Form_ReportBase : Form
    {
        #region 字段及属性
        BindingSource bs = new BindingSource();
     
        int _pageSize = 0;     //每页显示行数
        int totalCount = 0;   //总记录数
        private int pageCount = 0;    //总页数＝总记录数/每页显示行数
        int _CurrentPageNO = 0;   //当前页号
        int CurrentRowNO = 0;      //当前记录行
        private DataTable _DateGridViewSource;//封装DataGridView数据源
   
       
        /// <summary>
        /// 接收报表数据源
        /// </summary>
        public DataTable DateGridViewSource
        {
            set { _DateGridViewSource = value; }
            get { return _DateGridViewSource; }
        }
 
        /// <summary>
        /// 每页显示行数
        /// </summary>
        public int PageSize
        { get { return _pageSize; }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 当前页面
        /// </summary>
        public int CurrentPageNO
        { get
            { return _CurrentPageNO; }
            set { _CurrentPageNO = value; }
        }
        /// <summary>
        /// 报表名称
        /// </summary>
        public string reportName;

 
        #endregion

        /// <summary>
        /// 初始化窗体
        /// </summary>
        public Form_ReportBase()
        {
            InitializeComponent();
            dataGridView_Report.TopLeftHeaderCell.Value = "序号";
            dataGridView_Report.RowHeadersWidth = 60;
            dataGridView_Report.ScrollBars = ScrollBars.Both;
            DoubleBufferedDataGridView.DoubleBuffered(this.dataGridView_Report, true);//解决该控件滚动条移动时，数据刷新过慢的问题

        
            
        }

        /// <summary>
        /// 窗体加载时补充初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //时间的初始值等于时间控件的默认值
            this.textBox_startDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 8) + "01";
            textBox_endDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);
        }

        #region 时间查询条件输入
        /// <summary>
        /// 开始时间输入并格式化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_startDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_startDate.Format = DateTimePickerFormat.Custom;
            textBox_startDate.Text = dateTimePicker_startDate.Value.ToString().Substring(0, 10);

        }

        /// <summary>
        /// 结束时间输入并格式化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_endDate.CustomFormat = "yyyy-mm-dd";
            dateTimePicker_endDate.Format = DateTimePickerFormat.Custom;
            //根据时间控件输入日期
            textBox_endDate.Text = dateTimePicker_endDate.Value.ToString().Substring(0, 10);
        }
        #endregion


        
        #region 加载数据，根据分页算法

        /// <summary>
        /// 初始化DataGridView数据源根据默认分页参数
        /// </summary>
        public void InitDataSet()
        {
            //分页初始值
            this._pageSize = 100;      //设置页面行数
            this._CurrentPageNO = 1;    //当前页数从1开始
            this.CurrentRowNO = 0;     //当前记录数从0开始

            if (_DateGridViewSource.Rows.Count > 0)
            {

                //计算总记录数
                this.totalCount = _DateGridViewSource.Rows.Count;
                this.toolStripLabel_totalCount.Text = "共" + this.totalCount.ToString() + "条数记录";
                //计算出总页数
                this.pageCount = (totalCount / _pageSize);
                if ((totalCount % _pageSize) > 0) pageCount++;
                LoadData();
            }
        }

        /// <summary>
        /// 邦定数据，根据分页参数
        /// </summary>
        private void LoadData()
        {
            DataTable dtTemp = _DateGridViewSource.Clone();   //克隆DataTable结构框架并作为DataGridView的分页数据源
            
            this.toolStripLabel_totalPageCount.Text = this.pageCount.ToString();
            #region 得到分页数据源
            int nStartPosition = 0;   //当前页面开始记录行
            int nEndPosition = 0;     //当前页面结束记录行

            //计算起始行
            if(this._CurrentPageNO-1==0)
            {
                nStartPosition = 0;
            }
            else
            {
                nStartPosition =_pageSize * (this._CurrentPageNO - 1);
            }    
            

            //计算结束行
            if (this.CurrentRowNO == totalCount)
            {
                nEndPosition = this.totalCount;
            }
            else
            {
                if (this._CurrentPageNO == this.pageCount)
                {
                    nEndPosition = this.totalCount;

                }

                else

                {
                    nEndPosition = _pageSize * this._CurrentPageNO;
                }
            }
  
            this.toolStripLabel_totalPageCount.Text = "/"+this.pageCount.ToString();
            this.toolStripTextBox_CurrentPage.Text = Convert.ToString(this._CurrentPageNO);

            //从元数据源复制记录行
            for (int i = nStartPosition; i < nEndPosition; i++)
            {
                dtTemp.ImportRow(_DateGridViewSource.Rows[i]);
                this.CurrentRowNO++;
            }

            #endregion

            #region 求得单页小计与整个数据的合计
            //求得分页小计
            DataRow dr = dtTemp.NewRow();//是按照dt的表结构建立的行对象,保存分页小计
            DataRow dr1 = dtTemp.NewRow();//是按照dt的表结构建立的行对象,保存数据合计
            foreach (DataColumn c in dtTemp.Columns)
            {

                if (c.ColumnName.ToString().Contains("量") || c.ColumnName.ToString().Contains("合") || c.ColumnName.ToString().Contains("金"))
                {
                    decimal sum = 0;

                    for (int i = 0; i < dtTemp.Rows.Count-1; i++)
                    {
                        sum += Convert.ToDecimal(dtTemp.Rows[i][c.ColumnName]);
                    }
                    //在dt中增加一行，第一列显示合计，第五列需要求和的列赋值为a。 

                    dr[c.ColumnName] = sum;

                }
            }

            //求得整个数据的合计
            foreach (DataColumn c in _DateGridViewSource.Columns)
            {

                if (c.ColumnName.ToString().Contains("量") || c.ColumnName.ToString().Contains("合")|| c.ColumnName.ToString().Contains("金"))
                {
                    decimal sum = 0;

                    for (int i = 0; i < _DateGridViewSource.Rows.Count-1; i++)//DataTable 中表头也算一行
                    {
                        sum += Convert.ToDecimal(_DateGridViewSource.Rows[i][c.ColumnName]);
                    }
                    //在dt中增加一行，第一列显示合计，第五列需要求和的列赋值为a。 

                    dr1[c.ColumnName] = sum;

                }
            }

            //增加小计与合计行
            dr[1] = "小计";
            dtTemp.Rows.Add(dr);
            dr1[1] = "合计";
            dtTemp.Rows.Add(dr1);

            #endregion

            //绑定分页数据源
            bs.DataSource = dtTemp;
            this.bindingNavigator_pageUp.BindingSource = bs;
            this.dataGridView_Report.DataSource = bs;

            #region 格式化数字格式

            foreach (DataGridViewColumn d in dataGridView_Report.Columns)
                {

                    if (d.Name.ToString().Contains("量") || d.Name.ToString().Contains("价") || d.Name.ToString().Contains("金"))
                    {
                        dataGridView_Report.Columns[d.Name].DefaultCellStyle.Format = "###,###.00";
                        dataGridView_Report.Columns[d.Name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        //以下代码本是准备在前端对DataGridView中的数据进行合计，但编译时系统提示“已经绑定数据源的DataGridView控件不允许再增加行”
                    //decimal sum = 0;
                        //for (int i = 0; i < this.dataGridView_Report.Rows.Count; i++)
                        //{
                        //    sum += Convert.ToDecimal(dataGridView_Report.Rows[i].Cells[c.Name].Value);
                        //}
                        ////在DataGridVies中增加一行，第一列显示合计，第五列需要求和的列赋值为a。 
                        ////DataGridViewRow dr = new DataGridViewRow();
                        ////dr.Cells[1].Value = "合计";
                        ////dr.Cells[c.Name].Value = sum;
                        //dataGridView_Report.Rows.Add();
                        //int index = this.dataGridView_Report.Rows.Add();
                        //this.dataGridView_Report.Rows[index].Cells[1].Value = "合计";
                        //this.dataGridView_Report.Rows[index].Cells[c.Name].Value =sum;


                    }
                }
            #endregion

        }


        /// <summary>
        /// 分页菜单响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdnInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            if (e.ClickedItem.Text == "上一页")
            {
                this._CurrentPageNO--;
                if (this._CurrentPageNO <= 0)
                {
                    MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                    return;

                }
                else
                {
                    this.CurrentRowNO = _pageSize * (this.CurrentRowNO - 1);
                }
                LoadData();
            }
            if (e.ClickedItem.Text == "下一页")
            {
                this._CurrentPageNO++;
                if (this._CurrentPageNO > pageCount)
                {
                    MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                    return;
                }
                else
                {
                    this.CurrentRowNO = _pageSize * (this._CurrentPageNO - 1);
                }
                LoadData();
            }
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
                if (StrRegex.IsInt(this.toolStripTextBox_CurrentPage.Text.ToString()))
                {
                    if (Convert.ToInt32(this.toolStripTextBox_CurrentPage.Text)>pageCount)//本地变量CurrentPageNO在toolStripTextBox_CurrentPage控件没完成回车事件时，无法更新，仍是旧值
                    {
                        MessageBox.Show("当前页不能大于最大页数！");
                        return;
                    }
                    this._CurrentPageNO = Convert.ToInt32(toolStripTextBox_CurrentPage.Text);
                    this.LoadData();
                }

                else
                {
                    MessageBox.Show("请输入正整数！");
                }

                
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
                this._pageSize = Convert.ToInt32(toolStripTextBox_CountPerPage.Text);
                //计算出总页数
                this.pageCount = (totalCount / _pageSize);
                if ((totalCount % _pageSize) > 0) pageCount++;
                //重置当前页
                this._CurrentPageNO = 1;
                this.LoadData();
            }
        }

        #endregion


        #region  窗体关闭


        private void toolStripButton_close_Click(object sender, EventArgs e)
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

        /// <summary>
        ///显示行标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_MaterialsOut_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StyleDataGridView.DisplayRowHeader(e, this.dataGridView_Report);
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
            U8common.ExportExcel.ExportExcelWithOffice(_DateGridViewSource,reportName);
            MessageBox.Show("数据导出成功！","导出提示");
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 验证日期数据是否符合要求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void textBox_startDate_TextChanged(object sender, EventArgs e)
        //{
        //    if (StrRegex.IsDate(this.Text))
        //    {
        //        return;
        //    }
        //    MessageBox.Show("请输入正确的日期！");
        //    this.Focus();
        //}
    }

}
