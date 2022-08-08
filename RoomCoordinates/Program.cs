Coordinate coordinate = new Coordinate(0, 0);


for (int i = -1; i < 2; i++)
{
    for (int j = -1; j < 2; j++)
    {
        Coordinate coordinate1 = new Coordinate(i, j);
        System.Console.WriteLine(Coordinate.isAdjacent(coordinate, coordinate1)); ;
    }
}



Console.Write("\nPress any key to exit...");
Console.ReadKey(true);




public struct Coordinate
{
    public int row { get; }
    public int column { get; }


    public Coordinate(int r, int c)
    {
        row = r;
        column = c;
    }
    public static bool isAdjacent(Coordinate coord1, Coordinate coord2)
    {
        if (coord1.row - 1 == coord2.row && coord1.column + 1 == coord2.column)
            return true;
        if (coord1.row == coord2.row && coord1.column + 1 == coord2.column)
            return true;
        if (coord1.row + 1 == coord2.row && coord1.column + 1 == coord2.column)
            return true;
        if (coord1.row - 1 == coord2.row && coord1.column == coord2.column)
            return true;
        if (coord1.row + 1 == coord2.row && coord1.column == coord2.column)
            return true;
        if (coord1.row - 1 == coord2.row && coord1.column - 1 == coord2.column)
            return true;
        if (coord1.row == coord2.row && coord1.column - 1 == coord2.column)
            return true;
        if (coord1.row + 1 == coord2.row && coord1.column - 1 == coord2.column)
            return true;
        return false;

    }

}