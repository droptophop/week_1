using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  public class Starter
  {
    public Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();

        user.Orders.Add(order);
        store.Orders.Add(order);

        return order;
      }
      catch
      {
        //return null;
        throw new System.Exception("we messed up");
      }
      finally
      {
        GC.Collect();
      }
    }

    internal static void PrintMenu()
    {
      Console.WriteLine("------ Menu ------");
      Console.WriteLine("Select 1 For Cheese Pizza");
      Console.WriteLine("Select 2 For Pepperoni Pizza");
      Console.WriteLine("Select 3 For Sausage Pizza");
      Console.WriteLine("Select 4 For Customized Pizza");
      Console.WriteLine("Select 5 To View Cart");
      Console.WriteLine("Select 6 To Exit\n");
    }
  }
}