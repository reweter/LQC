namespace LQC
{
    public sealed class Wallet : IWallet
    {
        private decimal Balance { get; set; }
        private string Address { get; set; }
        private string AuthToken { get; set; }

        public void Put(decimal sum)
        {
            Balance += sum;
        }

        public void Send(string address, decimal sum)
        {

        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string GetAuthToken()
        {
            return AuthToken;
        }

        public Wallet(string address, string authToken)
        {

        }
    }
}
