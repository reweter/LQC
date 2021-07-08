namespace LQC
{
    interface ITransaction
    {
        decimal Sum { get; }
        string AddressRecipient { get; }
        string AddressSender { get; }
        string CheckSum { get; }
    }
}
