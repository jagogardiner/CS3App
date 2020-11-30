
namespace CSCourseworkApp
{
    partial class MainForm
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
            this.adminStudentsButton = new System.Windows.Forms.Button();
            this.adminStaffButton = new System.Windows.Forms.Button();
            this.adminGroupsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manageGroupsPanel = new System.Windows.Forms.Panel();
            this.staffListLabel = new System.Windows.Forms.Label();
            this.academicYearLabel = new System.Windows.Forms.Label();
            this.editClassButton = new System.Windows.Forms.Button();
            this.addClassButton = new System.Windows.Forms.Button();
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.selectedGroupLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.manageStudentsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.manageStaffPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.SubjectNameLabel = new System.Windows.Forms.Label();
            this.adminPanel.SuspendLayout();
            this.manageGroupsPanel.SuspendLayout();
            this.manageStudentsPanel.SuspendLayout();
            this.manageStaffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.adminStudentsButton);
            this.adminPanel.Controls.Add(this.adminStaffButton);
            this.adminPanel.Controls.Add(this.adminGroupsButton);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Location = new System.Drawing.Point(8, 8);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(139, 277);
            this.adminPanel.TabIndex = 0;
            // 
            // adminStudentsButton
            // 
            this.adminStudentsButton.Location = new System.Drawing.Point(7, 91);
            this.adminStudentsButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.adminStaffButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.adminGroupsButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.manageGroupsPanel.Controls.Add(this.addClassButton);
            this.manageGroupsPanel.Controls.Add(this.deleteClassButton);
            this.manageGroupsPanel.Controls.Add(this.selectedGroupLabel);
            this.manageGroupsPanel.Controls.Add(this.label2);
            this.manageGroupsPanel.Controls.Add(this.groupsListBox);
            this.manageGroupsPanel.Location = new System.Drawing.Point(151, 8);
            this.manageGroupsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.manageGroupsPanel.Name = "manageGroupsPanel";
            this.manageGroupsPanel.Size = new System.Drawing.Size(390, 277);
            this.manageGroupsPanel.TabIndex = 1;
            this.manageGroupsPanel.Visible = false;
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
            this.editClassButton.Margin = new System.Windows.Forms.Padding(2);
            this.editClassButton.Name = "editClassButton";
            this.editClassButton.Size = new System.Drawing.Size(121, 29);
            this.editClassButton.TabIndex = 7;
            this.editClassButton.Text = "Edit group";
            this.editClassButton.UseVisualStyleBackColor = true;
            this.editClassButton.Visible = false;
            this.editClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(267, 246);
            this.addClassButton.Margin = new System.Windows.Forms.Padding(2);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(121, 29);
            this.addClassButton.TabIndex = 6;
            this.addClassButton.Text = "Add new class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteClassButton.Location = new System.Drawing.Point(183, 172);
            this.deleteClassButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(121, 29);
            this.deleteClassButton.TabIndex = 5;
            this.deleteClassButton.Text = "Delete group";
            this.deleteClassButton.UseVisualStyleBackColor = false;
            this.deleteClassButton.Visible = false;
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
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(171, 251);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedValueChanged += new System.EventHandler(this.GroupsListBox_SelectedValueChanged);
            // 
            // manageStudentsPanel
            // 
            this.manageStudentsPanel.Controls.Add(this.label3);
            this.manageStudentsPanel.Controls.Add(this.label4);
            this.manageStudentsPanel.Controls.Add(this.button1);
            this.manageStudentsPanel.Controls.Add(this.button2);
            this.manageStudentsPanel.Controls.Add(this.button3);
            this.manageStudentsPanel.Controls.Add(this.label5);
            this.manageStudentsPanel.Controls.Add(this.label6);
            this.manageStudentsPanel.Controls.Add(this.listBox1);
            this.manageStudentsPanel.Location = new System.Drawing.Point(151, 8);
            this.manageStudentsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.manageStudentsPanel.Name = "manageStudentsPanel";
            this.manageStudentsPanel.Size = new System.Drawing.Size(390, 277);
            this.manageStudentsPanel.TabIndex = 10;
            this.manageStudentsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assigned lecturer(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Academic Year: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit class";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add new class";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(180, 139);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Class";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "(Selected Group)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Groups";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 26);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 251);
            this.listBox1.TabIndex = 0;
            // 
            // manageStaffPanel
            // 
            this.manageStaffPanel.Controls.Add(this.label7);
            this.manageStaffPanel.Controls.Add(this.label8);
            this.manageStaffPanel.Controls.Add(this.button4);
            this.manageStaffPanel.Controls.Add(this.button5);
            this.manageStaffPanel.Controls.Add(this.button6);
            this.manageStaffPanel.Controls.Add(this.label9);
            this.manageStaffPanel.Controls.Add(this.label10);
            this.manageStaffPanel.Controls.Add(this.staffListBox);
            this.manageStaffPanel.Location = new System.Drawing.Point(151, 8);
            this.manageStaffPanel.Margin = new System.Windows.Forms.Padding(2);
            this.manageStaffPanel.Name = "manageStaffPanel";
            this.manageStaffPanel.Size = new System.Drawing.Size(390, 277);
            this.manageStaffPanel.TabIndex = 10;
            this.manageStaffPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Assigned lecturer(s):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Academic Year: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 107);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit information";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add new staff member";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(180, 139);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete staff user";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "(Selected Group)";
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
            this.staffListBox.Margin = new System.Windows.Forms.Padding(2);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(171, 251);
            this.staffListBox.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 292);
            this.Controls.Add(this.manageGroupsPanel);
            this.Controls.Add(this.manageStudentsPanel);
            this.Controls.Add(this.manageStaffPanel);
            this.Controls.Add(this.adminPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.manageGroupsPanel.ResumeLayout(false);
            this.manageGroupsPanel.PerformLayout();
            this.manageStudentsPanel.ResumeLayout(false);
            this.manageStudentsPanel.PerformLayout();
            this.manageStaffPanel.ResumeLayout(false);
            this.manageStaffPanel.PerformLayout();
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
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button editClassButton;
        private System.Windows.Forms.Label staffListLabel;
        private System.Windows.Forms.Label academicYearLabel;
        private System.Windows.Forms.Panel manageStudentsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel manageStaffPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Label SubjectNameLabel;
    }
}