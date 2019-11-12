using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Common
{
    public class sqlHelperBase
    {

        /// <summary> 
        /// 返回sqlDataReader 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static SqlDataReader GetSqlDataReader(SqlConnection conn, string strSql, SqlParameter[] parameters)
        {

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                                                    
                    cmd.Connection = conn;
                    cmd.CommandText = strSql;
                                      
                    cmd.Parameters.AddRange(parameters); 
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Close();
            
            return reader;
            
                       
                 

                    
                
         }

         
        /// <summary> 
        /// 执行查询并将结果返回至DataTable中 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <param name="parameters">可能带的参数</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static DataTable GetDataTableWithParameters(SqlConnection conn,string strSql, params SqlParameter[] parameters)
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
                    conn.Close();
                    return ds.Tables[0];
                }
               

            }
        }

        /// <summary> 
        /// 执行查询并将结果返回至DataTable中 
        /// </summary> 
        /// <param name="strSql">查询语句</param> 
        /// <returns>返回一张查询结果表</returns> 
        public static DataTable GetDataTable(SqlConnection conn,string strSql)
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
                    conn.Close();
                        return ds.Tables[0];
                    }
                }
            
        }

        /// <summary>
        /// 执行外挂数据库的存储过程
        /// </summary>
        /// <param name="conn">数据库连接对象</param>
        /// <param name="StoredProcedureName">存储过程名称</param>
        /// <param name="parameters">存储过程参数</param>
        public  DataTable ExecuteProc(SqlConnection conn,string StoredProcedureName, SqlParameter[] parameters)
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
                    conn.Close();
                        return ds.Tables[0];
                    }
                }
            
        }

        /// <summary>
        /// 执行对数据的增删改操作,不带参数
        /// </summary>
        /// <param name="SQLstring"></param>
        public static void UpdateNOparameters(SqlConnection conn,string SQLstring)
        {
            
            
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = SQLstring;
                   
                    cmd.ExecuteNonQuery();
                }
            conn.Close();
        }

        ///<summary> 
        /// 执行对数据的增删改操作 
        /// </summary> 
        /// <param name="strSql"></param> 
        /// <param name="parameters"></param> 
        public static void ExecuteNonQuery(SqlConnection conn, string strSql, params SqlParameter[] parameters)
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
            conn.Close();
        }

   
    }




       
}
        
        

    

