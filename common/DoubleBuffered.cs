using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U8common
{
    /// <summary>
    /// 设置DataGridView的DoubleBuffered属性为True,解决DataGridView的滚动缓慢问题
    /// </summary>
    public static class DoubleBufferedDataGridView
    {

            public static void DoubleBuffered(this DataGridView dgv, bool setting)
            {
                Type dgvType = dgv.GetType();//因为该属性为私有属性，所以采用反射解决
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, setting, null);
            }
        }
    
}
