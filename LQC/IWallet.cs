namespace LQC
{
    public interface IWallet
    {
        public void Put(decimal sum);

        public void Send(string address, decimal sum);

        public decimal GetBalance();
        public string GetAddress();
        public string GetAuthToken();
    }
}
