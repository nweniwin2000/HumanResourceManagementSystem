using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourceManagementSystem.Presentation.Forms
{
    public partial class FrmAdminHome : Form
    {   
        private Form activeForm;
        
        public FrmAdminHome()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelNevigator.Controls.Add(childForm);    
            this.panelNevigator.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnHome_Click(object sender, EventArgs e)
        {           
            FrmAdminHome f1 = new FrmAdminHome();
            f1.Show();          
            this.Hide();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentation.Forms.FrmAddEmployee(), sender);
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentation.Forms.FrmEmployeeList(), sender);
        }

        private void btnAttendanceList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentation.Forms.FrmAttendanceList(), sender);
        }

        private void btnLeaveList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentation.Forms.FrmLeaveList(), sender);
        }
    }
}
