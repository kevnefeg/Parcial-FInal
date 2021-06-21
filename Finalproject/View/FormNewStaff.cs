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

namespace Finalproject
{
    public partial class frm_NewStaff : Form
    {
        SqlConnection cn = new SqlConnection("Server=ANDRES;Database=VaccinationDB;Trusted_Connection=True;");

        public frm_NewStaff()
        {
            InitializeComponent();
        }

        private void btn_CreateStaff_Click(object sender, EventArgs e)
        {
            int n;

            if (cmb_StaffType.SelectedItem == "Cabin Manager")
            {
                n = 2;
                Staff(n);
                this.Close();
            }
            else if (cmb_StaffType.SelectedItem == "Staff")
            {
                n = 3;
                Staff(n);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de empleado", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Staff(int n)
        {
            cn.Open();
            string id = txt_Staff_id.Text;
            string name = txt_Staff_name.Text;
            string email = txt_Staff_Email.Text;
            string address = txt_Staff_Address.Text;
            int Idtype = n;
            SqlCommand query = new SqlCommand("INSERT INTO STAFF(id, name_staff, email, address_staff, id_type) " +
                "VALUES ('"+id+"','"+name+"','"+email+"','"+address+"','"+Idtype+"')", cn);
            query.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Se a registrado exitosamente el nuevo empleado!");

        }
    }
}
