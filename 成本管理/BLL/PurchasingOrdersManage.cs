using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using 成本管理.DAL.Reports;

namespace 成本管理.BLL
{
    class PurchasingOrdersManage
    {
       public DataTable PurchasingOrdersWithSum(params SqlParameter[] parameters)
        {
            DataTable dt = new PurchasingOrdersService().PurchasingOrders(parameters);
            decimal sum=0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
              sum += Convert.ToDecimal(dt.Rows[i][11]);
            }
           
            //在dt中增加一行，第一列显示合计，第五列需要求和的列赋值为a。 
             DataRow dr = dt.NewRow();//是按照dt的表结构建立的行对象
            dr[1] = "合计";
            dr[11] = sum;
            dt.Rows.Add(dr);
            return dt;
        }
    }     
        
       
}
