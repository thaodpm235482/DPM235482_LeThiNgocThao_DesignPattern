namespace Pattern38_ReplaceExceptionWithTest
{
    public class AfterCode
    {
        private int[] _values = { 10, 20, 30 };

        public int GetValue(int index)
        {
            // Kiểm tra điều kiện thay vì đợi Exception xảy ra
            if (index < 0 || index >= _values.Length)
            {
                return -1;
            }
            return _values[index];
        }
    }
}