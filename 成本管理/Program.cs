using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using 成本管理;
using 成本管理.Model;
using 成本管理.UI;


namespace 成本管理
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
            



        }
    }
}
