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
        /// 执行外挂数据库存储过程
        /// </summary>
        /// <param name="StoredProcedureName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable ExecuteProcedure(string StoredProcedureName, SqlParameter[] parameters)
        {
            using (SqlConnection conn = conectiongString.creatConection_UF_out_manage())
            {
                 
                sqlHelperBase s = new sqlHelperBase();
                DataTable dt=s.ExecuteProc(conn, StoredProcedureName, parameters);
                return dt;
            }
        }
    }
}
