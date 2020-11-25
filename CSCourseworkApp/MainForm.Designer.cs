
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
            this.label4 = new System.Windows.Forms.Label();
            this.academicYearLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectedGroupLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.manageStaffPanel = new System.Windows.Forms.Panel();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.adminPanel.SuspendLayout();
            this.manageGroupsPanel.SuspendLayout();
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
            this.adminStudentsButton.Location = new System.Drawing.Point(11, 140);
            this.adminStudentsButton.Name = "adminStudentsButton";
            this.adminStudentsButton.Size = new System.Drawing.Size(182, 44);
            this.adminStudentsButton.TabIndex = 5;
            this.adminStudentsButton.Text = "Manage Students";
            this.adminStudentsButton.UseVisualStyleBackColor = true;
            this.adminStudentsButton.Click += new System.EventHandler(this.adminStudentsButton_Click);
            // 
            // adminStaffButton
            // 
            this.adminStaffButton.Location = new System.Drawing.Point(11, 90);
            this.adminStaffButton.Name = "adminStaffButton";
            this.adminStaffButton.Size = new System.Drawing.Size(182, 44);
            this.adminStaffButton.TabIndex = 2;
            this.adminStaffButton.Text = "Manage Staff";
            this.adminStaffButton.UseVisualStyleBackColor = true;
            this.adminStaffButton.Click += new System.EventHandler(this.adminStaffButton_Click);
            // 
            // adminGroupsButton
            // 
            this.adminGroupsButton.Location = new System.Drawing.Point(11, 40);
            this.adminGroupsButton.Name = "adminGroupsButton";
            this.adminGroupsButton.Size = new System.Drawing.Size(182, 44);
            this.adminGroupsButton.TabIndex = 1;
            this.adminGroupsButton.Text = "Manage Groups";
            this.adminGroupsButton.UseVisualStyleBackColor = true;
            this.adminGroupsButton.Click += new System.EventHandler(this.manageGroupsButton_Click);
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
            this.manageGroupsPanel.Controls.Add(this.label4);
            this.manageGroupsPanel.Controls.Add(this.academicYearLabel);
            this.manageGroupsPanel.Controls.Add(this.button3);
            this.manageGroupsPanel.Controls.Add(this.button2);
            this.manageGroupsPanel.Controls.Add(this.button1);
            this.manageGroupsPanel.Controls.Add(this.selectedGroupLabel);
            this.manageGroupsPanel.Controls.Add(this.label2);
            this.manageGroupsPanel.Controls.Add(this.groupsListBox);
            this.manageGroupsPanel.Location = new System.Drawing.Point(227, 12);
            this.manageGroupsPanel.Name = "manageGroupsPanel";
            this.manageGroupsPanel.Size = new System.Drawing.Size(585, 426);
            this.manageGroupsPanel.TabIndex = 1;
            this.manageGroupsPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned lecturer(s):";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit class";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add new class";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(270, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Class";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // selectedGroupLabel
            // 
            this.selectedGroupLabel.AutoSize = true;
            this.selectedGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGroupLabel.Location = new System.Drawing.Point(265, 40);
            this.selectedGroupLabel.Name = "selectedGroupLabel";
            this.selectedGroupLabel.Size = new System.Drawing.Size(178, 25);
            this.selectedGroupLabel.TabIndex = 2;
            this.selectedGroupLabel.Text = "(Selected Group)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Groups";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 20;
            this.groupsListBox.Location = new System.Drawing.Point(5, 40);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(254, 384);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedValueChanged += new System.EventHandler(this.groupsListBox_SelectedValueChanged);
            // 
            // manageStaffPanel
            // 
            this.manageStaffPanel.Controls.Add(this.staffListBox);
            this.manageStaffPanel.Location = new System.Drawing.Point(227, 12);
            this.manageStaffPanel.Name = "manageStaffPanel";
            this.manageStaffPanel.Size = new System.Drawing.Size(585, 426);
            this.manageStaffPanel.TabIndex = 5;
            this.manageStaffPanel.Visible = false;
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.ItemHeight = 20;
            this.staffListBox.Location = new System.Drawing.Point(0, 0);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(254, 384);
            this.staffListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.manageGroupsPanel);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.manageStaffPanel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.manageGroupsPanel.ResumeLayout(false);
            this.manageGroupsPanel.PerformLayout();
            this.manageStaffPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel manageStaffPanel;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Button adminStudentsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label academicYearLabel;
    }
}