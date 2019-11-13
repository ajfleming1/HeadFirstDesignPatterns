using System;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      PizzaStore nyStore = new NYPizzaStore();
      PizzaStore chicagoStore = new ChicagoPizzaStore();

      Pizza pizza = nyStore.OrderPizza("cheese");
      Console.WriteLine($"Ethan ordered a {pizza.Name}");

      Console.WriteLine();

      pizza = chicagoStore.OrderPizza("cheese");
      Console.WriteLine($"Joel ordered a {pizza.Name}");

      Console.ReadLine();
    }
  }
}
