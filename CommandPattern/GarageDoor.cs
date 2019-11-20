using System;

namespace CommandPattern
{
  public class GarageDoor
  {
    private readonly string _name;

    public GarageDoor(string name)
    {
      this._name = name;
    }

    public void Up()
    {
      Console.WriteLine($"The {_name} garage door is open.");
    }

    public void Down()
    {
      Console.WriteLine($"The {_name} garage door is closed.");
    }

    public void Stop()
    {
      Console.WriteLine($"The {_name} garage door is stopped.");
    }

    public void LightOn()
    {
      Console.WriteLine($"The {_name} garage door light is on.");
    }

    public void LightOff()
    {
      Console.WriteLine($"The {_name} garage door light is off.");
    }
  }
}