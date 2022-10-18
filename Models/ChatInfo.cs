using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TcpChatLib.Models
{
  public class ChatInfo
  {
    public string NikName { get; set; } = "";
    public string Message { get; set; } = "";
    public bool ComeIn { get; set; }
  }
}
