namespace Pattern35_HideMethod
{
    public class BeforeCode
    {
        public double CalculateTotal(double price)
        {
            return price + CalculateTax(price);
        }

        // Phương thức này chỉ dùng nội bộ trong class nhưng lại public
        public double CalculateTax(double price)
        {
            return price * 0.1; // Thuế 10%
        }
    }
}