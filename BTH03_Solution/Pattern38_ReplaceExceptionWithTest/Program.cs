using System;

namespace Pattern38_ReplaceExceptionWithTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 38: REPLACE EXCEPTION WITH TEST ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}