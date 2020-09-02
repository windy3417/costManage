using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 成本管理.DAL.Reports
{
    class InspectItemService
    {
        public DataTable GetCostObejectItem()
        {

            string SqlStr = "select a.InvCode as BOM母件编码 ,i.cInvName as BOM母件名称, i.cInvStd as BOM母件规格型号, f.citemcode as 成本对象编码 " +
    "from bom_parent as o " +

       " inner join bas_part as a " +

            "on o.ParentId = a.PartId" +

        " inner join inventory as i" +

            " on a.InvCode = i.cInvCode" +

        " left join fitemss99 as f " +

            " on a.InvCode = f.citemcode" +
    " where a.InvCode like '4%'  and f.citemcode is null";

            DataTable dt = sqlHelper.GetDataTable(SqlStr,DBName.u8);
            return dt;


        }
    }
}
