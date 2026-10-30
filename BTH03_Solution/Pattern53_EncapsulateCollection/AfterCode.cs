using System.Collections.Generic;

namespace Pattern53_EncapsulateCollection
{
    public class Course
    {
        public string Name { get; set; }
    }

    public class AfterCode
    {
        private readonly List<Course> _courses = new List<Course>();

        // Chỉ trả về danh sách đọc (ReadOnly)
        public IReadOnlyCollection<Course> Courses => _courses.AsReadOnly();

        // Quản lý việc thêm/xóa qua các phương thức riêng
        public void AddCourse(Course course) => _courses.Add(course);
        public void RemoveCourse(Course course) => _courses.Remove(course);
    }
}