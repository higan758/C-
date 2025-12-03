namespace Task5;

class Program
{
    static void Main()
    {
        int[] nums = { 2, 5, 12, 7, 20, 9, 14 };

        Console.WriteLine("Even numbers:");
        NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers greater than 10:");
        NumberProcessor.ProcessNumbers(nums, n => n > 10);
    }
}
