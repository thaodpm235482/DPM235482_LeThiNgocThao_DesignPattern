namespace Pattern53_EncapsulateCollection
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode student = new AfterCode();
            student.AddCourse(new Course { Name = "Refactoring C#" });

            System.Console.WriteLine($"So luong khoi hoc: {student.Courses.Count}");
        }
    }
}