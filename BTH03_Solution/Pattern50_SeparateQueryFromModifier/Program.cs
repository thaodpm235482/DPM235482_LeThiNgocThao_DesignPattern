using System;

namespace Pattern50_SeparateQueryFromModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 50: SEPARATE QUERY FROM MODIFIER ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}