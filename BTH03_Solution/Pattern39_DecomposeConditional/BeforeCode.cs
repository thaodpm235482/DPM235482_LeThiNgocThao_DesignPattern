using System;

namespace Pattern39_DecomposeConditional
{
    public class BeforeCode
    {
        private DateTime _summerStart = new DateTime(2023, 6, 1);
        private DateTime _summerEnd = new DateTime(2023, 8, 31);

        public double CalculateCharge(DateTime date, int quantity)
        {
            double charge;
            // Điều kiện phức tạp khó đọc
            if (date < _summerStart || date > _summerEnd)
            {
                charge = quantity * 1.5 + 10;
            }
            else
            {
                charge = quantity * 2.0;
            }
            return charge;
        }
    }
}