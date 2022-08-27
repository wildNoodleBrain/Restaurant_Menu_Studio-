using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._8.__Restaurant_Menu
{
    internal class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItems> Items { get; set; }
        public Menu(DateTime updateDate, List<MenuItems> item)
        {
            LastUpdated = updateDate;
            Items = item;
        }
        public void PrintMenu(MenuItems item)
        {
            Console.WriteLine($"\n{item.Name}, ${item.Price}\n{item.Description}");
            if (item.New)
            {
                Console.WriteLine("New Item");
            }
        }
    }
}
       
