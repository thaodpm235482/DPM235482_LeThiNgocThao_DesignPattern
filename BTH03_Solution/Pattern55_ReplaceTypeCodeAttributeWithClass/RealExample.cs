namespace Pattern55_ReplaceTypeCodeAttributeWithClass
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = new AfterCode(BloodGroup.O);
            System.Console.WriteLine($"Nhom mau da duoc thiet lap an toan voi ma: {person.GetBloodGroup().Code}");
        }
    }
}