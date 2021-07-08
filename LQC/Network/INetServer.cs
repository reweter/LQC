using System.Collections.Generic;

namespace LQC.Network
{
    interface INetServer
    {
        List<Client> Clients { get; set; }
        void Open(string host, int port);
        void Close();
    }
}
