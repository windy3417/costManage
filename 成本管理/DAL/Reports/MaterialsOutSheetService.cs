using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace 成本管理.DAL.Reports
{
    class MaterialsOutSheetService
    {
         
        /// <summary>
        /// 获得销售订单列表
        /// </summary>
        /// <param name="parameters">查询条件</param>
        /// <returns></returns>
        public DataTable MaterialsOutSheet(params SqlParameter[] parameters)
        {

            DataTable dt = SQLcommand.ExecuteProcedure("Usp_MaterialsOutSheet", parameters,DBName.plug);
            return dt;

        }
    }
}
