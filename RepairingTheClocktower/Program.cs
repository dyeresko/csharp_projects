namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(System.Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine("Tick");
            }
            else
            {
                System.Console.WriteLine("Tock");
            }

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}