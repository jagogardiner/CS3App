
namespace CSCourseworkApp
{
    partial class AddPreviousResultsForm
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
            this.PreviousResultView = new System.Windows.Forms.DataGridView();
            this.saveTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousResultView
            // 
            this.PreviousResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousResultView.Location = new System.Drawing.Point(12, 12);
            this.PreviousResultView.Name = "PreviousResultView";
            this.PreviousResultView.Size = new System.Drawing.Size(453, 290);
            this.PreviousResultView.TabIndex = 0;
            this.PreviousResultView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PreviousResultView_RowsAdded);
            // 
            // saveTable
            // 
            this.saveTable.Location = new System.Drawing.Point(372, 308);
            this.saveTable.Name = "saveTable";
            this.saveTable.Size = new System.Drawing.Size(93, 23);
            this.saveTable.TabIndex = 1;
            this.saveTable.Text = "Save Table";
            this.saveTable.UseVisualStyleBackColor = true;
            this.saveTable.Click += new System.EventHandler(this.saveTable_Click);
            // 
            // AddPreviousResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 338);
            this.Controls.Add(this.saveTable);
            this.Controls.Add(this.PreviousResultView);
            this.Name = "AddPreviousResultsForm";
            this.Text = "Edit Previous Results";
            this.Load += new System.EventHandler(this.AddPreviousResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousResultView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PreviousResultView;
        private System.Windows.Forms.Button saveTable;
    }
}