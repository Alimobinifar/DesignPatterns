using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class ElectricCar:ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving an electric car.");
        }
    }
}
