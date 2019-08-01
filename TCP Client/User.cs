using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Client
{
    class User
    {
        public string nick;
        public string ipAddress;
        public int color;

        public void person(string nick, string ipAddress, int color)
        {
            this.nick = nick;
            this.ipAddress = ipAddress;
            this.color = color;
        }

    }
}
