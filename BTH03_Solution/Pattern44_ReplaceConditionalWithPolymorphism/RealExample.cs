namespace Pattern44_ReplaceConditionalWithPolymorphism
{
    public class RealExample
    {
        public void Run()
        {
            Bird bird = new EuropeanBird();
            System.Console.WriteLine($"Toc do cua chim Chau Au: {bird.GetSpeed()}");
        }
    }
}