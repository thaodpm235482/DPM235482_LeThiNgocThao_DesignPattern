namespace Pattern58_ReplaceSubclassWithFields
{
    public abstract class Person
    {
        public abstract char GetGenderCode();
    }

    public class Male : Person
    {
        public override char GetGenderCode() => 'M';
    }

    public class Female : Person
    {
        public override char GetGenderCode() => 'F';
    }
}