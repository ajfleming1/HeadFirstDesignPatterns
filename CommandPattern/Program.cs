using System;

namespace CommandPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var simpleRemoteControl = new SimpleRemoteControl();
      var light = new Light("Bedroom");
      var lightOnCommand = new LightOnCommand(light);

      simpleRemoteControl.SetCommand(lightOnCommand);
      simpleRemoteControl.ButtonWasPressed();

      var door = new GarageDoor("");
      var garageDoorOpenCommand = new GarageDoorOpenCommand(door);

      simpleRemoteControl.SetCommand(garageDoorOpenCommand);
      simpleRemoteControl.ButtonWasPressed();

      Console.WriteLine();

      var livingRoomLight = new Light("Living Room");
      var kitchenLight = new Light("Kitchen");
      var ceilingFan = new CeilingFan("Living Room");
      var garageDoor = new GarageDoor("");
      var stereo = new Stereo("Living Room");

      var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
      var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
      var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
      var kitchenLightOffCommand = new LightOffCommand(kitchenLight);

      var ceilingFanOnCommand = new CeilingFanOnCommand(ceilingFan);
      var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

      var garageDoorUpCommand = new GarageDoorOpenCommand(garageDoor);
      var garageDoorDownCommand = new GarageDoorCloseCommand(garageDoor);

      var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
      var stereoOffCommand = new StereoOffCommand(stereo);

      var remote = new RemoteControl();
      remote.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
      remote.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
      remote.SetCommand(2, ceilingFanOnCommand, ceilingFanOffCommand);
      remote.SetCommand(3, stereoOnWithCdCommand, stereoOffCommand);

      Console.WriteLine(remote.ToString());
      Console.WriteLine();
      remote.OnButtonWasPushed(0);
      remote.OffButtonWasPushed(0);
      remote.OnButtonWasPushed(1);
      remote.OffButtonWasPushed(1);
      remote.OnButtonWasPushed(2);
      remote.OffButtonWasPushed(2);
      remote.OnButtonWasPushed(3);
      remote.OffButtonWasPushed(3);

      Console.WriteLine();
      Console.WriteLine("------------ Remote with Undo ------------");

      var remoteWithUndo = new RemoteControlWithUndo();
      var sunRoomLight = new Light("Sun Room");
      var sunRoomLightOnCommand = new LightOnCommand(sunRoomLight);
      var sunRoomLightOffCommand = new LightOffCommand(sunRoomLight);

      remoteWithUndo.SetCommand(0, sunRoomLightOnCommand, sunRoomLightOffCommand);

      remoteWithUndo.OnButtonWasPushed(0);
      remoteWithUndo.OffButtonWasPushed(0);
      Console.WriteLine(remoteWithUndo.ToString());
      remoteWithUndo.UndoButtonWasPushed();
      remoteWithUndo.OffButtonWasPushed(0);
      remoteWithUndo.OnButtonWasPushed(0);
      Console.WriteLine(remoteWithUndo.ToString());
      remoteWithUndo.UndoButtonWasPushed();

      Console.WriteLine();
      Console.WriteLine("------------ Ceiling Fan with Undo ------------");

      remoteWithUndo = new RemoteControlWithUndo();
      var ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
      var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
      ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
      remoteWithUndo.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand);
      remoteWithUndo.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

      remoteWithUndo.OnButtonWasPushed(0);
      remoteWithUndo.OffButtonWasPushed(0);
      Console.WriteLine(remoteWithUndo.ToString());
      remoteWithUndo.UndoButtonWasPushed();

      remoteWithUndo.OnButtonWasPushed(1);
      Console.WriteLine(remoteWithUndo.ToString());
      remoteWithUndo.UndoButtonWasPushed();

      Console.WriteLine();
      Console.WriteLine("------------ Party Mode (Macro Commands) ------------");
      remoteWithUndo = new RemoteControlWithUndo();
      ICommand[] partyOn = {livingRoomLightOnCommand, stereoOnWithCdCommand, ceilingFanMediumCommand};
      ICommand[] partyOff = { livingRoomLightOffCommand, stereoOffCommand, ceilingFanOffCommand };
      var partyOnMacro = new MacroCommand(partyOn);
      var partyOffMacro = new MacroCommand(partyOff);
      remoteWithUndo.SetCommand(0, partyOnMacro, partyOffMacro);
      remoteWithUndo.OnButtonWasPushed(0);
      Console.WriteLine();
      remoteWithUndo.OffButtonWasPushed(0);

      Console.ReadLine();
    }
  }
}
