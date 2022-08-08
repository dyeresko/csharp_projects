
Sword standardSword = new Sword(GemstoneType.None, MaterialType.Iron, 25);
Sword enemySword = standardSword with { materialType = MaterialType.Bronze };


Sword legendarySword = standardSword with { materialType = MaterialType.Binarium, gemstoneType = GemstoneType.Bitstone };

System.Console.WriteLine(legendarySword.ToString());
System.Console.WriteLine(standardSword.ToString());
System.Console.WriteLine(enemySword.ToString());




Console.Write("\nPress any key to exit...");
Console.ReadKey(true);





public record Sword(GemstoneType gemstoneType, MaterialType materialType, float crossguardWidth)
{
    public override string ToString()
    {
        return $"Gemstone type: {gemstoneType}, Material type: {materialType}, Crossguard width: {crossguardWidth}";
    }
}



public enum GemstoneType
{
    None,
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
}


public enum MaterialType
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium

}
