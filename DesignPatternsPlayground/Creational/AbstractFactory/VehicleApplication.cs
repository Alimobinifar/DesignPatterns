using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public class VehicleApplication 
    {
        private ICar _car;
        private IMotorbike _motorbike;

        public VehicleApplication(IVehicleFactory vehicleFactory)
        {
            _car = vehicleFactory.CreateCar();
            _motorbike = vehicleFactory.CreateMotorBike();
        }

        public void Run()
        {
            _car.Drive();
            _motorbike.Ride();
        }
    }
}
