using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_IP_observer
{
    internal class User
    {
        public string nickname { get; private set; }
        public string ip { get; private set; }
        public int port { get; private set; }
        public List<Message> messages { get; private set; } = new List<Message>();

        public User(string nickname, string ip, int port) { 
            this.port = port;
            this.nickname = nickname;
            this.ip = ip;
        }
        public void AddMessage(Message msg)
        {
            messages.Add(msg);
        }
    }
}
