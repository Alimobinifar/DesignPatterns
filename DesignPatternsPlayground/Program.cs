using DesignPatternsPlayground.Behaviral.Strategy;
using DesignPatternsPlayground.Creational.AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Design Patterns Playground 🚀");

        // اجرای دموهای مختلف
        //StrategyDemo.Run();
        //SingletonDemo.Run();
        //FactoryDemo.Run();
        AbstractFactoryDemo.Build();

    }
}