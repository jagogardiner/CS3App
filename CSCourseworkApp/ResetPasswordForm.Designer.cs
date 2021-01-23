
namespace CSCourseworkApp
{
    partial class ResetPasswordForm
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
            this.pwBox = new System.Windows.Forms.TextBox();
            this.pwBoxConfirm = new System.Windows.Forms.TextBox();
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm:";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(75, 10);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(147, 20);
            this.pwBox.TabIndex = 2;
            // 
            // pwBoxConfirm
            // 
            this.pwBoxConfirm.Location = new System.Drawing.Point(75, 37);
            this.pwBoxConfirm.Name = "pwBoxConfirm";
            this.pwBoxConfirm.Size = new System.Drawing.Size(147, 20);
            this.pwBoxConfirm.TabIndex = 3;
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Location = new System.Drawing.Point(75, 64);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(146, 23);
            this.savePasswordButton.TabIndex = 4;
            this.savePasswordButton.Text = "Save";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 105);
            this.Controls.Add(this.savePasswordButton);
            this.Controls.Add(this.pwBoxConfirm);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPasswordForm";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.TextBox pwBoxConfirm;
        private System.Windows.Forms.Button savePasswordButton;
    }
}