namespace CommandPattern
{
  public class GarageDoorOpenCommand : ICommand
  {
    private readonly GarageDoor _door;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
      this._door = garageDoor;
    }

    public void Execute()
    {
      _door.Up();
    }

    public void Undo()
    {
      _door.Down();
    }
  }
}