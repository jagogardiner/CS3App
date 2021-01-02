
namespace CSCourseworkApp
{
    partial class AdminForm
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.manageSubjectsButton = new System.Windows.Forms.Button();
            this.adminStudentsButton = new System.Windows.Forms.Button();
            this.adminStaffButton = new System.Windows.Forms.Button();
            this.adminGroupsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manageGroupsPanel = new System.Windows.Forms.Panel();
            this.SubjectNameLabel = new System.Windows.Forms.Label();
            this.staffListLabel = new System.Windows.Forms.Label();
            this.academicYearLabel = new System.Windows.Forms.Label();
            this.editClassButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.selectedGroupLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.manageStudentsPanel = new System.Windows.Forms.Panel();
            this.stuAcademicYearLabel = new System.Windows.Forms.Label();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.selectedStudentLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.manageStaffPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.editStaffInfoButton = new System.Windows.Forms.Button();
            this.addStaffMemberButton = new System.Windows.Forms.Button();
            this.deleteStaffButton = new System.Windows.Forms.Button();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.manageSubjectsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addNewSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.backToOverseerButton = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.manageGroupsPanel.SuspendLayout();
            this.manageStudentsPanel.SuspendLayout();
            this.manageStaffPanel.SuspendLayout();
            this.manageSubjectsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.backToOverseerButton);
            this.adminPanel.Controls.Add(this.manageSubjectsButton);
            this.adminPanel.Controls.Add(this.adminStudentsButton);
            this.adminPanel.Controls.Add(this.adminStaffButton);
            this.adminPanel.Controls.Add(this.adminGroupsButton);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Location = new System.Drawing.Point(8, 8);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(139, 277);
            this.adminPanel.TabIndex = 0;
            // 
            // manageSubjectsButton
            // 
            this.manageSubjectsButton.Location = new System.Drawing.Point(7, 123);
            this.manageSubjectsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageSubjectsButton.Name = "manageSubjectsButton";
            this.manageSubjectsButton.Size = new System.Drawing.Size(121, 29);
            this.manageSubjectsButton.TabIndex = 6;
            this.manageSubjectsButton.Text = "Manage Subjects";
            this.manageSubjectsButton.UseVisualStyleBackColor = true;
            this.manageSubjectsButton.Click += new System.EventHandler(this.manageSubjectsButton_Click);
            // 
            // adminStudentsButton
            // 
            this.adminStudentsButton.Location = new System.Drawing.Point(7, 91);
            this.adminStudentsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminStudentsButton.Name = "adminStudentsButton";
            this.adminStudentsButton.Size = new System.Drawing.Size(121, 29);
            this.adminStudentsButton.TabIndex = 5;
            this.adminStudentsButton.Text = "Manage Students";
            this.adminStudentsButton.UseVisualStyleBackColor = true;
            this.adminStudentsButton.Click += new System.EventHandler(this.AdminStudentsButton_Click);
            // 
            // adminStaffButton
            // 
            this.adminStaffButton.Location = new System.Drawing.Point(7, 58);
            this.adminStaffButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminStaffButton.Name = "adminStaffButton";
            this.adminStaffButton.Size = new System.Drawing.Size(121, 29);
            this.adminStaffButton.TabIndex = 2;
            this.adminStaffButton.Text = "Manage Staff";
            this.adminStaffButton.UseVisualStyleBackColor = true;
            this.adminStaffButton.Click += new System.EventHandler(this.AdminStaffButton_Click);
            // 
            // adminGroupsButton
            // 
            this.adminGroupsButton.Location = new System.Drawing.Point(7, 26);
            this.adminGroupsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminGroupsButton.Name = "adminGroupsButton";
            this.adminGroupsButton.Size = new System.Drawing.Size(121, 29);
            this.adminGroupsButton.TabIndex = 1;
            this.adminGroupsButton.Text = "Manage Groups";
            this.adminGroupsButton.UseVisualStyleBackColor = true;
            this.adminGroupsButton.Click += new System.EventHandler(this.ManageGroupsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // manageGroupsPanel
            // 
            this.manageGroupsPanel.Controls.Add(this.SubjectNameLabel);
            this.manageGroupsPanel.Controls.Add(this.staffListLabel);
            this.manageGroupsPanel.Controls.Add(this.academicYearLabel);
            this.manageGroupsPanel.Controls.Add(this.editClassButton);
            this.manageGroupsPanel.Controls.Add(this.addGroupButton);
            this.manageGroupsPanel.Controls.Add(this.deleteClassButton);
            this.manageGroupsPanel.Controls.Add(this.selectedGroupLabel);
            this.manageGroupsPanel.Controls.Add(this.label2);
            this.manageGroupsPanel.Controls.Add(this.groupsListBox);
            this.manageGroupsPanel.Location = new System.Drawing.Point(151, 8);
            this.manageGroupsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageGroupsPanel.Name = "manageGroupsPanel";
            this.manageGroupsPanel.Size = new System.Drawing.Size(390, 277);
            this.manageGroupsPanel.TabIndex = 1;
            this.manageGroupsPanel.Visible = false;
            // 
            // SubjectNameLabel
            // 
            this.SubjectNameLabel.AutoSize = true;
            this.SubjectNameLabel.Location = new System.Drawing.Point(180, 123);
            this.SubjectNameLabel.Name = "SubjectNameLabel";
            this.SubjectNameLabel.Size = new System.Drawing.Size(49, 13);
            this.SubjectNameLabel.TabIndex = 10;
            this.SubjectNameLabel.Text = "Subject: ";
            // 
            // staffListLabel
            // 
            this.staffListLabel.AutoSize = true;
            this.staffListLabel.Location = new System.Drawing.Point(180, 60);
            this.staffListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffListLabel.Name = "staffListLabel";
            this.staffListLabel.Size = new System.Drawing.Size(102, 13);
            this.staffListLabel.TabIndex = 9;
            this.staffListLabel.Text = "Assigned lecturer(s):";
            // 
            // academicYearLabel
            // 
            this.academicYearLabel.AutoSize = true;
            this.academicYearLabel.Location = new System.Drawing.Point(180, 45);
            this.academicYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.academicYearLabel.Name = "academicYearLabel";
            this.academicYearLabel.Size = new System.Drawing.Size(85, 13);
            this.academicYearLabel.TabIndex = 8;
            this.academicYearLabel.Text = "Academic Year: ";
            // 
            // editClassButton
            // 
            this.editClassButton.Location = new System.Drawing.Point(183, 140);
            this.editClassButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editClassButton.Name = "editClassButton";
            this.editClassButton.Size = new System.Drawing.Size(121, 29);
            this.editClassButton.TabIndex = 7;
            this.editClassButton.Text = "Edit group";
            this.editClassButton.UseVisualStyleBackColor = true;
            this.editClassButton.Visible = false;
            this.editClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(267, 246);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(121, 29);
            this.addGroupButton.TabIndex = 6;
            this.addGroupButton.Text = "Add new group";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteClassButton.Location = new System.Drawing.Point(183, 172);
            this.deleteClassButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(121, 29);
            this.deleteClassButton.TabIndex = 5;
            this.deleteClassButton.Text = "Delete group";
            this.deleteClassButton.UseVisualStyleBackColor = false;
            this.deleteClassButton.Visible = false;
            this.deleteClassButton.Click += new System.EventHandler(this.deleteClassButton_Click);
            // 
            // selectedGroupLabel
            // 
            this.selectedGroupLabel.AutoSize = true;
            this.selectedGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGroupLabel.Location = new System.Drawing.Point(180, 26);
            this.selectedGroupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedGroupLabel.Name = "selectedGroupLabel";
            this.selectedGroupLabel.Size = new System.Drawing.Size(110, 16);
            this.selectedGroupLabel.TabIndex = 2;
            this.selectedGroupLabel.Text = "(Selected Group)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Groups";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(3, 26);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(171, 251);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedValueChanged += new System.EventHandler(this.GroupsListBox_SelectedValueChanged);
            // 
            // manageStudentsPanel
            // 
            this.manageStudentsPanel.Controls.Add(this.stuAcademicYearLabel);
            this.manageStudentsPanel.Controls.Add(this.editStudentButton);
            this.manageStudentsPanel.Controls.Add(this.addStudentButton);
            this.manageStudentsPanel.Controls.Add(this.deleteStudentButton);
            this.manageStudentsPanel.Controls.Add(this.selectedStudentLabel);
            this.manageStudentsPanel.Controls.Add(this.label6);
            this.manageStudentsPanel.Controls.Add(this.studentsListBox);
            this.manageStudentsPanel.Location = new System.Drawing.Point(151, 8);
            this.manageStudentsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageStudentsPanel.Name = "manageStudentsPanel";
            this.manageStudentsPanel.Size = new System.Drawing.Size(390, 277);
            this.manageStudentsPanel.TabIndex = 10;
            this.manageStudentsPanel.Visible = false;
            // 
            // stuAcademicYearLabel
            // 
            this.stuAcademicYearLabel.AutoSize = true;
            this.stuAcademicYearLabel.Location = new System.Drawing.Point(180, 45);
            this.stuAcademicYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stuAcademicYearLabel.Name = "stuAcademicYearLabel";
            this.stuAcademicYearLabel.Size = new System.Drawing.Size(85, 13);
            this.stuAcademicYearLabel.TabIndex = 8;
            this.stuAcademicYearLabel.Text = "Academic Year: ";
            // 
            // editStudentButton
            // 
            this.editStudentButton.Location = new System.Drawing.Point(180, 107);
            this.editStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(121, 29);
            this.editStudentButton.TabIndex = 7;
            this.editStudentButton.Text = "Edit information";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(267, 246);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(121, 29);
            this.addStudentButton.TabIndex = 6;
            this.addStudentButton.Text = "Add new student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteStudentButton.Location = new System.Drawing.Point(180, 139);
            this.deleteStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(121, 29);
            this.deleteStudentButton.TabIndex = 5;
            this.deleteStudentButton.Text = "Delete student";
            this.deleteStudentButton.UseVisualStyleBackColor = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // selectedStudentLabel
            // 
            this.selectedStudentLabel.AutoSize = true;
            this.selectedStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudentLabel.Location = new System.Drawing.Point(179, 26);
            this.selectedStudentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedStudentLabel.Name = "selectedStudentLabel";
            this.selectedStudentLabel.Size = new System.Drawing.Size(118, 16);
            this.selectedStudentLabel.TabIndex = 2;
            this.selectedStudentLabel.Text = "(Selected Student)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Students";
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(3, 26);
            this.studentsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(171, 251);
            this.studentsListBox.TabIndex = 0;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            // 
            // manageStaffPanel
            // 
            this.manageStaffPanel.Controls.Add(this.label7);
            this.manageStaffPanel.Controls.Add(this.editStaffInfoButton);
            this.manageStaffPanel.Controls.Add(this.addStaffMemberButton);
            this.manageStaffPanel.Controls.Add(this.deleteStaffButton);
            this.manageStaffPanel.Controls.Add(this.staffNameLabel);
            this.manageStaffPanel.Controls.Add(this.label10);
            this.manageStaffPanel.Controls.Add(this.staffListBox);
            this.manageStaffPanel.Location = new System.Drawing.Point(151, 8);
            this.manageStaffPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageStaffPanel.Name = "manageStaffPanel";
            this.manageStaffPanel.Size = new System.Drawing.Size(390, 277);
            this.manageStaffPanel.TabIndex = 10;
            this.manageStaffPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Information to be filled in";
            // 
            // editStaffInfoButton
            // 
            this.editStaffInfoButton.Location = new System.Drawing.Point(183, 152);
            this.editStaffInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editStaffInfoButton.Name = "editStaffInfoButton";
            this.editStaffInfoButton.Size = new System.Drawing.Size(121, 29);
            this.editStaffInfoButton.TabIndex = 7;
            this.editStaffInfoButton.Text = "Edit information";
            this.editStaffInfoButton.UseVisualStyleBackColor = true;
            this.editStaffInfoButton.Click += new System.EventHandler(this.editStaffInfoButton_Click);
            // 
            // addStaffMemberButton
            // 
            this.addStaffMemberButton.Location = new System.Drawing.Point(267, 246);
            this.addStaffMemberButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStaffMemberButton.Name = "addStaffMemberButton";
            this.addStaffMemberButton.Size = new System.Drawing.Size(121, 29);
            this.addStaffMemberButton.TabIndex = 6;
            this.addStaffMemberButton.Text = "Add new staff member";
            this.addStaffMemberButton.UseVisualStyleBackColor = true;
            this.addStaffMemberButton.Click += new System.EventHandler(this.addStaffMemberButton_Click);
            // 
            // deleteStaffButton
            // 
            this.deleteStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteStaffButton.Location = new System.Drawing.Point(183, 184);
            this.deleteStaffButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteStaffButton.Name = "deleteStaffButton";
            this.deleteStaffButton.Size = new System.Drawing.Size(121, 29);
            this.deleteStaffButton.TabIndex = 5;
            this.deleteStaffButton.Text = "Delete staff user";
            this.deleteStaffButton.UseVisualStyleBackColor = false;
            this.deleteStaffButton.Click += new System.EventHandler(this.deleteStaffButton_Click);
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameLabel.Location = new System.Drawing.Point(180, 26);
            this.staffNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(152, 16);
            this.staffNameLabel.TabIndex = 2;
            this.staffNameLabel.Text = "(Selected Staff Member)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Manage Staff";
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.Location = new System.Drawing.Point(3, 26);
            this.staffListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(171, 251);
            this.staffListBox.TabIndex = 0;
            this.staffListBox.SelectedIndexChanged += new System.EventHandler(this.staffListBox_SelectedIndexChanged);
            this.staffListBox.SelectedValueChanged += new System.EventHandler(this.staffListBox_SelectedValueChanged);
            // 
            // manageSubjectsPanel
            // 
            this.manageSubjectsPanel.Controls.Add(this.label3);
            this.manageSubjectsPanel.Controls.Add(this.textBox1);
            this.manageSubjectsPanel.Controls.Add(this.addNewSubjectButton);
            this.manageSubjectsPanel.Controls.Add(this.deleteSubjectButton);
            this.manageSubjectsPanel.Controls.Add(this.label9);
            this.manageSubjectsPanel.Controls.Add(this.subjectsListBox);
            this.manageSubjectsPanel.Location = new System.Drawing.Point(151, 8);
            this.manageSubjectsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageSubjectsPanel.Name = "manageSubjectsPanel";
            this.manageSubjectsPanel.Size = new System.Drawing.Size(390, 277);
            this.manageSubjectsPanel.TabIndex = 11;
            this.manageSubjectsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New subject name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 7;
            // 
            // addNewSubjectButton
            // 
            this.addNewSubjectButton.Location = new System.Drawing.Point(209, 107);
            this.addNewSubjectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewSubjectButton.Name = "addNewSubjectButton";
            this.addNewSubjectButton.Size = new System.Drawing.Size(121, 29);
            this.addNewSubjectButton.TabIndex = 6;
            this.addNewSubjectButton.Text = "Add new subject";
            this.addNewSubjectButton.UseVisualStyleBackColor = true;
            this.addNewSubjectButton.Click += new System.EventHandler(this.addNewSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSubjectButton.Location = new System.Drawing.Point(209, 26);
            this.deleteSubjectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(121, 29);
            this.deleteSubjectButton.TabIndex = 5;
            this.deleteSubjectButton.Text = "Delete subject";
            this.deleteSubjectButton.UseVisualStyleBackColor = false;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Manage Subjects";
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.Location = new System.Drawing.Point(3, 26);
            this.subjectsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(195, 251);
            this.subjectsListBox.TabIndex = 0;
            this.subjectsListBox.SelectedIndexChanged += new System.EventHandler(this.subjectsListBox_SelectedIndexChanged);
            // 
            // backToOverseerButton
            // 
            this.backToOverseerButton.Location = new System.Drawing.Point(7, 222);
            this.backToOverseerButton.Name = "backToOverseerButton";
            this.backToOverseerButton.Size = new System.Drawing.Size(121, 50);
            this.backToOverseerButton.TabIndex = 7;
            this.backToOverseerButton.Text = "Back to Overseer functions";
            this.backToOverseerButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 292);
            this.Controls.Add(this.manageStudentsPanel);
            this.Controls.Add(this.manageGroupsPanel);
            this.Controls.Add(this.manageSubjectsPanel);
            this.Controls.Add(this.manageStaffPanel);
            this.Controls.Add(this.adminPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.manageGroupsPanel.ResumeLayout(false);
            this.manageGroupsPanel.PerformLayout();
            this.manageStudentsPanel.ResumeLayout(false);
            this.manageStudentsPanel.PerformLayout();
            this.manageStaffPanel.ResumeLayout(false);
            this.manageStaffPanel.PerformLayout();
            this.manageSubjectsPanel.ResumeLayout(false);
            this.manageSubjectsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button adminGroupsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminStaffButton;
        private System.Windows.Forms.Panel manageGroupsPanel;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedGroupLabel;
        private System.Windows.Forms.Button deleteClassButton;
        private System.Windows.Forms.Button adminStudentsButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button editClassButton;
        private System.Windows.Forms.Label staffListLabel;
        private System.Windows.Forms.Label academicYearLabel;
        private System.Windows.Forms.Panel manageStudentsPanel;
        private System.Windows.Forms.Label stuAcademicYearLabel;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Label selectedStudentLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Panel manageStaffPanel;
        private System.Windows.Forms.Button editStaffInfoButton;
        private System.Windows.Forms.Button addStaffMemberButton;
        private System.Windows.Forms.Button deleteStaffButton;
        private System.Windows.Forms.Label staffNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Label SubjectNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel manageSubjectsPanel;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.Button addNewSubjectButton;
        private System.Windows.Forms.Button manageSubjectsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backToOverseerButton;
    }
}