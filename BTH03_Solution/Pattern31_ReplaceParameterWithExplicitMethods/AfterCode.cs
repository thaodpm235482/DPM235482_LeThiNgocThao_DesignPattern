namespace Pattern31_ReplaceParameterWithExplicitMethods
{
    public class AfterCode
    {
        private int _height;
        private int _width;

        // Tách thành các phương thức rõ ràng
        public void SetHeight(int value)
        {
            _height = value;
        }

        public void SetWidth(int value)
        {
            _width = value;
        }

        public int GetArea()
        {
            return _height * _width;
        }
    }
}