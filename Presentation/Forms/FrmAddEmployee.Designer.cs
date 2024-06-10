namespace HumanResourceManagementSystem.Presentation.Forms
{
    partial class FrmAddEmployee
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
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Location = new System.Drawing.Point(288, 181);
            this.labelAddEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(100, 19);
            this.labelAddEmployee.TabIndex = 0;
            this.labelAddEmployee.Text = "Add Employee";
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 364);
            this.Controls.Add(this.labelAddEmployee);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddEmployee";
            this.Text = "FrmAddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddEmployee;
    }
}