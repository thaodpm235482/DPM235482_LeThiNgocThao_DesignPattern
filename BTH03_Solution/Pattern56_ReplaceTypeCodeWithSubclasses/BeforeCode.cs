namespace Pattern56_ReplaceTypeCodeWithSubclasses
{
    public class BeforeCode
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public int Type { get; private set; }

        public BeforeCode(int type)
        {
            Type = type;
        }
    }
}