ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Gray);
ColoredItem<Bow> coloredBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Blue);
ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Cyan);
coloredAxe.Display();
System.Console.WriteLine("HI!");
coloredSword.Display();
System.Console.WriteLine("HI!");
coloredBow.Display();
System.Console.WriteLine("HI!");


Console.Write("\nPress any key to exit...");
Console.ReadKey(true);

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<T>
{
    public T Item { get; }
    public ConsoleColor ConsoleColour { get; }

    public ColoredItem(T Item, ConsoleColor ConsoleColor)
    {
        this.Item = Item;
        this.ConsoleColour = ConsoleColor;
    }


    public void Display()
    {
        Console.ForegroundColor = ConsoleColour;
        System.Console.WriteLine(Item.ToString());
        Console.ForegroundColor = ConsoleColor.White;
    }
}