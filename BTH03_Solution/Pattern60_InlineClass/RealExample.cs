namespace Pattern60_InlineClass
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = new AfterCode { Name = "Jane Doe", FullNumber = "0987654321" };
            System.Console.WriteLine($"SDT cua {person.Name} la: {person.FullNumber}");
        }
    }
}