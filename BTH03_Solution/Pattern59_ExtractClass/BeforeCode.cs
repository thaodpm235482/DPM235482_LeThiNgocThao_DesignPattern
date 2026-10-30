namespace Pattern59_ExtractClass
{
    public class BeforeCode
    {
        public string Name { get; set; }

        // Dữ liệu số điện thoại bị nhồi nhét vào lớp Person
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetTelephoneNumber() => $"({OfficeAreaCode}) {OfficeNumber}";
    }
}