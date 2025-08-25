using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public sealed class RegularCustomerDiscount : IDiscountStrategy
    {
        public string Name => "Regular 5%";
        public decimal Calculate(decimal price)
        {
            if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price));
            return price * 0.95m;
        }
    }
}
