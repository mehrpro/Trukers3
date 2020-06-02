using CLD;
using System;
using System.Collections.Generic;

namespace CLB
{
    public interface IUserModule:IDisposable
    {
        List<Users> GetUsers();
        List<UserModel> GetAllUser();
        Users GetUserById(int userid);
        bool AddUsers(Users user);
        bool EditUsers(Users user);
        bool DeleteUsers(Users user);
        bool DeleteUserById(int userid);
        bool ChangePasswordById(int userId, string oldPass, string newPass);
        bool ChangeRole(int userid, string role);
        bool LoginUser(string username, string password);
    }

 
}
