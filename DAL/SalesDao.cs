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
        public void UpdateBill(Bill bill, Table table)
        {
            string query = "UPDATE Bill SET Amount_Due = @AmountDue, Tips = @Tip, Total_Due = @Total, Comment = @Feedback, VAT = @VAT, Payment_Method = @PayMethod" +
                " from Bill join Tables on tables.Bill_ID = bill.Bill_ID" +
                " where table_ID = @TableId";

            SqlParameter[] sqlParameters = { new SqlParameter("@AmountDue", bill.AmountDue),
                                             new SqlParameter("@Tip", bill.Tip),
                                             new SqlParameter("@Total", bill.TotalDue),
                                             new SqlParameter("@Feedback", bill.Feedback),
                                             new SqlParameter("@VAT", bill.VAT),
                                             new SqlParameter("@PayMethod", bill.PaymentMethod.ToString()),
                                             new SqlParameter("@TableId", table.Id)
                                           };

            ExecuteEditQuery(query, sqlParameters);
        }

        //Update order as "paid" once the payment has been processed
        public void UpdateOrder(Bill bill, Table table)
        {
            foreach (Order order in bill.Orders)
            {
                int paidStatus = PaidStatusConverter.ConvertToInt(order.PaidStatus);
                string query = $"UPDATE [Order] SET Is_Paid = @Paid_status" +
                   " Where table_ID = @TableId";
                SqlParameter[] sqlParameters = { new SqlParameter("@Paid_status", paidStatus),
            new SqlParameter("@TableId", table.Id)};
                ExecuteEditQuery(query, sqlParameters);
            }
            }
            //public void UpdateOrder(Table table, List<OrderItem> orderItems)
            //{
            //    int paidStatus = 0;
            //    foreach (OrderItem item in orderItems)
            //    {
            //        if (item.IsPaid == true)
            //        { paidStatus = 1; }
            //        string query = $"UPDATE [Order] SET Is_Paid = @Paid_status" +
            //           " Where table_ID = @TableId";
            //        SqlParameter[] sqlParameters = { new SqlParameter("@Paid_status", paidStatus),
            //    new SqlParameter("@TableId", table.Id)};
            //        ExecuteEditQuery(query, sqlParameters);
            //    }
            //}
            public List<OrderItem> GetOrderItemsForBill(int tableId)
            {
                //Need to get item name, quantity, price and VAT
                string query = "Select Item_Name as [Name], SUM(Quantity)" +
                " as [Quantity], SUM(Price) as [Price], AVG(VAT) as [VAT]" +
                " from Item Join [Order_Item] ON [Order_Item].Item_ID = Item.Item_ID" +
                " Join [Order] ON [Order].Order_ID = Order_Item.Order_ID" +
                " Where [Order].Table_ID = @TableId" +
                " AND [Order].Is_Paid = 0" +
                " Group by Item_Name;";
                SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableId) };
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
