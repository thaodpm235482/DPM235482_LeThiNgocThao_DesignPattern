using System;

namespace Pattern37_ReplaceErrorCodeWithException
{
    public class AfterCode
    {
        private int _balance = 100;

        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new InvalidOperationException("So du khong du de rut tien.");
            }
            _balance -= amount;
        }
    }
}