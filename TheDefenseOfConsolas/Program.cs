namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Target Row? ");
            int targetRow = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("");
            System.Console.Write("Target Column? ");
            int targetColumn = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Deploy to: ");
            System.Console.WriteLine($"({targetRow}, {targetColumn - 1})");
            System.Console.WriteLine($"({targetRow - 1}, {targetColumn})");
            System.Console.WriteLine($"({targetRow}, {targetColumn + 1})");
            System.Console.WriteLine($"({targetRow + 1}, {targetColumn})");
            Console.Title = "Defense of Consolas";
            Console.Beep(440, 1000);


            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}