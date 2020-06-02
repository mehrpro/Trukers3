using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLB
{
    public class UserModel
    {
        [Display(Name = "کد کاربر")]
        public int UserID { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "نقش")]
        public string Role { get; set; }

    }
}
