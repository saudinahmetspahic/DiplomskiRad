using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.EF;
using WebApp.Helper;

namespace ChatApp.ViewComponents
{
    public class RoomViewComponent : ViewComponent
    {
        private MyContext _ctx;

        public RoomViewComponent(MyContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _ctx.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();


            var chats = _ctx.Chat
                            .Include(i => i.Users)
                            .Where(w => w.Users.Any(a => a.UserId == loggedUser.Id))
                            .ToList();

            return View(chats);
        }
    }
}