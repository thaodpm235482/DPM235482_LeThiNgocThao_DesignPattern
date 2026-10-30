namespace Pattern32_PreserveWholeObject
{
    public class TempRange
    {
        public int Low { get; set; }
        public int High { get; set; }
    }

    public class BeforeCode
    {
        public bool WithinRange(int low, int high)
        {
            return low >= 10 && high <= 30; // Điều kiện giả định
        }

        public void CheckTemp()
        {
            TempRange range = new TempRange { Low = 15, High = 25 };
            // Lấy từng giá trị lẻ tẻ ra để truyền
            bool isValid = WithinRange(range.Low, range.High);
        }
    }
}