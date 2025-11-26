namespace Teachers
{
    class Program
    {
        static void Main(string[] args)
        {
            NepaliTeacher nt = new NepaliTeacher();
            nt.Name = "Krishna";
            Console.WriteLine($"Name: {nt.Name}");
            nt.Teaching();      
            nt.SalaryInfo();   

            Console.WriteLine();

            EnglishTeacher et = new EnglishTeacher();
            et.Name = "John";
            Console.WriteLine($"Name: {et.Name}");
            et.Teaching();      
            et.SalaryInfo();    
        }
    }


}