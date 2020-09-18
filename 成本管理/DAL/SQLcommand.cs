using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Common;


namespace 成本管理.DAL
{
    class SQLcommand
    {
        /// <summary>
        /// 执行数据库存储过程,并返回DataTable
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="parameters"></param>
        /// <param name="dBName">连接U8或外挂数据库，使用DBname的枚举值</param>
        /// <returns>DataTable</returns>
        public static DataTable ExecuteProcedure(string StoredProcedureName, SqlParameter[] parameters,DBName dBName)
        {
            using (SqlConnection conn = ConectiongString.creatConection(dBName))
            {

                sqlHelperBase s = new sqlHelperBase();
                DataTable dt = s.ExecuteProc(conn, StoredProcedureName, parameters);
                return dt;
            }
        }
    }

    
 
}

