using System.ComponentModel.DataAnnotations;

namespace task1;

public class Program
{
    
    public static void Main()
    {
        Rectangle r = new Rectangle();
            r.Length = 10;
            r.Breadth = 5;




        Console.WriteLine(r.GetArea());
        Console.WriteLine(r.Perimeter());
        Console.WriteLine(r.showDetails());


    }
}
