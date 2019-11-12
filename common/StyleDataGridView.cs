using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U8common
{
    public  class StyleDataGridView

    {
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="e">RowPostPaint事件</param>
        /// <param name="D">DataGridView控件</param>
        public static  void DisplayRowHeader(DataGridViewRowPostPaintEventArgs e, DataGridView D)
        {
            if ((e.RowIndex + 1) < D.Rows.Count)
            {
                Color color = D.RowHeadersDefaultCellStyle.ForeColor;
                if (D.Rows[e.RowIndex].Selected)
                    color = D.RowHeadersDefaultCellStyle.SelectionForeColor;
                else
                    color = D.RowHeadersDefaultCellStyle.ForeColor;
                using (SolidBrush b = new SolidBrush(color))
                {
                    //在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 6);

                }

            }
        }
    }
}
