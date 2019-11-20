namespace CommandPattern
{
  public class StereoOffCommand : ICommand
  {
    private readonly Stereo _stereo;

    public StereoOffCommand(Stereo stereo)
    {
      this._stereo = stereo;
    }

    public void Execute()
    {
      _stereo.Off();
    }

    public void Undo()
    {
      _stereo.On();
    }
  }
}