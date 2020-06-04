using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
    public class ExistenceBass
    {
        [Key][Display(Name = "کد")]
        public int ExistenceId { get; set; }
        [Display(Name = "موجودیت")][Required(ErrorMessage = "لطفا {0} را وارد کنید")][MaxLength(100)]
        public string ExistenceName { get; set; }
        [Display(Name = "شرح کاملی از موجودیت")][Required(ErrorMessage = "لطفا {0} را وارد کنید")][MaxLength(500)]
        public string Description { get; set; }

        public ICollection<ExistenceGroup>ExistenceGroups { get; set; }

        public ExistenceBass()
        {
            this.ExistenceGroups = new HashSet<ExistenceGroup>();
        }


        



    }
}