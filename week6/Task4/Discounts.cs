
namespace Task4;

    public delegate double DiscountStrategy(double originalPrice);
    public class Discounts
    {
       
        public static double NoDiscount(double originalPrice) => originalPrice ;
        
        public static double SeasonalDiscount(double originalPrice) => originalPrice - originalPrice * 0.9;

        public static double FestivalDiscount(double originalPrice) => originalPrice - originalPrice * 0.7;

    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);
       
    }
          
 
    