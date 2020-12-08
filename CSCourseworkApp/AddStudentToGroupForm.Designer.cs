
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current groups:";
            // 
            // currentGroupsListBox
            // 
            this.currentGroupsListBox.FormattingEnabled = true;
            this.currentGroupsListBox.Location = new System.Drawing.Point(15, 28);
            this.currentGroupsListBox.Name = "currentGroupsListBox";
            this.currentGroupsListBox.Size = new System.Drawing.Size(235, 134);
            this.currentGroupsListBox.TabIndex = 1;
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Location = new System.Drawing.Point(15, 169);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(235, 23);
            this.removeGroupButton.TabIndex = 2;
            this.removeGroupButton.Text = "Remove selected group";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            // 
            // availableGroupsListBox
            // 
            this.availableGroupsListBox.FormattingEnabled = true;
            this.availableGroupsListBox.Location = new System.Drawing.Point(15, 223);
            this.availableGroupsListBox.Name = "availableGroupsListBox";
            this.availableGroupsListBox.Size = new System.Drawing.Size(235, 134);
            this.availableGroupsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available groups:";
            // 
            // addToGroupsButton
            // 
            this.addToGroupsButton.Location = new System.Drawing.Point(15, 363);
            this.addToGroupsButton.Name = "addToGroupsButton";
            this.addToGroupsButton.Size = new System.Drawing.Size(235, 23);
            this.addToGroupsButton.TabIndex = 5;
            this.addToGroupsButton.Text = "Add to student groups";
            this.addToGroupsButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 412);
            this.ControlBox = false;
            this.Controls.Add(this.addToGroupsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableGroupsListBox);
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
        private System.Windows.Forms.ListBox availableGroupsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToGroupsButton;
    }
}