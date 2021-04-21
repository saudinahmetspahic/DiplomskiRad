using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Helper
{
    public class Autorization
    {
        public class AutorizationAttribute : TypeFilterAttribute
        {
                
            public AutorizationAttribute(bool user, bool admin)    
                : base(typeof(AutorizationClass))
            {
                Arguments = new object[] { user, admin };
            }

        }

        public class AutorizationClass : IAsyncActionFilter
        { 
            private readonly bool _user;
            private readonly bool _admin;

            public AutorizationClass(bool user, bool admin)
            {
                _user = user;
                _admin = admin;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                UserAccount nalog = context.HttpContext.GetLoggedUser();

                if (nalog == null)
                {
                    if (context.Controller is Controller controller1)
                    {
                        controller1.TempData["msg"] = "You are not logged in.";
                    }
                    context.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });
                    return;
                }

                MyContext db = context.HttpContext.RequestServices.GetService<MyContext>();

                if (_user && db.UserAccount.Any(w => w.Id == nalog.Id))
                {
                    await next();
                    return;
                }

                if (_admin && db.UserAccount.Any(w => w.Id == nalog.Id && w.Role == UserRole.Admin))
                {
                    await next();
                    return;
                }

                if (context.Controller is Controller controller)
                {
                    controller.TempData["msg"] = "You are not authorized.";
                }

                context.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });
            }
            public void OnActionExecutedAsync(ActionExecutingContext context)
            {

            }
        }
    }
}
