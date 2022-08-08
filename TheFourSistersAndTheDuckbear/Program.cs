namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter how many eggs you gathered that day");
            int numberOfEggsThatDay = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Each sister will have " + numberOfEggsThatDay / 4 + " eggs");
            System.Console.WriteLine("The duck bear will have " + numberOfEggsThatDay % 4 + " eggs");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓
        }
    }
}