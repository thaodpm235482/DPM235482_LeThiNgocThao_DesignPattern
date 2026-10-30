namespace Pattern50_SeparateQueryFromModifier
{
    public class AfterCode
    {
        private string _securityAlarm = "Tắt";

        // Chỉ trả về giá trị (Query)
        public string GetMascot()
        {
            return "Mascot found";
        }

        // Chỉ thực hiện thay đổi trạng thái (Modifier)
        public void TriggerAlarm()
        {
            _securityAlarm = "Bật";
        }
    }
}