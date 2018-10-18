using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Muvees
/// </summary>
public class Moveis
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]

    public int MoveiID { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(20)]
    [Required]
    public string MoveiName { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(30)]
    public string Janer { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(20)]
    public string MovieDirector { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(300)]
    public string Trailer { get; set; }
    public decimal? RatingAvg { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(1100)]
    public string Description { get; set; }
    public byte[] MoveiImage { get; set; }

    public virtual ICollection<Feedback> Feedback { get; set; }
    public virtual ICollection<TimeAndPlace> TimeAndPlace { get; set; }

}