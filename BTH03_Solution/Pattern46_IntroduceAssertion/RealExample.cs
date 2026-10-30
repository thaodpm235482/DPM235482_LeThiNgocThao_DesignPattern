namespace Pattern46_IntroduceAssertion
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode project = new AfterCode(5000);
            System.Console.WriteLine($"Gioi han chi phi la: {project.GetExpenseLimit()}");
        }
    }
}