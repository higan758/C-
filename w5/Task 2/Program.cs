namespace Vechicless;

class Program
{
    static void Main(string[] args)
    {
        // Car Object
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 120;
        car.Seats = 4;

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        // Motorcycle Object
        Motorcycle moto = new Motorcycle();
        moto.Brand = "Yamaha";
        moto.Speed = 90;
        moto.HasCarrier = true;

        moto.Start();
        moto.DisplayInfo();
        moto.Stop();

        Console.ReadLine();
    }
}
