using System.ComponentModel.DataAnnotations;

namespace CLD
{
    public class TruckDriver
    {
        public TruckDriver()
        {
            
        }

        [Key][Display(Name = "کد")]
        public int DriverID { get; set; }
        [Display(Name = "نام")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string LastName { get; set; }
        [Display(Name = "تلفن همراه")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کارت هوشمند")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int SmartCart { get; set; }
        [Display(Name = "پلاک")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string TagNumber { get; set; }
        [Display(Name = "گروه")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public byte GroupID { get; set; }
        [Display(Name = "ثبت کننده")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public byte userID { get; set; }
        [Display(Name = "کد اشتراک")]
        public int SubscriptionCode { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}