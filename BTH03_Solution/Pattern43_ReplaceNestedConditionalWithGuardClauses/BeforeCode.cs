namespace Pattern43_ReplaceNestedConditionalWithGuardClauses
{
    public class BeforeCode
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            if (isDead)
            {
                result = 1000;
            }
            else
            {
                if (isSeparated)
                {
                    result = 2000;
                }
                else
                {
                    if (isRetired)
                    {
                        result = 3000;
                    }
                    else
                    {
                        result = 4000;
                    }
                }
            }
            return result;
        }
    }
}