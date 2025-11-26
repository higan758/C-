using Vehicless;

namespace Vechicless;

public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        Console.WriteLine($"Has Carrier: {HasCarrier}");
    }
}
