namespace Pattern45_IntroduceNullObject
{
    public class RealExample
    {
        public void Run()
        {
            AbstractCustomer customer = new NullCustomer();
            AfterCode app = new AfterCode();
            app.DisplayCustomer(customer);
        }
    }
}