namespace Pattern59_ExtractClass
{
    // Tách riêng thành lớp TelephoneNumber
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetFullNumber() => $"({AreaCode}) {Number}";
    }

    public class AfterCode
    {
        public string Name { get; set; }
        public TelephoneNumber OfficeTelephone { get; } = new TelephoneNumber();
    }
}