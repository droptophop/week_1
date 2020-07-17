using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Cart
    {
        // bool exit = false;
        public List<Pizza> List = new List<Pizza>();
        
        public void AddPizza(Pizza pizza)
        {
            List.Add(pizza);
        }

        public void RemovePizza(Pizza pizza)
        {
            List.RemoveAt(List.IndexOf(pizza));
        }
        public void displayCart()
        {
            Console.WriteLine("------ Cart ------");
            foreach(Pizza pizza in List)
            {
                Console.WriteLine(pizza);
            }
            Console.WriteLine("------ **** ------\n");
        }
    }
}