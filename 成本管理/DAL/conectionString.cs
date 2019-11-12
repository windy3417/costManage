using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace 成本管理.DAL
{
   public class  conectiongString
    {
        public static SqlConnection creatConection_manage()
        {
            string con = "Data Source=192.168.10.66;Initial Catalog=manage;User ID=sa;Password=000000;Pooling=False";
            SqlConnection conn = new SqlConnection(con);
            return conn;

        }
        public static SqlConnection creatConection_ufsystem()
        {
            string con = "Data Source=192.168.10.66;Initial Catalog=ufsystem;User ID=sa;Password=000000;Pooling=False";
            SqlConnection conn = new SqlConnection(con);
            return conn;

        }
        /// <summary>
        /// 连接业务数据库
        /// </summary>
        /// <returns></returns>
        public static SqlConnection creatConection_myConcetion()
        {
          
            ConnectionStringSettings conStrings = ConfigurationManager.ConnectionStrings["myConcetion"];
            SqlConnection conn = new SqlConnection(conStrings.ConnectionString);
            return conn;

        }
        /// <summary>
        /// 连接外挂数据库
        /// </summary>
        /// <returns></returns>
        public static SqlConnection creatConection_UF_out_manage()
        {
            string IP;
            if (ConfigurationManager.ConnectionStrings["myConcetion"] != null)
            {
                ConnectionStringSettings conString = ConfigurationManager.ConnectionStrings["myConcetion"];
                //int dataBaseIndex = conString.ConnectionString.IndexOf("Catalog=");
                int InitialIndex = conString.ConnectionString.IndexOf(";Initial");

                IP = conString.ConnectionString.Substring(12, InitialIndex-12);
                string con = "Data Source=" + IP + ";Initial Catalog=UF_out_manage;User ID=sa;Password=000000;Pooling=False";
                SqlConnection conn = new SqlConnection(con);
                return conn;
            }

            else
            {
                throw new Exception();
            }
        }
            
           
}
}
