using System;

namespace LQC
{
    public sealed class Transaction : ITransaction
    {
        public decimal Sum { get; }
        public string AddressRecipient { get; }
        public string AddressSender { get; }
        public string CheckSum { get; }

        public Transaction(decimal sum, string addressRecipient, string addressSender)
        {
            try
            {
                if (addressRecipient != addressSender)
                {
                    AddressRecipient = addressRecipient;
                    AddressSender = AddressSender;
                }
                else
                    throw new ArgumentException("The recipient's address cannot be equal to the sender's address", nameof(addressRecipient));

                Sum = sum;
            }
            catch (Exception)
            {
            }
        }
    }
}
