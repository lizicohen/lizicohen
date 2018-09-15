namespace EmployeeSkills
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BriefDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblgrvEmployees = new System.Windows.Forms.Label();
            this.lblgrivSkills = new System.Windows.Forms.Label();
            this.lblSkillRef = new System.Windows.Forms.Label();
            this.txtSearchSkills = new System.Windows.Forms.TextBox();
            this.txtSkillsRef = new System.Windows.Forms.TextBox();
            this.lblSearchSkills = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbInsEmp = new System.Windows.Forms.GroupBox();
            this.txtEmpMail = new System.Windows.Forms.TextBox();
            this.txtEmpAlias = new System.Windows.Forms.TextBox();
            this.txtEmpLN = new System.Windows.Forms.TextBox();
            this.txtEmpFN = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblNewEmp = new System.Windows.Forms.Label();
            this.btnSubEmployee = new System.Windows.Forms.Button();
            this.grbAddSkill = new System.Windows.Forms.GroupBox();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.txtBrief = new System.Windows.Forms.TextBox();
            this.lblBrief = new System.Windows.Forms.Label();
            this.lblNameSkill = new System.Windows.Forms.Label();
            this.lblNewSkill = new System.Windows.Forms.Label();
            this.btnsubSkill = new System.Windows.Forms.Button();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.grbInsRef = new System.Windows.Forms.GroupBox();
            this.txtRefAlias = new System.Windows.Forms.TextBox();
            this.lblRefAlias = new System.Windows.Forms.Label();
            this.txtRefMail = new System.Windows.Forms.TextBox();
            this.txtRefPos = new System.Windows.Forms.TextBox();
            this.txtRefLN = new System.Windows.Forms.TextBox();
            this.txtRefFN = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnSuRef = new System.Windows.Forms.Button();
            this.lblAddRef = new System.Windows.Forms.Label();
            this.lblAddInfo = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnSubInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefEmp = new System.Windows.Forms.Button();
            this.btnRefSkill = new System.Windows.Forms.Button();
            this.ttipRefreshE = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.gbInsEmp.SuspendLayout();
            this.grbAddSkill.SuspendLayout();
            this.grbInsRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Alias,
            this.Email});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(26, 35);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(473, 92);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillName,
            this.BriefDescription});
            this.dataGridViewSkills.Location = new System.Drawing.Point(26, 170);
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.Size = new System.Drawing.Size(473, 76);
            this.dataGridViewSkills.TabIndex = 1;
            this.dataGridViewSkills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkills_CellClick);
            // 
            // SkillName
            // 
            this.SkillName.HeaderText = "Skill Name";
            this.SkillName.Name = "SkillName";
            // 
            // BriefDescription
            // 
            this.BriefDescription.HeaderText = "Brief Description";
            this.BriefDescription.Name = "BriefDescription";
            // 
            // lblgrvEmployees
            // 
            this.lblgrvEmployees.AutoSize = true;
            this.lblgrvEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblgrvEmployees.Location = new System.Drawing.Point(23, 9);
            this.lblgrvEmployees.Name = "lblgrvEmployees";
            this.lblgrvEmployees.Size = new System.Drawing.Size(282, 13);
            this.lblgrvEmployees.TabIndex = 2;
            this.lblgrvEmployees.Text = "Employees (Click to select an existing employee)";
            // 
            // lblgrivSkills
            // 
            this.lblgrivSkills.AutoSize = true;
            this.lblgrivSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblgrivSkills.Location = new System.Drawing.Point(23, 142);
            this.lblgrivSkills.Name = "lblgrivSkills";
            this.lblgrivSkills.Size = new System.Drawing.Size(223, 13);
            this.lblgrivSkills.TabIndex = 3;
            this.lblgrivSkills.Text = "Skills (Click to get all skill information)";
            // 
            // lblSkillRef
            // 
            this.lblSkillRef.AutoSize = true;
            this.lblSkillRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSkillRef.Location = new System.Drawing.Point(595, 10);
            this.lblSkillRef.Name = "lblSkillRef";
            this.lblSkillRef.Size = new System.Drawing.Size(108, 13);
            this.lblSkillRef.TabIndex = 4;
            this.lblSkillRef.Text = "Skills/References";
            // 
            // txtSearchSkills
            // 
            this.txtSearchSkills.Location = new System.Drawing.Point(131, 259);
            this.txtSearchSkills.Name = "txtSearchSkills";
            this.txtSearchSkills.Size = new System.Drawing.Size(497, 20);
            this.txtSearchSkills.TabIndex = 5;
            this.txtSearchSkills.Text = "Add keywords seaparated by a apace. Press <Enter> to search.";
            this.txtSearchSkills.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSkills_KeyDown);
            // 
            // txtSkillsRef
            // 
            this.txtSkillsRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSkillsRef.Location = new System.Drawing.Point(598, 33);
            this.txtSkillsRef.Margin = new System.Windows.Forms.Padding(10);
            this.txtSkillsRef.Multiline = true;
            this.txtSkillsRef.Name = "txtSkillsRef";
            this.txtSkillsRef.Size = new System.Drawing.Size(473, 213);
            this.txtSkillsRef.TabIndex = 6;
            // 
            // lblSearchSkills
            // 
            this.lblSearchSkills.AutoSize = true;
            this.lblSearchSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearchSkills.Location = new System.Drawing.Point(23, 266);
            this.lblSearchSkills.Name = "lblSearchSkills";
            this.lblSearchSkills.Size = new System.Drawing.Size(102, 13);
            this.lblSearchSkills.TabIndex = 7;
            this.lblSearchSkills.Text = "Search for skills:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(458, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(553, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbInsEmp
            // 
            this.gbInsEmp.Controls.Add(this.txtEmpMail);
            this.gbInsEmp.Controls.Add(this.txtEmpAlias);
            this.gbInsEmp.Controls.Add(this.txtEmpLN);
            this.gbInsEmp.Controls.Add(this.txtEmpFN);
            this.gbInsEmp.Controls.Add(this.lblAlias);
            this.gbInsEmp.Controls.Add(this.lblLastName);
            this.gbInsEmp.Controls.Add(this.lblEmail);
            this.gbInsEmp.Controls.Add(this.lblFirstname);
            this.gbInsEmp.Controls.Add(this.lblNewEmp);
            this.gbInsEmp.Controls.Add(this.btnSubEmployee);
            this.gbInsEmp.Location = new System.Drawing.Point(39, 329);
            this.gbInsEmp.Name = "gbInsEmp";
            this.gbInsEmp.Size = new System.Drawing.Size(266, 250);
            this.gbInsEmp.TabIndex = 10;
            this.gbInsEmp.TabStop = false;
            this.gbInsEmp.Text = "grInsEmp";
            // 
            // txtEmpMail
            // 
            this.txtEmpMail.Location = new System.Drawing.Point(87, 120);
            this.txtEmpMail.Name = "txtEmpMail";
            this.txtEmpMail.Size = new System.Drawing.Size(144, 20);
            this.txtEmpMail.TabIndex = 22;
            // 
            // txtEmpAlias
            // 
            this.txtEmpAlias.Location = new System.Drawing.Point(87, 89);
            this.txtEmpAlias.Name = "txtEmpAlias";
            this.txtEmpAlias.Size = new System.Drawing.Size(144, 20);
            this.txtEmpAlias.TabIndex = 21;
            // 
            // txtEmpLN
            // 
            this.txtEmpLN.Location = new System.Drawing.Point(87, 63);
            this.txtEmpLN.Name = "txtEmpLN";
            this.txtEmpLN.Size = new System.Drawing.Size(144, 20);
            this.txtEmpLN.TabIndex = 19;
            // 
            // txtEmpFN
            // 
            this.txtEmpFN.Location = new System.Drawing.Point(87, 30);
            this.txtEmpFN.Name = "txtEmpFN";
            this.txtEmpFN.Size = new System.Drawing.Size(144, 20);
            this.txtEmpFN.TabIndex = 18;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAlias.Location = new System.Drawing.Point(6, 92);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(32, 13);
            this.lblAlias.TabIndex = 17;
            this.lblAlias.Text = "Alias:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLastName.Location = new System.Drawing.Point(6, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "LastName";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(6, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFirstname.Location = new System.Drawing.Point(6, 33);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(60, 13);
            this.lblFirstname.TabIndex = 14;
            this.lblFirstname.Text = "First Name:";
            // 
            // lblNewEmp
            // 
            this.lblNewEmp.AutoSize = true;
            this.lblNewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNewEmp.Location = new System.Drawing.Point(6, 0);
            this.lblNewEmp.Name = "lblNewEmp";
            this.lblNewEmp.Size = new System.Drawing.Size(78, 13);
            this.lblNewEmp.TabIndex = 13;
            this.lblNewEmp.Text = "New Employee";
            // 
            // btnSubEmployee
            // 
            this.btnSubEmployee.Location = new System.Drawing.Point(87, 185);
            this.btnSubEmployee.Name = "btnSubEmployee";
            this.btnSubEmployee.Size = new System.Drawing.Size(108, 23);
            this.btnSubEmployee.TabIndex = 13;
            this.btnSubEmployee.Text = "Submit Employee";
            this.btnSubEmployee.UseVisualStyleBackColor = true;
            this.btnSubEmployee.Click += new System.EventHandler(this.btnSubEmployee_Click);
            // 
            // grbAddSkill
            // 
            this.grbAddSkill.Controls.Add(this.txtNameSkill);
            this.grbAddSkill.Controls.Add(this.txtBrief);
            this.grbAddSkill.Controls.Add(this.lblBrief);
            this.grbAddSkill.Controls.Add(this.lblNameSkill);
            this.grbAddSkill.Controls.Add(this.lblNewSkill);
            this.grbAddSkill.Controls.Add(this.btnsubSkill);
            this.grbAddSkill.Location = new System.Drawing.Point(355, 371);
            this.grbAddSkill.Name = "grbAddSkill";
            this.grbAddSkill.Size = new System.Drawing.Size(261, 193);
            this.grbAddSkill.TabIndex = 11;
            this.grbAddSkill.TabStop = false;
            // 
            // txtNameSkill
            // 
            this.txtNameSkill.Location = new System.Drawing.Point(9, 54);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(234, 20);
            this.txtNameSkill.TabIndex = 31;
            // 
            // txtBrief
            // 
            this.txtBrief.Location = new System.Drawing.Point(9, 103);
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(234, 20);
            this.txtBrief.TabIndex = 30;
            // 
            // lblBrief
            // 
            this.lblBrief.AutoSize = true;
            this.lblBrief.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBrief.Location = new System.Drawing.Point(6, 84);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(121, 13);
            this.lblBrief.TabIndex = 29;
            this.lblBrief.Text = "Brief Description of Skill:";
            // 
            // lblNameSkill
            // 
            this.lblNameSkill.AutoSize = true;
            this.lblNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNameSkill.Location = new System.Drawing.Point(6, 20);
            this.lblNameSkill.Name = "lblNameSkill";
            this.lblNameSkill.Size = new System.Drawing.Size(167, 13);
            this.lblNameSkill.TabIndex = 28;
            this.lblNameSkill.Text = "Short Name of Skill or technology:";
            // 
            // lblNewSkill
            // 
            this.lblNewSkill.AutoSize = true;
            this.lblNewSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNewSkill.Location = new System.Drawing.Point(6, 2);
            this.lblNewSkill.Name = "lblNewSkill";
            this.lblNewSkill.Size = new System.Drawing.Size(51, 13);
            this.lblNewSkill.TabIndex = 23;
            this.lblNewSkill.Text = "New Skill";
            // 
            // btnsubSkill
            // 
            this.btnsubSkill.Location = new System.Drawing.Point(89, 164);
            this.btnsubSkill.Name = "btnsubSkill";
            this.btnsubSkill.Size = new System.Drawing.Size(75, 23);
            this.btnsubSkill.TabIndex = 27;
            this.btnsubSkill.Text = "Submit Skill";
            this.btnsubSkill.UseVisualStyleBackColor = true;
            this.btnsubSkill.Click += new System.EventHandler(this.btnsubSkill_Click);
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.Location = new System.Drawing.Point(748, 282);
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(270, 20);
            this.txtAddInfo.TabIndex = 20;
            this.txtAddInfo.Text = "https://www.";
            // 
            // grbInsRef
            // 
            this.grbInsRef.Controls.Add(this.txtRefAlias);
            this.grbInsRef.Controls.Add(this.lblRefAlias);
            this.grbInsRef.Controls.Add(this.txtRefMail);
            this.grbInsRef.Controls.Add(this.txtRefPos);
            this.grbInsRef.Controls.Add(this.txtRefLN);
            this.grbInsRef.Controls.Add(this.txtRefFN);
            this.grbInsRef.Controls.Add(this.lblPosition);
            this.grbInsRef.Controls.Add(this.lblLName);
            this.grbInsRef.Controls.Add(this.lblMail);
            this.grbInsRef.Controls.Add(this.lblFName);
            this.grbInsRef.Controls.Add(this.btnSuRef);
            this.grbInsRef.Controls.Add(this.lblAddRef);
            this.grbInsRef.Location = new System.Drawing.Point(687, 371);
            this.grbInsRef.Name = "grbInsRef";
            this.grbInsRef.Size = new System.Drawing.Size(266, 208);
            this.grbInsRef.TabIndex = 23;
            this.grbInsRef.TabStop = false;
            // 
            // txtRefAlias
            // 
            this.txtRefAlias.Location = new System.Drawing.Point(87, 107);
            this.txtRefAlias.Name = "txtRefAlias";
            this.txtRefAlias.Size = new System.Drawing.Size(144, 20);
            this.txtRefAlias.TabIndex = 24;
            // 
            // lblRefAlias
            // 
            this.lblRefAlias.AutoSize = true;
            this.lblRefAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRefAlias.Location = new System.Drawing.Point(9, 107);
            this.lblRefAlias.Name = "lblRefAlias";
            this.lblRefAlias.Size = new System.Drawing.Size(32, 13);
            this.lblRefAlias.TabIndex = 23;
            this.lblRefAlias.Text = "Alias:";
            // 
            // txtRefMail
            // 
            this.txtRefMail.Location = new System.Drawing.Point(87, 132);
            this.txtRefMail.Name = "txtRefMail";
            this.txtRefMail.Size = new System.Drawing.Size(144, 20);
            this.txtRefMail.TabIndex = 22;
            // 
            // txtRefPos
            // 
            this.txtRefPos.Location = new System.Drawing.Point(87, 82);
            this.txtRefPos.Name = "txtRefPos";
            this.txtRefPos.Size = new System.Drawing.Size(144, 20);
            this.txtRefPos.TabIndex = 21;
            // 
            // txtRefLN
            // 
            this.txtRefLN.Location = new System.Drawing.Point(87, 56);
            this.txtRefLN.Name = "txtRefLN";
            this.txtRefLN.Size = new System.Drawing.Size(144, 20);
            this.txtRefLN.TabIndex = 19;
            // 
            // txtRefFN
            // 
            this.txtRefFN.Location = new System.Drawing.Point(87, 30);
            this.txtRefFN.Name = "txtRefFN";
            this.txtRefFN.Size = new System.Drawing.Size(144, 20);
            this.txtRefFN.TabIndex = 18;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPosition.Location = new System.Drawing.Point(6, 84);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLName.Location = new System.Drawing.Point(6, 59);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(55, 13);
            this.lblLName.TabIndex = 16;
            this.lblLName.Text = "LastName";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMail.Location = new System.Drawing.Point(6, 132);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-mail";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFName.Location = new System.Drawing.Point(6, 33);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "First Name:";
            // 
            // btnSuRef
            // 
            this.btnSuRef.Location = new System.Drawing.Point(87, 170);
            this.btnSuRef.Name = "btnSuRef";
            this.btnSuRef.Size = new System.Drawing.Size(108, 23);
            this.btnSuRef.TabIndex = 13;
            this.btnSuRef.Text = "Submit Ref";
            this.btnSuRef.UseVisualStyleBackColor = true;
            this.btnSuRef.Click += new System.EventHandler(this.btnSuRef_Click);
            // 
            // lblAddRef
            // 
            this.lblAddRef.AutoSize = true;
            this.lblAddRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddRef.Location = new System.Drawing.Point(-3, 0);
            this.lblAddRef.Name = "lblAddRef";
            this.lblAddRef.Size = new System.Drawing.Size(209, 13);
            this.lblAddRef.TabIndex = 13;
            this.lblAddRef.Text = "Add Reference Person to Select Employee";
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.AutoSize = true;
            this.lblAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddInfo.Location = new System.Drawing.Point(697, 256);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(255, 13);
            this.lblAddInfo.TabIndex = 24;
            this.lblAddInfo.Text = "Add Info to Current Skills , Press before on skill name";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUrl.Location = new System.Drawing.Point(684, 282);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(60, 13);
            this.lblUrl.TabIndex = 25;
            this.lblUrl.Text = "URL/UNC:";
            // 
            // btnSubInfo
            // 
            this.btnSubInfo.Location = new System.Drawing.Point(910, 319);
            this.btnSubInfo.Name = "btnSubInfo";
            this.btnSubInfo.Size = new System.Drawing.Size(108, 23);
            this.btnSubInfo.TabIndex = 23;
            this.btnSubInfo.Text = "Submit Info";
            this.btnSubInfo.UseVisualStyleBackColor = true;
            this.btnSubInfo.Click += new System.EventHandler(this.btnSubInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(996, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefEmp
            // 
            this.btnRefEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnRefEmp.Image")));
            this.btnRefEmp.Location = new System.Drawing.Point(311, 0);
            this.btnRefEmp.Name = "btnRefEmp";
            this.btnRefEmp.Size = new System.Drawing.Size(28, 33);
            this.btnRefEmp.TabIndex = 27;
            this.btnRefEmp.UseVisualStyleBackColor = true;
            this.btnRefEmp.Click += new System.EventHandler(this.btnRefEmp_Click);
            this.btnRefEmp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRefEmp_MouseMove);
            // 
            // btnRefSkill
            // 
            this.btnRefSkill.Image = ((System.Drawing.Image)(resources.GetObject("btnRefSkill.Image")));
            this.btnRefSkill.Location = new System.Drawing.Point(252, 132);
            this.btnRefSkill.Name = "btnRefSkill";
            this.btnRefSkill.Size = new System.Drawing.Size(29, 25);
            this.btnRefSkill.TabIndex = 28;
            this.btnRefSkill.UseVisualStyleBackColor = true;
            this.btnRefSkill.Click += new System.EventHandler(this.btnRefSkill_Click);
            this.btnRefSkill.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRefSkill_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 602);
            this.Controls.Add(this.btnRefSkill);
            this.Controls.Add(this.btnRefEmp);
            this.Controls.Add(this.btnSubInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAddInfo);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblAddInfo);
            this.Controls.Add(this.grbInsRef);
            this.Controls.Add(this.grbAddSkill);
            this.Controls.Add(this.gbInsEmp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSearchSkills);
            this.Controls.Add(this.txtSkillsRef);
            this.Controls.Add(this.txtSearchSkills);
            this.Controls.Add(this.lblSkillRef);
            this.Controls.Add(this.lblgrivSkills);
            this.Controls.Add(this.lblgrvEmployees);
            this.Controls.Add(this.dataGridViewSkills);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "FormMain";
            this.Text = "Skills Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.gbInsEmp.ResumeLayout(false);
            this.gbInsEmp.PerformLayout();
            this.grbAddSkill.ResumeLayout(false);
            this.grbAddSkill.PerformLayout();
            this.grbInsRef.ResumeLayout(false);
            this.grbInsRef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.Label lblgrvEmployees;
        private System.Windows.Forms.Label lblgrivSkills;
        private System.Windows.Forms.Label lblSkillRef;
        private System.Windows.Forms.TextBox txtSearchSkills;
        private System.Windows.Forms.TextBox txtSkillsRef;
        private System.Windows.Forms.Label lblSearchSkills;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbInsEmp;
        private System.Windows.Forms.Button btnSubEmployee;
        private System.Windows.Forms.GroupBox grbAddSkill;
        private System.Windows.Forms.Label lblNewEmp;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtEmpMail;
        private System.Windows.Forms.TextBox txtEmpAlias;
        private System.Windows.Forms.TextBox txtEmpLN;
        private System.Windows.Forms.TextBox txtEmpFN;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.GroupBox grbInsRef;
        private System.Windows.Forms.TextBox txtRefMail;
        private System.Windows.Forms.TextBox txtRefPos;
        private System.Windows.Forms.TextBox txtRefLN;
        private System.Windows.Forms.TextBox txtRefFN;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnSuRef;
        private System.Windows.Forms.Label lblAddRef;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnsubSkill;
        private System.Windows.Forms.Button btnSubInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.TextBox txtBrief;
        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Label lblNameSkill;
        private System.Windows.Forms.Label lblNewSkill;
        private System.Windows.Forms.TextBox txtRefAlias;
        private System.Windows.Forms.Label lblRefAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BriefDescription;
        private System.Windows.Forms.Button btnRefEmp;
        private System.Windows.Forms.Button btnRefSkill;
        private System.Windows.Forms.ToolTip ttipRefreshE;
    }
}

