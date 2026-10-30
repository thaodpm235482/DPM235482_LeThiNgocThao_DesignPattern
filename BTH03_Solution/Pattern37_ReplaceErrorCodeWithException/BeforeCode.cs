namespace Pattern37_ReplaceErrorCodeWithException
{
    public class BeforeCode
    {
        private int _balance = 100;

        // Trả về -1 nếu lỗi (không đủ tiền)
        public int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1;
            }
            _balance -= amount;
            return 0; // Thành công
        }
    }
}