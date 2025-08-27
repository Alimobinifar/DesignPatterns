using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.FactoryMethod
{
    public sealed class FullTimeEmployee : IEmployee
    {
        public string GetDetails()
        {
            return "Full-time employee : Fixed salary = $ 3000";
        }
    }
}
