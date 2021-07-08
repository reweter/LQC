using System.Net.Sockets;

namespace LQC.Network
{
    interface INetTcpClient
    {
        TcpClient NClient { get; set; }
        NetworkStream NStream { get; set; }
    }
}
