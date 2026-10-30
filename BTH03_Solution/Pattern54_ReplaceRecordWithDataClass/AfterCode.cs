namespace Pattern54_ReplaceRecordWithDataClass
{
    public class CustomerData
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public CustomerData(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
        }
    }
}