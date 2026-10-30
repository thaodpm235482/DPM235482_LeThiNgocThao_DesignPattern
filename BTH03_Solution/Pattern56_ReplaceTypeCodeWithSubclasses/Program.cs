using System;

namespace Pattern56_ReplaceTypeCodeWithSubclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 56: REPLACE TYPE CODE WITH SUBCLASSES ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}