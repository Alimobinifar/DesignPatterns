using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public sealed class CouponCodeDiscount : IDiscountStrategy
    {
        private readonly string _code;
        private static readonly IDictionary<string, decimal> Table =
            new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
            {
                ["OFF10"] = 0.10m,
                ["OFF25"] = 0.25m,
                ["OFF50"] = 0.50m
            };

        public CouponCodeDiscount(string code)
        {
            _code = code ?? throw new ArgumentNullException(nameof(code));

            if (!Table.ContainsKey(_code))
                throw new ArgumentException("Invalid coupon code.", nameof(code));
        }

        public string Name => $"Coupon {_code}";
        public decimal Calculate(decimal price)
        {
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            return price * (1 - Table[_code]);
        }
    }
}
