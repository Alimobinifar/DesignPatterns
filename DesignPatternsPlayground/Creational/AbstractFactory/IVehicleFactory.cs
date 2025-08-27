using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public interface IVehicleFactory 
    {
        ICar CreateCar();
        IMotorbike CreateMotorBike();
    }
}
