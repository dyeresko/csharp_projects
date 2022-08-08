// METHODS

Arrow MyArrow = Arrow.ChooseTheArrow();
// MyArrow.X means that I haven't chosen the X yet
if (MyArrow.arrowhead == 0)
{
    MyArrow.arrowhead = ChooseTheArrowhead();
}

if (MyArrow.fletching == 0)
{
    MyArrow.fletching = ChooseTheFletching();
}
if (MyArrow.shaft == 0)
{
    MyArrow.shaft = ChooseTheShaft();
}

System.Console.WriteLine(MyArrow.GetCost());

Console.Write("\nPress any key to exit...");
Console.ReadKey(true);



Arrowhead ChooseTheArrowhead()
{
    System.Console.WriteLine("------------------------------");
    System.Console.WriteLine("Choose the arrowhead");
    System.Console.WriteLine($"{((int)Arrowhead.Steel)} - {Arrowhead.Steel}");
    System.Console.WriteLine($"{((int)Arrowhead.Wood)} - {Arrowhead.Wood} ");
    System.Console.WriteLine($"{((int)Arrowhead.Obsidian)} - {Arrowhead.Obsidian}");
    return Convert.ToInt32(System.Console.ReadLine()) switch
    {
        1 => Arrowhead.Steel,
        2 => Arrowhead.Wood,
        3 => Arrowhead.Obsidian,
        _ => ChooseTheArrowhead()
    };
}

int ChooseTheShaft()
{

    System.Console.WriteLine("------------------------------");
    System.Console.WriteLine("Choose the shaft between 60 and 100");
    int sh = Convert.ToInt32(System.Console.ReadLine());
    if (sh > 60 && sh < 100)
    {
        return sh;
    }
    else
    {
        return ChooseTheShaft();
    }

}




Fletching ChooseTheFletching()
{
    System.Console.WriteLine("------------------------------");
    System.Console.WriteLine("Choose the fletching");
    System.Console.WriteLine($"{((int)Fletching.Plastic)} - {Fletching.Plastic}");
    System.Console.WriteLine($"{((int)Fletching.TurkeyFeathers)} - {Fletching.TurkeyFeathers}");
    System.Console.WriteLine($"{((int)Fletching.GooseFeathers)} - {Fletching.GooseFeathers}");
    return Convert.ToInt32(System.Console.ReadLine()) switch
    {
        1 => Fletching.Plastic,
        2 => Fletching.TurkeyFeathers,
        3 => Fletching.GooseFeathers,
        _ => ChooseTheFletching()
    };
}




class Arrow
{
    public Arrowhead arrowhead { get; set; }
    public int shaft { get; set; }
    public Fletching fletching { get; set; }

    private static Arrow CreateCustomArrow()
    {
        return new Arrow();
    }

    private static Arrow CreateStandardArrow()
    {
        System.Console.WriteLine("------------------------------");
        System.Console.WriteLine("Choose the arrow type");
        System.Console.WriteLine("1 - Elite Arrow");
        System.Console.WriteLine("2 - Beginner Arrow");
        System.Console.WriteLine("3 - Marksman Arrow");
        return Convert.ToInt32(System.Console.ReadLine()) switch
        {
            1 => Arrow.CreateEliteArrow(),
            2 => Arrow.CreateBeginnerArrow(),
            3 => Arrow.CreateMarksmanArrow(),
            _ => CreateStandardArrow()
        };

    }


    public static Arrow ChooseTheArrow()
    {

        System.Console.WriteLine("------------------------------");
        System.Console.WriteLine("1 - Create your own arrow");
        System.Console.WriteLine("2 - Create from a list");



        return Convert.ToInt32(System.Console.ReadLine()) switch
        {
            1 => CreateCustomArrow(),
            2 => CreateStandardArrow(),
            _ => ChooseTheArrow()
        };
    }




    public static Arrow CreateEliteArrow(Arrowhead TheEliteArrowhead = Arrowhead.Steel, int TheEliteShaft = 95, Fletching TheEliteFletching = Fletching.Plastic)
    {
        Arrow TheEliteArrow = new();
        TheEliteArrow.arrowhead = TheEliteArrowhead;
        TheEliteArrow.fletching = TheEliteFletching;
        TheEliteArrow.shaft = TheEliteShaft;
        return TheEliteArrow;
    }


    public static Arrow CreateBeginnerArrow(Arrowhead TheBeginnerArrowhead = Arrowhead.Wood, int TheBeginnerShaft = 75, Fletching TheBeginnerFletching = Fletching.GooseFeathers)
    {
        Arrow TheBeginnerArrow = new();
        TheBeginnerArrow.arrowhead = TheBeginnerArrowhead;
        TheBeginnerArrow.fletching = TheBeginnerFletching;
        TheBeginnerArrow.shaft = TheBeginnerShaft;
        return TheBeginnerArrow;
    }

    public static Arrow CreateMarksmanArrow(Arrowhead TheMarksmanArrowhead = Arrowhead.Steel, int TheMarksmanShaft = 75, Fletching TheMarksmanFletching = Fletching.Plastic)
    {
        Arrow TheBeginnerArrow = new();
        TheBeginnerArrow.arrowhead = TheMarksmanArrowhead;
        TheBeginnerArrow.fletching = TheMarksmanFletching;
        TheBeginnerArrow.shaft = TheMarksmanShaft;
        return TheBeginnerArrow;
    }




    private int GetThePriceOfArrowhead()
    {

        return this.arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
            _ => 0
        };

    }




    private int GetThePriceofFletching()
    {
        return this.fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3,
            _ => 0
        };
    }



    private float GetThePriceofShaft() => this.shaft * 0.05f;

    public float GetCost() => GetThePriceOfArrowhead() + GetThePriceofFletching() + GetThePriceofShaft();
}


enum Arrowhead
{
    Null,
    Steel,
    Wood,
    Obsidian
}
enum Fletching
{
    Null,
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}


