namespace Pattern40_ConsolidateConditionalExpression
{
    public class AfterCode
    {
        public double CalculateDisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
            {
                return 0;
            }

            return 500.0;
        }

        // Gộp chung vào một phương thức kiểm tra duy nhất
        private bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return seniority < 2 || monthsDisabled > 12 || isPartTime;
        }
    }
}