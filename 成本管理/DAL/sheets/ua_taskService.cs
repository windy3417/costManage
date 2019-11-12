using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



using 成本管理.DAL;

namespace 成本管理.DAL.sheets
{
    class ua_taskService
    {

        string sqlstring = "delete ufsystem..ua_task";
        public void deleteUa_task()

        {
            sqlHelper.UpdateNOparameters(sqlstring);
        }
       




    }
}
