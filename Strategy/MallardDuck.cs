using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      QuackBehavior = new QuackBehavior();
      FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
      Console.WriteLine("I am a real mallard.");
    }
  }
}
