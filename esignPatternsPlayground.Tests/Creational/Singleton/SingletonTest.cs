using DesignPatternsPlayground.Creational.Singleton;
 using Xunit;

namespace DesignPatternsPlayground.Tests.Creational.Singleton
{
    public class SingletonTest
    {
        [Fact]
        public void Logger_ShouldReturnSameInstance()
        {
            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;
            Assert.Same(logger1, logger2);
        }
    }
}
