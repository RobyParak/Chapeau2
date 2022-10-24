using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public Bill Bill { get; set; }
        public Table Table { get; set; }
        public PaidStatus PaidStatus { get; set; }
        public string Comment { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

    }
}


