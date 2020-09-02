using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 成本管理.DAL.Reports
{
    class QueryWriteResultService
    {

        /// <summary>
        /// 查询成本对象
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable QueryWriteResult(params SqlParameter[] parameters)
        {
            DataTable dt = sqlHelper.ExecuteProc("QueryWriteCostObjectResult", parameters,DBName.u8);
            return dt;
        
         }
           
       

     

    }
}
