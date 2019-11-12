namespace Decorator
{
  public class Whip : CondimentDecorator
  {
    public Whip(Beverage beverage) : base(beverage)
    {
      Description = "Whip";
    }

    public override string GetDescription()
    {
      return $"{Beverage.GetDescription()}, {Description}";
    }

    public override double Cost()
    {
      return Beverage.Cost() + .10;
    }

    public override Size GetSize()
    {
      return this.Size;
    }
  }
}