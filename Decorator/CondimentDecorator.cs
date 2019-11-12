namespace Decorator
{
  public abstract class CondimentDecorator : Beverage
  {
    protected Beverage Beverage;

    protected CondimentDecorator(Beverage beverage) : base(beverage.Size)
    {
      Beverage = beverage;
    }

    public override double Cost()
    {
      return Beverage.Cost();
    }

    public override string GetDescription()
    {
      return Beverage.Description;
    }
  }
}