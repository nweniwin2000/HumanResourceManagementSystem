namespace HumanResourceManagementSystem.Presentation.Forms
{
    partial class FrmAdminHome
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
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLeaveList = new System.Windows.Forms.Button();
            this.btnAttendanceList = new System.Windows.Forms.Button();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelNevigator = new System.Windows.Forms.Panel();
            this.panelBtn.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBtn.Controls.Add(this.btnLogOut);
            this.panelBtn.Controls.Add(this.btnLeaveList);
            this.panelBtn.Controls.Add(this.btnAttendanceList);
            this.panelBtn.Controls.Add(this.btnEmployeeList);
            this.panelBtn.Controls.Add(this.btnAddEmployee);
            this.panelBtn.Controls.Add(this.btnHome);
            this.panelBtn.Controls.Add(this.panelMenu);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(137, 461);
            this.panelBtn.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(28, 393);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 28);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnLeaveList
            // 
            this.btnLeaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveList.Location = new System.Drawing.Point(0, 291);
            this.btnLeaveList.Name = "btnLeaveList";
            this.btnLeaveList.Size = new System.Drawing.Size(137, 58);
            this.btnLeaveList.TabIndex = 5;
            this.btnLeaveList.Text = "Leave List";
            this.btnLeaveList.UseVisualStyleBackColor = true;
            this.btnLeaveList.Click += new System.EventHandler(this.btnLeaveList_Click);
            // 
            // btnAttendanceList
            // 
            this.btnAttendanceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceList.Location = new System.Drawing.Point(0, 233);
            this.btnAttendanceList.Name = "btnAttendanceList";
            this.btnAttendanceList.Size = new System.Drawing.Size(137, 58);
            this.btnAttendanceList.TabIndex = 4;
            this.btnAttendanceList.Text = "Attendance List";
            this.btnAttendanceList.UseVisualStyleBackColor = true;
            this.btnAttendanceList.Click += new System.EventHandler(this.btnAttendanceList_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeList.Location = new System.Drawing.Point(0, 175);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(137, 58);
            this.btnEmployeeList.TabIndex = 3;
            this.btnEmployeeList.Text = "Employee List";
            this.btnEmployeeList.UseVisualStyleBackColor = true;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 117);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(137, 58);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 59);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 58);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(137, 58);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(137, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(747, 58);
            this.panelTop.TabIndex = 1;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(260, 18);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(214, 23);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "HR Management System";
            // 
            // panelNevigator
            // 
            this.panelNevigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNevigator.Location = new System.Drawing.Point(137, 58);
            this.panelNevigator.Name = "panelNevigator";
            this.panelNevigator.Size = new System.Drawing.Size(747, 403);
            this.panelNevigator.TabIndex = 2;
            // 
            // FrmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelNevigator);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBtn);
            this.Name = "FrmAdminHome";
            this.Text = "FrmAdminHome";
            this.panelBtn.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Panel panelNevigator;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Button btnLeaveList;
        public System.Windows.Forms.Button btnAttendanceList;
        public System.Windows.Forms.Button btnEmployeeList;
        public System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnLogOut;
    }
}