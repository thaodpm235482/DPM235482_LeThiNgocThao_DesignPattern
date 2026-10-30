using System;

namespace Pattern39_DecomposeConditional
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode calculator = new AfterCode();
            DateTime today = new DateTime(2023, 7, 15);

            System.Console.WriteLine($"Chi phi mua he: {calculator.CalculateCharge(today, 100)}");
        }
    }
}