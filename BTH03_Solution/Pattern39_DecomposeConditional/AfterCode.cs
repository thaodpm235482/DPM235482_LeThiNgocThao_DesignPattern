using System;

namespace Pattern39_DecomposeConditional
{
    public class AfterCode
    {
        private DateTime _summerStart = new DateTime(2023, 6, 1);
        private DateTime _summerEnd = new DateTime(2023, 8, 31);

        public double CalculateCharge(DateTime date, int quantity)
        {
            if (IsSummer(date))
                return SummerCharge(quantity);
            else
                return WinterCharge(quantity);
        }

        private bool IsSummer(DateTime date)
        {
            return date >= _summerStart && date <= _summerEnd;
        }

        private double WinterCharge(int quantity) => quantity * 1.5 + 10;

        private double SummerCharge(int quantity) => quantity * 2.0;
    }
}