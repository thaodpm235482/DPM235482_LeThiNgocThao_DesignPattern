using System;

namespace Pattern37_ReplaceErrorCodeWithException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 37: REPLACE ERROR CODE WITH EXCEPTION ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}