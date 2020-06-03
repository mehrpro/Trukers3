using CLD;
using System;
using System.Collections.Generic;

namespace CLB
{
    public interface IUserModule:IDisposable
    {
        List<AppUser> GetUsers();
        List<UserModel> GetAllUser();
        AppUser GetUserById(int userid);
        bool AddUsers(AppUser user);
        bool EditUsers(AppUser user);
        bool DeleteUsers(AppUser user);
        bool DeleteUserById(int userid);
        bool ChangePasswordById(int userId, string oldPass, string newPass);
        bool ChangeRole(int userid, string role);
        bool LoginUser(string username, string password);
    }

 
}
