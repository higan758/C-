
namespace Task6;

public class NumberOperations
{
    public static IEnumerable<int> SquareNumbers(List<int> numbers)
    {
        // LINQ Projection using Select()
        return numbers.Select(n => n * n);
    }
}
