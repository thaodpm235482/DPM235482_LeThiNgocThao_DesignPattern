using System;

namespace Pattern42_RemoveControlFlag
{
    public class AfterCode
    {
        public void CheckPeople(string[] people)
        {
            // Thay cờ kiểm soát bằng lệnh break ngay khi tìm thấy
            foreach (var person in people)
            {
                if (person == "Don")
                {
                    Console.WriteLine("Da tim thay Don!");
                    break;
                }
            }
        }
    }
}