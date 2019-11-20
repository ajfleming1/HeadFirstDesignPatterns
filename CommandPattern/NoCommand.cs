using System;

namespace CommandPattern
{
  public class NoCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("Nothing happened.");
    }

    public void Undo()
    {
      Console.WriteLine("Nothing to undo.");
    }
  }
}