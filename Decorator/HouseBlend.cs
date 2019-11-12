namespace Decorator
{
  public class HouseBlend : Beverage
  {
    public HouseBlend(Size s) : base(s)
    {
      Description = "House Blend Coffee";
    }

    public override Size GetSize()
    {
      return this.Size;
    }

    public override double Cost()
    {
      return .89;
    }

    public override string GetDescription()
    {
      return this.Description;
    }
  }
}