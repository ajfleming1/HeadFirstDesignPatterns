using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public class FlyWithRockets : IFlyBehavior
  {
    public void Fly()
    {
      Console.WriteLine("I am flying with rocket power!");
    }
  }
}
