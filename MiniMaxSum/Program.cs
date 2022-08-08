namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            long maxSum = long.MinValue;
            long minSum = long.MaxValue;
            int n = 5;
            string[] s = System.Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        sum += arr[j];
                    }
                }
                if (sum < minSum)
                {
                    minSum = sum;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
            System.Console.WriteLine(minSum + " " + maxSum);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            //Console.WriteLine("[{0}]", string.Join(", ", numbers));
            // 〤✓–
        }
    }
}