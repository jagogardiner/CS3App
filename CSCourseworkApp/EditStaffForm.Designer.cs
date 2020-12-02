
namespace CSCourseworkApp
{
    partial class EditStaffForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.staffNameBox = new System.Windows.Forms.TextBox();
            this.tutorCheckBox = new System.Windows.Forms.CheckBox();
            this.overseerCheckBox = new System.Windows.Forms.CheckBox();
            this.staffUsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.addToGroupButton = new System.Windows.Forms.Button();
            this.removeFromGroupButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resetPasswordTickBox = new System.Windows.Forms.CheckBox();
            this.saveStaffButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Staff Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // staffNameBox
            // 
            this.staffNameBox.Location = new System.Drawing.Point(87, 58);
            this.staffNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffNameBox.Name = "staffNameBox";
            this.staffNameBox.Size = new System.Drawing.Size(224, 26);
            this.staffNameBox.TabIndex = 2;
            // 
            // tutorCheckBox
            // 
            this.tutorCheckBox.AutoSize = true;
            this.tutorCheckBox.Location = new System.Drawing.Point(26, 178);
            this.tutorCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tutorCheckBox.Name = "tutorCheckBox";
            this.tutorCheckBox.Size = new System.Drawing.Size(72, 24);
            this.tutorCheckBox.TabIndex = 3;
            this.tutorCheckBox.Text = "Tutor";
            this.tutorCheckBox.UseVisualStyleBackColor = true;
            // 
            // overseerCheckBox
            // 
            this.overseerCheckBox.AutoSize = true;
            this.overseerCheckBox.Location = new System.Drawing.Point(26, 215);
            this.overseerCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.overseerCheckBox.Name = "overseerCheckBox";
            this.overseerCheckBox.Size = new System.Drawing.Size(99, 24);
            this.overseerCheckBox.TabIndex = 4;
            this.overseerCheckBox.Text = "Overseer";
            this.overseerCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffUsernameBox
            // 
            this.staffUsernameBox.Location = new System.Drawing.Point(117, 98);
            this.staffUsernameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffUsernameBox.Name = "staffUsernameBox";
            this.staffUsernameBox.Size = new System.Drawing.Size(194, 26);
            this.staffUsernameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 20;
            this.groupsListBox.Location = new System.Drawing.Point(26, 279);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(286, 224);
            this.groupsListBox.TabIndex = 8;
            // 
            // addToGroupButton
            // 
            this.addToGroupButton.Location = new System.Drawing.Point(26, 515);
            this.addToGroupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addToGroupButton.Name = "addToGroupButton";
            this.addToGroupButton.Size = new System.Drawing.Size(141, 35);
            this.addToGroupButton.TabIndex = 9;
            this.addToGroupButton.Text = "Add to Group";
            this.addToGroupButton.UseVisualStyleBackColor = true;
            this.addToGroupButton.Click += new System.EventHandler(this.addToGroupButton_Click);
            // 
            // removeFromGroupButton
            // 
            this.removeFromGroupButton.Location = new System.Drawing.Point(176, 515);
            this.removeFromGroupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeFromGroupButton.Name = "removeFromGroupButton";
            this.removeFromGroupButton.Size = new System.Drawing.Size(135, 35);
            this.removeFromGroupButton.TabIndex = 10;
            this.removeFromGroupButton.Text = "Remove";
            this.removeFromGroupButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Groups:";
            // 
            // resetPasswordTickBox
            // 
            this.resetPasswordTickBox.AutoSize = true;
            this.resetPasswordTickBox.Location = new System.Drawing.Point(26, 142);
            this.resetPasswordTickBox.Name = "resetPasswordTickBox";
            this.resetPasswordTickBox.Size = new System.Drawing.Size(151, 24);
            this.resetPasswordTickBox.TabIndex = 12;
            this.resetPasswordTickBox.Text = "Reset Password";
            this.resetPasswordTickBox.UseVisualStyleBackColor = true;
            // 
            // saveStaffButton
            // 
            this.saveStaffButton.Location = new System.Drawing.Point(26, 559);
            this.saveStaffButton.Name = "saveStaffButton";
            this.saveStaffButton.Size = new System.Drawing.Size(285, 33);
            this.saveStaffButton.TabIndex = 13;
            this.saveStaffButton.Text = "Save Staff Member";
            this.saveStaffButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(23, 598);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(288, 27);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 637);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveStaffButton);
            this.Controls.Add(this.resetPasswordTickBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeFromGroupButton);
            this.Controls.Add(this.addToGroupButton);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.staffUsernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.overseerCheckBox);
            this.Controls.Add(this.tutorCheckBox);
            this.Controls.Add(this.staffNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Staff";
            this.Load += new System.EventHandler(this.EditStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffNameBox;
        private System.Windows.Forms.CheckBox tutorCheckBox;
        private System.Windows.Forms.CheckBox overseerCheckBox;
        private System.Windows.Forms.TextBox staffUsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Button addToGroupButton;
        private System.Windows.Forms.Button removeFromGroupButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox resetPasswordTickBox;
        private System.Windows.Forms.Button saveStaffButton;
        private System.Windows.Forms.Button cancelButton;
    }
}