using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSkills
{
    public class Reference
    {
        [Key]
        public int ReferenceId { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string Position { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Alias { get; set; }

        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        public string Email { get; set; }

        public int EmployeeId { get; set; }
    }
}
