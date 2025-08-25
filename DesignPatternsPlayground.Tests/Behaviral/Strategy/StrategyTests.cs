using Xunit;
using DesignPatternsPlayground.Behaviral.Strategy;

namespace DesignPatternsPlayground.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void RegularCustomer_Should_NotHaveDiscount()
        {
            var calc = new PriceCalculator(new RegularCustomerDiscount());
            var result = calc.FinalPrice(100);
            Assert.Equal(100, result);
        }

        [Fact]
        public void VipCustomer_Should_Have20PercentDiscount()
        {
            var calc = new PriceCalculator(new VipCustomerDiscount());
            var result = calc.FinalPrice(100);
            Assert.Equal(80, result);
        }

        [Fact]
        public void SeasonalDiscount_Should_ApplyConfiguredPercentage()
        {
            var calc = new PriceCalculator(new SeasonalDiscount(10)); // 10%
            var result = calc.FinalPrice(100);
            Assert.Equal(90, result);
        }

        [Theory]
        [InlineData("OFF10", 90)]
        [InlineData("OFF25", 75)]
        [InlineData("OFF50", 50)]
        [InlineData("INVALID", 100)] // invalid coupon = no discount
        public void CouponCodeDiscount_Should_WorkWithCodes(string code, decimal expected)
        {
            var calc = new PriceCalculator(new CouponCodeDiscount(code));
            var result = calc.FinalPrice(100);

            Assert.Equal(expected, result);
        }
    }
}
