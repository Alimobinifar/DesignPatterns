using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public class StrategyDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Strategy Pattern Demo ===");

            var regular = new PriceCalculator(new RegularCustomerDiscount());
            Console.WriteLine($"Regular Customer: {regular.FinalPrice(100)}");

            var vip = new PriceCalculator(new VipCustomerDiscount());
            Console.WriteLine($"VIP Customer: {vip.FinalPrice(100)}");

            var festival = new PriceCalculator(new SeasonalDiscount(0.10m));
            Console.WriteLine($"Seasonal Discount : {festival.FinalPrice(100)}");

            var coupon = new PriceCalculator(new CouponCodeDiscount("OFF25"));
            Console.WriteLine($"Coupon OFF25: {coupon.FinalPrice(100)}");

        }
       
    }
}
