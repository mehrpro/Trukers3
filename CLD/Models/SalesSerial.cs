using System;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
    public class SalesSerial
    {
        [Key]
        public int SerialID { get; set; }
        [Display(Name = "شماره سریال")]
        public int SerialNumber { get; set; }
        [Display(Name = "محموع قبض صادر شده")]
        public int TotalOrder { get; set; }
        [Display(Name = "آغاز فروش")]
        public DateTime StartDateTime { get; set; }
        [Display(Name = "پایان فروش")]
        public DateTime FinishDateTime { get; set; }
        [Display(Name = "بسته شده")]
        public bool Closed { get; set; }
        [Display(Name = "ثبت کننده")]
        public int userID { get; set; }
        [Display(Name = "وضعیت")]
        public bool enabeled { get; set; }

        public virtual AppUser AppUser { get; set; }

        public SalesSerial()
        {
            
        }
    }
}
