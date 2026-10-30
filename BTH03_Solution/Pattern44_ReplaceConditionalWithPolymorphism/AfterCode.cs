namespace Pattern44_ReplaceConditionalWithPolymorphism
{
    public abstract class Bird
    {
        public abstract double GetSpeed();
    }

    public class EuropeanBird : Bird
    {
        public override double GetSpeed() => 100.0;
    }

    public class AfricanBird : Bird
    {
        public override double GetSpeed() => 80.0;
    }
}