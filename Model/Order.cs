using System;
using System.Collections.Generic;

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }

        //since I changed tableID to table I assume billID should also become bill object?
        public int BillId { get; set; }
        public Table Table { get; set; }
        public bool IsPaid { get; set; }
        public string Comment { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

    }
}


