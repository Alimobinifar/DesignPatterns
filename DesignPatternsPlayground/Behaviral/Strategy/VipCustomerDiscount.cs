using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public class VipCustomerDiscount : IDiscountStrategy
    {
        public string Name => "VIP 20%";

        public decimal Calculate(decimal price)
        {
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            return price * 0.80m;
        }
    }
}
