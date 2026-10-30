using System;

namespace Pattern57_ReplaceTypeCodeWithStateStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 57: REPLACE TYPE CODE WITH STATE/STRATEGY ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}