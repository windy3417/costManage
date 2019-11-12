using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 成本管理.Model
{
    public delegate void DataBaseChangedHandle();
    static class DataBaseInfo
    {
        /// <summary>
        /// 数据库配置改变事件，目的为即时更新动态SQL代码中的数据库信息
        /// </summary>
        public static event DataBaseChangedHandle DataBaseChangedEventHandle;

        private static string _dataBaseName;

        /// <summary>
        /// 数据库名
        /// </summary>
        /// 
        public static string dataBaseName

        {
            get { return _dataBaseName; }
            set
            {
                //判断数据库配置是否改变，相当于引发事件的方法
                if (_dataBaseName == value) return;
                _dataBaseName = value;
                //如果数据库配置改变且调用列表不为空，则触发该事件所对应的方法
                if (DataBaseChangedEventHandle != null)
                {
                    DataBaseChangedEventHandle();
                }

            }




           
        }
    }
}
