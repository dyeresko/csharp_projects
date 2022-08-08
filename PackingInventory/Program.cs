
Pack pack = new Pack();
while (true)
{
    System.Console.WriteLine(pack.ToString());
    InventoryItem item = Menu();
    pack.Add(item);
}


Console.Write("\nPress any key to exit...");
Console.ReadKey(true);




InventoryItem Menu()
{
    DisplayMenu();
    int choice = Convert.ToInt32(System.Console.ReadLine());
    return choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
        _ => Menu()
    };

}

void DisplayMenu()
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
    System.Console.WriteLine("Choose the item you want to add in your pack: ");
    System.Console.WriteLine("1 - Arrow");
    System.Console.WriteLine("2 - Bow");
    System.Console.WriteLine("3 - Rope");
    System.Console.WriteLine("4 - Water");
    System.Console.WriteLine("5 - Food");
    System.Console.WriteLine("6 - Sword");
}

class InventoryItem
{

    public float weight { get; private set; }
    public float volume { get; private set; }

    public InventoryItem(float weight, float volume)
    {
        this.weight = weight;
        this.volume = volume;
    }

}

class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f)
    {

    }
    public override string ToString()
    {
        return "Arrow";
    }
}

class Rope : InventoryItem
{
    public Rope() : base(1, 1.5f)
    {

    }
    public override string ToString()
    {
        return "Rope";
    }
}

class Bow : InventoryItem
{
    public Bow() : base(1f, 4f)
    {

    }
    public override string ToString()
    {
        return "Bow";
    }
}

class Water : InventoryItem
{
    public Water() : base(2, 3)
    {

    }
    public override string ToString()
    {
        return "Water";
    }
}

class Food : InventoryItem
{
    public Food() : base(1, 0.5f)
    {

    }
    public override string ToString()
    {
        return "Food";
    }
}

class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    {

    }
    public override string ToString()
    {
        return "Sword";
    }
}


class Pack
{
    static int maximumCount = 10;
    static float maximumWeight = 10f;
    static float maximumVolume = 10f;


    public InventoryItem[] items = new InventoryItem[maximumCount];

    public float currentVolume { get; set; }
    public float currentWeight { get; set; }
    private int currentItemCount { get; set; }

    public override string ToString()
    {
        string result = "Pack containing";
        for (int i = 0; i < items.Length; i++)
        {
            result += " " + items[i];
        }
        return result;
    }
    public bool Add(InventoryItem item)
    {
        if (currentVolume + item.volume <= maximumVolume && currentWeight + item.weight <= maximumWeight && currentItemCount + 1 <= 10)
        {
            items[currentItemCount] = item;
            currentVolume += item.volume;
            currentWeight += item.weight;
            currentItemCount++;
            return true;
        }
        else
        {
            return false;
        }
    }
}

