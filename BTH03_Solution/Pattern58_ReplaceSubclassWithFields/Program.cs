using System;

namespace Pattern58_ReplaceSubclassWithFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 58: REPLACE SUBCLASS WITH FIELDS ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}