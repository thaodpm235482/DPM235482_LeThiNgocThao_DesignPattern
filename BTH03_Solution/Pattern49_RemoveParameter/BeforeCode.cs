namespace Pattern49_RemoveParameter
{
    public class BeforeCode
    {
        // Tham số date không được sử dụng ở bất kỳ đâu trong hàm
        public double CalculateTotal(double price, int qty, string date)
        {
            return price * qty;
        }
    }
}