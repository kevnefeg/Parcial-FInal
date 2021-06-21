using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finalproject.View
{
    public partial class frmCreate_User : Form
    {
        public frmCreate_User()
        {
            InitializeComponent();
        }

        

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncreatenewuserr_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Server=ANDRES;Database=VaccinationDB;Trusted_Connection=True;");
            cn.Open();
            string name = txtname.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string user = txtid.Text;
            string address = txtaddress.Text;
            int Idtype = Int32.Parse(txtstaff.Text);
            SqlCommand query = new SqlCommand("INSERT INTO STAFF VALUES('"+name+"','"+email+ "','"+password+"','"+user+"'," +
                "'"+address+"','"+Idtype+"')",cn);
            query.ExecuteNonQuery();
            cn.Close();

        }
    }
}
