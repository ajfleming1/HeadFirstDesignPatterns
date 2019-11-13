using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
  public class ChicagoStyleCheesePizza : Pizza
  {
    public ChicagoStyleCheesePizza()
    {
      Name = "Chicago Style Deep Dish Cheese Pizza";
      Dough = "Extra Thick Crust Dough";
      Sauce = "Plum tomato sauce";

      Toppings.Add("Shredded Mozzarella Cheese");
    }

    public override void Cut()
    {
      Console.WriteLine("Cutting the pizza into square slices");
    }
  }
}
