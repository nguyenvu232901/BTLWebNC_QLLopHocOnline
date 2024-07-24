using BTLWebNC_QLLopHocOnline.Models;

namespace BTLWebNC_QLLopHocOnline.Interfaces;

public interface ISessionService {
    UserModel? CurrentUser();
}
