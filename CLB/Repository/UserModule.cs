using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CLD;

namespace CLB
{
    public class UserModule : IUserModule
    {
        private readonly TruckersEntities _db;

        public UserModule() : this(null)
        {
            _db = new TruckersEntities();
        }

        public UserModule(TruckersEntities db)
        {
            _db = db;
        }

        public List<Users> GetUsers()
        {
            return _db.Users.ToList();
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
                    Role = item.Roul
                });
            }

            return list.ToList();
        }

        public Users GetUserById(int userid)
        {
            return _db.Users.Find(userid);
        }

        public bool AddUsers(Users user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditUsers(Users user)
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

        public bool DeleteUsers(Users user)
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
                usr.Roul = role;
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
            var usr = _db.Users.SingleOrDefault(x => x.username == username);
            return usr != null && usr.password == password;
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}