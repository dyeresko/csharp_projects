namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The following items are available:");
            System.Console.WriteLine("1 – Rope");
            System.Console.WriteLine("2 – Torches");
            System.Console.WriteLine("3 – Climbing Equipment");
            System.Console.WriteLine("4 – Clean Water");
            System.Console.WriteLine("5 – Machete");
            System.Console.WriteLine("6 – Canoe");
            System.Console.WriteLine("7 – Food Supplies");
            System.Console.Write("What number do you want to see the price of? ");
            string choice = System.Console.ReadLine();
            (string, float) price;
            price = choice switch
            {
                "1" => ("Rope", 10),
                "2" => ("Torches", 15),
                "3" => ("Climbing Equipment", 25),
                "4" => ("Clean Water", 1),
                "5" => ("Machete", 5),
                "6" => ("Canoe", 200),
                "7" => ("Food Suplies", 1),
                _ => ("Apologies. I do not know that one", -1)
            };

            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            if (price.Item2 != -1 && name != "Den")
                System.Console.WriteLine($"Price of {price.Item1} is {price.Item2} gold.");
            else if (name == "Den")
            {
                System.Console.WriteLine($"Price of {price.Item1} with discount is {price.Item2 * 0.5} gold.");
            }
            else
            {
                System.Console.WriteLine(price.Item1);
            }
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓–
        }
    }
}