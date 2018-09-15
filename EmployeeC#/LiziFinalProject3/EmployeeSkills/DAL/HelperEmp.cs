using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeSkills.DAL
{
    class HelperEmp
    {
    public static  SqlConnection connection =new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProjectLiziEntities"].ConnectionString);
       
        #region Select All Employees
        public static DataTable GetEmployees(string query)
        {  
            
            DataTable employee = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                  
                 SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);
                    tableAdapter.Fill(employee);

                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
          
            return employee;
        }

      
        #endregion

        #region GetEmployeesBySkills
        public static DataTable GetEmployeesBySkills(string query, string skillName)
        {
            DataTable employee = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@skillName";
                    param.Value = skillName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    tableAdapter.Fill(employee);
                }
                }catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        
            return employee;
        }
        #endregion

        #region GetRefToEmp
        public static DataTable GetRefToEmp(string query, int employeeId)
        {
            DataTable reference = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@employeeId";
                    param.Value = employeeId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        tableAdapter.Fill(reference);
                    }
                    catch (Exception)
                    {
                      //  MessageBox.Show("Press on lastName cell");
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return reference;
        }
        #endregion

        #region GetEmpID
        public static int empId;
        public static int GetEmployeeCorrect(string query, string lastName)
        {
            empId = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                  
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@lastName";
                    param.Value = lastName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);
                    try
                    {
                        empId = (int)cmd.ExecuteScalar();
                    }catch(Exception )
                    {
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return empId;

        }
        #endregion 

        #region Insert Employee
        public static DataTable InsertEmployeesTable(string query, string lastName, string firstName, string alias, string email)
        {
            DataTable employee = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@LastName";
                    param.Value = lastName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@FirstName";
                    param.Value = firstName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Alias";
                    param.Value = alias;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Email";
                    param.Value = email;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    employee.Load(sqlDR);

                   
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        
                    return employee; 
            }

      

        #endregion

        #region Insert Reference
        public static DataTable InsertReferenceTable(string query, string lastName, string firstName, string alias,string position ,string email ,int employeeId)
        {
            DataTable references = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@LastName";
                    param.Value = lastName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@FirstName";
                    param.Value = firstName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Alias";
                    param.Value = alias;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Position";
                    param.Value = position;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@Email";
                    param.Value = email;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@EmployeeId";
                    param.Value = employeeId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    references.Load(sqlDR);
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return references;
        }

        #endregion

      
        public static void OpenConnection()
        {
            connection.Open();
        }
        public static  void CloseConnection()
    {    
      connection.Close();
    }
       

    }
}
