
namespace CSCourseworkApp
{
    partial class EditGroupForm
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
            this.groupTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.academicYearComboBox = new System.Windows.Forms.ComboBox();
            this.lecturerBox = new System.Windows.Forms.ListBox();
            this.addStaffIDButton = new System.Windows.Forms.Button();
            this.removeStaffButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveGroupButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupTitleLabel
            // 
            this.groupTitleLabel.AutoSize = true;
            this.groupTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTitleLabel.Location = new System.Drawing.Point(13, 9);
            this.groupTitleLabel.Name = "groupTitleLabel";
            this.groupTitleLabel.Size = new System.Drawing.Size(86, 20);
            this.groupTitleLabel.TabIndex = 0;
            this.groupTitleLabel.Text = "Edit Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group name:";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(87, 50);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.groupNameTextBox.TabIndex = 3;
            // 
            // academicYearComboBox
            // 
            this.academicYearComboBox.FormattingEnabled = true;
            this.academicYearComboBox.Location = new System.Drawing.Point(101, 91);
            this.academicYearComboBox.Name = "academicYearComboBox";
            this.academicYearComboBox.Size = new System.Drawing.Size(115, 21);
            this.academicYearComboBox.TabIndex = 4;
            // 
            // lecturerBox
            // 
            this.lecturerBox.FormattingEnabled = true;
            this.lecturerBox.Location = new System.Drawing.Point(17, 153);
            this.lecturerBox.Name = "lecturerBox";
            this.lecturerBox.Size = new System.Drawing.Size(255, 173);
            this.lecturerBox.TabIndex = 5;
            // 
            // addStaffIDButton
            // 
            this.addStaffIDButton.Location = new System.Drawing.Point(17, 343);
            this.addStaffIDButton.Name = "addStaffIDButton";
            this.addStaffIDButton.Size = new System.Drawing.Size(121, 39);
            this.addStaffIDButton.TabIndex = 7;
            this.addStaffIDButton.Text = "Add by staff ID";
            this.addStaffIDButton.UseVisualStyleBackColor = true;
            this.addStaffIDButton.Click += new System.EventHandler(this.AddStaffIDButton_Click);
            // 
            // removeStaffButton
            // 
            this.removeStaffButton.Location = new System.Drawing.Point(144, 343);
            this.removeStaffButton.Name = "removeStaffButton";
            this.removeStaffButton.Size = new System.Drawing.Size(128, 39);
            this.removeStaffButton.TabIndex = 8;
            this.removeStaffButton.Text = "Remove";
            this.removeStaffButton.UseVisualStyleBackColor = true;
            this.removeStaffButton.Click += new System.EventHandler(this.RemoveStaffButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lecturers:";
            // 
            // saveGroupButton
            // 
            this.saveGroupButton.Location = new System.Drawing.Point(17, 389);
            this.saveGroupButton.Name = "saveGroupButton";
            this.saveGroupButton.Size = new System.Drawing.Size(255, 30);
            this.saveGroupButton.TabIndex = 10;
            this.saveGroupButton.Text = "Save Group";
            this.saveGroupButton.UseVisualStyleBackColor = true;
            this.saveGroupButton.Click += new System.EventHandler(this.SaveGroupButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 425);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(255, 33);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditGroupForm
            // 
            this.ClientSize = new System.Drawing.Size(285, 470);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.saveGroupButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeStaffButton);
            this.Controls.Add(this.addStaffIDButton);
            this.Controls.Add(this.lecturerBox);
            this.Controls.Add(this.academicYearComboBox);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupTitleLabel);
            this.Name = "EditGroupForm";
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.ComboBox academicYearComboBox;
        private System.Windows.Forms.ListBox lecturerBox;
        private System.Windows.Forms.Button addStaffIDButton;
        private System.Windows.Forms.Button removeStaffButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveGroupButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}
