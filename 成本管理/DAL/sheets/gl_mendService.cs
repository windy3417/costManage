using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using 成本管理.DAL;

namespace 成本管理.DAL.sheets
{
    /// <summary>
    /// 检查所在会计期间是否结账
    /// </summary>
    class gl_mendService
    {
        public  bool QueryPeriodState(SqlParameter[] parameters)
        {
          
            string SQLstring = "select bflag_ST , iYPeriod  from gl_mend  where iYPeriod=@string_iperiodStart or iYPeriod=@string_iperiodEnd";
            SqlDataReader reader = sqlHelper.GetSqlDataReader(SQLstring, parameters);
            
            reader.Read();

            if ((bool)reader[0] == true)//返回第一列的值

            {
                reader.Close();
                return true;

            }

            reader.Close();
             return false;
            
        }
                
            
        
    }
}
