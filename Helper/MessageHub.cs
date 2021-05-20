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
        public Task JoinRoom(string roomId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, roomId);
        }

        public Task LeaveRoom(string roomId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId);
        }








        //private readonly static ConnectionMapping<string> _groups = new ConnectionMapping<string>();
        //// group, user
        ////private readonly Dictionary<string, string> _groups = new Dictionary<string, string>();
        ////public async Task SendMessage(string message)
        ////{
        ////    await Clients.All.SendAsync("RecieveMessage", message);
        ////}

        //public Task SendMessageToGroup(string group, string sender, string message)
        //{
        //    return Clients.Group(group).SendAsync("RecieveMessage", group, sender, message);
        //}

        ////public async Task SendMessageToClient(string email, string message)
        ////{
        ////    var connectionid = _clients.GetConnectionId(email);
        ////    if (connectionid != null)
        ////    {
        ////        await Clients.Client(connectionid).SendAsync("RecieveMessage", message);
        ////        await Clients.Caller.SendAsync("RecieveMessage", message);
        ////    }
        ////}

        //public async Task AddUserToGroup(string group)
        //{
        //    var currentGroup = _groups.GetGroup(Context.ConnectionId);
        //    await RemoveFromGroup(currentGroup);
        //    await AddToGroup(group);

        //    //await RemoveUserFromGroups();
        //    //_groups.Add(Context.UserIdentifier, group);
        //    //await Groups.AddToGroupAsync(Context.UserIdentifier, group);
        //    //await Clients.Caller.SendAsync("AddedToGroup", group, Context.UserIdentifier);
        //}

        ////public async Task RemoveUserFromGroups()
        ////{ // Context.ConnectionId = "qIR0uRRr2ErVMakNP5DVxw"
        ////    var user = Context.UserIdentifier;
        ////    var groups = _groups.GetGroups(user).ToList();
        ////    foreach (var group in groups)
        ////    {
        ////        await Groups.RemoveFromGroupAsync(user, group);
        ////        _groups.Remove(user, group);
        ////        await Clients.Caller.SendAsync("RemovedFromGroup", group, user);
        ////    }
        ////}


        ////
        //public async Task AddToGroup(string groupName)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        //    _groups.Add(Context.ConnectionId, groupName);
        //    //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        //}

        //public async Task RemoveFromGroup(string groupName)
        //{
        //    await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

        //    //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
        //}
        ////









        //public class ConnectionMapping<T>
        //{
        //    //  user group
        //    private readonly Dictionary<T, HashSet<string>> _connections = new Dictionary<T, HashSet<string>>();

        //    public int Count
        //    {
        //        get
        //        {
        //            return _connections.Count;
        //        }
        //    }

        //    public void Add(T key, string connectionId)
        //    {
        //        lock (_connections)
        //        {
        //            HashSet<string> connections;
        //            if (!_connections.TryGetValue(key, out connections))
        //            {
        //                connections = new HashSet<string>();
        //                _connections.Add(key, connections);
        //            }

        //            lock (connections)
        //            {
        //                connections.Add(connectionId);
        //            }
        //        }
        //    }
        //    public string GetGroup(T key)
        //    {
        //        HashSet<string> connection;
        //        if (_connections.TryGetValue(key, out connection))
        //        {
        //            return connection.First();
        //        }

        //        return string.Empty;
        //    }

        //    public IEnumerable<string> GetGroups(T key)
        //    {
        //        HashSet<string> connections;
        //        if (_connections.TryGetValue(key, out connections))
        //        {
        //            return connections;
        //        }

        //        return Enumerable.Empty<string>();
        //    }

        //    public void Remove(T key, string connectionId)
        //    {
        //        lock (_connections)
        //        {
        //            HashSet<string> connections;
        //            if (!_connections.TryGetValue(key, out connections))
        //            {
        //                return;
        //            }

        //            lock (connections)
        //            {
        //                connections.Remove(connectionId);

        //                if (connections.Count == 0)
        //                {
        //                    _connections.Remove(key);
        //                }
        //            }
        //        }
        //    }
        //}
    }

}
