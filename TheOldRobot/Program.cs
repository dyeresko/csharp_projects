Robot robot = new Robot();
for (int index = 0; index < 3; index++)
    robot.Commands[index] = ChooseTheCommand();
robot.Run();


Console.Write("\nPress any key to exit...");
Console.ReadKey(true);

IRobotCommand ChooseTheCommand()
{

    for (int i = 0; i < 10; i++)
    {
        System.Console.Write("-");
    }
    System.Console.Write("MENU");
    for (int i = 0; i < 10; i++)
    {
        System.Console.Write("-");
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Choose the command to the robot: ");
    System.Console.WriteLine("1 - Arrow");
    System.Console.WriteLine("2 - Bow");
    System.Console.WriteLine("3 - Rope");
    System.Console.WriteLine("4 - Water");
    System.Console.WriteLine("5 - Food");
    System.Console.WriteLine("6 - Sword");



    return System.Console.ReadLine() switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "west" => new WestCommand(),
        "east" => new EastCommand(),
        "south" => new SouthCommand(),
        _ => ChooseTheCommand()
    };
}



public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}
public interface IRobotCommand
{
    void Run(Robot Run);
}


public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X--;
        }
    }
}

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X++;
        }
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y--;
        }
    }
}
