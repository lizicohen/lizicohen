using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebSinema
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private string dbConnString;
        private SqlConnection sqlCon;


        public WebService()
        {
            dbConnString = ConfigurationManager.ConnectionStrings["DB12"].ConnectionString;

            sqlCon = new SqlConnection();
            sqlCon.ConnectionString = dbConnString;
            sqlCon.Open();
        }

        [WebMethod, ScriptMethod]
        public List<string> GetMoveiNameList(string prefixText, int count)
        {
            List<string> lstMovies = new List<string>();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = sqlCon;
                cmd.CommandText = "select MoveiName from Moveis where MoveiName like @SearchText + '%' ";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstMovies.Add(reader["MoveiName"].ToString());
                }
            }
            sqlCon.Close();
            return lstMovies;
        }
        [WebMethod, ScriptMethod]
        public List<Moveis> GetMovies(string name)
        {
            List<Moveis> moveis = new List<Moveis>();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("select * from Moveis where  MoveiName= @name ", sqlCon))
                    {

                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = name;
                        param.SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.Add(param);
                        try
                        {
                        moveis.Add( (Moveis)cmd.ExecuteScalar());
                        }
                        catch (Exception)
                        {
                          
                        }
                    }
                }
                catch (SqlException )
                {
                    
                }

                return moveis;
            }
        }
}



   


    