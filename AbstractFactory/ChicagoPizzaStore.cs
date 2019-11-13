namespace AbstractFactory
{
  public class ChicagoPizzaStore : PizzaStore
  {
    private readonly PizzaIngredientFactory _factory = new ChicagoPizzaIngredientFactory();
    private Pizza pizza;
    protected override Pizza CreatePizza(string type)
    {
      if (type == "cheese")
      {
        pizza = new CheesePizza(_factory) { Name = "Chicago Style Cheese Pizza" };
      }

      return pizza;
    }
  }
}