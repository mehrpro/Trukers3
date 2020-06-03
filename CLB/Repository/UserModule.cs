using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CLD;


namespace CLB
{
    public class UserModule : IUserModule
    {
        private readonly QMS _db;

        public UserModule() : this(null)
        {
            _db = new QMS();
        }

        public UserModule(QMS db)
        {
            _db = db;
        }

        public List<AppUser> GetUsers()
        {
            return _db.AppUsers.ToList();
        }

        public List<UserModel> GetAllUser()
        {
       
            var list = new List<UserModel>();
            foreach (var item in GetUsers())
            {
                list.Add(new UserModel
                {
                    UserID = item.userID,
                    UserName = item.username,
                    Password = item.password,
                    Role = item.RoleID
                });
            }

            return list.ToList();
        }

        public AppUser GetUserById(int userid)
        {
            return _db.AppUsers.Find(userid);
        }

        public bool AddUsers(AppUser user)
        {
            try
            {
                _db.AppUsers.Add(user);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditUsers(AppUser user)
        {
            try
            {
                _db.Entry(user).State = EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUsers(AppUser user)
        {
            try
            {
                _db.Entry(user).State = EntityState.Deleted;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUserById(int userid)
        {
            try
            {
                var usr = GetUserById(userid);
                DeleteUsers(usr);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangePasswordById(int userId, string oldPass, string newPass)
        {
            try
            {
                var usr = GetUserById(userId);
                if (usr.password == oldPass)
                {
                    usr.password = newPass;
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeRole(int userid, string role)
        {
            try
            {
                var usr = GetUserById(userid);
                usr.RoleID = role;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LoginUser(string username, string password)
        {
            var usr = _db.AppUsers.SingleOrDefault(x => x.username == username);
            return usr != null && usr.password == password;
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}