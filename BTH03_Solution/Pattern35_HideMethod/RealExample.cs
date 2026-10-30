namespace Pattern35_HideMethod
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode order = new AfterCode();
            double total = order.CalculateTotal(100);

            System.Console.WriteLine($"Tong tien bao gom thue (da an ham tinh thue): {total}");
        }
    }
}