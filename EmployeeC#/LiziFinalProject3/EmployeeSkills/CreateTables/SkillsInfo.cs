using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSkills
{
   public class SkillsInfo
    {
        [Key]
        public int SkillInfoId { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(80)]
        [Required]
        public string Url { get; set; }

        //[ForeignKey("SkillId")]
        public int SkillId { get; set; }
        [ForeignKey("SkillInfoId")]
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
