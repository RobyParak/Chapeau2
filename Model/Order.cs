using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {

        public int OrderId { get; set; }
        public int BillId { get; set; }
        public int TableId { get; set; }
        public bool IsPaid { get; set; }
        
        public string Comment { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        //not sure about the following line
        public OrderItem O_Item { get; set; }
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

    }
}


