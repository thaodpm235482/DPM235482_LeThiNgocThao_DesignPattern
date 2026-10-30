namespace Pattern57_ReplaceTypeCodeWithStateStrategy
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode emp = new AfterCode();
            emp.SetType(new ManagerType());
            System.Console.WriteLine($"Luong cua quan ly: {emp.PayAmount()}");
        }
    }
}