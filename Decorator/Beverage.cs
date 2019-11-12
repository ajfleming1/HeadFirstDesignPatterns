using System.Drawing;

namespace Decorator
{
  public abstract class Beverage
  {
    public string Description { get; set; }
    public Size Size { get; set; }

    protected Beverage(Size s)
    {
      this.Size = s;
    }

    public abstract double Cost();
    public abstract string GetDescription();
    public abstract Size GetSize();
  }
}