namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string attack = "Normal";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    attack = "Electric and Fire";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                if (i % 3 == 0)
                {
                    attack = "Fire";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                if (i % 5 == 0)
                {
                    attack = "Electric";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    attack = "Normal";
                    Console.ForegroundColor = ConsoleColor.White;
                }
                System.Console.WriteLine($"{i}: {attack}");
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓–
        }
    }
}