using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

public class Feedback
{
    [Key]
    public int FeedbackID { get; set; }

    [Column(TypeName = "Nvarchar")]
    [MaxLength(600)]
    [Required]
    public string FeedbackText { get; set; }
    [Required]
      public decimal? Rating { get; set; }
    public int MoveiID { get; set; }
    [ForeignKey("MoveiID")]
    public virtual Moveis Moveis { get; set; }

}

