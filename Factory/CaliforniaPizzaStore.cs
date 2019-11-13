namespace Factory
{
  public class CaliforniaPizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(string item)
    {
      if (item.Equals("cheese"))
      {
        return new CaliforniaStyleCheesePizza();
      }

      return null;
    }
  }
}