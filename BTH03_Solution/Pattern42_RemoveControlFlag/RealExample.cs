namespace Pattern42_RemoveControlFlag
{
    public class RealExample
    {
        public void Run()
        {
            string[] names = { "Alice", "Bob", "Don", "Charlie" };
            AfterCode checker = new AfterCode();
            checker.CheckPeople(names);
        }
    }
}