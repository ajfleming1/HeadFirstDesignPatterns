namespace Decorator
{
  public class SteamedMilk : CondimentDecorator
  {
    private readonly Beverage _beverage;

    public SteamedMilk(Beverage b) : base(b)
    {
      _beverage = b;
    }

    public override string GetDescription()
    {
      return _beverage.GetDescription() + ", steamed milk";
    }

    public override double Cost()
    {
      return .10 + _beverage.Cost();
    }

    public override Size GetSize()
    {
      return this.Size;
    }
  }
}