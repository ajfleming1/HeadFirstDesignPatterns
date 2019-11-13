namespace AbstractFactory
{
  internal class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
  {
    public Dough CreateDough()
    {
      return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
      return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
      return new MozzarellaCheese();
    }

    public Veggie[] CreateVeggies()
    {
      return new Veggie[] {new Onion()};
    }

    public Pepperoni CreatePepperoni()
    {
      return new SlicedPepperoni();
    }

    public Clams CreateClams()
    {
      return new CannedClams();
    }
  }
}