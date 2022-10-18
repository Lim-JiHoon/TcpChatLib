using System.Net.Sockets;
using TcpChatLib.Models;
using TcpChatLib.Utils;

namespace TcpChatLib.Extensions
{
  public static class SocketExtensions
  {
    public static bool IsConnected(this Socket socket)
    {
      try
      {
        return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
      }
      catch (SocketException) { return false; }
    }

    public static int SendMsgWithSerialize(this Socket socket, ChatInfo chatInfo, string message)
    {
      chatInfo.Message = message;
      return socket.Send(JsonUtils.SerializeToBytes(chatInfo)!);
    }
  }
}
