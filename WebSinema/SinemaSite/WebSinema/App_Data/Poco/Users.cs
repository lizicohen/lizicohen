using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Users
/// </summary>
/// 
public enum CreditCompany
{
    Isracard, Visa, AmericanExpress, Dainers, leumiCard, MasterCard
}

public class Users
{
    [Key]
    public int UserID { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(30)]
    [Required]
    public string UserName { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(20)]
    [Required]
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(12)]
    public string Phone { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(30)]
    public string Email { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(15)]
    public string FirstName { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(15)]
    public string LastName { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(10)]
    public string OwnerId { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(16)]
    public string NumCard { get; set; }
    [Column(TypeName = "Nvarchar")]
    [MaxLength(3)]
    public string Cvv { get; set; }
    public CreditCompany CreditCard { get; set; }

     public DateTime ExpirtyDate { get; set; }
     public ICollection<Orders> Orders { get; set; }
}



