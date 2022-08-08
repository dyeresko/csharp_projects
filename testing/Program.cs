int[] numbers = new[] { 1, 2, 3 };
numbers = AddToArray(numbers, 4);


List1<int> nums = new List1<int>();
nums.Add(5);
nums.Add(4);

System.Console.WriteLine(nums.number);

int[] AddToArray(int[] input, int newNumber)
{
    int[] output = new int[input.Length + 1];
    for (int index = 0; index < input.Length; index++)
    {
        output[index] = input[index];

    }
    output[^1] = newNumber;
    return output;
}


public class ListOfNumbers
{

    public int[] numbers = new int[0];
    public int GetItemAt(int index) => this.numbers[index];
    public void SetItemAt(int index, int value) => this.numbers[index] = value;

    public void Add(int newValue)
    {
        int[] updated = new int[this.numbers.Length + 1];
        for (int index = 0; index <= numbers.Length; index++)
            updated[index] = this.numbers[index];
        updated[^1] = newValue;
        this.numbers = updated;
    }
}

public class List1<T> where T : string
{
    private T[] items = new T[0];
    public T GetItemAt(int index) => this.items[index];
    public void Add(T newValue)
    {
        T[] updated = new T[this.items.Length + 1];
        for (int index = 0; index < this.items.Length; index++)
        {
            updated[index] = this.items[index];
        }
        updated[^1] = newValue;
        this.items = updated;
    }
}
