namespace AbstractFactory
{
  public class NYPizzaStore : PizzaStore
  {
    private Pizza _pizza;
    readonly PizzaIngredientFactory _factory = new NYPizzaFactory();

    protected override Pizza CreatePizza(string type)
    {
      if (type == "cheese")
      {
        _pizza = new CheesePizza(_factory) { Name = "New York Style Cheese Pizza" };
      }

      return _pizza;
    }
  }
}