using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public class SqueakQuack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("Squeak!");
    }
  }
}
