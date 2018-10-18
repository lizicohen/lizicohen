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

    public class ServiceConnection : System.Web.Services.WebService
    {
        private string dbConnString;
        private SqlConnection sqlCon;
        public ServiceConnection()
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
        #region Select
        public DataTable GetUserLog()
        {
            string sqlQuery = " select * from Users WHERE UserName = @UserName AND Password = @Password ";
            DataTable allMoveis = new DataTable();
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                SqlDataReader sqlDR = cmd.ExecuteReader();
                try
                {
                    allMoveis.Load(sqlDR);
                }
                catch (SqlException se)
                {
                    Console.WriteLine("Error reading from DB! \n{0}", se.Message);
                }
                finally
                {
                    sqlDR.Close();
                }
                return allMoveis;
            }
        }
        #endregion
        [WebMethod, ScriptMethod]
        public DataTable GetAllMuvies()
        {
            DataTable tblMovies = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = sqlCon;
                cmd.CommandText = "select top(3) * from Moveis order by ratingAvg  desc";
                SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);
                tableAdapter.Fill(tblMovies);
            }
            sqlCon.Close();

            return tblMovies;
        }
       // [WebMethod, ScriptMethod]
        //public Moveis GetMuvies()
        //{
        //    Moveis movei = new Moveis();

        //    using (SqlCommand cmd = new SqlCommand())
        //    {

        //        cmd.Connection = sqlCon;
        //        cmd.CommandText = "select top(3) * from Moveis order by ratingAvg  desc";
        //        SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);
        //        tableAdapter.Fill(tblMovies);
        //    }
        //    sqlCon.Close();

        //    return tblMovies;
        //}
    
    }

}


