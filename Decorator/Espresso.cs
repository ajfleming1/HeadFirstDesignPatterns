namespace Decorator
{
  public class Espresso : Beverage
  {
    public Espresso(Size s) : base(s)
    {
      Description = "Espresso";
    }

    public override Size GetSize()
    {
      return this.Size;
    }

    public override double Cost()
    {
      return 1.99;
    }

    public override string GetDescription()
    {
      return Description;
    }
  }
}