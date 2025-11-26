namespace NullCheckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of NullOperations class
            NullOperations nullOps = new NullOperations();

            // Call the PerformNullChecks() method
            nullOps.PerformNullChecks();

            Console.ReadLine();
        }
    }
}