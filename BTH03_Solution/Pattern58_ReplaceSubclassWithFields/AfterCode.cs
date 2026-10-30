namespace Pattern58_ReplaceSubclassWithFields
{
    public class AfterCode
    {
        private readonly char _genderCode;

        // Thay vì tạo Subclass, chỉ cần truyền Field qua Constructor
        private AfterCode(char genderCode)
        {
            _genderCode = genderCode;
        }

        public static AfterCode CreateMale() => new AfterCode('M');
        public static AfterCode CreateFemale() => new AfterCode('F');

        public char GetGenderCode() => _genderCode;
    }
}