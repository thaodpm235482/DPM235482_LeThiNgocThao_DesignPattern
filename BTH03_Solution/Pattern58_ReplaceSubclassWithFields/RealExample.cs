namespace Pattern58_ReplaceSubclassWithFields
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = AfterCode.CreateFemale();
            System.Console.WriteLine($"Ma gioi tinh: {person.GetGenderCode()}");
        }
    }
}