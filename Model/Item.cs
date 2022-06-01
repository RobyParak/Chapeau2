using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public double VAT { get; set; }
    }
}
