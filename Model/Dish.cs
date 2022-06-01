using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Dish : Item
    {
        public int DishType { get; set; } //0 - Starter, 1 - Main, 2 - Dessert, 3 - Entremets
    }
}
