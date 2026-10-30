namespace Pattern44_ReplaceConditionalWithPolymorphism
{
    public class BeforeCode
    {
        public double GetSpeed(string type)
        {
            switch (type)
            {
                case "European":
                    return 100.0;
                case "African":
                    return 80.0;
                default:
                    return 0.0;
            }
        }
    }
}