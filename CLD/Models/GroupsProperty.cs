using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CLD
{
    public class GroupsProperty
    {
        [Key]
        [Display(Name = "کد")]
        public int PropertyID { get; set; }
        [Display(Name = "ویژگی")]
        [MaxLength(100)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Property { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(500)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public ExistenceGroup ExistenceGroup { get; set; }



        public GroupsProperty()
        {
            
        }

    }
}
