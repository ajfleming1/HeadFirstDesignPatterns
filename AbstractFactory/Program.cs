using System;

namespace AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      PizzaStore store = new NYPizzaStore();
      var pizza = store.OrderPizza("cheese");
      Console.WriteLine($"Ordered {pizza.Name}");

      Console.WriteLine();

      store = new ChicagoPizzaStore();
      pizza = store.OrderPizza("cheese");
      Console.WriteLine($"Ordered {pizza.Name}");
      Console.ReadLine();
    }
  }
}
