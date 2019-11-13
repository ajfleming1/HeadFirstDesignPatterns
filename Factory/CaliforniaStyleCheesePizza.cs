namespace Factory
{
  public class CaliforniaStyleCheesePizza : Pizza
  {
    public CaliforniaStyleCheesePizza()
    {
      Name = "California Style Cheese Pizza";
      Dough = "Gluten Free Dough";
      Sauce = "Organic tomato sauce";

      Toppings.Add("Goat Cheese");
    }
  }
}