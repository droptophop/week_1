using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Pizza
    {
        public string imageURL = "";
        public string Size { get; }
        public string Crust { get; }
        public List<string> Toppings = new List<string>();


        
        public Pizza(string size, string crust, List<string> toppings)
        {
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);
        }



        void AddToppings(string topping)
        {
            Toppings.Add(topping);        
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            foreach(var t in Toppings)
            {
                sb.Append(t);
            }
            return $"{Size} {Crust}\nToppings: {sb}\n";
        }
    }
}