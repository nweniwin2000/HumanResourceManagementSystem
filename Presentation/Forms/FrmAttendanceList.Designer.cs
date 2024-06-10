namespace HumanResourceManagementSystem.Presentation.Forms
{
    partial class FrmAttendanceList
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
            this.labelAttendanceList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAttendanceList
            // 
            this.labelAttendanceList.AutoSize = true;
            this.labelAttendanceList.Location = new System.Drawing.Point(297, 116);
            this.labelAttendanceList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttendanceList.Name = "labelAttendanceList";
            this.labelAttendanceList.Size = new System.Drawing.Size(104, 19);
            this.labelAttendanceList.TabIndex = 0;
            this.labelAttendanceList.Text = "Attendance List";
            // 
            // FrmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 364);
            this.Controls.Add(this.labelAttendanceList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAttendanceList";
            this.Text = "FrmAttendanceList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAttendanceList;
    }
}