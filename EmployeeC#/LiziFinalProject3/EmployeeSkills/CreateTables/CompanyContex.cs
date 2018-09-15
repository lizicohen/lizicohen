using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmployeeSkills
{
  public  class CompanyContex:DbContext
    {
      public CompanyContex()
          : base("name=FinalProjectLiziEntities") 
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CompanyContex>());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SkillsInfo> SkillsInfo { get; set; }

    }
}
