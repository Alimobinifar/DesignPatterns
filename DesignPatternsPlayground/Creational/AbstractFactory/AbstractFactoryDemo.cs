using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.AbstractFactory
{
    public static class AbstractFactoryDemo
    {
        public static void Build() 
        {
            IVehicleFactory electricFactory = new ElectricFactory();
            VehicleApplication app1 = new VehicleApplication(electricFactory);
            app1.Run();

            IVehicleFactory gasFactory = new GasFactory();
            VehicleApplication app2 = new VehicleApplication(gasFactory);
            app2.Run();
        }
    }
}
