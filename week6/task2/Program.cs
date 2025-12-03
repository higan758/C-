using task2;

namespace Calculations;

public class Program
{
    public static void Main()
    {
        DelegateCalculation delAdd = Calculation.Add;
        DelegateCalculation delSubstract = Calculation.Substract;

        Console.WriteLine("Addition: " + delAdd(10, 5));
        Console.WriteLine("Subtraction: " + delSubstract(10, 5));
       

    }
}