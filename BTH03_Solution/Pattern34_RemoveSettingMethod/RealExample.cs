namespace Pattern34_RemoveSettingMethod
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode account = new AfterCode("ACC-999888");
            System.Console.WriteLine($"ID Tai khoan: {account.GetAccountId()}");
            System.Console.WriteLine("ID nay da duoc co dinh, khong the thay doi.");
        }
    }
}