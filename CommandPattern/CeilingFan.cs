using System;
using System.Runtime.ConstrainedExecution;

namespace CommandPattern
{
  public class CeilingFan
  {
    public static readonly int HIGH = 3;
    public static readonly int MEDIUM = 2;
    public static readonly int LOW = 1;
    public static readonly int OFF = 0;

    private int speed;
    private readonly string _name;

    public CeilingFan(string name)
    {
      this._name = name;
      speed = OFF;
    }

    public void High()
    {
      speed = HIGH;
      // Code to set fan to high.
      Console.WriteLine($"The ceiling fan {_name} has been turned on high.");
    }

    public void Medium()
    {
      speed = MEDIUM;
      // Code to set fan to medium.
      Console.WriteLine($"The ceiling fan {_name} has been turned on medium.");
    }

    public void Low()
    {
      speed = LOW;
      // Code to set fan to low.
      Console.WriteLine($"The ceiling fan {_name} has been turned on low.");
    }

    public void On()
    {
      Console.WriteLine($"The ceiling fan {_name} has been turned on.");
    }

    public void Off()
    {
      speed = OFF;
      Console.WriteLine($"The ceiling fan {_name} has been turned off.");
    }

    public int GetSpeed()
    {
      return speed;
    }
  }
}