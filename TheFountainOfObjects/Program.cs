


Player player = new();


System.Console.WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search");
System.Console.WriteLine("of the Fountain of Objects");
System.Console.WriteLine("Light is visible only in the entrance, and no other light is seen anywhere in the caverns.");
System.Console.WriteLine("You must navigate the Caverns with your other senses.");
System.Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
System.Console.WriteLine("Look out for pits. You will feel a breeze if a pit is in an adjacent room. If you enter a room with a pit, you will die");
System.Console.WriteLine("Maelstroms areviolent forces of sentient wind. Entering a room with one could transport you to any other location in the caverns. You will be able to hear their growling and groaning in nearby rooms.");
System.Console.WriteLine("Amaroks roam the caverns. Encountering one is certain death, but you can smell their rotten stench in nearby rooms.");
System.Console.WriteLine("You carry with you a bow and a quiver of arrows. You can use them to shoot monsters in the caverns but be warned: you have a limited supply.");

while (true)
{



    System.Console.WriteLine("-------------------------");
    if (player.game.gridOfRooms[player.Row][player.Col].IsMaelstorm)
    {
        if (player.Col + 1 < player.game.Columns)
        {
            player.game.RemovePosition(player);
            player.Col++;
            player.game.UpdatePosition(player);
        }
        if (player.Col + 1 < player.game.Columns)
        {
            player.game.RemovePosition(player);
            player.Col++;
            player.game.UpdatePosition(player);
        }

        if (player.Row + 1 < player.game.Rows)
        {
            player.game.RemovePosition(player);
            player.Row++;
            player.game.UpdatePosition(player);
        }
        System.Console.WriteLine("ZIP ZAP!");
    }
    System.Console.WriteLine($"You are in the room at ({player.ToString()})");
    if ((player.game.fountain.IsFountainEnabled && (player.Row == 0 && player.Col == 0)))
    {

        System.Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
        System.Console.WriteLine("You win!");
        break;
    }
    if (player.game.gridOfRooms[player.Row][player.Col].IsPit)
    {
        System.Console.WriteLine("You are in a pit!!!");
        System.Console.WriteLine("GAME OVER");
        break;
    }
    if (player.game.gridOfRooms[player.Row][player.Col].IsAmarok)
    {
        System.Console.WriteLine("You faced an Amarok !!!");
        System.Console.WriteLine("GAME OVER");
        break;
    }
    if (player.game.gridOfRooms[player.Row][player.Col].IsEntrance)
        System.Console.WriteLine("You see light coming from the cavern entrance.");
    if (player.game.gridOfRooms[player.Row][player.Col].IsFountain)
    {
        if (!player.game.fountain.IsFountainEnabled)
            System.Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        else
            System.Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");

    }
    if (player.game.CheckIfPit(player))
    {
        System.Console.WriteLine("You feel a draft. There is a pit in a nearby room.");
    }

    if (player.game.CheckIfAmarok(player))
    {
        System.Console.WriteLine("You can smell the rotten stench of an amarok in a nearby room.");
    }
    if (player.game.CheckIfMaelstorm(player))
    {
        System.Console.WriteLine("You hear the growling and groaning of a maelstrom nearby.");
    }


    System.Console.WriteLine($"You have {player.AmountOfArrows}/5 arrows left");
    player.Action = ChooseTheCommand();
    player.Run();
    System.Console.WriteLine();
}




Console.Write("\nPress any key to exit...");
Console.ReadKey(true);

// 1



IPlayerAction ChooseTheCommand()
{
    System.Console.Write("What do you want to do? ");
    return System.Console.ReadLine() switch
    {
        "enable fountain" => new EnableFountainCommand(),
        "move north" => new NorthCommand(),
        "move west" => new WestCommand(),
        "move east" => new EastCommand(),
        "move south" => new SouthCommand(),
        "shoot north" => new ShootNorthCommand(),
        "shoot west" => new ShootWestCommand(),
        "shoot east" => new ShootEastCommand(),
        "shoot south" => new ShootSouthCommand(),
        "help" => new HelpCommand(),
        _ => ChooseTheCommand()
    };
}

public record struct Fountain(int Row, int Col, bool IsFountainEnabled);
public class EnableFountainCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Row == Game.fountainLocation.Row && player.Col == Game.fountainLocation.Col)
            player.game.fountain.IsFountainEnabled = true;
    }
}

