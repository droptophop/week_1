﻿using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to The Leaning Tower of Pizza");

      // array
      //1-dimensional
      string[] cart1 = { "", "", "" }; // initial values
      string[] cart2 = new string[3]; // default values
      string[] cart3 = new[] { "", "", "" }; // initial values - custom datatypes or earlier C# versions

      // list
      List<string> cart4 = new List<string> { "", "", "" }; // initial values
      List<string> cart5 = new List<string>(); // default values
      List<Pizza> cart6 = new List<Pizza>();

      //Menu(cart2);
      //Menu2(cart6);

      var starter = new Starter();
      var user = new User();
      var store = new Store();

      //var order = startup.CreateOrder(user, store);
      // if (order != null)
      // {
      //   Menu3(order);
      // }
      // else
      // {
      //   System.Console.WriteLine("technical difficulties, we be back!");
      // }

      try
      {
        Menu(starter.CreateOrder(user, store));
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
    }

    // static void Menu(string[] cart)
    // {
    //   var exit = false;
    //   var number = 0;

    //   do
    //   {
    //     if (number < cart.Length)
    //     {
    //       System.Console.WriteLine("Select 1 for Cheese Pizza");
    //       System.Console.WriteLine("Select 2 for Pepperoni Pizza");
    //       System.Console.WriteLine("Select 3 for Pineapple Pizza");
    //       System.Console.WriteLine("Select 4 for Custom Pizza");
    //       System.Console.WriteLine("Select 5 for Show Cart");
    //       System.Console.WriteLine("Select 6 for Exit");
    //       System.Console.WriteLine();

    //       int select;

    //       int.TryParse(Console.ReadLine(), out select);

    //       switch (select)
    //       {
    //         case 1:
    //           cart[number] = "cheese";
    //           number += 1;
    //           System.Console.WriteLine("added Cheese");
    //           break;
    //         case 2:
    //           cart[number] = "pepperoni";
    //           number += 1;
    //           System.Console.WriteLine("added Pepperoni");
    //           break;
    //         case 3:
    //           cart[number] = "pineapple";
    //           number += 1;
    //           System.Console.WriteLine("added Pineapple");
    //           break;
    //         case 4:
    //           cart[number] = "custom";
    //           number += 1;
    //           System.Console.WriteLine("added Custom");
    //           break;
    //         case 5:
    //           DisplayCart(cart);
    //           break;
    //         case 6:
    //           System.Console.WriteLine("thank you, goodbye!");
    //           exit = true;
    //           break;
    //       }
    //     }
    //     else
    //     {
    //       DisplayCart(cart);
    //       exit = true;
    //     }
    //   } while (!exit);
    // }

    // static void Menu2(List<Pizza> cart)
    // {
    //   var exit = false;
    //   var number = 0;
    //   var startup = new PizzaStore.Client.Startup();

    //   do
    //   {
    //     if (number < 10)
    //     {
    //       System.Console.WriteLine("Select 1 for Cheese Pizza");
    //       System.Console.WriteLine("Select 2 for Pepperoni Pizza");
    //       System.Console.WriteLine("Select 3 for Pineapple Pizza");
    //       System.Console.WriteLine("Select 4 for Custom Pizza");
    //       System.Console.WriteLine("Select 5 for Show Cart");
    //       System.Console.WriteLine("Select 6 for Exit");
    //       System.Console.WriteLine();

    //       int select;

    //       int.TryParse(Console.ReadLine(), out select);

    //       switch (select)
    //       {
    //         case 1:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"cheese"}));
    //           number += 1;
    //           System.Console.WriteLine("added Cheese");
    //           break;
    //         case 2:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"}));
    //           number += 1;
    //           System.Console.WriteLine("added Pepperoni");
    //           break;
    //         case 3:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pineapple"}));
    //           number += 1;
    //           System.Console.WriteLine("added Pineapple");
    //           break;
    //         case 4:
    //           cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"custom"}));
    //           number += 1;
    //           System.Console.WriteLine("added Custom");
    //           break;
    //         case 5:
    //           DisplayCart2(cart);
    //           break;
    //         case 6:
    //           System.Console.WriteLine("thank you, goodbye!");
    //           exit = true;
    //           break;
    //       }
    //     }
    //     else
    //     {
    //       DisplayCart2(cart);
    //       exit = true;
    //     }

    //     System.Console.WriteLine();
    //   } while (!exit);
    // }

    // static void DisplayCart(string[] cart)
    // {
    //   foreach (var pizza in cart)
    //   {
    //     System.Console.WriteLine(pizza);
    //   }
    // }

    // static void DisplayCart2(List<Pizza> cart)
    // {
    //   foreach (var pizza in cart)
    //   {
    //     System.Console.WriteLine(pizza);
    //   }
    // }

    static void Menu(Order cart)
    {
      var exit = false;

      do
      {
        Starter.PrintMenu();

        int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.CreatePizza("L", "Deep Dish Crust", new List<string>{"Cheese"});
            Console.WriteLine("Cheese Pizza Added To Cart\n");
            break;
        case 2:
            cart.CreatePizza("L", "Pan Crust", new List<String>{"Cheese, Pepperoni"});
            Console.WriteLine("Pepperoni Pizza Added To Cart\n");
            break;
        case 3:
            cart.CreatePizza("L", "Thin Crust", new List<String>{"Cheese, Sausage"});
            Console.WriteLine("Sausage Pizza Added To Cart\n");
            break;
        case 4:
            cart.CreatePizza("L", "Stuffed Crust", new List<String>{"Cheese, Pepperoni, Sausage, Onions, Bell Peppers, Olives"});
            Console.WriteLine("Custom Pizza Added To Cart\n");
            break;
          case 5:
            DisplayCart(cart);
            break;
          case 6:
            var fmw = new FileManager();
            fmw.Write(cart);
            System.Console.WriteLine("Thanks for visiting!\nSee you next time!");
            exit = true;
            break;
          case 7:
            var fmr = new FileManager();
            DisplayCart(fmr.Read());
            break;
        }

        System.Console.WriteLine();
      } while (!exit);
    }

    static void DisplayCart(Order cart)
    { 
      Console.WriteLine("------ Cart ------");
      foreach (var pizza in cart.Pizzas)
      {
        Console.WriteLine($"{pizza}\n");
      }
      Console.WriteLine("------ **** ------");
    }
  }
}
