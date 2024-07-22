using BTLWebNC_QLLopHocOnline.Databases;
using BTLWebNC_QLLopHocOnline.Interfaces;
using BTLWebNC_QLLopHocOnline.Models;

namespace BTLWebNC_QLLopHocOnline.Services
{
    public class SessionService(DatabaseContext DB, IHttpContextAccessor HttpContextAccessor) : ISessionService
    {
        public UserModel? CurrentUser()
        {
            if (HttpContextAccessor.HttpContext == null)
                return null;

            var userId = HttpContextAccessor.HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return null;

            return DB.Users.Find(userId);
        }
    }
}
