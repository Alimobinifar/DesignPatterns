using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Creational.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private Logger() { }
        public static Logger Instance => _instance;
        public void Log(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }
}
