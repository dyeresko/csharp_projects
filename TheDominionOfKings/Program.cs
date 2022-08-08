namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of your provinces");
            int numberOfProvinces = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Enter the number of your duchies");
            int numberOfDuchies = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Enter the number of your estates");
            int numberOfEstates = Convert.ToInt16(Console.ReadLine());
            int totalScore = (1 * numberOfEstates) + (3 * numberOfDuchies) + (6 * numberOfProvinces);
            System.Console.WriteLine($"Your point total is {totalScore}.");

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}