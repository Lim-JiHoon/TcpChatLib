using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace TcpChatLib.Utils
{
  public class SocketUtils
  {
    public static IPEndPoint GetIPEndPoint(string ip, int port)
    {
      IPAddress ipAddress = IPAddress.Parse(ip);
      return new IPEndPoint(ipAddress, port);
    }

    public static Socket Connect(string ip , int port)
    {      
      IPEndPoint endPoint = GetIPEndPoint(ip, port);
      Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      socket.Connect(endPoint);

      return socket;
    }

    public static Socket Listen(string ip, int port)
    {
      IPEndPoint endPoint = GetIPEndPoint(ip, port);
      Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      socket.Bind(endPoint); // 소켓에 엔드포인트 연결(ip, port)
      socket.Listen(10); // 요청 수신 대기

      return socket;
    }
  }
}
