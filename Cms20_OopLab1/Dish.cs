using System;
using System.Collections.Generic;
using System.Text;

namespace Cms20_OopLab1
{
    class Dish
    {
        public string Name { get; set; }
        public decimal Price { private get; set; }

        public FoodType Type { get; set; }
        public int NumberOfCalories { get;set; }

        public Dish(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetPrice()
        {
            //TODO ADD CHECK kl 11-13
            var price = Price;
            if (Type == FoodType.Vegetarian  
                && DateTime.Now.Hour >= 11 && DateTime.Now.Hour <= 13)
            {
                price = price * 0.8m;
            }

            return price;

        }
    }
}
