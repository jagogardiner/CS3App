
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffNameBox = new System.Windows.Forms.TextBox();
            this.overseerCheckBox = new System.Windows.Forms.CheckBox();
            this.staffUsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resetPasswordTickBox = new System.Windows.Forms.CheckBox();
            this.saveStaffButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addToGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Edit Staff Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // staffNameBox
            // 
            this.staffNameBox.Location = new System.Drawing.Point(58, 38);
            this.staffNameBox.Name = "staffNameBox";
            this.staffNameBox.Size = new System.Drawing.Size(151, 20);
            this.staffNameBox.TabIndex = 2;
            // 
            // overseerCheckBox
            // 
            this.overseerCheckBox.AutoSize = true;
            this.overseerCheckBox.Location = new System.Drawing.Point(17, 114);
            this.overseerCheckBox.Name = "overseerCheckBox";
            this.overseerCheckBox.Size = new System.Drawing.Size(69, 17);
            this.overseerCheckBox.TabIndex = 4;
            this.overseerCheckBox.Text = "Overseer";
            this.overseerCheckBox.UseVisualStyleBackColor = true;
            // 
            // staffUsernameBox
            // 
            this.staffUsernameBox.Location = new System.Drawing.Point(78, 64);
            this.staffUsernameBox.Name = "staffUsernameBox";
            this.staffUsernameBox.Size = new System.Drawing.Size(131, 20);
            this.staffUsernameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(17, 181);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(192, 134);
            this.groupsListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Groups:";
            // 
            // resetPasswordTickBox
            // 
            this.resetPasswordTickBox.AutoSize = true;
            this.resetPasswordTickBox.Location = new System.Drawing.Point(17, 92);
            this.resetPasswordTickBox.Margin = new System.Windows.Forms.Padding(2);
            this.resetPasswordTickBox.Name = "resetPasswordTickBox";
            this.resetPasswordTickBox.Size = new System.Drawing.Size(103, 17);
            this.resetPasswordTickBox.TabIndex = 12;
            this.resetPasswordTickBox.Text = "Reset Password";
            this.resetPasswordTickBox.UseVisualStyleBackColor = true;
            // 
            // saveStaffButton
            // 
            this.saveStaffButton.Location = new System.Drawing.Point(17, 363);
            this.saveStaffButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveStaffButton.Name = "saveStaffButton";
            this.saveStaffButton.Size = new System.Drawing.Size(192, 29);
            this.saveStaffButton.TabIndex = 13;
            this.saveStaffButton.Text = "Save Staff Member";
            this.saveStaffButton.UseVisualStyleBackColor = true;
            this.saveStaffButton.Click += new System.EventHandler(this.saveStaffButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(17, 396);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(192, 30);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addToGroupButton
            // 
            this.addToGroupButton.Location = new System.Drawing.Point(17, 321);
            this.addToGroupButton.Name = "addToGroupButton";
            this.addToGroupButton.Size = new System.Drawing.Size(192, 26);
            this.addToGroupButton.TabIndex = 9;
            this.addToGroupButton.Text = "Edit Groups";
            this.addToGroupButton.UseVisualStyleBackColor = true;
            this.addToGroupButton.Click += new System.EventHandler(this.addToGroupButton_Click);
            // 
            // EditStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 432);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveStaffButton);
            this.Controls.Add(this.resetPasswordTickBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addToGroupButton);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.staffUsernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.overseerCheckBox);
            this.Controls.Add(this.staffNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Staff";
            this.Load += new System.EventHandler(this.EditStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffNameBox;
        private System.Windows.Forms.CheckBox overseerCheckBox;
        private System.Windows.Forms.TextBox staffUsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox resetPasswordTickBox;
        private System.Windows.Forms.Button saveStaffButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addToGroupButton;
    }
}