
namespace CSCourseworkApp
{
    partial class EditResultsForm
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
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsComboBox = new System.Windows.Forms.ComboBox();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.assignmentsBox = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(12, 9);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(93, 13);
            this.assignmentLabel.TabIndex = 0;
            this.assignmentLabel.Text = "Assignment name:";
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(15, 58);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(138, 199);
            this.studentsListBox.TabIndex = 2;
            this.studentsListBox.SelectedIndexChanged += new System.EventHandler(this.studentsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students:";
            // 
            // resultsComboBox
            // 
            this.resultsComboBox.FormattingEnabled = true;
            this.resultsComboBox.Location = new System.Drawing.Point(159, 175);
            this.resultsComboBox.Name = "resultsComboBox";
            this.resultsComboBox.Size = new System.Drawing.Size(108, 21);
            this.resultsComboBox.TabIndex = 4;
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(159, 205);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(108, 23);
            this.saveResultButton.TabIndex = 5;
            this.saveResultButton.Text = "Save result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // assignmentsBox
            // 
            this.assignmentsBox.FormattingEnabled = true;
            this.assignmentsBox.Location = new System.Drawing.Point(111, 6);
            this.assignmentsBox.Name = "assignmentsBox";
            this.assignmentsBox.Size = new System.Drawing.Size(154, 21);
            this.assignmentsBox.TabIndex = 6;
            this.assignmentsBox.SelectedIndexChanged += new System.EventHandler(this.assignmentsBox_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(156, 159);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(40, 13);
            this.Result.TabIndex = 7;
            this.Result.Text = "Result:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EditResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 266);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.assignmentsBox);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.resultsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.assignmentLabel);
            this.Name = "EditResultsForm";
            this.Text = "Add Assignment/Test";
            this.Load += new System.EventHandler(this.EditResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox resultsComboBox;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.ComboBox assignmentsBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button exitButton;
    }
}