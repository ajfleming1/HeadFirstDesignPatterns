using System;
using System.Collections.Generic;

namespace Factory
{
  public abstract class Pizza
  {
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();

    public void Prepare()
    {
      Console.WriteLine($"Preparing {Name}");
      Console.WriteLine($"Tossing dough...");
      Console.WriteLine($"Adding Sauce...");
      Console.WriteLine($"Adding Toppings ");
      foreach (var topping in Toppings)
      {
        Console.WriteLine($"{topping} ");
      }
    }

    public void Bake()
    {
      Console.WriteLine($"Bake for 25 minutes at 350.");
    }

    public virtual void Cut()
    {
      Console.WriteLine($"Cutting the pizza in diagonal slices.");
    }

    public void Box()
    {
      Console.WriteLine($"Putting the pizza in an official PizzaStore box.");
    }
  }
}