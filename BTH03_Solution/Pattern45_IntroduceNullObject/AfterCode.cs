namespace Pattern45_IntroduceNullObject
{
    public abstract class AbstractCustomer
    {
        public abstract string GetName();
    }

    public class RealCustomer : AbstractCustomer
    {
        private string _name;
        public RealCustomer(string name) { _name = name; }
        public override string GetName() => _name;
    }

    // Null Object đại diện cho trường hợp đối tượng null
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName() => "Khach hang khong xac dinh";
    }

    public class AfterCode
    {
        public void DisplayCustomer(AbstractCustomer customer)
        {
            // Không cần kiểm tra null nữa
            System.Console.WriteLine($"Ten: {customer.GetName()}");
        }
    }
}