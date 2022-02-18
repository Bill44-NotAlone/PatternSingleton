using PatternSingletonLib;
using System;

namespace PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChocolateBoiler.counter);
            ChocolateBoiler boiler1 = ChocolateBoiler.GetChocolateBoiler();
            Console.WriteLine(ChocolateBoiler.counter);
            ChocolateBoiler boiler2 = ChocolateBoiler.GetChocolateBoiler();
            Console.WriteLine((boiler2 == boiler1) + " " + ChocolateBoiler.counter);
            Console.ReadKey();
        }
    }
}
