
namespace CSCourseworkApp
{
    partial class EditGroupForm
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
            this.groupTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.academYearComboBox = new System.Windows.Forms.ComboBox();
            this.lecturerBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupTitleLabel
            // 
            this.groupTitleLabel.AutoSize = true;
            this.groupTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTitleLabel.Location = new System.Drawing.Point(13, 9);
            this.groupTitleLabel.Name = "groupTitleLabel";
            this.groupTitleLabel.Size = new System.Drawing.Size(86, 20);
            this.groupTitleLabel.TabIndex = 0;
            this.groupTitleLabel.Text = "Edit Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group name:";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(87, 50);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.groupNameTextBox.TabIndex = 3;
            // 
            // academYearComboBox
            // 
            this.academYearComboBox.FormattingEnabled = true;
            this.academYearComboBox.Location = new System.Drawing.Point(101, 91);
            this.academYearComboBox.Name = "academYearComboBox";
            this.academYearComboBox.Size = new System.Drawing.Size(115, 21);
            this.academYearComboBox.TabIndex = 4;
            // 
            // lecturerBox
            // 
            this.lecturerBox.FormattingEnabled = true;
            this.lecturerBox.Location = new System.Drawing.Point(17, 153);
            this.lecturerBox.Name = "lecturerBox";
            this.lecturerBox.Size = new System.Drawing.Size(255, 173);
            this.lecturerBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add by staff ID";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lecturers:";
            // 
            // saveGroupButton
            // 
            this.saveGroupButton.Location = new System.Drawing.Point(17, 389);
            this.saveGroupButton.Name = "saveGroupButton";
            this.saveGroupButton.Size = new System.Drawing.Size(255, 40);
            this.saveGroupButton.TabIndex = 10;
            this.saveGroupButton.Text = "Save Group";
            this.saveGroupButton.UseVisualStyleBackColor = true;
            // 
            // EditGroupForm
            // 
            this.ClientSize = new System.Drawing.Size(285, 441);
            this.Controls.Add(this.saveGroupButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lecturerBox);
            this.Controls.Add(this.academYearComboBox);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupTitleLabel);
            this.Name = "EditGroupForm";
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.ComboBox academYearComboBox;
        private System.Windows.Forms.ListBox lecturerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveGroupButton;
    }
}
