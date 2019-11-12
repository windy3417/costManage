using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using 成本管理;
using System.Windows.Forms;

namespace 成本管理.DAL
{
    public class sqlHelper
    {

        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(string strSql, SqlParameter[] parameters)
        {

            SqlConnection conn = conectiongString.creatConection_myConcetion();
            
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                                                    
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                                      
                    cmd.Parameters.AddRange(parameters);
                   

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
            return reader;
            
                       
                 

                    
                
         }

        /// <summary>
        /// 返回sqlDataReader with out paramters
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static SqlDataReader GetSqlDataReader(string strSql)
        {

            SqlConnection conn = conectiongString.creatConection_myConcetion();

            conn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = strSql;
                       
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader;






        }

        /// <summary> 
        /// 执行查询并将结果返回至DataTable中 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static DataTable GetDataTableWithParameters(string strSql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn =conectiongString.creatConection_myConcetion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }

        /// <summary> 
        /// 执行查询并将结果返回至DataTable中 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static DataTable GetDataTable(string strSql)
        {
            using (SqlConnection conn = conectiongString.creatConection_myConcetion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                   
                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }

        /// <summary>
        /// 执行外挂数据库的存储过程
        /// </summary>
        /// <param name="StoredProcedureName">存储过程名称</param>
        /// <param name="parameters">存储过程参数</param>
        public static DataTable ExecuteProc(string StoredProcedureName, SqlParameter[] parameters)
        {
            using (SqlConnection conn = conectiongString.creatConection_UF_out_manage())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcedureName;
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    DataSet ds = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
        }

        /// <summary>
        /// 执行对数据的增删改操作,不带参数
        /// </summary>
        /// <param name="SQLstring"></param>
        public static void UpdateNOparameters(string SQLstring)
        {
            using (SqlConnection conn = conectiongString.creatConection_myConcetion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = SQLstring;
                   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        ///<summary> 
        /// 执行对数据的增删改操作 
        /// </summary> 
        /// <param name="strSql"></param> 
        /// <param name="parameters"></param> 
        public static void ExecuteNonQuery( string strSql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = conectiongString.creatConection_myConcetion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

   
    }




       
}
        
        

    

