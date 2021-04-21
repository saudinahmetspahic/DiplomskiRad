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
        private readonly static ConnectionMapping<string> _groups = new ConnectionMapping<string>();
        // group, user
        //private readonly Dictionary<string, string> _groups = new Dictionary<string, string>();
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
            _groups.Add(Context.ConnectionId, group);
            //await Clients.Caller.SendAsync("AddedToGroup", group, Context.ConnectionId);

            await Groups.AddToGroupAsync(Context.ConnectionId, group);
            await Clients.Caller.SendAsync("AddedToGroup", group, Context.ConnectionId);
        }

        public async Task RemoveUserFromGroups()
        {
            var user = Context.ConnectionId;
            var groups = _groups.GetGroups(user).ToList();
            foreach (var group in groups)
            {
                await Groups.RemoveFromGroupAsync(user, group);
                _groups.Remove(user, group);
                await Clients.Caller.SendAsync("RemovedFromGroup", group, user);
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




        public class ConnectionMapping<T>
        {
            //  user group
            private readonly Dictionary<T, HashSet<string>> _connections = new Dictionary<T, HashSet<string>>();

            public int Count
            {
                get
                {
                    return _connections.Count;
                }
            }

            public void Add(T key, string connectionId)
            {
                lock (_connections)
                {
                    HashSet<string> connections;
                    if (!_connections.TryGetValue(key, out connections))
                    {
                        connections = new HashSet<string>();
                        _connections.Add(key, connections);
                    }

                    lock (connections)
                    {
                        connections.Add(connectionId);
                    }
                }
            }

            public IEnumerable<string> GetGroups(T key)
            {
                HashSet<string> connections;
                if (_connections.TryGetValue(key, out connections))
                {
                    return connections;
                }

                return Enumerable.Empty<string>();
            }

            public void Remove(T key, string connectionId)
            {
                lock (_connections)
                {
                    HashSet<string> connections;
                    if (!_connections.TryGetValue(key, out connections))
                    {
                        return;
                    }

                    lock (connections)
                    {
                        connections.Remove(connectionId);

                        if (connections.Count == 0)
                        {
                            _connections.Remove(key);
                        }
                    }
                }
            }
        }
    }

}
