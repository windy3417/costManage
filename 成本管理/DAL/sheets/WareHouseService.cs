using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace 成本管理.DAL.sheets
{
    class WareHouseService
    {
        string sqlstr = "select cWhCode,cWhName from Warehouse";
        public DataTable GetWareHouse()
        {
            return
                sqlHelper.GetDataTable(sqlstr);
        }
    }
}
