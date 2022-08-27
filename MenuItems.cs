using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._8.__Restaurant_Menu
{
    public class MenuItems
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public bool New { get; set; }

        public MenuItems(string itemName, string description, double price, string category, bool isNew)
        {
            Name = itemName;
            Description = description;
            Price = price;
            Category = category;
            New = isNew;
        }

    }
}