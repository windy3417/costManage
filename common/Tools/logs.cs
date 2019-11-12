using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace U8Common.Tools
{
  public  class logs
    {

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="lt">日志数据的List<String>集合</param>
        public static void LogWriteWtihList(List<string> lt)
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

        public static void LogWriteWtihString(string logString)
        {
            string path = @"MyTest2.txt";

            //Create the file.
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                        sw.WriteLine("{0}\t,{1}", DateTime.Now.ToString(), logString);

                }
            }
        }

    }
}
