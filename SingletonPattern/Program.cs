using System;

namespace SingletonPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var singleton = Singleton.Instance;
    }
  }
}
