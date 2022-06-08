using System;
using System.Collections.Generic;
using DAL;
using Model;


public class SalesService
{
	SalesDao salesDao;
    public SalesService()
    {
        salesDao = new SalesDao();
    }
    public void UpdateOrderStatus(Order order)
    {
        salesDao.UpdateOrder(order);
    }
    public void UpdateBill(Bill bill, Table table)
    {
        salesDao.UpdateBill(bill, table);
    }
    public List<OrderItem> GetOrdersForBill(int tableId)
    {
        return salesDao.GetOrderItemsForBill(tableId);
    }
}
