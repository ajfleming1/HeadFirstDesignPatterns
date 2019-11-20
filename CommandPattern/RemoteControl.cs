using System.Text;

namespace CommandPattern
{
  public class RemoteControl
  {
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;

    public RemoteControl()
    {
      _onCommands = new ICommand[7];
      _offCommands = new ICommand[7];
      ICommand noCommand = new NoCommand();

      for (var i = 0; i < 7; i++)
      {
        _onCommands[i] = noCommand;
        _offCommands[i] = noCommand;
      }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
      _onCommands[slot] = onCommand;
      _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
      _onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot)
    {
      _offCommands[slot].Execute();
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("\n-------------- Remote Control --------------\n");
      for (var i = 0; i < _onCommands.Length; i++)
      {
        builder.Append($"Slot {i}: ON: {_onCommands[i].GetType()} \t OFF: {_offCommands[i].GetType()}\n");
      }

      return builder.ToString();
    }
  }
}