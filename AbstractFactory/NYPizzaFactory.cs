namespace AbstractFactory
{
  public class NYPizzaFactory : PizzaIngredientFactory
  {
    public Dough CreateDough()
    {
      return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
      return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
      return new ReggianoCheese();
    }

    public Veggie[] CreateVeggies()
    {
      return new Veggie[] {new Garlic(), new Mushroom(), new Onion(), };
    }

    public Pepperoni CreatePepperoni()
    {
      return new SlicedPepperoni();
    }

    public Clams CreateClams()
    {
      return new FreshClams();
    }
  }
}