public class ShootNorthCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Row + 1 < player.game.Rows && player.AmountOfArrows != 0)
        {
            if (player.game.gridOfRooms[player.Row + 1][player.Col].IsAmarok)
            {
                player.game.gridOfRooms[player.Row + 1][player.Col].IsAmarok = false;
            }
            if (player.game.gridOfRooms[player.Row + 1][player.Col].IsMaelstorm)
            {
                player.game.gridOfRooms[player.Row + 1][player.Col].IsMaelstorm = false;
            }
            player.AmountOfArrows--;
        }

    }
}
public class HelpCommand : IPlayerAction
{
    public void Run(Player player)
    {
        System.Console.WriteLine("List of commands: ");
        System.Console.WriteLine("enable fountain");
        System.Console.WriteLine("move north");
        System.Console.WriteLine("move west");
        System.Console.WriteLine("move east");
        System.Console.WriteLine("move south");
        System.Console.WriteLine("shoot north");
        System.Console.WriteLine("shoot west");
        System.Console.WriteLine("shoot east");
        System.Console.WriteLine("shoot south");
        System.Console.WriteLine("enable fountain - command to enable fountain (you can enable it only if you are in a room with a fountain). Type it and return to the entrance to win the game");
        System.Console.WriteLine("move <direction> - command to move to another room");
        System.Console.WriteLine("shoot <direction> - command to shoot the monsters in the caverns");
    }
}

public class ShootSouthCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Row - 1 >= 0 && player.AmountOfArrows != 0)
        {
            if (player.game.gridOfRooms[player.Row - 1][player.Col].IsAmarok)
            {
                player.game.gridOfRooms[player.Row - 1][player.Col].IsAmarok = false;
            }
            if (player.game.gridOfRooms[player.Row - 1][player.Col].IsMaelstorm)
            {
                player.game.gridOfRooms[player.Row - 1][player.Col].IsMaelstorm = false;
            }
            player.AmountOfArrows--;
        }

    }
}

public class ShootWestCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Col - 1 >= 0 && player.AmountOfArrows != 0)
        {
            if (player.game.gridOfRooms[player.Row][player.Col - 1].IsAmarok)
            {
                player.game.gridOfRooms[player.Row][player.Col - 1].IsAmarok = false;
            }
            if (player.game.gridOfRooms[player.Row][player.Col - 1].IsMaelstorm)
            {
                player.game.gridOfRooms[player.Row + 1][player.Col].IsMaelstorm = false;
            }
            player.AmountOfArrows--;
        }

    }
}

public class ShootEastCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Col + 1 < player.game.Columns && player.AmountOfArrows != 0)
        {
            if (player.game.gridOfRooms[player.Row][player.Col + 1].IsAmarok)
            {
                player.game.gridOfRooms[player.Row][player.Col + 1].IsAmarok = false;
            }
            if (player.game.gridOfRooms[player.Row][player.Col + 1].IsMaelstorm)
            {
                player.game.gridOfRooms[player.Row][player.Col + 1].IsMaelstorm = false;
            }
            player.AmountOfArrows--;
        }

    }
}




public class NorthCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Row + 1 < player.game.Rows)
        {
            player.game.RemovePosition(player);
            player.Row++;
            player.game.UpdatePosition(player);
        }

    }
}
public class WestCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Col - 1 >= 0)
        {
            player.game.RemovePosition(player);
            player.Col--;
            player.game.UpdatePosition(player);
        }

    }
}




public class EastCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Col + 1 < player.game.Columns)
        {
            player.game.RemovePosition(player);
            player.Col++;
            player.game.UpdatePosition(player);
        }
    }
}

public class SouthCommand : IPlayerAction
{
    public void Run(Player player)
    {
        if (player.Row - 1 >= 0)
        {
            player.game.RemovePosition(player);
            player.Row--;
            player.game.UpdatePosition(player);
        }

    }
}

public class Room
{
    public bool IsFountain { get; }
    public bool IsEntrance { get; }
    public bool IsPlayer { get; set; }
    public bool IsPit { get; set; }
    public bool IsAmarok { get; set; }
    public bool IsMaelstorm { get; set; }
    public Room(bool IsFountain = false, bool IsEntrance = false, bool IsPlayer = false, bool isPit = false, bool isAmarok = false, bool IsMaelstorm = false)
    {
        this.IsFountain = IsFountain;
        this.IsEntrance = IsEntrance;
        this.IsPlayer = IsPlayer;
        this.IsPit = isPit;
        this.IsAmarok = isAmarok;
        this.IsMaelstorm = IsMaelstorm;
    }


}


public class Player
{
    public Game game = new();
    public int Row
    { get; set; }
    public int Col { get; set; }
    public IPlayerAction? Action;
    public int AmountOfArrows { get; set; } = 5;
    public void Run()
    {
        Action?.Run(this);
    }
    public Player()
    {
        this.Row = 0;
        this.Col = 0;
    }

    public override string ToString()
    {
        return $"Row={Row}, Column={Col}";
    }
}

public interface IPlayerAction
{
    void Run(Player player);
}





public class Game
{
    public static (int Row, int Col) fountainLocation = (0, 2);

    public Fountain fountain = new(fountainLocation.Row, fountainLocation.Col, false);
    public int Rows { get; set; }
    public int Columns { get; set; }
    public Room[][] gridOfRooms { get; }
    private int numOfTraps;
    private int numOfAmaroks;
    Random rand = new Random();



