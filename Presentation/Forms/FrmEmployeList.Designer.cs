namespace HumanResourceManagementSystem.Presentation.Forms
{
    partial class FrmEmployeeList
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
            this.labelEmployeeList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmployeeList
            // 
            this.labelEmployeeList.AutoSize = true;
            this.labelEmployeeList.Location = new System.Drawing.Point(302, 131);
            this.labelEmployeeList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeList.Name = "labelEmployeeList";
            this.labelEmployeeList.Size = new System.Drawing.Size(95, 19);
            this.labelEmployeeList.TabIndex = 0;
            this.labelEmployeeList.Text = "Employee List";
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 364);
            this.Controls.Add(this.labelEmployeeList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmployeeList";
            this.Text = "FrmEmployeeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeList;
    }
}