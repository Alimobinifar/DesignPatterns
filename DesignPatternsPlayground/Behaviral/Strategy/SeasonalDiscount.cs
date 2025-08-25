using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public class SeasonalDiscount : IDiscountStrategy
    {
        private readonly decimal _percent;
        public SeasonalDiscount(decimal percent)
        {
            if (percent < 0 || percent > 0.90m)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "percent must be between 0 and 0.9");
            }
            _percent = percent;
        }
        public string Name => $"Seasonal {_percent:P0}";

        public decimal Calculate(decimal price)
        {
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            return price * (1 - _percent);
        }
    }
}
