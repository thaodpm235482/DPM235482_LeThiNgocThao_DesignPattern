namespace Pattern48_AddParameter
{
    public class AfterCode
    {
        // Thêm tham số discount (giảm giá) để hàm linh hoạt hơn
        public double GetContactPrice(double discount)
        {
            double basePrice = 100.0;
            return basePrice - discount;
        }
    }
}