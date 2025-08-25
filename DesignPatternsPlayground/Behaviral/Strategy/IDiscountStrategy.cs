using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Behaviral.Strategy
{
    public interface IDiscountStrategy
    {
        decimal Calculate (decimal price);
        string Name { get; }
    }
}
