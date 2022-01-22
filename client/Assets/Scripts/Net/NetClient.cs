using System.Text;
using KCPNet;

// 这个网络模块只是随便写写，一个基于KCP的简易通信模块
public class NetClient: SingleTon<NetClient>
{
    private KCPClient kcpClient;
    
    public bool TryLogin()
    {
        var ret = kcpClient.SendMessage(Encoding.ASCII.GetBytes("登录游戏"));
        return ret;
    }
}