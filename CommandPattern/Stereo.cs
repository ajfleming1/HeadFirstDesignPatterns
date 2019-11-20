using System;

namespace CommandPattern
{
  public class Stereo
  {
    private readonly string _name;

    public Stereo(string name)
    {
      this._name = name;
    }

    public void On()
    {
      Console.WriteLine($"The {_name} stereo has been turned on.");
    }

    public void SetCd()
    {
      Console.WriteLine($"The {_name} stereo has been set to cd mode.");
    }

    public void SetVolume(int volume)
    {
      Console.WriteLine($"The {_name} stereo's volume is set to {volume}.");
    }

    public void Off()
    {
      Console.WriteLine($"The {_name} stereo has been turned off.");
    }
  }
}