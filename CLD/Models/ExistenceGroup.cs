

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
   public class ExistenceGroup
    {

        [Key][Display(Name = "کد گروه")]
        public int GroupID { get; set; }
        [Display(Name = "عنوان گروه")][MaxLength(100)][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string GroupName { get; set; }
        [Display(Name = "موجودیت")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public ExistenceBass ExistenceBass { get; set; }

        private ICollection<GroupsProperty> GroupsProperties { get; set; }

        public ExistenceGroup()
        {
            this.GroupsProperties = new HashSet<GroupsProperty>();
        }



    }
}
