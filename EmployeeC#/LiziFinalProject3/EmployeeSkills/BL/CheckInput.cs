using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSkills.BL
{
    class CheckInput 
    {
       public static  string lastNCorrect;
      public  static int empIdCorrect;
       public static string skillCorrect;


        public static void SubInfo(string url)
        {
            if (url.Length < 15)
                MessageBox.Show("Enter url/unc name! ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((url.Substring(0, 12) != "https://www.") && (url.Substring(0, 12) != "http://www."))
            {
                MessageBox.Show("Erorr! \n url begin with https://www. ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int skillId = GetQuery.GetskillID(skillCorrect);
                   GetQuery.InsertUrl(url, skillId);
                    MessageBox.Show("Url added", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static bool SubRef(string firstN, string lastN, string alias, string position, string email)
        {
            if (lastN == "")
            {
                MessageBox.Show("Enter Last name");
                return false;
            }
            else if (alias == "")
            {
                MessageBox.Show("Enter Alias");
                return false;
            }
            else if (CheckMail(email))
            {
                try
                {
                    GetQuery.InsertRef(lastN.Trim(), firstN.Trim(), position.Trim(), alias.Trim(), email.Trim(), empIdCorrect);
                    
                    MessageBox.Show("Reference added", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;

        }
        public static bool SubEmp(string firstN, string lastN, string alias, string email)
        {
            if (lastN == "")
            {
                MessageBox.Show("Enter Last name");
                return false;
            }
            else if (alias == "")
            {
                MessageBox.Show("Enter Alias");
                return false;
            }
            else if (CheckMail(email))
            {
                GetQuery.InsertEmployees(lastN, firstN, alias, email);
                MessageBox.Show("New Employee added", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;  
        }
        public static void SubSkill(string skillName, string brief)
        {
            if (brief == "")
                MessageBox.Show("enter Brief Description of Skill!");
            else if (skillName == "")
                MessageBox.Show("enter Short Name of Skill or technology!");
            else
            {
                GetQuery.InsertSkills(skillName, brief, empIdCorrect);
                MessageBox.Show("new skill added", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void CheckSearch(string search)
        {
            if (search != "") { }
            else
                MessageBox.Show("enter skill search!", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static void CellSkillEvent(string skillCor)
        {
            skillCorrect = skillCor;

        }
        public static bool CheckMail(string email)
        {
            if (email != "")
            {
                try
                {
                    int count = email.Count(x => x == '@');
                    if ((email.Substring(email.Length - 4, 4) != ".com") || (count != 1))
                    {
                        MessageBox.Show("the mail worong", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("the mail worong", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }
            else return true;
        }




    }
}
    
