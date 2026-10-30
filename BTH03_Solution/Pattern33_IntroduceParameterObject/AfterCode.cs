using System;

namespace Pattern33_IntroduceParameterObject
{
    // Tạo đối tượng tham số gom nhóm dữ liệu
    public class DateRange
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public DateRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }

    public class AfterCode
    {
        // Sử dụng đối tượng tham số
        public void PrintReport(DateRange range)
        {
            Console.WriteLine($"In bao cao tu {range.StartDate:dd/MM/yyyy} den {range.EndDate:dd/MM/yyyy}");
        }
    }
}