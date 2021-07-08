using System.Collections.Generic;
using System.Net.Sockets;

namespace LQC.Network
{
    public sealed class Server : INetServer, INetTcpServer
    {
        public TcpListener Listener { get; set; }
        public List<Client> Clients { get; set; }

        public void Process()
        {

        }

        public void Open(string host, int port)
        {

        }

        public void Close()
        {

        }
    }
}
