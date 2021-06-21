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
    public partial class frm_NewPltManager : Form
    {
        public frm_NewPltManager()
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
            string id = txtid.Text;
            string name = txtname.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string user = txtid.Text;
            string address = txtaddress.Text;
            int Idtype = 1;
            SqlCommand query = new SqlCommand("INSERT INTO STAFF VALUES('"+id+"','"+name+ "','"+email+"','"+password+"'," +
                "'"+user+"','"+address+ "','"+Idtype+"')", cn);
            query.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Se ha creado exitosamente el nuevo gestor!");
            this.Close();
        }
    }
}
