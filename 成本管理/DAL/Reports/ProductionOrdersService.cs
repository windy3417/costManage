using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace 成本管理.DAL.Reports
{
    class ProductionOrdersService
    {
        /// <summary>
        /// 获得生产订单列表
        /// </summary>
        /// <param name="parameters">查询条件</param>
        /// <returns></returns>
        public DataTable ProductionOrders(params SqlParameter[] parameters)
        {
           
            DataTable dt = SQLcommand.ExecuteProcedure("QueryProductionOrder", parameters,DBName.u8);
            return dt;

        }

    }
}
