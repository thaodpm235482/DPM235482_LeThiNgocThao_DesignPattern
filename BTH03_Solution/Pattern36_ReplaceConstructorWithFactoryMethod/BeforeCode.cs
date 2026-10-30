namespace Pattern36_ReplaceConstructorWithFactoryMethod
{
    public class BeforeCode
    {
        public string Type { get; set; }

        public BeforeCode(int typeCode)
        {
            if (typeCode == 1)
                Type = "Engineer";
            else if (typeCode == 2)
                Type = "Manager";
            else
                Type = "Unknown";
        }
    }
}