using System;

namespace Pattern37_ReplaceErrorCodeWithException
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode account = new AfterCode();
            try
            {
                account.Withdraw(150);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi giao dich: {ex.Message}");
            }
        }
    }
}