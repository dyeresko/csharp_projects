

IInterface instance = new newClass();

instance.GetSome();
instance.GetSomeAnother();
instance.PublicProp = "hello";


public class King : ChessPiece
{
    public override bool IsLegalMove(int row, int column)
    {
        if (!base.IsLegalMove(row, column))
        {
            return false;
        }
        if (Math.Abs(row - Row) > 1)
        {
            return false;
        }
        if (Math.Abs(column - Column) > 1)
        {
            return false;
        }
        return true;
    }
}

// Encapsulation - combining data and the operations on data into a well-defined unit
class Score
{
    // Example of encapsulation
    public string name = "Den"; // Data
    public int points;          // Data
    public int level;           // Data

    public void DisplayScore() => System.Console.WriteLine($"{this.name} has {this.points} points"); // Operation on Data

}

// Information hiding - only the object itself should directly access the data

class Rectangle
{
    // We can't access data outside the class
    private float width;
    private float height;
    private float area;

    // We can use data inside the class
    public Rectangle(float width, float height, float area)
    {
        this.width = width;
        this.height = height;
        this.area = area;
    }
}

// Abstraction - concept that allow the inner workings change without affecting the outside world. The world doesn't know things that you do in your well defined unit. The client use only what the server allows to use.

class Triangle
{

    private float trBase;
    private float height;


    public Triangle(float trBase, float height, float area)
    {
        this.trBase = trBase;
        this.height = height;

    }

    public float GetArea() => this.trBase * height;
}


// Inheritance - concept, that allows to derive new classes based on existing ones.

public class GameObject // Base
{
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }

    public void Update() // Base method
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}

public class Asteroid : GameObject // Inheriting... 
{
    public float Size { get; }
    public float RotationAngle { get; }
}

// Polymorphism - derived classes can override methods from base class.

public abstract class ChessPiece
{
    public int Row { get; set; }
    public int Column { get; set; }

    protected bool IsOnBoard(int row, int column)
    {
        return row >= 0 && row < 8 && column >= 0 && column < 8;
    }

    protected bool IsCurrentLocation(int row, int column)
    {
        return row == Row && column == Column;
    }
    public virtual bool IsLegalMove(int row, int column)
    {
        return IsOnBoard(row, column) && !IsCurrentLocation(row, column);
    }
}


// Interface - aspect of C# that serves to form all public members of class



interface IInterface
{
    string PublicProp { get; set; }
    void GetSome();
    void GetSomeAnother();

}


class newClass : IInterface
{
    public string PublicProp { get; set; }
    private string word = "word";

    public string getWord()
    {
        return this.word;
    }
    public void GetSome()
    {
        Console.WriteLine(getWord());
    }

    public void GetSomeAnother()
    {
        System.Console.WriteLine("Some Another");
    }
}