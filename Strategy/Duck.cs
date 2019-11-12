using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public abstract class Duck
  {
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;

    public Duck() { }

    public abstract void Display();

    public void PerformFly()
    {
      this.FlyBehavior.Fly();
    }
    public void PerformQuack()
    {
      this.QuackBehavior.Quack();
    }

    public void Swim()
    {
      Console.WriteLine("All ducks can swim, even fake ones.");
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
      FlyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
      QuackBehavior = qb;
    }
  }
}
