namespace Pattern57_ReplaceTypeCodeWithStateStrategy
{
    public abstract class EmployeeType
    {
        public abstract double GetPayAmount(double salary);
    }

    public class EngineerType : EmployeeType
    {
        public override double GetPayAmount(double salary) => salary;
    }

    public class ManagerType : EmployeeType
    {
        public override double GetPayAmount(double salary) => salary + 500;
    }

    public class AfterCode
    {
        private EmployeeType _type;
        private double _salary = 1000;

        // Trạng thái (Type) có thể được thay đổi linh hoạt bằng Strategy
        public void SetType(EmployeeType type) => _type = type;

        public double PayAmount() => _type.GetPayAmount(_salary);
    }
}