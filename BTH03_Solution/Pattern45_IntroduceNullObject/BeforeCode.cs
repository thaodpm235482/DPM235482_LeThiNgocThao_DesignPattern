namespace Pattern45_IntroduceNullObject
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class BeforeCode
    {
        public void DisplayCustomer(Customer customer)
        {
            // Phải kiểm tra null thủ công nhiều lần
            string name = (customer == null) ? "Khach hang khong xac dinh" : customer.Name;
            System.Console.WriteLine(name);
        }
    }
}