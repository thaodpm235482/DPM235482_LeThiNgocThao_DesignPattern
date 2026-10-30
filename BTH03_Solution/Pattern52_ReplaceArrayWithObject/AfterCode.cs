namespace Pattern52_ReplaceArrayWithObject
{
    // Tạo Class với thuộc tính có tên gọi rõ ràng
    public class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Points { get; set; }
    }

    public class AfterCode
    {
        public Performance GetPerformanceData()
        {
            return new Performance
            {
                Name = "Liverpool",
                Wins = 15,
                Points = 45
            };
        }
    }
}