namespace Pattern50_SeparateQueryFromModifier
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode system = new AfterCode();

            // Gọi rạch ròi 2 hành động
            system.TriggerAlarm();
            string mascot = system.GetMascot();

            System.Console.WriteLine($"Da tim thay: {mascot}, Dong thoi he thong bao dong da duoc bat.");
        }
    }
}