using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Helper
{
    public static class MyCookieExtension
    {
        public static T GetCookieJson<T>(this HttpRequest request, string key)
        {

            string result = request.Cookies[key];
            return (result == null ? default : JsonConvert.DeserializeObject<T>(result));
        }

        public static void SetCookieJson(this HttpResponse response, string key, object value, int? expireTime = null)
        {
            if (value == null)
            {
                response.Cookies.Delete(key);
                return;
            }

            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
            {
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            }
            else
            {
                option.Expires = DateTime.Now.AddDays(7);
            }

            string v = JsonConvert.SerializeObject(value);

            response.Cookies.Append(key, v, option);
        }

        public static void RemoveCookieJson(this HttpResponse response, string key)
        {
            response.Cookies.Delete(key);
        }
    }
}
