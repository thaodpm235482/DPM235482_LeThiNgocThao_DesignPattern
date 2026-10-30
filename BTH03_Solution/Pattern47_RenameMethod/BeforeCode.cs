namespace Pattern47_RenameMethod
{
    public class BeforeCode
    {
        private string _n;

        public BeforeCode(string n)
        {
            _n = n;
        }

        // Tên phương thức quá viết tắt, không rõ ràng
        public string GetNm()
        {
            return _n;
        }
    }
}