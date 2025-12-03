using Task4;

public class Program
{
    public static void Main()
    {
        double price = 1000;

 
        Console.WriteLine("Festival Discount: " +
            Discounts.CalculateFinalPrice(price, Discounts.FestivalDiscount));

        Console.WriteLine("Seasonal Discount: " +
            Discounts.CalculateFinalPrice(price, Discounts.SeasonalDiscount));

        Console.WriteLine("No Discount: " +
            Discounts.CalculateFinalPrice(price, Discounts.NoDiscount));

        Console.WriteLine("Lambda 30% Discount: " +
            Discounts.CalculateFinalPrice(price, p => p * 0.7));
    }
}
