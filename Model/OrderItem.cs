using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OrderItem
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public bool IsPaid = false;

        public OrderItem()
        {
           Item = new Item();
        }
    }
}
