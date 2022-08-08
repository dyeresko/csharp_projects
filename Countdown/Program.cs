namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            void Countdown(int x = 10)
            {

                if (x == 0)
                {
                    return;
                }
                Console.WriteLine(x);
                Countdown(x - 1);
            }

            Countdown();
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            //Console.WriteLine("[{0}]", string.Join(", ", numbers));
            // 〤✓–
        }
    }
}