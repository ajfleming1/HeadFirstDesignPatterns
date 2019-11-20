using System;

namespace CommandPattern
{
  public class Light
  {
    private readonly string _name;

    public Light(string name)
    {
      this._name = name;
    }

    public void On()
    {
      Console.WriteLine($"The {_name} light has been turned on.");
    }

    public void Off()
    {
      Console.WriteLine($"The {_name} light has been turned off.");
    }
  }
}