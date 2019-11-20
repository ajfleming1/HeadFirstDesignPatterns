using System.Text;

namespace CommandPattern
{
  public class RemoteControlWithUndo
  {
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;
    private ICommand _undoCommand;

    public RemoteControlWithUndo()
    {
      _onCommands = new ICommand[7];
      _offCommands = new ICommand[7];
      ICommand noCommand = new NoCommand();

      for (var i = 0; i < 7; i++)
      {
        _onCommands[i] = noCommand;
        _offCommands[i] = noCommand;
      }

      _undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
      _onCommands[slot] = onCommand;
      _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
      _onCommands[slot].Execute();
      _undoCommand = _onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
      _offCommands[slot].Execute();
      _undoCommand = _offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
      _undoCommand.Undo();
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("\n-------------- Remote Control --------------\n");
      for (var i = 0; i < _onCommands.Length; i++)
      {
        builder.Append($"Slot {i}: ON: {_onCommands[i].GetType()} \t OFF: {_offCommands[i].GetType()}\n");
      }

      builder.Append($"Undo: {_undoCommand.GetType()}\n");

      return builder.ToString();
    }
  }
}