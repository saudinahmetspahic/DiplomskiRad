using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Helper
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string Message)
        {
            await Clients.All.SendAsync("RecieveMessage", Message);
        }
    }
}
