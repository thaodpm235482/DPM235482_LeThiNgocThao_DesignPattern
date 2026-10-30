namespace Pattern40_ConsolidateConditionalExpression
{
    public class BeforeCode
    {
        public double CalculateDisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            // Nhiều lệnh if trả về cùng 1 kết quả
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;

            return 500.0; // Số tiền hợp lệ
        }
    }
}