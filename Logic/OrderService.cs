using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class OrderService
    {
        OrderDao _orderDao;
        public OrderService()
        {
            _orderDao = new OrderDao();
        }
        public List<Order> GetAllOrdersForTable(int tableId)
        {
            return _orderDao.GetAllOrdersForTable(tableId);
        }

        public void UpdateOrder(int orderId, int quantity, string comment)
        {
            _orderDao.UpdateOrder(orderId, quantity, comment);
        }

        public void DeleterOrder(int orderId)
        {
            _orderDao.DeleterOrder(orderId);
        }

        public void CreateOrder(Order order, Item item, Staff staff)
        {
            _orderDao.CreateOrder(order, item, staff);
        }
    }
}
