namespace Pattern49_RemoveParameter
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode cart = new AfterCode();
            double total = cart.CalculateTotal(50, 3);
            System.Console.WriteLine($"Tong tien don hang: {total}");
        }
    }
}