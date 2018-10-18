using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSinema.DAL
{
    public class DbTabels: DbContext
    {
       
            private static DbTabels context = null;
            public DbTabels() : base("name=DB12")
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbTabels>());
            }
            public DbSet<Feedback> FeedBack { get; set; }
            public DbSet<Moveis> Moveis { get; set; }
            public DbSet<Users> Users { get; set; }
            public DbSet<Orders> Orders { get; set; }
            public DbSet<TimeAndPlace> TimeAndPlace { get; set; }

            public static DbTabels GetInstance()
            {
                if (context == null)
                {
                    context = new DbTabels();
                }
                return context;
            }
        }
    
}
