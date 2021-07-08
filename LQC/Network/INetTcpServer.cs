using System.Net.Sockets;

namespace LQC.Network
{
    interface INetTcpServer
    {
        TcpListener Listener { get; set; }
    }
}
