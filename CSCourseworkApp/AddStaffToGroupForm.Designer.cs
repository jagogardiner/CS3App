
namespace CSCourseworkApp
{
    partial class AddStaffToGroupForm
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
            System.Windows.Forms.Button delGroupButton;
            System.Windows.Forms.Button saveButton;
            this.availableGroupsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.selectedGroupsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            delGroupButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delGroupButton
            // 
            delGroupButton.Location = new System.Drawing.Point(11, 337);
            delGroupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            delGroupButton.Name = "delGroupButton";
            delGroupButton.Size = new System.Drawing.Size(188, 26);
            delGroupButton.TabIndex = 5;
            delGroupButton.Text = "Delete from group";
            delGroupButton.UseVisualStyleBackColor = true;
            delGroupButton.Click += new System.EventHandler(this.delGroupButton_Click);
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(11, 367);
            saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(188, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // availableGroupsList
            // 
            this.availableGroupsList.FormattingEnabled = true;
            this.availableGroupsList.Location = new System.Drawing.Point(11, 21);
            this.availableGroupsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.availableGroupsList.Name = "availableGroupsList";
            this.availableGroupsList.Size = new System.Drawing.Size(189, 134);
            this.availableGroupsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available groups:";
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(11, 158);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(188, 26);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Add group";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // selectedGroupsList
            // 
            this.selectedGroupsList.FormattingEnabled = true;
            this.selectedGroupsList.Location = new System.Drawing.Point(11, 201);
            this.selectedGroupsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedGroupsList.Name = "selectedGroupsList";
            this.selectedGroupsList.Size = new System.Drawing.Size(189, 134);
            this.selectedGroupsList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Groups staff member is in:";
            // 
            // AddStaffToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 401);
            this.ControlBox = false;
            this.Controls.Add(saveButton);
            this.Controls.Add(delGroupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedGroupsList);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availableGroupsList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStaffToGroupForm";
            this.Text = "Add to group";
            this.Load += new System.EventHandler(this.AddStaffToGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableGroupsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ListBox selectedGroupsList;
        private System.Windows.Forms.Label label2;
    }
}