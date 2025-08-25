using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public sealed class PriceCalculator
    {
        private IDiscountStrategy _strategy;
        public PriceCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy)); ;
        }

        public void SetStrategy(IDiscountStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy)); ;
        }

        public decimal FinalPrice(decimal price) => _strategy.Calculate(price);
    }
}
