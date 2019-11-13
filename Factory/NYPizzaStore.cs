namespace Factory
{
  public class NYPizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(string item)
    {
      if (item.Equals("cheese"))
      {
        return new NYStyleCheesePizza();
      }

      return null;
    }
  }
}