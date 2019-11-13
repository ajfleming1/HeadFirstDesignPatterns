using System;
using System.Data;

namespace AbstractFactory
{
  public abstract class Pizza
  {
    public string Name { get; set; }
    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public Veggie[] Veggies { get; set; }
    public Cheese Cheese { get; set; }
    public Pepperoni Pepperoni { get; set; }
    public Clams Clams { get; set; }

    public abstract void Prepare();

    internal void Bake()
    {
      Console.WriteLine("Baking pizza at 350 for 20 minutes.");
    }

    internal virtual void Cut()
    {
      Console.WriteLine("Cutting the pizza into diagonal slices.");
    }

    internal void Box()
    {
      Console.WriteLine("Putting the pizza in an official PizzaStore box.");
    }
  }
}