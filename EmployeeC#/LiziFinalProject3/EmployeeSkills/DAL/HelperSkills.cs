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
    class HelperSkills
    {
        #region Select All Skills
        public static DataTable GetSkills(string query)
        {

            DataTable skills = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);
                    tableAdapter.Fill(skills);

                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return skills;
        }
        #endregion

        #region Get Skill for Employee
        public static DataTable GetSkillsToEmp(string query, int employeeId)
        {
            DataTable skills = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {
                    SqlDataAdapter tableAdapter = new SqlDataAdapter(cmd);

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@employeeId";
                    param.Value = employeeId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    tableAdapter.Fill(skills);
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            return skills;
        }
        #endregion

        #region GetSkillId
        static int skillInfo;
        public static int GetskillIdByNameS(string query, string skillName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@skillName";
                    param.Value = skillName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);
                    skillInfo = (int)cmd.ExecuteScalar();   
                
                }
            }
            catch (SqlException )
            {
                if(skillInfo<0)
                MessageBox.Show("Press on skill Name cell");
            }

            return skillInfo;
        }
        #endregion

        #region GetSkillInfo
        static string url;
        public static string GetskillInfo(string query, int skillId)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@skillId";
                    param.Value = skillId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);
                    try
                    {
                        url = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Press on skill Name cell");
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return url;
        }
        #endregion

        #region Insert SkillInfo
        public static DataTable InsertSkillInfoTable(string query, string url, int skillId)
        {
            DataTable skillInfo = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@URL";
                    param.Value = url;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@SkillId";
                    param.Value = skillId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    skillInfo.Load(sqlDR);


                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            return skillInfo;
        }

        #endregion

        #region Insert Skill
        public static DataTable InsertSkillTable(string query, string skillName, string briefDescription, int EmployeeId)
        {
            DataTable skill = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand(query, HelperEmp.connection))
                {

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@skillName";
                    param.Value = skillName;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@briefDescription";
                    param.Value = briefDescription;
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Size = 50;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@employeeId";
                    param.Value = EmployeeId;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    SqlDataReader sqlDR = cmd.ExecuteReader();
                    skill.Load(sqlDR);

                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            return skill;
        }

        #endregion

    }

}
