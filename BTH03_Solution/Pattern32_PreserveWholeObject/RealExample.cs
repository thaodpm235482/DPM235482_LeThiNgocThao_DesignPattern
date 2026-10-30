namespace Pattern32_PreserveWholeObject
{
    public class RealExample
    {
        public void Run()
        {
            TempRange todayTemp = new TempRange { Low = 15, High = 25 };
            AfterCode checker = new AfterCode();

            bool isSafe = checker.WithinRange(todayTemp);
            System.Console.WriteLine($"Nhiet do hom nay co an toan khong? {isSafe}");
        }
    }
}