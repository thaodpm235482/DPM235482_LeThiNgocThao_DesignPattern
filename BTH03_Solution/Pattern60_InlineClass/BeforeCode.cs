namespace Pattern60_InlineClass
{
    public class TelephoneNumber
    {
        public string FullNumber { get; set; }
    }

    public class BeforeCode
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }
}