namespace Pattern35_HideMethod
{
    public class AfterCode
    {
        public double CalculateTotal(double price)
        {
            return price + CalculateTax(price);
        }

        // Đổi thành private vì class ngoài không cần gọi trực tiếp tới hàm này
        private double CalculateTax(double price)
        {
            return price * 0.1;
        }
    }
}