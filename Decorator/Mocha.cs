namespace Decorator
{
  public class Mocha : CondimentDecorator
  {
    private readonly Beverage _beverage;

    public Mocha(Beverage b) : base(b)
    {
      _beverage = b;
    }

    public override string GetDescription()
    {
      return _beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
      return .20 + _beverage.Cost();
    }

    public override Size GetSize()
    {
      return this.Size;
    }
  }
}