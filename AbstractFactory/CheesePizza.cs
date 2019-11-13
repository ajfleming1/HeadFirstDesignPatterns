using System;

namespace AbstractFactory
{
  public class CheesePizza : Pizza
  {
    private readonly PizzaIngredientFactory _ingredientFactory;

    public CheesePizza(PizzaIngredientFactory factory)
    {
      _ingredientFactory = factory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing " + Name);
      Dough = _ingredientFactory.CreateDough();
      Sauce = _ingredientFactory.CreateSauce();
      Cheese = _ingredientFactory.CreateCheese();
    }
  }
}