using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Services
{
    public class Helo_Msg1 : IMessage
    {
        public string GetMessage(string name)
        {
            return $"Hai {name}, have a great week ahead!";
        }
    }
    public class Helo_Msg2 : IMessage
    {
        IConfiguration config;
        public Helo_Msg2(IConfiguration c)
        {
            config = c;
        }
        public string GetMessage(string name)
        {
            //return $"Hai {name}, Happy New Year!!";
            string msg = $"Hai {name}, {config["Greetings"]}";
            return msg;
        }
    }
}
