namespace Pattern52_ReplaceArrayWithObject
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode app = new AfterCode();
            Performance team = app.GetPerformanceData();
            System.Console.WriteLine($"Doi bóng: {team.Name}, So tran thang: {team.Wins}, Diem: {team.Points}");
        }
    }
}