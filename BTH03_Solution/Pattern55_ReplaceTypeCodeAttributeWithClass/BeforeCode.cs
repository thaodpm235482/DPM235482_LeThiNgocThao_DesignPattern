namespace Pattern55_ReplaceTypeCodeAttributeWithClass
{
    public class BeforeCode
    {
        public const int O_BLOOD = 0;
        public const int A_BLOOD = 1;

        private int _bloodGroup;

        public BeforeCode(int bloodGroup)
        {
            _bloodGroup = bloodGroup; // Có thể bị truyền nhầm số bất kỳ
        }
    }
}