using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSkills.DAL

{
    /// <summary>
    /// / almog- I try to do singelton but no success yet, because use in HelperEmp class for query. I will need try again.
    /// </summary>
    class Connection
    {
        private static Connection singleton = null;
        private Connection()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectLiziEntities"].ConnectionString);
        
        }
    public static Connection NewInstance()
        {
            if (singleton == null)
            {
                singleton = new Connection();
            }
        return singleton;
        }

    }
}



 