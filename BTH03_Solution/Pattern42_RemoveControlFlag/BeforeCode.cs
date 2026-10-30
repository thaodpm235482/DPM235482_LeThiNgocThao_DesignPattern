namespace Pattern42_RemoveControlFlag
{
    public class BeforeCode
    {
        public void CheckPeople(string[] people)
        {
            bool found = false; // Biến cờ kiểm soát (Control Flag)
            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i] == "Don")
                    {
                        found = true;
                    }
                }
            }
        }
    }
}