using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSkills
{
   public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName  = "Nvarchar")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Alias { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual ICollection<Reference> Reference { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
