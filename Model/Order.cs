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

        //list of order_items
        public string Comment { get; set; }

        //the followings must be removed:
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }
    }

}


