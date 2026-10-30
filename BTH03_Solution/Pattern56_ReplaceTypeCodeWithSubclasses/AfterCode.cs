namespace Pattern56_ReplaceTypeCodeWithSubclasses
{
    public abstract class Employee
    {
        public abstract int GetTypeCode();

        // Phương thức tạo đối tượng (Factory method)
        public static Employee Create(int type)
        {
            if (type == 0) return new Engineer();
            if (type == 1) return new Salesman();
            throw new System.ArgumentException("Loai nhan vien khong hop le");
        }
    }

    public class Engineer : Employee
    {
        public override int GetTypeCode() => 0;
    }

    public class Salesman : Employee
    {
        public override int GetTypeCode() => 1;
    }
}