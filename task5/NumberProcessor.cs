namespace Task5;

public class NumberProcessor
{
    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }
}
