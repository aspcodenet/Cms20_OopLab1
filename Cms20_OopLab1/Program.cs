using System;
using System.Collections.Generic;

namespace Cms20_OopLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchMenu = new List<Dish>();
            var dish1 = new Dish("Pancakes",89);
            dish1.NumberOfCalories = 20;
            dish1.Type = FoodType.Vegetarian;

            lunchMenu.Add(dish1);

            var dish2 = new Dish("Ceasarsalad",89);
            dish2.NumberOfCalories = 20;
            dish2.Type = FoodType.Vegetarian;
            lunchMenu.Add(dish2);

            var dish3 = new Dish("Pleskavisca",99);
            dish3.NumberOfCalories = 20;
            dish3.Type = FoodType.Meat;
            lunchMenu.Add(dish3);

            //Vegetarisk 20% mellan kl 11-13
            // FUNKTION FÖR PRICBERÄKBNING - ligger den fel?

            while (true)
            {
                Console.Clear();
                foreach (var dish in lunchMenu)
                {
                    decimal price = dish.GetPrice();
                    Console.WriteLine($"{dish.Name} {price}");
                }
                System.Threading.Thread.Sleep(5000);
            }

        }
    }
}
