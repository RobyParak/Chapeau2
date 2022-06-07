using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DAL
{
    public class SalesDao : BaseDao
    {

        //update bill once it's paid
        public void UpdateBill(Bill bill)
        {
            string query = "UPDATE Bill SET Amount_Due = @AmountDue, Tips = @Tip, Total_Due = @Total, Comment = @Feedback, Payment_Method = @PayMethod";

            SqlParameter[] sqlParameters = { new SqlParameter("@AmountDue", bill.AmountDue),
                                             new SqlParameter("@Tip", bill.Tip),
                                             new SqlParameter("@Total", bill.TotalDue),
                                             new SqlParameter("@Feedback", bill.Feedback),
                                             new SqlParameter("@PayMethod", bill.PaymentMethod.ToString())
                                           };

            ExecuteEditQuery(query, sqlParameters);
        }

        //Update order as "paid" once the payment has been processed
        public void UpdateOrder(Order order)
        {
            int paidStatus = (order.IsPaid) ? 1 : 0;
            string query = $"UPDATE [Order] SET Order_Paid = @Paid_status";
            SqlParameter[] sqlParameters = { new SqlParameter("@Paid_status", paidStatus) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> GetOrderItemsForBill(int tableId)
        {
            //Need to get item name, quantity, price and VAT
            string query = "Select Item_Name as [Name], count(Quantity)" +
            " as [Quantity], SUM(Price) as [Price], AVG(VAT) as [VAT]" +
            " from Item Join [Order_Item] ON [Order_Item].Item_ID = Item.Item_ID" +
            " Join [Order] ON [Order].Order_ID = Order_Item.Order_ID" +
            " Where [Order].Table_ID = @TableId" +
            " Group by Item_Name;";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableId)};
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> ordersItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            { 
                OrderItem orderItem = new OrderItem()
                {
                    Quantity = (int)dr["Quantity"],
                    Item = new Item() 
                    {
                        ItemName = (string)dr["Name"],
                        Price = (double)dr["Price"],
                        VAT = (double)dr["VAT"]
                    }
                };
                ordersItems.Add(orderItem);
            }
            return ordersItems;
        }
    }
}