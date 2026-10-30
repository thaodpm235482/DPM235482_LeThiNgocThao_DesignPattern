namespace Pattern32_PreserveWholeObject
{
    public class TempRange
    {
        public int Low { get; set; }
        public int High { get; set; }
    }

    public class AfterCode
    {
        // Truyền cả nguyên đối tượng TempRange
        public bool WithinRange(TempRange range)
        {
            return range.Low >= 10 && range.High <= 30;
        }
    }
}