namespace Pattern51_ParameterizeMethod
{
    public class BeforeCode
    {
        private double _salary = 1000;

        // Các hàm bị lặp logic, chỉ khác tỉ lệ phần trăm
        public void RaiseFivePercent()
        {
            _salary *= 1.05;
        }

        public void RaiseTenPercent()
        {
            _salary *= 1.10;
        }

        public double GetSalary() => _salary;
    }
}