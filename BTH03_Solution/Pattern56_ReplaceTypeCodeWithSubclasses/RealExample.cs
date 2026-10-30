namespace Pattern56_ReplaceTypeCodeWithSubclasses
{
    public class RealExample
    {
        public void Run()
        {
            Employee emp = Employee.Create(0);
            System.Console.WriteLine($"Ma kieu cua nhan vien (0-Ky su, 1-Sale): {emp.GetTypeCode()}");
        }
    }
}