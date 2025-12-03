

namespace Task3
{

    public delegate double DiscountStrategy(double originalPrice);

    public class Discount
    {
        public static double FestivalDiscount(double originalPrice) => originalPrice - originalPrice * 0.8 ;
        public static double SeasonalDiscount(double originalPrice) => originalPrice - originalPrice * 0.4;
        public static double NoDiscount(double originalPrice) => originalPrice;


    }
}
