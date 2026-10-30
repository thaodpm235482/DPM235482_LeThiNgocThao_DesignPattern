namespace Pattern34_RemoveSettingMethod
{
    public class AfterCode
    {
        // Đánh dấu readonly để đảm bảo không bị thay đổi
        private readonly string _accountId;

        // Chỉ được gán 1 lần duy nhất trong Constructor
        public AfterCode(string id)
        {
            _accountId = id;
        }

        // Xóa hàm SetAccountId()

        public string GetAccountId() => _accountId;
    }
}