using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.FactoryMethod
{
    public static class EmployeeFactory
    {
        public static IEmployee CreateEmployee(string type)
        {
            switch (type.ToLower())
            {
                case "fulltime": return new FullTimeEmployee();
                case "parttime": return new PartTimeEmployee();
                case "intern": return new InternEmployee();
                default: throw new ArgumentException("Invalid employee type");
            }
        }
    }
}
