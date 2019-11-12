using System;

namespace Strategy
{
  class Program
  {
    static void Main(string[] args)
    {
      Duck duck = new MallardDuck();
      duck.PerformFly();
      duck.PerformQuack();
      duck.Display();

      duck = new ModelDuck();
      duck.Display();
      duck.PerformFly();
      duck.PerformQuack();
      duck.SetFlyBehavior(new FlyWithRockets());
      duck.PerformFly();

      Console.ReadLine();
    }
  }
}
