using Vehicless;

namespace Vechicless;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        Console.WriteLine($"Seats: {Seats}");
    }

}
