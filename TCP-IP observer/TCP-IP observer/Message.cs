using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_IP_observer
{
    internal class Message
    {
        public TimeSpan time { get; private set; }
        public string msg { get; private set; }

        public Message(string msg)
        {
            this.msg = msg;
            time = DateTime.Now.TimeOfDay;
        }
    }
}
