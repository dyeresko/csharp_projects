namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter an x value");
            int x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter an y value");
            int y = Convert.ToInt32(System.Console.ReadLine());
            if (x < 0 && y > 0)
            {
                System.Console.WriteLine("The enemy is to the northwest!");
            }
            else if (x == 0 && y > 0)
            {
                System.Console.WriteLine("The enemy is to the north!");
            }
            else if (x > 0 && y > 0)
            {
                System.Console.WriteLine("The enemy is to the northeast!");
            }
            else if (x < 0 && y == 0)
            {
                System.Console.WriteLine("The enemy is to the west!");
            }
            else if (x == 0 && y == 0)
            {
                System.Console.WriteLine("The enemy is here!");
            }
            else if (x > 0 && y == 0)
            {
                System.Console.WriteLine("The enemy is to the east!");
            }
            else if (x < 0 && y < 0)
            {
                System.Console.WriteLine("The enemy is to the southwest!");
            }
            else if (x == 0 && y < 0)
            {
                System.Console.WriteLine("The enemy is to the south!");
            }
            else if (x > 0 && y < 0)
            {
                System.Console.WriteLine("The enemy is to the southeast!");
            }

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}