


for (int rankNumber = 0; rankNumber < GetRankLength(); rankNumber++)
{
    for (int colorNumber = 0; colorNumber < GetColorLength(); colorNumber++)
    {
        Card card = new((CardColors)colorNumber, (Rank)rankNumber);

        card.PrintCard();
    }
}

Console.Write("\nPress any key to exit...");
Console.ReadKey(true);


int GetRankLength()
{
    return Enum.GetValues(typeof(Rank)).Length;
}
int GetColorLength()
{
    return Enum.GetValues(typeof(CardColors)).Length;
}

class Card
{
    public CardColors cardColors { get; private set; }
    public Rank rank { get; private set; }


    public Card(CardColors cardColors, Rank rank)
    {
        this.cardColors = cardColors;
        this.rank = rank;
    }





    public void PrintCard()
    {
        System.Console.WriteLine($"The {cardColors} {rank}");
    }
    public bool CheckTheCard() => rank <= Rank.Ten;


}


enum CardColors
{
    Red,
    Blue,
    Green,
    Yellow
}



enum Rank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand
}