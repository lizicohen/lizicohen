using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EmployeeSkills
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                DAL.HelperEmp.OpenConnection();
                ShowTableEmployees();
                ShowTableSkills();
            } catch(Exception) {
                MessageBox.Show("There is not connection to server", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        #region show table Employees

        DataTable showtable;
        private void ShowTableEmployees()
        {
            try
            {
                 showtable = BL.GetQuery.GetAllEmployees();
                dataGridViewEmployees.Rows.Clear();
                foreach (DataRow currentEmployee in showtable.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cellLN = new DataGridViewTextBoxCell();
                    cellLN.Value = currentEmployee["LastName"];
                    row.Cells.Add(cellLN);

                    DataGridViewTextBoxCell cellIFN = new DataGridViewTextBoxCell();
                    cellIFN.Value = currentEmployee["FirstName"];
                    row.Cells.Add(cellIFN);

                    DataGridViewTextBoxCell cellIAlias = new DataGridViewTextBoxCell();
                    cellIAlias.Value = currentEmployee["Alias"];
                    row.Cells.Add(cellIAlias);

                    DataGridViewTextBoxCell cellIEmail = new DataGridViewTextBoxCell();
                    cellIEmail.Value = currentEmployee["Email"];
                    row.Cells.Add(cellIEmail);

                    dataGridViewEmployees.Rows.Add(row);
                }
                ShowSkillRef();
               
            }
            catch (SqlException xs)
            {
                 if (showtable.Rows.Count == 0)
                    MessageBox.Show("there are no Employees");
                 else
                MessageBox.Show(xs.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region show table Skills

        DataTable showTable;
            private void ShowTableSkills()
        {
            try
            {
                showTable = BL.GetQuery.GetAllSkills();
                dataGridViewSkills.Rows.Clear();
                foreach (DataRow currentSkill in showTable.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cellNskill = new DataGridViewTextBoxCell();
                    cellNskill.Value = currentSkill["SkillName"];
                    row.Cells.Add(cellNskill);

                    DataGridViewTextBoxCell cellBrief = new DataGridViewTextBoxCell();
                    cellBrief.Value = currentSkill["BriefDescription"];
                    row.Cells.Add(cellBrief);


                    dataGridViewSkills.Rows.Add(row);
                }
                ShowSkillRef();

            }
            catch (SqlException xs) {
                if (showTable.Rows.Count == 0)
                    MessageBox.Show("there are no Skills");
                else
                    MessageBox.Show(xs.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchSkills.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DAL.HelperEmp.CloseConnection();
            Application.Exit();
        }

        private void btnSubInfo_Click(object sender, EventArgs e)
        {
            BL.CheckInput.SubInfo(txtAddInfo.Text);
            ShowSkillRef();


        }

        private void btnSuRef_Click(object sender, EventArgs e)
        {
            if (BL.CheckInput.SubRef(txtRefLN.Text, txtRefFN.Text, txtRefAlias.Text, txtRefPos.Text, txtRefMail.Text))
            {
                txtRefFN.Clear();
                txtRefPos.Clear();
                txtRefMail.Clear();
                txtRefLN.Clear();
                txtRefAlias.Clear();
            }
            ShowSkillRef();

        }

        private void btnSubEmployee_Click(object sender, EventArgs e)
        {
            if (BL.CheckInput.SubEmp(txtEmpLN.Text.Trim(), txtEmpFN.Text.Trim(), txtEmpAlias.Text.Trim(), txtEmpMail.Text.Trim()))
            {
                try
                {
                    ShowTableEmployees();
                } catch (SqlException) { }
                txtEmpFN.Clear();
                txtEmpLN.Clear();
                txtEmpAlias.Clear();
                txtEmpMail.Clear();
            }
        }

        private void btnsubSkill_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CheckInput.SubSkill(txtNameSkill.Text.Trim(), txtBrief.Text.Trim());
                txtNameSkill.Clear();
                txtBrief.Clear();
                ShowSkillRef();
            }
            catch (Exception)
            {
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            BL.CheckInput.CheckSearch(txtSearchSkills.Text.ToLower().Trim());
            Search(txtSearchSkills.Text.ToLower().Trim());
        }

        #region Search
        public void Search(string search)
        {
            try
            {
                //  DataTable showEmployeeS = BL.GetQuery.checkskill(search);
                // dataGridViewEmployees.DataSource = showEmployeeS;
                dataGridViewEmployees.Rows.Clear();
                txtSkillsRef.Clear();
                DataTable showtable = BL.GetQuery.checkskill(search);

                foreach (DataRow currentEmployee in showtable.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cellLN = new DataGridViewTextBoxCell();
                    cellLN.Value = currentEmployee["LastName"];
                    row.Cells.Add(cellLN);

                    DataGridViewTextBoxCell cellIFN = new DataGridViewTextBoxCell();
                    cellIFN.Value = currentEmployee["FirstName"];
                    row.Cells.Add(cellIFN);

                    DataGridViewTextBoxCell cellIAlias = new DataGridViewTextBoxCell();
                    cellIAlias.Value = currentEmployee["Alias"];
                    row.Cells.Add(cellIAlias);

                    DataGridViewTextBoxCell cellIEmail = new DataGridViewTextBoxCell();
                    cellIEmail.Value = currentEmployee["Email"];
                    row.Cells.Add(cellIEmail);

                    dataGridViewEmployees.Rows.Add(row);
                }
            }
            catch (SqlException sx)
            {

                if (showtable.Rows.Count == 0)
                    MessageBox.Show("there are no Employees with this skill. try again!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

        }
        #endregion

        private void linkLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);

        }

        #region ShowSkillRef
        string url;
        private void ShowSkillRef()
        {
            try
            {

                txtSkillsRef.Clear();

                BL.CheckInput.lastNCorrect = "";
                BL.CheckInput.empIdCorrect = 0;
                BL.CheckInput.lastNCorrect = dataGridViewEmployees.CurrentCell.Value.ToString();
                BL.CheckInput.empIdCorrect = BL.GetQuery.GetEmployee(BL.CheckInput.lastNCorrect);

                if (BL.CheckInput.empIdCorrect == 0)
                {
                    MessageBox.Show("Press on lastName cell", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowTableSkills();
                    return;
                }
                else
                {
                    DataTable showTable = BL.GetQuery.GetSkillsByEmployeeId(BL.CheckInput.empIdCorrect);
                    dataGridViewSkills.Rows.Clear();
                    foreach (DataRow currentSkill in showTable.Rows)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell cellNskill = new DataGridViewTextBoxCell();
                        cellNskill.Value = currentSkill["SkillName"];
                        row.Cells.Add(cellNskill);


                        DataGridViewTextBoxCell cellBrief = new DataGridViewTextBoxCell();
                        cellBrief.Value = currentSkill["BriefDescription"];
                        row.Cells.Add(cellBrief);
                        txtSkillsRef.Text += cellNskill.Value + ": " + cellBrief.Value + " \r\n";

                        dataGridViewSkills.Rows.Add(row);

                        int skillId = BL.GetQuery.GetskillID(cellNskill.Value.ToString());
                        url = "";
                        if (skillId > 0)
                        {
                            url = BL.GetQuery.GetUrl(skillId);
                            txtSkillsRef.Text += "\r\n" + url + " \r\n" + "\r\n ";
                        }
                        if (skillId > 0)
                        {
                            LinkLabel link = new LinkLabel();

                            link.Text = url;
                            link.AutoSize = true;
                            int indexOfUrl = txtSkillsRef.Text.IndexOf(url);
                            Console.WriteLine(indexOfUrl);
                            Point specificWord = txtSkillsRef.GetPositionFromCharIndex(indexOfUrl);
                            link.Location = specificWord;

                            txtSkillsRef.Controls.Add(link);
                            link.Visible = true;
                            txtSkillsRef.SelectionStart = txtSkillsRef.TextLength;
                            link.Click += new System.EventHandler(this.linkLabel_Click);

                        }

                    }
                    if (showTable.Rows.Count == 0)
                    {
                        MessageBox.Show("there are no Skills", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    try
                    {
                        DataTable addRef = BL.GetQuery.GetReference(BL.CheckInput.empIdCorrect);
                        txtSkillsRef.Text += "References:\n\r";
                        foreach (DataRow currentRef in addRef.Rows)
                        {
                            DataGridViewRow row1 = new DataGridViewRow();
                            DataGridViewTextBoxCell cellFN = new DataGridViewTextBoxCell();
                            cellFN.Value = currentRef["FirstName"];

                            DataGridViewTextBoxCell cellLN = new DataGridViewTextBoxCell();
                            cellLN.Value = currentRef["LastName"];

                            DataGridViewTextBoxCell cellPo = new DataGridViewTextBoxCell();
                            cellPo.Value = currentRef["Position"];

                            DataGridViewTextBoxCell cellAli = new DataGridViewTextBoxCell();
                            cellAli.Value = currentRef["Alias"];


                            DataGridViewTextBoxCell cellEMail = new DataGridViewTextBoxCell();
                            cellEMail.Value = currentRef["Email"];

                            txtSkillsRef.Text += string.Format(" name: {0} {1}, alias: {2} ,Position: {3} ,E-Mail: {4} \r\n", cellFN.Value, cellLN.Value, cellAli.Value, cellPo.Value, cellEMail.Value);

                        }
                    }
                    catch (SqlException)
                    {
                        txtSkillsRef.Text += "there are not references for employee";
                    }

                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSkillRef();
        }
           
   
        private void dataGridViewSkills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Search(dataGridViewSkills.CurrentCell.Value.ToString());
        }



        private void btnRefEmp_Click(object sender, EventArgs e)
        {
            ShowTableEmployees();

        }

        private void btnRefSkill_Click(object sender, EventArgs e)
        {
            ShowTableSkills();
        }



        private void txtSearchSkills_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtSearchSkills.Text.ToLower().Trim();
                if (search != "")
                    Search(search);
                else
                    MessageBox.Show("enter skill search!");
            }
        }
        ToolTip ttipRef = new ToolTip();
        private void btnRefEmp_MouseMove(object sender, MouseEventArgs e)
        {
            ttipRef.SetToolTip(btnRefEmp, "refresh employees table");

        }

        private void btnRefSkill_MouseMove(object sender, MouseEventArgs e)
        {
            ttipRef.SetToolTip(btnRefSkill, "refresh skill table");
        }

      
    }
}
