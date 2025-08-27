using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class ElectricMotorbike:IMotorbike
    {
        public void Ride()
        {
            Console.WriteLine("Riding an electric motorbike.");
        }

    }
}
