
namespace CSCourseworkApp
{
    partial class TeacherMainForm
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
            this.teacherOverviewLabel = new System.Windows.Forms.Label();
            this.teacherClassListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // teacherOverviewLabel
            // 
            this.teacherOverviewLabel.AutoSize = true;
            this.teacherOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherOverviewLabel.Location = new System.Drawing.Point(11, 7);
            this.teacherOverviewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherOverviewLabel.Name = "teacherOverviewLabel";
            this.teacherOverviewLabel.Size = new System.Drawing.Size(147, 20);
            this.teacherOverviewLabel.TabIndex = 0;
            this.teacherOverviewLabel.Text = "Teacher Overview | ";
            // 
            // teacherClassListBox
            // 
            this.teacherClassListBox.FormattingEnabled = true;
            this.teacherClassListBox.Location = new System.Drawing.Point(15, 30);
            this.teacherClassListBox.Name = "teacherClassListBox";
            this.teacherClassListBox.Size = new System.Drawing.Size(143, 303);
            this.teacherClassListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(164, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 303);
            this.panel1.TabIndex = 2;
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.teacherClassListBox);
            this.Controls.Add(this.teacherOverviewLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherMainForm";
            this.Text = "TeacherMainForm";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherOverviewLabel;
        private System.Windows.Forms.ListBox teacherClassListBox;
        private System.Windows.Forms.Panel panel1;
    }
}