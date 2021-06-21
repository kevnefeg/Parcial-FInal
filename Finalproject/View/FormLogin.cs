using Finalproject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnCreatUser_Click(object sender, EventArgs e)
        {
            frm_NewPltManager newuser = new frm_NewPltManager();
            newuser.ShowDialog();
         }

        private void btn_PltManager_Click(object sender, EventArgs e)
        {
            frm_NewPltManager newPltManager = new frm_NewPltManager();
            newPltManager.ShowDialog();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frm_NewStaff NewStaff = new frm_NewStaff();
            NewStaff.ShowDialog();
        }
    }
}
