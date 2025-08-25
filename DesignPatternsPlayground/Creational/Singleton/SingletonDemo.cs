using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.Singleton
{
    public static class SingletonDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Singleton Pattern Demo ===");

            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;

            logger1.Log("First message");
            logger2.Log("Second message");

            Console.WriteLine($"logger1 == logger2 ? {logger1 == logger2}");
        }
    }
}
