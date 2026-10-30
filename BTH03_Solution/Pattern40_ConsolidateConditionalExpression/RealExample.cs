namespace Pattern40_ConsolidateConditionalExpression
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode calculator = new AfterCode();
            double amount = calculator.CalculateDisabilityAmount(3, 5, false);

            System.Console.WriteLine($"So tien tro cap duoc nhan: {amount}");
        }
    }
}