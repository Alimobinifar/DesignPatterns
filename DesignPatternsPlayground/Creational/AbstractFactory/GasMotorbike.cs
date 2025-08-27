using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class GasMotorbike:IMotorbike
    {
        public void Ride()
        {
            Console.WriteLine("Riding an Gas motorbike.");
        }
    }
}
