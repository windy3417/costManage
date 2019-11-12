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


        public DataTable QueryWriteResult(params SqlParameter[] parameters)
        {
            DataTable dt = sqlHelper.ExecuteProc("QueryWriteCostObjectResult", parameters);
            return dt;
        
         }
           
       

     

    }
}
