using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class BillDao : BaseDao
    {
        public int CreateEmptyBill(int tableId)
        {
            string query = "INSERT INTO dbo.Bill VALUES(0, 0, 0, ' ', 0, 0); "; //We create an empty bill
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
            query = "SELECT TOP 1 Bill_ID FROM dbo.Bill ORDER BY Bill_ID DESC"; //We then select the Id of the newly created bill
            var dataTable = ExecuteSelectQuery(query, sqlParameters);
            int billId = (int)dataTable.Rows[0]["Bill_ID"];
            query = "UPDATE [Tables] SET Bill_ID = @billId WHERE Table_ID = @tableId ;";
            SqlParameter[] newSqlParameters = { new SqlParameter("@billId", billId), new SqlParameter("@tableId", tableId) }; //We update the Tables table with the newly created bill Id
            ExecuteEditQuery(query, newSqlParameters);
            return billId; //Finally we return the billId
        }

        public int GetBillIdByTableId(int tableId)
        {
            string query = "SELECT B.Bill_ID FROM Bill AS B JOIN[Tables] AS T ON B.Bill_ID = T.Bill_ID WHERE T.Table_ID = @tableId ; ";
            SqlParameter[] sqlParameters = { new SqlParameter("@tableId", tableId) };
            var dataTable = ExecuteSelectQuery(query, sqlParameters);
            int billId = (int)dataTable.Rows[0]["Bill_ID"];
            return billId;
        }

        public Bill GetBillById(int billId)
        {
            string query = "SELECT Bill_ID, Amount_Due, Tips, Total_Due, Comment, VAT, Payment_Method FROM Bill WHERE Bill_ID = @billId ; ";
            SqlParameter[] sqlParameters = { new SqlParameter("@billId", billId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillId = (int)dr["Bill_ID"],
                    AmountDue = (double)dr["Amount_Due"],
                    Tip = (double)dr["Tips"],
                    TotalDue = (double)dr["Total_Due"],
                    Feedback = (string)dr["Comment"],
                    VAT = (double)dr["VAT"],
                    PaymentMethod = ((string)dr["Payment_Method"] == "Cash" ? PaymentType.Cash : PaymentType.Card)
                };
                bills.Add(bill);
            }
            return bills;
        }
        
    }
}
