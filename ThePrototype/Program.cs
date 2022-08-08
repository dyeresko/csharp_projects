
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            System.Console.Write("User 1, enter a number between 0 and 100 ");

            int correctNumber = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("User 2, guess the number.");
            do
            {
                System.Console.Write("What is your next guess? ");
                userNumber = Convert.ToInt32(System.Console.ReadLine());
                if (userNumber > correctNumber)
                {
                    System.Console.WriteLine($"{userNumber} is too high.");
                }
                else if (userNumber < correctNumber)
                {
                    System.Console.WriteLine($"{userNumber} is too low.");
                }
            } while (userNumber != correctNumber);
            System.Console.WriteLine("You guessed the number!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓–
        }
    }
}