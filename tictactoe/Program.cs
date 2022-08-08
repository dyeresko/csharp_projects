Game game = new Game();
while (game.stateStatus == StateStatus.running)
{
    game.ChooseTheCell();
    game.CheckTheStateStatus();
}

Console.Write("\nPress any key to exit...");
Console.ReadKey(true);





public class Game
{

    public StateStatus stateStatus { get; set; } = StateStatus.running;
    public int NumberOfTurns = 1;
    Player player { get; set; } = Player.X;
    private string[][] Turns = new string[3][];
    public record Cell(int row, int column);

    public Game()
    {
        for (int row = 0; row < 3; row++)
        {
            Turns[row] = new string[3];
            for (int column = 0; column < 3; column++)
            {
                Turns[row][column] = " ";
            }
        }
    }

    private void SetPlayer()
    {
        if (NumberOfTurns % 2 > 0)
        {
            player = Player.X;
        }
        else
        {
            player = Player.O;
        }
    }


    public void CreateBoard()
    {
        System.Console.WriteLine($" {Turns[0][0]} | {Turns[0][1]} | {Turns[0][2]} ");
        System.Console.WriteLine($"---+---+---");
        System.Console.WriteLine($" {Turns[1][0]} | {Turns[1][1]} | {Turns[1][2]} ");
        System.Console.WriteLine($"---+---+---");
        System.Console.WriteLine($" {Turns[2][0]} | {Turns[2][1]} | {Turns[2][2]} ");
    }
    public (int i, int j) ChooseTheCell()
    {
        int row = 0;
        int column = 0;
        System.Console.WriteLine($"It is {player}'s turn.");
        CreateBoard();
        System.Console.WriteLine("What cell do you want to play in?");
        (row, column) = System.Console.ReadLine() switch
        {
            "1" => (2, 0),
            "2" => (2, 1),
            "3" => (2, 2),
            "4" => (1, 0),
            "5" => (1, 1),
            "6" => (1, 2),
            "7" => (0, 0),
            "8" => (0, 1),
            "9" => (0, 2),
            _ => ChooseTheCell()
        };

        Cell cell = new Cell(row, column);

        // Checks if the cell we want to place a sign is free
        if (Turns[cell.row][cell.column] != " ")
        {
            CreateBoard();
            ChooseTheCell();
        }
        else
        {
            NumberOfTurns++;
            UpdateTurns(cell);
            SetPlayer();
        }
        return (row, column);

    }


    public void CheckTheWinner(string[] cellsToCheck)
    {
        int numberOfX = 0;
        int numberOfO = 0;
        foreach (string el in cellsToCheck)
        {
            if (el == "X")
            {
                numberOfX++;
            }
            if (el == "O")
            {
                numberOfO++;
            }
        }
        if (numberOfX == 3)
        {
            stateStatus = StateStatus.X;
            System.Console.WriteLine("X wins");
            CreateBoard();
        }
        if (numberOfO == 3)
        {
            stateStatus = StateStatus.O;
            System.Console.WriteLine("O wins");
            CreateBoard();
        }
    }


    public void CheckTheStateStatus()
    {
        string[] cellsToCheck = new string[Turns[0].Length];
        int freeCells = 0;
        int diagonalNum = -1;
        for (int row = 0; row < Turns.Length; row++)
        {

            for (int column = 0; column < Turns[0].Length; column++)
            {
                cellsToCheck[column] = Turns[row][column];
            }

            CheckTheWinner(cellsToCheck);


            for (int column = 0; column < Turns[0].Length; column++)
            {
                cellsToCheck[column] = Turns[column][row];
            }

            CheckTheWinner(cellsToCheck);


            for (int column = 0; column < Turns[0].Length; column++)
            {
                diagonalNum++;
                cellsToCheck[column] = Turns[column][diagonalNum];

            }

            CheckTheWinner(cellsToCheck);

            for (int column = 0; column < Turns[0].Length; column++)
            {
                cellsToCheck[column] = Turns[column][diagonalNum];
                diagonalNum--;
            }

            CheckTheWinner(cellsToCheck);


            for (int column = 0; column < Turns[0].Length; column++)
            {
                if (Turns[row][column] == " ")
                {
                    freeCells++;
                }
            }
        }
        if (freeCells == 0)
        {
            stateStatus = StateStatus.draw;
            System.Console.WriteLine("Draw!");
            CreateBoard();
        }
    }

    private void UpdateTurns(Cell cell)
    {
        Turns[cell.row][cell.column] = player switch
        {
            Player.X => "X",
            Player.O => "O",
            _ => ""
        };
    }

}


public enum Player
{
    X,
    O
}


public enum StateStatus
{
    X,
    O,
    running,
    draw

}

