namespace Pattern34_RemoveSettingMethod
{
    public class BeforeCode
    {
        private string _accountId;

        public BeforeCode(string id)
        {
            _accountId = id;
        }

        // Không nên cho phép sửa ID tài khoản sau khi tạo
        public void SetAccountId(string newId)
        {
            _accountId = newId;
        }

        public string GetAccountId() => _accountId;
    }
}