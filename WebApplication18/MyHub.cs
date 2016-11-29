using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication18
{
    public class MyHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.callBack("我是："+message);
        }
    }
}