using System;

namespace Pattern33_IntroduceParameterObject
{
    public class RealExample
    {
        public void Run()
        {
            DateRange Q1 = new DateRange(new DateTime(2023, 1, 1), new DateTime(2023, 3, 31));
            AfterCode reporter = new AfterCode();

            reporter.PrintReport(Q1);
        }
    }
}