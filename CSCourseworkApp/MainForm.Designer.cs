
namespace CSCourseworkApp
{
    partial class MainForm
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.manageClassesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.manageUsersButton);
            this.adminPanel.Controls.Add(this.manageClassesButton);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Location = new System.Drawing.Point(12, 12);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(208, 426);
            this.adminPanel.TabIndex = 0;
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Location = new System.Drawing.Point(11, 90);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(182, 44);
            this.manageUsersButton.TabIndex = 2;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            // 
            // manageClassesButton
            // 
            this.manageClassesButton.Location = new System.Drawing.Point(11, 40);
            this.manageClassesButton.Name = "manageClassesButton";
            this.manageClassesButton.Size = new System.Drawing.Size(182, 44);
            this.manageClassesButton.TabIndex = 1;
            this.manageClassesButton.Text = "Manage Classes";
            this.manageClassesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.adminPanel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button manageClassesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageUsersButton;
    }
}