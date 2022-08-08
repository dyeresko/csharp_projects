namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine($"Enter the number {i}");
                number = Convert.ToInt32(System.Console.ReadLine());
                numbers[i] = number;

            }
            int[] numbers1 = new int[5];
            numbers1 = numbers[..];
            numbers[0] = 9;
            Console.WriteLine("[{0}]", string.Join(", ", numbers));

            Console.WriteLine("[{0}]", string.Join(", ", numbers1));
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            // 〤✓–
        }
    }
}