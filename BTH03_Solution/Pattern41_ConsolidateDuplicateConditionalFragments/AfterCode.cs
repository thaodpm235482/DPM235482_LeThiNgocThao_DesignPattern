using System;

namespace Pattern41_ConsolidateDuplicateConditionalFragments
{
    public class AfterCode
    {
        private double _price = 100;

        public void ProcessOrder(bool isSpecialDeal)
        {
            double total;
            if (isSpecialDeal)
            {
                total = _price * 0.9;
            }
            else
            {
                total = _price;
            }

            // Đưa đoạn mã trùng lặp ra bên ngoài câu lệnh điều kiện
            SendInvoice(total);
        }

        private void SendInvoice(double total)
        {
            Console.WriteLine($"Da gui hoa don voi so tien: {total}");
        }
    }
}