
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
            this.availableGroupsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addToGroupsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current groups:";
            // 
            // currentGroupsListBox
            // 
            this.currentGroupsListBox.FormattingEnabled = true;
            this.currentGroupsListBox.ItemHeight = 20;
            this.currentGroupsListBox.Location = new System.Drawing.Point(22, 43);
            this.currentGroupsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentGroupsListBox.Name = "currentGroupsListBox";
            this.currentGroupsListBox.Size = new System.Drawing.Size(350, 204);
            this.currentGroupsListBox.TabIndex = 1;
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Location = new System.Drawing.Point(22, 260);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(352, 35);
            this.removeGroupButton.TabIndex = 2;
            this.removeGroupButton.Text = "Remove selected group";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // availableGroupsListBox
            // 
            this.availableGroupsListBox.FormattingEnabled = true;
            this.availableGroupsListBox.ItemHeight = 20;
            this.availableGroupsListBox.Location = new System.Drawing.Point(22, 343);
            this.availableGroupsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.availableGroupsListBox.Name = "availableGroupsListBox";
            this.availableGroupsListBox.Size = new System.Drawing.Size(350, 204);
            this.availableGroupsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available groups:";
            // 
            // addToGroupsButton
            // 
            this.addToGroupsButton.Location = new System.Drawing.Point(22, 558);
            this.addToGroupsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addToGroupsButton.Name = "addToGroupsButton";
            this.addToGroupsButton.Size = new System.Drawing.Size(352, 35);
            this.addToGroupsButton.TabIndex = 5;
            this.addToGroupsButton.Text = "Add to student groups";
            this.addToGroupsButton.UseVisualStyleBackColor = true;
            this.addToGroupsButton.Click += new System.EventHandler(this.addToGroupsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(20, 601);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(352, 35);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddStudentToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 652);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addToGroupsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableGroupsListBox);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.currentGroupsListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ListBox availableGroupsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToGroupsButton;
        private System.Windows.Forms.Button saveButton;
    }
}