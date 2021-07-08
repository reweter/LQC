using System;
using System.Net.Sockets;

namespace LQC.Network
{
    public sealed class Client : INetClient, INetTcpClient
    {
        public TcpClient NClient { get; set; }
        public NetworkStream NStream { get; set; }

        public void Disconect()
        {
            try
            {
                NStream.Close();
                NClient.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
