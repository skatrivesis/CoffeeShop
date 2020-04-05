using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MenuItems
    {
        private static string[] coffeeType = { "Dark", "Medium", "Light" };
        private static string[] servingSize = { "10lb", "5lb", "Tester" };

        public static string[] CoffeeType { get => coffeeType; set => coffeeType = value; }
        public static string[] ServingSize { get => servingSize; set => servingSize = value; }
    }
}
