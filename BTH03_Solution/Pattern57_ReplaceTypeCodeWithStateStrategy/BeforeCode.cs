namespace Pattern57_ReplaceTypeCodeWithStateStrategy
{
    public class BeforeCode
    {
        private int _type;
        private double _salary = 1000;

        public void SetType(int type) => _type = type;

        public double PayAmount()
        {
            switch (_type)
            {
                case 0: return _salary; // Engineer
                case 1: return _salary + 500; // Manager
                default: return 0;
            }
        }
    }
}