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
    public void UpdateBill(Bill bill)
    {
        salesDao.UpdateBill(bill);
    }
    public List<OrderItem> GetOrdersForBill(int tableId)
    {
        return salesDao.GetOrdersForBill(tableId);
    }
}
