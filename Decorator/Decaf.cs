namespace Decorator
{
  public class Decaf : Beverage
  {
    public Decaf(Size s) : base(s)
    {
      Description = "Decaf Coffee";
    }
    public override Size GetSize()
    {
      return this.Size;
    }

    public override double Cost()
    {
      return 1.05;
    }

    public override string GetDescription()
    {
      return Description;
    }
  }
}