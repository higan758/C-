
namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            double price = 1000;

            // Assign methods to the delegate
            DiscountStrategy d1 = Discount.FestivalDiscount;
            DiscountStrategy d2 = Discount.SeasonalDiscount;
            DiscountStrategy d3 = Discount.NoDiscount;

            Console.WriteLine("Festival Discount: " + d1(price));
            Console.WriteLine("Seasonal Discount: " + d2(price));
            Console.WriteLine("No Discount: " + d3(price));
        }
    }
}
