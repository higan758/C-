namespace Task6;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

        var squared = NumberOperations.SquareNumbers(nums);

        Console.WriteLine("Squared Numbers:");
        foreach (var n in squared)
        {
            Console.WriteLine(n);
        }
    }
}
