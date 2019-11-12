namespace Decorator
{
  public class Soy : CondimentDecorator
  {
    private readonly Beverage _beverage;

    public Soy(Beverage b) : base(b)
    {
      _beverage = b;
    }
    public override string GetDescription()
    {
      return _beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
      return .15 + _beverage.Cost();
    }

    public override Size GetSize()
    {
      return this.Size;
    }
  }
}