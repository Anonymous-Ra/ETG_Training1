using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Services
{
    public interface IMessage
    {
        string GetMessage(string name);
    }
}
