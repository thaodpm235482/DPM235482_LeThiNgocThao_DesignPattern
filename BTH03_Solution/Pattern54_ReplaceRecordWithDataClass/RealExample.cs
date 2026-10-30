namespace Pattern54_ReplaceRecordWithDataClass
{
    public class RealExample
    {
        public void Run()
        {
            CustomerData customer = new CustomerData("Nguyen Van B", "Ha Noi");
            customer.UpdateAddress("TP.HCM");

            System.Console.WriteLine($"Khach hang: {customer.Name}, Dia chi moi: {customer.Address}");
        }
    }
}