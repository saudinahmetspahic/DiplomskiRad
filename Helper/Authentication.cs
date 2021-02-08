using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Helper
{
    public static class Authentication
    {
        private const string Logged_User = "Logged_User";

        public static void SetLoggedUser(this HttpContext context, UserAccount account, bool saveCookie = false)
        {
            MyContext db = context.RequestServices.GetService<MyContext>();
            
            var oldToken = context.Request.GetCookieJson<string>(Logged_User);

            if (oldToken != null)
            {
                var toDelete = db.AuthToken.FirstOrDefault(w => w.Value == oldToken);
                if (toDelete != null)
                {
                    db.AuthToken.Remove(toDelete);
                    db.SaveChanges();
                }
            }

            if (account != null)
            {
                string token = Guid.NewGuid().ToString();
                db.AuthToken.Add(new AuthToken
                {
                    Date_Created = DateTime.Now,
                    UserAccountId = account.Id,
                    Value = token
                });
                db.SaveChanges();
                context.Response.SetCookieJson(Logged_User, token);
            }
        }

        public static string GetCurrentToken(this HttpContext context)
        {
            return context.Request.GetCookieJson<string>(Logged_User);
        }

        public static UserAccount GetLoggedUser(this HttpContext context)
        {
            MyContext db = context.RequestServices.GetService<MyContext>();

            string token = context.Request.GetCookieJson<string>(Logged_User);
            if (token == null)
                return null;

            return db.AuthToken.Where(w => w.Value == token).Select(s => s.UserAccount).SingleOrDefault();
        }
    }
}
