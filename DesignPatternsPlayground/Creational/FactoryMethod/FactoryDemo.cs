using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.FactoryMethod
{
    public static class FactoryDemo
    {
        public static void Run()
        {
            Console.WriteLine("===  Factory Pattern Demo  ===");
            
            var fullTime = EmployeeFactory.CreateEmployee("fulltime");
            Console.WriteLine(fullTime.GetDetails());

            var partTime = EmployeeFactory.CreateEmployee("parttime");
            Console.WriteLine(partTime.GetDetails());

            var intern = EmployeeFactory.CreateEmployee("intern");
            Console.WriteLine(intern.GetDetails());

        }





    }
}
