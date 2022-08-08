namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game's staring state
            const int defaultHealthOfCity = 15;
            const int defaultHealthOfManticore = 10;
            int healthOfManticore = 10;
            int healthOfCity = 15;
            int round = 1;


            // Choice of a player which distance of Manticore should be from the city
            int manticoreDistance = AskForDistanceInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
            Console.Clear();



            System.Console.WriteLine("Player 2, it is your turn.");

            // Game Loop
            while (true)
            {
                if (healthOfManticore <= 0)
                {
                    System.Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                    break;
                }
                if (healthOfCity <= 0)
                {
                    System.Console.WriteLine("The City has been destroyed! You couldn't save Consolas! :(");
                    break;
                }

                DisplayStatus(round, healthOfCity, healthOfManticore);
                System.Console.WriteLine($"The cannon is expected to deal {FireCannon(round)} damage this round.");
                healthOfManticore -= GetATargetRange("Enter desired cannon range: ", round);

                round++;
                healthOfCity--;
            }


            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);



            /* FUNCTIONS */


            // Function to display the the round number, the city’s health, and the Manticore’s health
            void DisplayStatus(int round, int cityHP, int manticoreHP)
            {
                System.Console.WriteLine("-----------------------------------------------------------");
                System.Console.WriteLine($"STATUS: Round: 1 City: {cityHP}/{defaultHealthOfCity} Manticore: {manticoreHP}/{defaultHealthOfManticore}");
            }


            // Ask the first player to choose the Manticore’s distance from the city (0 to 100).
            int AskForDistanceInRange(string text, int min, int max)
            {

                System.Console.Write(text);
                int distance = Convert.ToInt32(System.Console.ReadLine());
                if (distance > min && distance < max)
                {
                    return distance;
                }

                return AskForDistanceInRange(text, min, max);


            }


            // Computing how much damage the cannon will deal this round to Manticore
            int FireCannon(int round)
            {
                int attackPoints = 1;

                if (round % 3 == 0 && round % 5 == 0)
                {
                    attackPoints = 10;
                    return attackPoints;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    attackPoints = 3;
                    return attackPoints;
                }
                else
                {
                    attackPoints = 1;
                    return attackPoints;
                }
            }


            //Get a target range from the second player, and resolve its effect.
            int GetATargetRange(string text, int round)
            {
                int desiredRange;
                System.Console.Write(text);
                desiredRange = Convert.ToInt32(System.Console.ReadLine());


                if (desiredRange > manticoreDistance)
                {
                    System.Console.WriteLine("That round OVERSHOT the target.");
                    return 0;
                }
                else if (desiredRange < manticoreDistance)
                {
                    System.Console.WriteLine("That round FELL SHORT of the target.");
                    return 0;
                }
                else if (desiredRange == manticoreDistance)
                {
                    System.Console.WriteLine("That round was a DIRECT HIT!");
                    return FireCannon(round);
                }
                return 0;
            }
        }
    }
}