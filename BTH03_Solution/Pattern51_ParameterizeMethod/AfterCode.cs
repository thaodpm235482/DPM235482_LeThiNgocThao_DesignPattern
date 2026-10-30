namespace Pattern51_ParameterizeMethod
{
    public class AfterCode
    {
        private double _salary = 1000;

        // Gộp lại thành một hàm nhận tham số tỷ lệ
        public void Raise(double percentage)
        {
            _salary *= (1 + percentage);
        }

        public double GetSalary() => _salary;
    }
}