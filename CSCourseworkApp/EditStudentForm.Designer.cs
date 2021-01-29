
namespace CSCourseworkApp
{
    partial class EditStudentForm
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
            this.editStudentTitleLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.academicYearComboBox = new System.Windows.Forms.ComboBox();
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editGroupsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editStudentTitleLabel
            // 
            this.editStudentTitleLabel.AutoSize = true;
            this.editStudentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentTitleLabel.Location = new System.Drawing.Point(8, 11);
            this.editStudentTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editStudentTitleLabel.Name = "editStudentTitleLabel";
            this.editStudentTitleLabel.Size = new System.Drawing.Size(87, 18);
            this.editStudentTitleLabel.TabIndex = 0;
            this.editStudentTitleLabel.Text = "Edit Student";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(11, 54);
            this.studentNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(11, 94);
            this.studentIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.studentIDTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Academic Year";
            // 
            // academicYearComboBox
            // 
            this.academicYearComboBox.FormattingEnabled = true;
            this.academicYearComboBox.Location = new System.Drawing.Point(11, 138);
            this.academicYearComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.academicYearComboBox.Name = "academicYearComboBox";
            this.academicYearComboBox.Size = new System.Drawing.Size(146, 21);
            this.academicYearComboBox.TabIndex = 6;
            // 
            // GroupListBox
            // 
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Location = new System.Drawing.Point(11, 185);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(141, 108);
            this.GroupListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Groups";
            // 
            // editGroupsButton
            // 
            this.editGroupsButton.Location = new System.Drawing.Point(11, 300);
            this.editGroupsButton.Name = "editGroupsButton";
            this.editGroupsButton.Size = new System.Drawing.Size(141, 23);
            this.editGroupsButton.TabIndex = 9;
            this.editGroupsButton.Text = "Edit Groups";
            this.editGroupsButton.UseVisualStyleBackColor = true;
            this.editGroupsButton.Click += new System.EventHandler(this.editGroupsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 342);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(141, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(11, 371);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 402);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editGroupsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GroupListBox);
            this.Controls.Add(this.academicYearComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.editStudentTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditStudentForm";
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editStudentTitleLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox academicYearComboBox;
        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editGroupsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}