
namespace CSCourseworkApp
{
    partial class TeacherMainForm
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
            this.teacherOverviewLabel = new System.Windows.Forms.Label();
            this.teacherClassListBox = new System.Windows.Forms.ListBox();
            this.subjectPanel = new System.Windows.Forms.Panel();
            this.predictedGradeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtgLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.testsAverageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeworkAverageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.addAssignmentButton = new System.Windows.Forms.Button();
            this.addTestResultButton = new System.Windows.Forms.Button();
            this.editAssignmentsButton = new System.Windows.Forms.Button();
            this.editTestResultsButton = new System.Windows.Forms.Button();
            this.subjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherOverviewLabel
            // 
            this.teacherOverviewLabel.AutoSize = true;
            this.teacherOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherOverviewLabel.Location = new System.Drawing.Point(11, 5);
            this.teacherOverviewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherOverviewLabel.Name = "teacherOverviewLabel";
            this.teacherOverviewLabel.Size = new System.Drawing.Size(147, 20);
            this.teacherOverviewLabel.TabIndex = 0;
            this.teacherOverviewLabel.Text = "Teacher Overview | ";
            // 
            // teacherClassListBox
            // 
            this.teacherClassListBox.FormattingEnabled = true;
            this.teacherClassListBox.Location = new System.Drawing.Point(15, 30);
            this.teacherClassListBox.Name = "teacherClassListBox";
            this.teacherClassListBox.Size = new System.Drawing.Size(143, 303);
            this.teacherClassListBox.TabIndex = 1;
            this.teacherClassListBox.SelectedIndexChanged += new System.EventHandler(this.teacherClassListBox_SelectedIndexChanged);
            // 
            // subjectPanel
            // 
            this.subjectPanel.Controls.Add(this.predictedGradeLabel);
            this.subjectPanel.Controls.Add(this.label7);
            this.subjectPanel.Controls.Add(this.mtgLabel);
            this.subjectPanel.Controls.Add(this.label5);
            this.subjectPanel.Controls.Add(this.testsAverageLabel);
            this.subjectPanel.Controls.Add(this.label3);
            this.subjectPanel.Controls.Add(this.homeworkAverageLabel);
            this.subjectPanel.Controls.Add(this.label1);
            this.subjectPanel.Location = new System.Drawing.Point(394, 30);
            this.subjectPanel.Name = "subjectPanel";
            this.subjectPanel.Size = new System.Drawing.Size(135, 303);
            this.subjectPanel.TabIndex = 2;
            // 
            // predictedGradeLabel
            // 
            this.predictedGradeLabel.AutoSize = true;
            this.predictedGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedGradeLabel.Location = new System.Drawing.Point(54, 212);
            this.predictedGradeLabel.Name = "predictedGradeLabel";
            this.predictedGradeLabel.Size = new System.Drawing.Size(26, 25);
            this.predictedGradeLabel.TabIndex = 7;
            this.predictedGradeLabel.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Predicted Grade";
            // 
            // mtgLabel
            // 
            this.mtgLabel.AutoSize = true;
            this.mtgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtgLabel.Location = new System.Drawing.Point(55, 141);
            this.mtgLabel.Name = "mtgLabel";
            this.mtgLabel.Size = new System.Drawing.Size(23, 24);
            this.mtgLabel.TabIndex = 5;
            this.mtgLabel.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minimum Target Grade";
            // 
            // testsAverageLabel
            // 
            this.testsAverageLabel.AutoSize = true;
            this.testsAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsAverageLabel.Location = new System.Drawing.Point(55, 83);
            this.testsAverageLabel.Name = "testsAverageLabel";
            this.testsAverageLabel.Size = new System.Drawing.Size(23, 24);
            this.testsAverageLabel.TabIndex = 3;
            this.testsAverageLabel.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tests Average";
            // 
            // homeworkAverageLabel
            // 
            this.homeworkAverageLabel.AutoSize = true;
            this.homeworkAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeworkAverageLabel.Location = new System.Drawing.Point(55, 25);
            this.homeworkAverageLabel.Name = "homeworkAverageLabel";
            this.homeworkAverageLabel.Size = new System.Drawing.Size(23, 24);
            this.homeworkAverageLabel.TabIndex = 1;
            this.homeworkAverageLabel.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Homework Average";
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(265, 30);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(123, 303);
            this.StudentsListBox.TabIndex = 3;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // addAssignmentButton
            // 
            this.addAssignmentButton.Location = new System.Drawing.Point(164, 30);
            this.addAssignmentButton.Name = "addAssignmentButton";
            this.addAssignmentButton.Size = new System.Drawing.Size(94, 23);
            this.addAssignmentButton.TabIndex = 4;
            this.addAssignmentButton.Text = "Add assignment";
            this.addAssignmentButton.UseVisualStyleBackColor = true;
            this.addAssignmentButton.Click += new System.EventHandler(this.addAssignmentButton_Click);
            // 
            // addTestResultButton
            // 
            this.addTestResultButton.Location = new System.Drawing.Point(164, 60);
            this.addTestResultButton.Name = "addTestResultButton";
            this.addTestResultButton.Size = new System.Drawing.Size(94, 23);
            this.addTestResultButton.TabIndex = 5;
            this.addTestResultButton.Text = "Add test result";
            this.addTestResultButton.UseVisualStyleBackColor = true;
            this.addTestResultButton.Click += new System.EventHandler(this.addTestResultButton_Click);
            // 
            // editAssignmentsButton
            // 
            this.editAssignmentsButton.Location = new System.Drawing.Point(164, 90);
            this.editAssignmentsButton.Name = "editAssignmentsButton";
            this.editAssignmentsButton.Size = new System.Drawing.Size(94, 23);
            this.editAssignmentsButton.TabIndex = 6;
            this.editAssignmentsButton.Text = "Edit assignments";
            this.editAssignmentsButton.UseVisualStyleBackColor = true;
            this.editAssignmentsButton.Click += new System.EventHandler(this.editAssignmentsButton_Click);
            // 
            // editTestResultsButton
            // 
            this.editTestResultsButton.Location = new System.Drawing.Point(164, 120);
            this.editTestResultsButton.Name = "editTestResultsButton";
            this.editTestResultsButton.Size = new System.Drawing.Size(94, 23);
            this.editTestResultsButton.TabIndex = 7;
            this.editTestResultsButton.Text = "Edit tests";
            this.editTestResultsButton.UseVisualStyleBackColor = true;
            this.editTestResultsButton.Click += new System.EventHandler(this.editTestResultsButton_Click);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 341);
            this.Controls.Add(this.editTestResultsButton);
            this.Controls.Add(this.editAssignmentsButton);
            this.Controls.Add(this.addTestResultButton);
            this.Controls.Add(this.addAssignmentButton);
            this.Controls.Add(this.StudentsListBox);
            this.Controls.Add(this.subjectPanel);
            this.Controls.Add(this.teacherClassListBox);
            this.Controls.Add(this.teacherOverviewLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.subjectPanel.ResumeLayout(false);
            this.subjectPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherOverviewLabel;
        private System.Windows.Forms.ListBox teacherClassListBox;
        private System.Windows.Forms.Panel subjectPanel;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Button addAssignmentButton;
        private System.Windows.Forms.Button addTestResultButton;
        private System.Windows.Forms.Button editAssignmentsButton;
        private System.Windows.Forms.Button editTestResultsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label homeworkAverageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testsAverageLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mtgLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label predictedGradeLabel;
    }
}