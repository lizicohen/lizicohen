using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Times
/// </summary>
[Table (name: "TimeAndPlace")]
public class TimeAndPlace
{
    [Key]
    public int TimeID { get; set; }
    [Column(TypeName = "int")]
    public int AmountCardsLeft { get; set; }
    [Column(TypeName = "int")]
    public int AmountCardsToSell { get; set; }
    [Column(TypeName = "int")]
    public int PriceCard { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(50)]
    public string Place { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(15)]
    public string Region { get; set; }

    public DateTime Date { get; set; }
    public int MoveiID { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(25)]
    public string MovieName { get; set; }

    public virtual ICollection<Orders> Orders { get; set; }

    public Moveis Moveis { get; set; }
   // public Orders Orders { get; set; }


}