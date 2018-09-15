using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EmployeeSkills.DAL;

namespace EmployeeSkills.BL
{
    class GetQuery
    {
        #region select defoult
        //defoult
        public static DataTable GetAllEmployees()
        {
            return HelperEmp.GetEmployees(" select LastName, FirstName, Alias, Email from Employees order by LastName");
        }
        //defoult
        public static DataTable GetAllSkills()
        {
            return HelperSkills.GetSkills(" select distinct skillName, BriefDescription from Skills order by skillName ");
        }
        #endregion

        #region select by click
        //by click on lastName employee in tableEmployee
          public static int GetEmployee(string lastName)
          {
              return HelperEmp.GetEmployeeCorrect(" select employeeId from Employees where lastName = @lastName", lastName);
        }

          public static DataTable GetSkillsByEmployeeId(int employeeId)
          {
              return HelperSkills.GetSkillsToEmp(" select skillName, BriefDescription from Skills where EmployeeId = @employeeId ", employeeId);
          }

        public static DataTable checkskill(string skillName)
        {
            return HelperEmp.GetEmployeesBySkills(" select LastName, FirstName, Alias, Email from Employees  where Exists ( select employeeId from skills where skillName = @skillName  and Employees.EmployeeId = Skills.EmployeeId) ", skillName);
           
        }
        public static DataTable GetReference(int employeeId)
        {
            return HelperEmp.GetRefToEmp(" select LastName, FirstName, Position, Alias, Email from Reference where EmployeeId = @employeeId ", employeeId);

        }
        public static int GetskillID(string skillName)
        {
            return HelperSkills.GetskillIdByNameS(" select SkillId from Skills where skillName = @skillName ", skillName);

        }
        public static string GetUrl(int skillId)
        {
            return HelperSkills.GetskillInfo(" select Url from SkillsInfo where skillId = @skillId ", skillId);

        }
        #endregion

        #region insert
        public static DataTable InsertEmployees(string lastName, string firstName, string alias, string email)
        {
            return HelperEmp.InsertEmployeesTable(string.Format(" insert into Employees " + " (LastName, FirstName, Alias, Email ) " +
                " values " + "( @lastName, @firstName, @alias, @email )"), lastName, firstName, alias, email);
        }
        public static DataTable InsertSkills(string skillName, string briefDescription, int employeeId)
        {
            return HelperSkills.InsertSkillTable(string.Format(" insert into Skills " + " (SkillName, BriefDescription ,EmployeeID) " +
                " values " + "( @SkillName, @BriefDescription ,@EmployeeId )"), skillName, briefDescription, employeeId);
        }
        public static DataTable InsertUrl(string url, int skillId)
        {
            return HelperSkills.InsertSkillInfoTable(string.Format(" insert into SkillsInfo " + " (URL, SkillId) " +
                " values " + "( @URL, @SkillId ) "), url, skillId);
        }
        public static DataTable InsertRef(string lastName,  string firstName, string position, string alias, string email, int employeeId)
        {
            return HelperEmp.InsertReferenceTable(string.Format(" insert into Reference " + " ( LastName, FirstName ,Position ,Alias, Email ,EmployeeId ) " +
                " values " + "( @lastName, @firstName, @position, @alias, @email ,@employeeId ) "), lastName, firstName, position, alias, email, employeeId);
        }
        #endregion

     

    }
}
