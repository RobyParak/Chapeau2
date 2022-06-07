using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrdersForTable(int tableId)
        {
            string query = "SELECT O.Order_ID, Bill_ID, Table_ID, OI.Item_ID, I.Item_Name, I.Price, OI.Comments, OI.Quantity, VAT FROM dbo.[Order] AS O JOIN dbo.Order_Item AS OI ON O.Order_ID = OI.Order_ID JOIN dbo.Item AS I ON I.Item_ID = OI.Item_ID WHERE Table_ID = @TableId AND O.Is_Paid = 0; ";
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CreateOrder(Order order, Item item, Staff staff)
        {
            int tableId = order.TableId;
            int billId = order.BillId;
            string query = "INSERT INTO dbo.[Order] VALUES ( @TableId , @BillId ,0)"; //First we create the order in the database
            SqlParameter[] sqlParameters = { new SqlParameter("@TableId", tableId), new SqlParameter("@BillId", billId) };
            ExecuteEditQuery(query, sqlParameters);
            query = "SELECT TOP 1 Order_ID FROM dbo.[Order] ORDER BY Order_ID DESC; "; //Then we get the Id of the most recent Order we just created
            sqlParameters = new SqlParameter[0];
            var dataTable = ExecuteSelectQuery(query, sqlParameters);
            int orderId = (int)dataTable.Rows[0]["Order_ID"];
            int itemId = item.ItemId;
            int orderQuantity = order.Quantity;
            query = $"INSERT INTO dbo.[Order_Item] VALUES( @OrderId , @ItemId , '', @OrderQuantity ); ";
            SqlParameter[] sqlParametersSecondLastQuery = { new SqlParameter("@OrderId", orderId), new SqlParameter("@ItemId", itemId), new SqlParameter("@OrderQuantity", orderQuantity) };
            ExecuteEditQuery(query, sqlParametersSecondLastQuery);
            query = $"INSERT INTO dbo.[Order_Staff] VALUES( @OrderId , @StaffId ); ";
            SqlParameter[] sqlParametersLastQuery = { new SqlParameter("@OrderId", orderId), new SqlParameter("@StaffId", staff.StaffID) };
            ExecuteEditQuery(query, sqlParametersSecondLastQuery);
        }



        public void UpdateOrder(int orderId, int quantity,string comment)
        {
            string query = "UPDATE Order_Item SET Quantity = @Quantity, Comments = @Comment WHERE Order_ID = @OrderId ; ";
            SqlParameter[] sqlParameters = { new SqlParameter("@Quantity", quantity), new SqlParameter("@Comment", comment), new SqlParameter("@OrderId", orderId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleterOrder(int orderId)
        {
            string query = "DELETE FROM Order_Item WHERE Order_ID = @OrderId ; DELETE FROM[Order] WHERE Order_ID = @OrderId ; ";
            SqlParameter[] sqlParameters = { new SqlParameter("@OrderId", orderId) };
            ExecuteEditQuery(query, sqlParameters);
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_ID"],
                    BillId = (int)dr["Bill_ID"],
                    TableId = (int)dr["Table_ID"],
                    ItemName = (string)dr["Item_Name"],
                    Price = (double)dr["Price"],
                    Comment = (string)dr["Comments"],
                    VAT = (double)dr["Vat"],
                    IsPaid = false,
                    Quantity = (int)dr["Quantity"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
