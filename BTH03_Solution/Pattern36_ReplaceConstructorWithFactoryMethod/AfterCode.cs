namespace Pattern36_ReplaceConstructorWithFactoryMethod
{
    public class AfterCode
    {
        public string Type { get; private set; }

        // Đổi constructor thành private
        private AfterCode(string type)
        {
            Type = type;
        }

        // Sử dụng các Factory Method để tạo đối tượng rõ ràng hơn
        public static AfterCode CreateEngineer()
        {
            return new AfterCode("Engineer");
        }

        public static AfterCode CreateManager()
        {
            return new AfterCode("Manager");
        }
    }
}