namespace Pattern59_ExtractClass
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = new AfterCode { Name = "John Doe" };
            person.OfficeTelephone.AreaCode = "024";
            person.OfficeTelephone.Number = "12345678";

            System.Console.WriteLine($"SDT cua {person.Name}: {person.OfficeTelephone.GetFullNumber()}");
        }
    }
}