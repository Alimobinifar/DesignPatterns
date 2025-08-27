using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class ElectricFactory : IVehicleFactory
    {
        public ICar CreateCar() => new ElectricCar();

        public IMotorbike CreateMotorBike() => new ElectricMotorbike(); 
    }
}
