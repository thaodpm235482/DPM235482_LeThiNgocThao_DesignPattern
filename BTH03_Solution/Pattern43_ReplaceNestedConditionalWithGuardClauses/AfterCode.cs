namespace Pattern43_ReplaceNestedConditionalWithGuardClauses
{
    public class AfterCode
    {
        // Dùng Guard Clauses (return sớm) giúp code phẳng và dễ đọc hơn
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return 1000;
            if (isSeparated) return 2000;
            if (isRetired) return 3000;

            return 4000;
        }
    }
}