namespace CommandPattern
{
  public class CeilingFanOnCommand : ICommand
  {
    private readonly CeilingFan _ceilingFan;

    public CeilingFanOnCommand(CeilingFan ceilingFan)
    {
      this._ceilingFan = ceilingFan;
    }

    public void Execute()
    {
      _ceilingFan.On();
    }

    public void Undo()
    {
      _ceilingFan.Off();
    }
  }
}