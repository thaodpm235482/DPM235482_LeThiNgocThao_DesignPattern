namespace Pattern46_IntroduceAssertion
{
    public class BeforeCode
    {
        private double _expenseLimit;

        public BeforeCode(double limit)
        {
            _expenseLimit = limit;
        }

        public double GetExpenseLimit()
        {
            // Giả định ngầm định là _expenseLimit luôn phải lớn hơn 0 nhưng không kiểm tra
            return _expenseLimit;
        }
    }
}