namespace Pattern43_ReplaceNestedConditionalWithGuardClauses
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode payroll = new AfterCode();
            double amount = payroll.GetPayAmount(false, false, true);
            System.Console.WriteLine($"So tien luong nhan duoc: {amount}");
        }
    }
}