using Pattern30_ReplaceConditionalWithPolymorphism;
using System;

namespace Pattern44_ReplaceConditionalWithPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 44: REPLACE CONDITIONAL WITH POLYMORPHISM ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}