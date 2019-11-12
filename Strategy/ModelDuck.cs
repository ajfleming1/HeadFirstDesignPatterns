using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
  public class ModelDuck : Duck
  {
    public ModelDuck()
    {
      FlyBehavior = new FlyNoWay();
      QuackBehavior = new MuteQuack();
    }

    public override void Display()
    {
      Console.WriteLine("I am a model duck.");
    }
  }
}
