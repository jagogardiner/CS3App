
namespace CSCourseworkApp
{
    partial class OverseerForm
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
            this.teachingFunctionsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.tutorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overseer Panel";
            // 
            // teachingFunctionsButton
            // 
            this.teachingFunctionsButton.Location = new System.Drawing.Point(16, 37);
            this.teachingFunctionsButton.Name = "teachingFunctionsButton";
            this.teachingFunctionsButton.Size = new System.Drawing.Size(138, 39);
            this.teachingFunctionsButton.TabIndex = 1;
            this.teachingFunctionsButton.Text = "Go to teacher overview";
            this.teachingFunctionsButton.UseVisualStyleBackColor = true;
            this.teachingFunctionsButton.Click += new System.EventHandler(this.teachingFunctionsButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(16, 82);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(138, 39);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Go to admin overview";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // tutorButton
            // 
            this.tutorButton.Location = new System.Drawing.Point(16, 127);
            this.tutorButton.Name = "tutorButton";
            this.tutorButton.Size = new System.Drawing.Size(138, 39);
            this.tutorButton.TabIndex = 3;
            this.tutorButton.Text = "Go to tutor overview";
            this.tutorButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 172);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OverseerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 224);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tutorButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.teachingFunctionsButton);
            this.Controls.Add(this.label1);
            this.Name = "OverseerForm";
            this.Text = "OverseerForm";
            this.Load += new System.EventHandler(this.OverseerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teachingFunctionsButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button tutorButton;
        private System.Windows.Forms.Button exitButton;
    }
}