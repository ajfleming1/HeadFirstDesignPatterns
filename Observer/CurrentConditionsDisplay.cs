using System;

namespace ObserverPattern
{
  public class CurrentConditionsDisplay : IObserver, IDisplayElement
  {
    private readonly ISubject _weatherData;
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
      this._weatherData = weatherData;
      _weatherData.RegisterObserver(this);
    }

    public void Update(float temp, float humidity, float pressure)
    {
      this._temperature = temp;
      this._humidity = humidity;
      Display();
    }

    public void Display()
    {
      Console.WriteLine($"Current Conditions: Temperature {_temperature}. Humidity {_humidity}%");
    }
  }
}