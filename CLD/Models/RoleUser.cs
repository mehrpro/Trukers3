using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
    public class RoleUser
    {
        [Key][Display(Name = "کد نقش")]
        public int RoleID { get; set; }
        [Display(Name = "عنوان")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RoleName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }

        public RoleUser()
        {
            this.AppUsers = new HashSet<AppUser>();
        }

    }
}