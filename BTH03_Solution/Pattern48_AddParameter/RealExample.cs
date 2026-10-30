namespace Pattern48_AddParameter
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode billing = new AfterCode();
            double finalPrice = billing.GetContactPrice(15.5);
            System.Console.WriteLine($"Gia cuoi cung sau khi giam: {finalPrice}");
        }
    }
}