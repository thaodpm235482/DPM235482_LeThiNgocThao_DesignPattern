namespace Pattern51_ParameterizeMethod
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode emp = new AfterCode();
            emp.Raise(0.08); // Tăng 8%
            System.Console.WriteLine($"Luong sau khi tang: {emp.GetSalary()}");
        }
    }
}