namespace Pattern55_ReplaceTypeCodeAttributeWithClass
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);

        public int Code { get; }

        private BloodGroup(int code)
        {
            Code = code;
        }
    }

    public class AfterCode
    {
        private BloodGroup _bloodGroup;

        // Bắt buộc truyền đúng đối tượng BloodGroup
        public AfterCode(BloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public BloodGroup GetBloodGroup() => _bloodGroup;
    }
}