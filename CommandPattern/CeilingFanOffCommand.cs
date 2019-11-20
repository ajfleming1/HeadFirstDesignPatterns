namespace CommandPattern
{
  public class CeilingFanOffCommand : ICommand
  {
    private readonly CeilingFan _ceilingFan;
    private int _previousSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
      this._ceilingFan = ceilingFan;
    }

    public void Execute()
    {
      this._previousSpeed = _ceilingFan.GetSpeed();
      _ceilingFan.Off();
    }

    public void Undo()
    {
      if (_previousSpeed == CeilingFan.HIGH)
      {
        _ceilingFan.High();
      }
      else if (_previousSpeed == CeilingFan.MEDIUM)
      {
        _ceilingFan.Medium();
      }
      else if (_previousSpeed == CeilingFan.LOW)
      {
        _ceilingFan.Low();
      }
      else if (_previousSpeed == CeilingFan.OFF)
      {
        _ceilingFan.Off();
      }
    }
  }
}