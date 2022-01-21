using System.Net;
using System.Net.Sockets;
using System.Net.Sockets.Kcp;

// 这个网络模块只是随便写写，一个基于KCP的简易通信模块
public class NetClient: SingleTon<NetClient>
{
    public enum NetClientState
    {
        None,
        Connected,
        DisConnected
    }
    
    private uint sid; // Session ID
    private IPEndPoint remoteEndPoint;
    private Kcp kcp;
    private UdpClient udpClient;

    public void Start(string ip, int port)
    {
        this.remoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
    }
    
    // public void ConnectToServer()
}