
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
            System.Windows.Forms.Button cancelButton;
            this.availableGroupsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.selectedGroupsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            delGroupButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableGroupsList
            // 
            this.availableGroupsList.FormattingEnabled = true;
            this.availableGroupsList.ItemHeight = 20;
            this.availableGroupsList.Location = new System.Drawing.Point(16, 32);
            this.availableGroupsList.Name = "availableGroupsList";
            this.availableGroupsList.Size = new System.Drawing.Size(282, 204);
            this.availableGroupsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available groups:";
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(16, 243);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(282, 31);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Add group";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // selectedGroupsList
            // 
            this.selectedGroupsList.FormattingEnabled = true;
            this.selectedGroupsList.ItemHeight = 20;
            this.selectedGroupsList.Location = new System.Drawing.Point(16, 304);
            this.selectedGroupsList.Name = "selectedGroupsList";
            this.selectedGroupsList.Size = new System.Drawing.Size(282, 204);
            this.selectedGroupsList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Groups staff member is in:";
            // 
            // delGroupButton
            // 
            delGroupButton.Location = new System.Drawing.Point(16, 514);
            delGroupButton.Name = "delGroupButton";
            delGroupButton.Size = new System.Drawing.Size(282, 31);
            delGroupButton.TabIndex = 5;
            delGroupButton.Text = "Delete from group";
            delGroupButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(16, 565);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(282, 44);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(16, 615);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(282, 41);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddStaffToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 668);
            this.ControlBox = false;
            this.Controls.Add(cancelButton);
            this.Controls.Add(saveButton);
            this.Controls.Add(delGroupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedGroupsList);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availableGroupsList);
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