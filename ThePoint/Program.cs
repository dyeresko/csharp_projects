
Point Point1 = new(2, 3);
Point Point2 = new(-4, 0);
System.Console.WriteLine($"({Point1.X}, {Point1.Y})");
System.Console.WriteLine($"({Point2.X}, {Point2.Y})");


Console.Write("\nPress any key to exit...");
Console.ReadKey(true);

public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public Point()
    {
        this.X = 0f;
        this.Y = 0f;
    }


}



public class Asteroid
{
    public float PositionX { get; private set; }
    public float PositionY { get; private set; }
    public float VelocityX { get; private set; }
    public float VelocityY { get; private set; }

    public Asteroid(float positionX, float positionY,
    float velocityX, float velocityY)
    {
        PositionX = positionX;
        PositionY = positionY;
        VelocityX = velocityX;
        VelocityY = velocityY;
    }
    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}
public class AsteroidsGame
{
    private Asteroid[] _asteroids;
    public AsteroidsGame()
    {
        _asteroids = new Asteroid[5];
        _asteroids[0] = new Asteroid(100, 200, -4, -2);
        _asteroids[1] = new Asteroid(-50, 100, -1, +3);
        _asteroids[2] = new Asteroid(0, 0, 2, 1);
        _asteroids[3] = new Asteroid(400, -100, -3, -1);
        _asteroids[4] = new Asteroid(200, -300, 0, 3);
    }
    public void Run()
    {
        while (true)
        {
            foreach (Asteroid asteroid in _asteroids)
                asteroid.Update();
        }
    }
}