using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class BillDao : BaseDao
    {
        public int CreateEmptyBill()
        {
            string query = "INSERT INTO dbo.Bill VALUES(0, 0, 0, ' ', 0, 0); "; //We create an empty bill
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
            query = "SELECT TOP 1 Bill_ID FROM dbo.Bill ORDER BY Bill_ID DESC"; //We then select the Id of the newly created bill...
            var dataTable = ExecuteSelectQuery(query, sqlParameters);
            int billId = (int)dataTable.Rows[0]["Bill_ID"];
            return billId; //... and return it
        }
    }
}
