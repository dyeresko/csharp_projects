namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter your triangle's base size");
            float triangleBaseSize = Convert.ToSingle(Console.ReadLine());


            System.Console.WriteLine("Enter your triangle's height");
            float triangleHeight = Convert.ToSingle(Console.ReadLine());
            float areaOfTriangle = (triangleBaseSize * triangleHeight) / 2;
            Console.WriteLine("Computing the area...");
            System.Console.WriteLine("Area of a triangle is " + areaOfTriangle);

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}