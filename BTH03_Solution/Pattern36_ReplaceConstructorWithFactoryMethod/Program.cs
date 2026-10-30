using System;

namespace Pattern36_ReplaceConstructorWithFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 36: REPLACE CONSTRUCTOR WITH FACTORY METHOD ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}