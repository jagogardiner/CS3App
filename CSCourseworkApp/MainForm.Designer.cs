﻿
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
            this.SubjectNameLabel = new System.Windows.Forms.Label();
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
            this.groupsLabel = new System.Windows.Forms.Label();
            this.editStaffInfoButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteStaffButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.staffListBox = new System.Windows.Forms.ListBox();
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
            this.adminPanel.Location = new System.Drawing.Point(12, 12);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(208, 426);
            this.adminPanel.TabIndex = 0;
            // 
            // adminStudentsButton
            // 
            this.adminStudentsButton.Location = new System.Drawing.Point(10, 140);
            this.adminStudentsButton.Name = "adminStudentsButton";
            this.adminStudentsButton.Size = new System.Drawing.Size(182, 45);
            this.adminStudentsButton.TabIndex = 5;
            this.adminStudentsButton.Text = "Manage Students";
            this.adminStudentsButton.UseVisualStyleBackColor = true;
            this.adminStudentsButton.Click += new System.EventHandler(this.AdminStudentsButton_Click);
            // 
            // adminStaffButton
            // 
            this.adminStaffButton.Location = new System.Drawing.Point(10, 89);
            this.adminStaffButton.Name = "adminStaffButton";
            this.adminStaffButton.Size = new System.Drawing.Size(182, 45);
            this.adminStaffButton.TabIndex = 2;
            this.adminStaffButton.Text = "Manage Staff";
            this.adminStaffButton.UseVisualStyleBackColor = true;
            this.adminStaffButton.Click += new System.EventHandler(this.AdminStaffButton_Click);
            // 
            // adminGroupsButton
            // 
            this.adminGroupsButton.Location = new System.Drawing.Point(10, 40);
            this.adminGroupsButton.Name = "adminGroupsButton";
            this.adminGroupsButton.Size = new System.Drawing.Size(182, 45);
            this.adminGroupsButton.TabIndex = 1;
            this.adminGroupsButton.Text = "Manage Groups";
            this.adminGroupsButton.UseVisualStyleBackColor = true;
            this.adminGroupsButton.Click += new System.EventHandler(this.ManageGroupsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
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
            this.manageGroupsPanel.Location = new System.Drawing.Point(226, 12);
            this.manageGroupsPanel.Name = "manageGroupsPanel";
            this.manageGroupsPanel.Size = new System.Drawing.Size(585, 426);
            this.manageGroupsPanel.TabIndex = 1;
            this.manageGroupsPanel.Visible = false;
            // 
            // SubjectNameLabel
            // 
            this.SubjectNameLabel.AutoSize = true;
            this.SubjectNameLabel.Location = new System.Drawing.Point(270, 189);
            this.SubjectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectNameLabel.Name = "SubjectNameLabel";
            this.SubjectNameLabel.Size = new System.Drawing.Size(71, 20);
            this.SubjectNameLabel.TabIndex = 10;
            this.SubjectNameLabel.Text = "Subject: ";
            // 
            // staffListLabel
            // 
            this.staffListLabel.AutoSize = true;
            this.staffListLabel.Location = new System.Drawing.Point(270, 92);
            this.staffListLabel.Name = "staffListLabel";
            this.staffListLabel.Size = new System.Drawing.Size(154, 20);
            this.staffListLabel.TabIndex = 9;
            this.staffListLabel.Text = "Assigned lecturer(s):";
            // 
            // academicYearLabel
            // 
            this.academicYearLabel.AutoSize = true;
            this.academicYearLabel.Location = new System.Drawing.Point(270, 69);
            this.academicYearLabel.Name = "academicYearLabel";
            this.academicYearLabel.Size = new System.Drawing.Size(125, 20);
            this.academicYearLabel.TabIndex = 8;
            this.academicYearLabel.Text = "Academic Year: ";
            // 
            // editClassButton
            // 
            this.editClassButton.Location = new System.Drawing.Point(274, 215);
            this.editClassButton.Name = "editClassButton";
            this.editClassButton.Size = new System.Drawing.Size(182, 45);
            this.editClassButton.TabIndex = 7;
            this.editClassButton.Text = "Edit group";
            this.editClassButton.UseVisualStyleBackColor = true;
            this.editClassButton.Visible = false;
            this.editClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(400, 378);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(182, 45);
            this.addClassButton.TabIndex = 6;
            this.addClassButton.Text = "Add new class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteClassButton.Location = new System.Drawing.Point(274, 265);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(182, 45);
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
            this.selectedGroupLabel.Location = new System.Drawing.Point(270, 40);
            this.selectedGroupLabel.Name = "selectedGroupLabel";
            this.selectedGroupLabel.Size = new System.Drawing.Size(162, 25);
            this.selectedGroupLabel.TabIndex = 2;
            this.selectedGroupLabel.Text = "(Selected Group)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Groups";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 20;
            this.groupsListBox.Location = new System.Drawing.Point(4, 40);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(254, 384);
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
            this.manageStudentsPanel.Location = new System.Drawing.Point(226, 12);
            this.manageStudentsPanel.Name = "manageStudentsPanel";
            this.manageStudentsPanel.Size = new System.Drawing.Size(585, 426);
            this.manageStudentsPanel.TabIndex = 10;
            this.manageStudentsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assigned lecturer(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Academic Year: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit class";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add new class";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(270, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Class";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "(Selected Group)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Groups";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(4, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 384);
            this.listBox1.TabIndex = 0;
            // 
            // manageStaffPanel
            // 
            this.manageStaffPanel.Controls.Add(this.groupsLabel);
            this.manageStaffPanel.Controls.Add(this.editStaffInfoButton);
            this.manageStaffPanel.Controls.Add(this.button5);
            this.manageStaffPanel.Controls.Add(this.deleteStaffButton);
            this.manageStaffPanel.Controls.Add(this.label9);
            this.manageStaffPanel.Controls.Add(this.label10);
            this.manageStaffPanel.Controls.Add(this.staffListBox);
            this.manageStaffPanel.Location = new System.Drawing.Point(226, 12);
            this.manageStaffPanel.Name = "manageStaffPanel";
            this.manageStaffPanel.Size = new System.Drawing.Size(585, 426);
            this.manageStaffPanel.TabIndex = 10;
            this.manageStaffPanel.Visible = false;
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Location = new System.Drawing.Point(272, 69);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(66, 20);
            this.groupsLabel.TabIndex = 8;
            this.groupsLabel.Text = "Groups:";
            this.groupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editStaffInfoButton
            // 
            this.editStaffInfoButton.Location = new System.Drawing.Point(274, 234);
            this.editStaffInfoButton.Name = "editStaffInfoButton";
            this.editStaffInfoButton.Size = new System.Drawing.Size(182, 45);
            this.editStaffInfoButton.TabIndex = 7;
            this.editStaffInfoButton.Text = "Edit information";
            this.editStaffInfoButton.UseVisualStyleBackColor = true;
            this.editStaffInfoButton.Click += new System.EventHandler(this.editStaffInfoButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add new staff member";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // deleteStaffButton
            // 
            this.deleteStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteStaffButton.Location = new System.Drawing.Point(274, 283);
            this.deleteStaffButton.Name = "deleteStaffButton";
            this.deleteStaffButton.Size = new System.Drawing.Size(182, 45);
            this.deleteStaffButton.TabIndex = 5;
            this.deleteStaffButton.Text = "Delete staff user";
            this.deleteStaffButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "(Selected Staff Member)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Manage Staff";
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.ItemHeight = 20;
            this.staffListBox.Location = new System.Drawing.Point(4, 40);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(254, 384);
            this.staffListBox.TabIndex = 0;
            this.staffListBox.SelectedValueChanged += new System.EventHandler(this.staffListBox_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 449);
            this.Controls.Add(this.manageStaffPanel);
            this.Controls.Add(this.manageGroupsPanel);
            this.Controls.Add(this.manageStudentsPanel);
            this.Controls.Add(this.adminPanel);
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
        private System.Windows.Forms.Button editStaffInfoButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deleteStaffButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Label SubjectNameLabel;
        private System.Windows.Forms.Label groupsLabel;
    }
}