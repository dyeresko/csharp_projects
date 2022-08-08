
Color Purple = Color.CreatePurple();
Color Red = Color.CreateRed();

Color CustomColor = new(1, 128, 15);
System.Console.WriteLine($"({Purple.Red}, {Purple.Green}, {Purple.Blue})");
System.Console.WriteLine($"({Red.Red}, {Red.Green}, {Red.Blue})");
System.Console.WriteLine($"({CustomColor.Red}, {CustomColor.Green}, {CustomColor.Blue})");


Console.Write("\nPress any key to exit...");
Console.ReadKey(true);

class Color
{
    public byte Red { get; private set; }
    public byte Green { get; private set; }
    public byte Blue { get; private set; }

    public Color(byte r, byte g, byte b)
    {
        this.Red = r;
        this.Blue = b;
        this.Green = g;
    }

    public static Color CreateRed() => new Color(255, 0, 0);
    public static Color CreateBlue() => new Color(0, 255, 0);
    public static Color CreateGreen() => new Color(0, 0, 255);
    public static Color CreateYellow() => new Color(255, 255, 0);
    public static Color CreateWhite() => new Color(255, 255, 255);
    public static Color CreateBlack() => new Color(0, 0, 0);
    public static Color CreatePurple() => new Color(255, 0, 255);
    public static Color CreateAqua() => new Color(0, 255, 255);


}

