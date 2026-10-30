namespace Pattern31_ReplaceParameterWithExplicitMethods
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode rectangle = new AfterCode();
            rectangle.SetHeight(10);
            rectangle.SetWidth(20);

            System.Console.WriteLine($"Dien tich hinh chu nhat: {rectangle.GetArea()}");
        }
    }
}