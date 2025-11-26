namespace Print;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        p.Print("Hello World!");
        p.Print(123);
        p.Print("Repeat this", 3);

        Console.ReadLine();
    }
}
