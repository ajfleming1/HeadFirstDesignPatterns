using System;

namespace AbstractFactory
{
  public class ClamPizza : Pizza
  {
    private readonly PizzaIngredientFactory _ingredientFactory;

    public ClamPizza(PizzaIngredientFactory factory)
    {
      _ingredientFactory = factory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing " + Name);
      Dough = _ingredientFactory.CreateDough();
      Sauce = _ingredientFactory.CreateSauce();
      Cheese = _ingredientFactory.CreateCheese();
      Clams = _ingredientFactory.CreateClams();
    }
  }
}