    public Game()
    {
        WorldType worldType = ChooseTheWorldType();
        switch (worldType)
        {
            case WorldType.Small:
                Rows = 4;
                Columns = 4;
                numOfTraps = 1;
                break;
            case WorldType.Medium:
                Rows = 6;
                Columns = 6;
                numOfTraps = 2;
                break;
            case WorldType.Large:
                Rows = 8;
                Columns = 8;
                numOfTraps = 3;
                break;
        }




        gridOfRooms = new Room[this.Rows][];
        for (int i = 0; i < this.Rows; i++)
        {
            gridOfRooms[i] = new Room[this.Columns];
            for (int j = 0; j < this.Columns; j++)
            {
                if (i == 0 && j == 0)
                {
                    gridOfRooms[i][j] = new Room(false, true, true);
                    continue;
                }


                if (i == fountain.Row && j == fountain.Col)
                {
                    gridOfRooms[i][j] = new Room(true, false, false);
                    continue;
                }

                gridOfRooms[i][j] = new Room();


            }
        }


        for (int k = 0; k < numOfTraps; k++)
        {
            gridOfRooms[rand.Next(1, Rows)][rand.Next(1, Columns)].IsPit = true;
            gridOfRooms[rand.Next(1, Rows)][rand.Next(1, Columns)].IsAmarok = true;
            gridOfRooms[rand.Next(1, Rows)][rand.Next(1, Columns)].IsMaelstorm = true;
        }

    }
    private WorldType ChooseTheWorldType()
    {
        System.Console.WriteLine("Choose the world type: ");
        System.Console.WriteLine("1 - Small");
        System.Console.WriteLine("2 - Medium");
        System.Console.WriteLine("3 - Large");
        return System.Console.ReadLine() switch
        {
            "1" => WorldType.Small,
            "2" => WorldType.Medium,
            "3" => WorldType.Large,
            _ => ChooseTheWorldType()
        };
    }

    public void UpdatePosition(Player player)
    {
        gridOfRooms[player.Row][player.Col].IsPlayer = true;

    }

    public void RemovePosition(Player player)
    {
        gridOfRooms[player.Row][player.Col].IsPlayer = false;
    }

    public bool CheckIfPit(Player player)
    {

        if (player.Row - 1 >= 0 && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row - 1][player.Col + 1].IsPit)
                return true;
        if (player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row][player.Col + 1].IsPit)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row + 1][player.Col + 1].IsPit)
                return true;
        if (player.Row - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col].IsPit)
                return true;
        if (player.Row + 1 < player.game.Rows)
            if (gridOfRooms[player.Row + 1][player.Col].IsPit)
                return true;
        if (player.Row - 1 >= 0 && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col - 1].IsPit)
                return true;
        if (player.Col - 1 >= 0)
            if (gridOfRooms[player.Row][player.Col - 1].IsPit)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row + 1][player.Col - 1].IsPit)
                return true;
        return false;
    }


    public bool CheckIfAmarok(Player player)
    {

        if (player.Row - 1 >= 0 && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row - 1][player.Col + 1].IsAmarok)
                return true;
        if (player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row][player.Col + 1].IsAmarok)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row + 1][player.Col + 1].IsAmarok)
                return true;
        if (player.Row - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col].IsAmarok)
                return true;
        if (player.Row + 1 < player.game.Rows)
            if (gridOfRooms[player.Row + 1][player.Col].IsAmarok)
                return true;
        if (player.Row - 1 >= 0 && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col - 1].IsAmarok)
                return true;
        if (player.Col - 1 >= 0)
            if (gridOfRooms[player.Row][player.Col - 1].IsAmarok)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row + 1][player.Col - 1].IsAmarok)
                return true;
        return false;
    }

    public bool CheckIfMaelstorm(Player player)
    {

        if (player.Row - 1 >= 0 && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row - 1][player.Col + 1].IsMaelstorm)
                return true;
        if (player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row][player.Col + 1].IsMaelstorm)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col + 1 < player.game.Columns)
            if (gridOfRooms[player.Row + 1][player.Col + 1].IsMaelstorm)
                return true;
        if (player.Row - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col].IsMaelstorm)
                return true;
        if (player.Row + 1 < player.game.Rows)
            if (gridOfRooms[player.Row + 1][player.Col].IsMaelstorm)
                return true;
        if (player.Row - 1 >= 0 && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row - 1][player.Col - 1].IsMaelstorm)
                return true;
        if (player.Col - 1 >= 0)
            if (gridOfRooms[player.Row][player.Col - 1].IsMaelstorm)
                return true;
        if (player.Row + 1 < player.game.Rows && player.Col - 1 >= 0)
            if (gridOfRooms[player.Row + 1][player.Col - 1].IsMaelstorm)
                return true;
        return false;
    }

}




enum WorldType
{
    Small,
    Medium,
    Large
}