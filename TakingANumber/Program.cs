namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = AskForNumberInRange("Type a number", 30, 40);
            System.Console.WriteLine(num + 2);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            //Console.WriteLine("[{0}]", string.Join(", ", numbers));
            // 〤✓–

            int AskForNumber(string text)
            {
                System.Console.WriteLine(text);
                return Convert.ToInt32(System.Console.ReadLine());
            }
            int AskForNumberInRange(string text, int min, int max)
            {

                while (true)
                {
                    System.Console.WriteLine(text);
                    int num = Convert.ToInt32(System.Console.ReadLine());
                    if (num > min && num < max)
                    {
                        return num;
                    }
                }

            }
        }


    }
}