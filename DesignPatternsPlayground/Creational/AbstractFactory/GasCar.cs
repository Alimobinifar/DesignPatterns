using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class GasCar :ICar
    {
        public void Drive() => Console.WriteLine("Driving a gas car ... ");   
    }
}
