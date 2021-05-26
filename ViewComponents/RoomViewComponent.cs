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

            //var chats = _ctx.ChatUsers
            //    .Include(x => x.Chat)
            //    .Where(x => x.UserId == userId
            //        && x.Chat.Type == ChatType.Room)
            //    .Select(x => x.Chat)
            //    .ToList();

            var chats = _ctx.ChatUser
                .Include(x => x.Chat)
                .Where(x => x.UserId == loggedUser.Id
                    || x.User.UserAccount.Role == WebApp.EntityModels.UserRole.Admin)
                .Select(x => x.Chat)
                .Distinct()
                .ToList();

            return View(chats);
        }
    }
}