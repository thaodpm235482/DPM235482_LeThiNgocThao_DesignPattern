using System;

namespace Pattern38_ReplaceExceptionWithTest
{
    public class BeforeCode
    {
        private int[] _values = { 10, 20, 30 };

        public int GetValue(int index)
        {
            try
            {
                return _values[index];
            }
            catch (IndexOutOfRangeException)
            {
                return -1; // Lợi dụng Exception để xử lý logic sai
            }
        }
    }
}