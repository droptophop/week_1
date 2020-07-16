using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    internal class Startup
    {
        internal Pizza CreatePizza(string size, string crust, List<string> toppings) 
        {
            var toppingList = new List<string>();
            toppingList.AddRange(toppings);
            Pizza pizza = new Pizza(size, crust, toppingList);
            // pizza.Size = size;
            // pizza.Crust = crust;
            // pizza.Toppings.AddRange(toppings);

            return pizza;
        }
    }
}