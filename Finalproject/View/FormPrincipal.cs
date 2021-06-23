using Finalproject.SqlServerContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Finalproject.View;

namespace Finalproject
{
    public partial class FrmPrincipal : Form
    {
        private bool stateInst = false;
        private bool stateDis = false;
        private string expressionDUI = "^0[0-9]{7}-[0-9]{1}$";
        private string expressionPhone = "^[7|6|2][0-9]{7}$";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtPhone.Text, expressionPhone))
            {
                MessageBox.Show("SI");
            }
            else { 
            
                MessageBox.Show("NO");
            }


            if (txtDui.Text == "" || txtAge.Text == ""|| txtAddress.Text==""|| txtName.Text==""||
               txtPhone.Text == "")
            {
                MessageBox.Show("No se permiten campos vacíos", "ERROR", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                if (Regex.IsMatch(txtDui.Text, expressionDUI) && Regex.IsMatch(txtPhone.Text, expressionPhone)) 
                {
                    bool priority = false;

                    var db = new VaccinationDBContext();
                    var institutions = db.Institutions
                        .OrderBy(i => i.Id)
                        .ToList();

                    var resultInstitution = institutions.Where(
                        i => i.Id.Equals(cmbInstitution.SelectedIndex + 1)
                     ).ToList();

                    int idType = resultInstitution[0].IdType;

                    if (Int32.Parse(txtAge.Text) >= 60)
                        priority = true;
                    else if (idType == 1 || idType == 3 || idType == 4)
                        priority = true;
                    else if (Int32.Parse(txtAge.Text) >= 18 &&
                        ((cmbDisType.SelectedIndex + 1) == 2 || (cmbDisType.SelectedIndex + 1) == 3))
                        priority = true;

                    if (priority)
                    {
                        Citizen newCitizen = new Citizen();

                        newCitizen.Dui = txtDui.Text;
                        newCitizen.Age = Int32.Parse(txtAge.Text);
                        newCitizen.CitizenName = txtName.Text;
                        newCitizen.AddressCitizen = txtAddress.Text;
                        newCitizen.Phone = txtPhone.Text;

                        if (chkInstQuestion.Checked) 
                        {
                            if (txtIdentifier.Text == "")
                            {
                                MessageBox.Show("Identificador de institución vacío", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else 
                            { 
                                newCitizen.Identifier = txtIdentifier.Text;
                                newCitizen.IdInstitution = cmbInstitution.SelectedIndex + 1;
                            }
                        }

                        db.Add(newCitizen);
                        db.SaveChanges();

                        // Falta guardar hora y fecha de la cita...


                        MessageBox.Show("Cita guardada", "Proceso de Cita", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                    }
                    else 
                    {
                        MessageBox.Show("No pertenece a ningún grupo de prioridad", "´Registro de Vacunación", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                     
                    }

                }
                else 
                {
                    MessageBox.Show("DUI o teléfono inválidos", "ERROR", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }

        }


        private void chkInstQuestion_CheckedChanged(object sender, EventArgs e)
        {
            var db = new VaccinationDBContext();

            if (!stateInst)
            {
                txtIdentifier.Enabled = true;
                cmbInstitution.Enabled = true;
                btnAddNewInst.Enabled = true;
                stateInst = true;

                cmbInstitution.DataSource = db.Institutions.ToList();
                cmbInstitution.DisplayMember = "Institution1";
                cmbInstitution.ValueMember = "Id";
            }
            else 
            { 
                txtIdentifier.Enabled = false;
                cmbInstitution.Enabled = false;
                btnAddNewInst.Enabled = false;
                stateInst = false;
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtIdentifier.Enabled = false;
            cmbInstitution.Enabled = false;

            this.Activated += (s, evt) => { UpdateCMB(); };

        }

        private void chkDiseaseAsk_CheckedChanged(object sender, EventArgs e)
        {
            var db = new VaccinationDBContext();

            if (!stateDis)
            {
                txtDisease.Enabled = true;
                cmbDisType.Enabled = true;
                stateDis = true;

                cmbDisType.DataSource = db.DiseaseTypes.ToList();
                cmbDisType.DisplayMember = "DiseaseType1";
                cmbDisType.ValueMember = "Id";
            }
            else
            {
                txtDisease.Enabled = false;
                cmbDisType.Enabled = false;
                stateDis = false;

            }
        }

        private void btnAddNewInst_Click(object sender, EventArgs e)
        {
            FrmAddInstitution formAdd = new FrmAddInstitution();
            formAdd.Show();
        }

        private void UpdateCMB()
        {
            var db = new VaccinationDBContext();
            cmbInstitution.DataSource = null;
            cmbInstitution.DataSource = db.Institutions.ToList();
            cmbInstitution.DisplayMember = "Institution1";
            cmbInstitution.ValueMember = "Id";
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
