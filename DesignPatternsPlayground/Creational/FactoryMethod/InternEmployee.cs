using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.FactoryMethod
{
    public class InternEmployee : IEmployee
    {
        public string GetDetails()
        {
            return "Intern Employee: Stipend = $500";
        }
    }
}
