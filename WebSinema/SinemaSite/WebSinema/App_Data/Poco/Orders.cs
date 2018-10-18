using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for Orders
/// </summary>
public class Orders
{
    [Key]
    public int OrdersID { get; set; }
   public int MoveiID { get; set; }

    public int UserID { get; set; }
    public int TimeID { get; set; }


    [Column(TypeName = "Int")]
    public int SumPrice { get; set; }

    [Column(TypeName = "Int")]
    public int AmountCardsIsBuy { get; set; }
    public DateTime DateOrders { get; set; }
    
    public Users Users { get; set; }
   public  TimeAndPlace TimeAndPlace{ get; set; }

}