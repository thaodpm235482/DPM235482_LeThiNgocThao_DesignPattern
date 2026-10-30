namespace Pattern47_RenameMethod
{
    public class AfterCode
    {
        private string _name;

        public AfterCode(string name)
        {
            _name = name;
        }

        // Đổi tên thành GetName cho rõ ràng
        public string GetName()
        {
            return _name;
        }
    }
}