
namespace CSCourseworkApp
{
    partial class AddStudentToGroupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentGroupsListBox = new System.Windows.Forms.ListBox();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addToGroupsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.availableGroupsListBox = new System.Windows.Forms.ListBox();
            this.mtgComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current groups:";
            // 
            // currentGroupsListBox
            // 
            this.currentGroupsListBox.FormattingEnabled = true;
            this.currentGroupsListBox.Location = new System.Drawing.Point(15, 244);
            this.currentGroupsListBox.Name = "currentGroupsListBox";
            this.currentGroupsListBox.Size = new System.Drawing.Size(235, 134);
            this.currentGroupsListBox.TabIndex = 1;
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Location = new System.Drawing.Point(15, 385);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(235, 23);
            this.removeGroupButton.TabIndex = 2;
            this.removeGroupButton.Text = "Remove selected group";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 412);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(235, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addToGroupsButton
            // 
            this.addToGroupsButton.Location = new System.Drawing.Point(15, 196);
            this.addToGroupsButton.Name = "addToGroupsButton";
            this.addToGroupsButton.Size = new System.Drawing.Size(235, 23);
            this.addToGroupsButton.TabIndex = 9;
            this.addToGroupsButton.Text = "Add to student groups";
            this.addToGroupsButton.UseVisualStyleBackColor = true;
            this.addToGroupsButton.Click += new System.EventHandler(this.addToGroupsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Available groups:";
            // 
            // availableGroupsListBox
            // 
            this.availableGroupsListBox.FormattingEnabled = true;
            this.availableGroupsListBox.Location = new System.Drawing.Point(15, 33);
            this.availableGroupsListBox.Name = "availableGroupsListBox";
            this.availableGroupsListBox.Size = new System.Drawing.Size(235, 134);
            this.availableGroupsListBox.TabIndex = 7;
            // 
            // mtgComboBox
            // 
            this.mtgComboBox.FormattingEnabled = true;
            this.mtgComboBox.Location = new System.Drawing.Point(187, 170);
            this.mtgComboBox.Name = "mtgComboBox";
            this.mtgComboBox.Size = new System.Drawing.Size(63, 21);
            this.mtgComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minimum target grade for subject:";
            // 
            // AddStudentToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtgComboBox);
            this.Controls.Add(this.addToGroupsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableGroupsListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.currentGroupsListBox);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentToGroupForm";
            this.Text = "Edit Groups";
            this.Load += new System.EventHandler(this.AddStudentToGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox currentGroupsListBox;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addToGroupsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox availableGroupsListBox;
        private System.Windows.Forms.ComboBox mtgComboBox;
        private System.Windows.Forms.Label label3;
    }
}