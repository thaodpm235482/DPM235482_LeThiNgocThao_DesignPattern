namespace Pattern41_ConsolidateDuplicateConditionalFragments
{
    public class BeforeCode
    {
        private double _price = 100;

        public void ProcessOrder(bool isSpecialDeal)
        {
            double total;
            if (isSpecialDeal)
            {
                total = _price * 0.9;
                SendInvoice(total); // Bị trùng lặp
            }
            else
            {
                total = _price;
                SendInvoice(total); // Bị trùng lặp
            }
        }

        private void SendInvoice(double total) { }
    }
}