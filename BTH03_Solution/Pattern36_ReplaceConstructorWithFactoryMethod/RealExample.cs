namespace Pattern36_ReplaceConstructorWithFactoryMethod
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode emp = AfterCode.CreateEngineer();
            System.Console.WriteLine($"Da tao nhan vien loai: {emp.Type}");
        }
    }
}