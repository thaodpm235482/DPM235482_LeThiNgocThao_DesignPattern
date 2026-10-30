using System.Collections.Generic;

namespace Pattern53_EncapsulateCollection
{
    public class Course
    {
        public string Name { get; set; }
    }

    public class BeforeCode
    {
        // Để public List cho phép bên ngoài can thiệp/xóa sạch dữ liệu tùy tiện
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}