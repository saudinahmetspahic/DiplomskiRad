using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApp.Helper
{
    public class MessageHub : Hub
    {
        // group, user
        private readonly Dictionary<string, string> _groups = new Dictionary<string, string>();
        //public async Task SendMessage(string message)
        //{
        //    await Clients.All.SendAsync("RecieveMessage", message);
        //}

        public Task SendMessageToGroup(string group, string sender, string message)
        {
            return Clients.Group(group).SendAsync("RecieveMessage", group, sender, message);
        }

        //public async Task SendMessageToClient(string email, string message)
        //{
        //    var connectionid = _clients.GetConnectionId(email);
        //    if (connectionid != null)
        //    {
        //        await Clients.Client(connectionid).SendAsync("RecieveMessage", message);
        //        await Clients.Caller.SendAsync("RecieveMessage", message);
        //    }
        //}
            
        public async Task AddUserToGroup(string group)
        {
            await RemoveUserFromGroups();
            _groups.Add(group, Context.ConnectionId);
            
            await Groups.AddToGroupAsync(Context.ConnectionId, group);
            await Clients.Caller.SendAsync("AddedToGroup", group, Context.ConnectionId);
        }

        public async Task RemoveUserFromGroups()
        {
            var user = Context.ConnectionId;
            var groups = _groups.Where(w => w.Value == user);
            foreach (var group in groups)
            {
                await Groups.RemoveFromGroupAsync(user, group.Key);
                await Clients.Caller.SendAsync("RemovedFromGroup", group.Key, user);
            }
        }

        //public override async Task OnConnectedAsync()
        //{
        //    await base.OnConnectedAsync();
        //}

        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    await base.OnDisconnectedAsync(exception);
        //}
    }

}
