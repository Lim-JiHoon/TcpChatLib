using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TcpChatLib.Models;

namespace TcpChatLib.Utils
{
  public class JsonUtils
  {
      public static ChatInfo? DeserializeByBytes(byte[] buffer)
    {
      string text = Encoding.UTF8.GetString(buffer);
      text = text.TrimEnd('\0');
      if (string.IsNullOrEmpty(text)) return null;
      return JsonSerializer.Deserialize<ChatInfo>(text)!;
    }

    public static byte[]? SerializeToBytes(ChatInfo chatInfo)
    {
      string jsonString = JsonSerializer.Serialize(chatInfo);
      return Encoding.UTF8.GetBytes(jsonString);
    }
  }
}
