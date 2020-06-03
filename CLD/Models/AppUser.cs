using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
   public class AppUser
    {
        public AppUser()
        {
            this.SalesSerials = new HashSet<SalesSerial>();
            this.TruckDrivers = new HashSet<TruckDriver>();
        }

        [Key]
        [Display(Name = "کدکاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public byte userID { get; set; }
        [Display(Name = "نام")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string LastName { get; set; }
        [Display(Name = "تلفن تماس")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Phone { get; set; }
        [Display(Name = "نقش")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RoleID { get; set; }
        [Display(Name = "نام کاربری")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string username { get; set; }
        [Display(Name = "رمز عبور")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string password { get; set; }


        public virtual RoleUser RoleUser { get; set; }
        public virtual ICollection<SalesSerial> SalesSerials { get; set; }
        public virtual ICollection<TruckDriver> TruckDrivers { get; set; }



    }
}
