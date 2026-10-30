namespace Pattern31_ReplaceParameterWithExplicitMethods
{
    public class BeforeCode
    {
        private int _height;
        private int _width;

        // Tham số 'name' quyết định hành vi của hàm, rất dễ truyền sai chuỗi
        public void SetValue(string name, int value)
        {
            if (name == "height")
                _height = value;
            else if (name == "width")
                _width = value;
        }
    }
}