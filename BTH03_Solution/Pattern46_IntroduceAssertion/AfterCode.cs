using System.Diagnostics;

namespace Pattern46_IntroduceAssertion
{
    public class AfterCode
    {
        private double _expenseLimit;

        public AfterCode(double limit)
        {
            _expenseLimit = limit;
        }

        public double GetExpenseLimit()
        {
            // Sử dụng Assert để đảm bảo điều kiện bắt buộc
            Debug.Assert(_expenseLimit > 0, "Gioi han chi phi phai lon hon 0!");
            return _expenseLimit;
        }
    }
}