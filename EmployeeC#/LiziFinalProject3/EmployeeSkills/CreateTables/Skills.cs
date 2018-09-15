using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSkills
{
   public class Skills
    {
        
        [Key]
        public int SkillId { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        [Required]
        public string SkillName { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength()]
        [Required]
        public string BriefDescription { get; set; }

        //[ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        //public Employees employees { get; set; }

        [ForeignKey("SkillId")]
        public  virtual ICollection<SkillsInfo> SkillsInfo { get; set; }

    }
}
