using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class GasFactory :IVehicleFactory
    {
        public ICar CreateCar() => new GasCar();

        public IMotorbike CreateMotorBike() => new GasMotorbike();
    }
}
