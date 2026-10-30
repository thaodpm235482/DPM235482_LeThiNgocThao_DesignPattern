using System;

namespace Pattern33_IntroduceParameterObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 33: INTRODUCE PARAMETER OBJECT ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}