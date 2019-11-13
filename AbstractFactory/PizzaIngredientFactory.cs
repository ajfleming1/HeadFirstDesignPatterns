namespace AbstractFactory
{
  public interface PizzaIngredientFactory
  {
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    Veggie[] CreateVeggies();
    Pepperoni CreatePepperoni();
    Clams CreateClams();
  }
}