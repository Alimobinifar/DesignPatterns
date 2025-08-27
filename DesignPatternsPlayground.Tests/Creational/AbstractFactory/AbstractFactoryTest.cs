using DesignPatternsPlayground.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatternsPlayground.Tests.Creational.AbstractFactory
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void ElectricFactory_ShouldCreateElectricCarAndMotorbike()
        {
            // Arrange
            IVehicleFactory factory = new ElectricFactory();
            var car = factory.CreateCar();
            var motorbike = factory.CreateMotorBike();

            // Act & Assert
            Assert.NotNull(car);
            Assert.NotNull(motorbike);

            Assert.IsType<ElectricCar>(car);
            Assert.IsType<ElectricMotorbike>(motorbike);
        }

        [Fact]
        public void GasFactory_ShouldCreateGasCarAndMotorbike()
        {
            // Arrange
            IVehicleFactory factory = new GasFactory();
            var car = factory.CreateCar();
            var motorbike = factory.CreateMotorBike();

            // Act & Assert
            Assert.NotNull(car);
            Assert.NotNull(motorbike);

            Assert.IsType<GasCar>(car);
            Assert.IsType<GasMotorbike>(motorbike);
        }
    }
}
