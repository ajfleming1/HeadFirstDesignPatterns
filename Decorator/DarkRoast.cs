namespace Decorator
{
  public class DarkRoast : Beverage
  {
    public DarkRoast(Size s) : base(s)
    {
      Description = "Dark Roast";
    }

    public override double Cost()
    {
      return 0.99;
    }

    public override string GetDescription()
    {
      return $"{this.Size} {Description}";
    }

    public override Size GetSize()
    {
      return this.Size;
    }
  }
}