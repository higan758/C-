using System;

namespace AgeCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // ===== Using if - else if - else =====
            Console.WriteLine("\nUsing if - else if - else:");
            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("\nUsing switch-case:");
            switch (age)
            {
                case < 13:
                    Console.WriteLine("Child");
                    break;

                case >= 13 and <= 19:
                    Console.WriteLine("Teenager");
                    break;

                case >= 20:
                    Console.WriteLine("Adult");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.ReadLine(); // Pause output window
        }
    }
}
