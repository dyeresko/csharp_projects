namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; // Start higher than anything in the array.
            foreach (int element in array)
            {

                if (element < currentSmallest)
                    currentSmallest = element;
            }
            DisplayArray(array);
            Console.WriteLine(currentSmallest);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));

            // 〤✓–
        }

    }
}