﻿namespace CommandPattern
{
  internal class CeilingFanHighCommand : ICommand
  {
    private readonly CeilingFan _ceilingFan;
    private int _previousSpeed;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
      this._ceilingFan = ceilingFan;
    }

    public void Execute()
    {
      _previousSpeed = _ceilingFan.GetSpeed();
      _ceilingFan.High();
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
      else if(_previousSpeed == CeilingFan.LOW)
      {
        _ceilingFan.Low();
      }
      else if(_previousSpeed == CeilingFan.OFF)
      {
        _ceilingFan.Off();
      }
    }
  }
}