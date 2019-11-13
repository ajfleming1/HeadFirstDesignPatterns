namespace Factory
{
  public class ChicagoPizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(string item)
    {
      if (item.Equals("cheese"))
      {
        return new ChicagoStyleCheesePizza();
      }

      return null;
    }
  }
}