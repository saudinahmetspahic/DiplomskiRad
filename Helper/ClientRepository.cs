using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.Helper
{
    public interface IRepository
    {
        public string GetEmail(string connectionId);
        public string GetConnectionId(string email);
        public void AddUser(string connectionId, string email);
    }

    public class ClientRepository : IRepository
    {


        //connectionId, email
        private ConcurrentDictionary<string, string> _clients = new ConcurrentDictionary<string, string>();

        public string GetEmail(string connectionId)
        {
            var result = _clients.Where(w => w.Key == connectionId).FirstOrDefault();
            return result.Value;
        }

        public string GetConnectionId(string email)
        {
            var result = _clients.Where(w => w.Value == email).FirstOrDefault();
            return result.Key;
        }

        public void AddUser(string connectionId, string email)
        {
            _clients.TryAdd(connectionId, email);
        }
    }
}
