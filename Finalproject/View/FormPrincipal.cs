﻿using Finalproject.SqlServerContext;
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
        private string emailExpression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        private List<ChronicDisease> diseases = new List<ChronicDisease>();


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
       {
            if (txtDui.Text == "" || txtAge.Text == ""|| txtAddress.Text==""|| txtName.Text==""||
               txtPhone.Text == "")
            {
                MessageBox.Show("No se permiten campos vacíos", "ERROR", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                if (txtEmail.Text != "") 
                {
                    if (Regex.IsMatch(txtEmail.Text, emailExpression))
                    {
                        if (Regex.IsMatch(txtDui.Text, expressionDUI) && Regex.IsMatch(txtPhone.Text, expressionPhone))
                            AddingCitizen();

                        else
                        {
                            MessageBox.Show("DUI o teléfono inválidos", "ERROR", MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Email inválido", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (Regex.IsMatch(txtDui.Text, expressionDUI) && Regex.IsMatch(txtPhone.Text, expressionPhone))
                        AddingCitizen();

                    else
                    {
                        MessageBox.Show("DUI o teléfono inválidos", "ERROR", MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
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
            txtDisease.Enabled = false;
            cmbDisType.Enabled = false;

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

        private void Clearing_Text()
        {
            txtAddress.Clear();
            txtAge.Clear();
            txtDisease.Clear();
            txtDui.Clear();
            txtEmail.Clear();
            txtIdentifier.Clear();
            txtName.Clear();
            txtPhone.Clear();
            chkDiseaseAsk.Checked = false;
            chkInstQuestion.Checked = false;
            dgvDisease.Rows.Clear();
        }

        private void AddingCitizen()
        {
            var db = new VaccinationDBContext();
            Citizen newCitizen = new Citizen();
           
            bool priority = false;
            int idType = 0;

            if (chkInstQuestion.Checked)
            {
                var institutions = db.Institutions
                    .OrderBy(i => i.Id)
                    .ToList();

                var resultInstitution = institutions.Where(
                    i => i.Id.Equals(cmbInstitution.SelectedIndex + 1)
                 ).ToList();

                idType = resultInstitution[0].IdType;
            }



            var citizens = db.Citizens.ToList();
            var resultCitizen = citizens.Where(
                    c => (c.Dui.Equals(txtDui.Text) ||
                        c.Phone.Equals(txtPhone.Text) ||
                        c.Email.Equals(txtEmail.Text) ||
                        c.Identifier.Equals(txtIdentifier.Text))
                        &&
                        (c.Email.Equals("None") ||
                        c.Identifier.Equals("None"))
                ).ToList();

            if (resultCitizen.Count == 0)
            {
                //bool stateType = false;
                //foreach (DataGridViewRow r in dgvDisease.Rows)
                //{
                //    if (Int32.Parse(r.Cells[2].Value.ToString()) == 2 ||
                //        Int32.Parse(r.Cells[2].Value.ToString()) == 3)
                //        stateType = true;
                //}

                if (Int32.Parse(txtAge.Text) >= 60)
                    priority = true;
                else if (idType == 1 || idType == 3 || idType == 4)
                    priority = true;
                //else if (Int32.Parse(txtAge.Text) >= 18 && stateType)
                //    priority = true;

                if (priority)
                {

                    newCitizen.Dui = txtDui.Text;
                    newCitizen.Age = Int32.Parse(txtAge.Text);
                    newCitizen.CitizenName = txtName.Text;
                    newCitizen.AddressCitizen = txtAddress.Text;
                    newCitizen.Phone = txtPhone.Text;
                    if (txtEmail.Text != "")
                        newCitizen.Email = txtEmail.Text;


                   //Chequeando que hayan datos en la institución
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
                            db.Add(newCitizen);
                            db.SaveChanges();

                            MessageBox.Show("Cita guardada", "Proceso de Cita", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        db.Add(newCitizen);
                        db.SaveChanges();

                        MessageBox.Show("Cita guardada", "Proceso de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }


                    //Chequeando que hayan datos en la enfermedad
                    ChronicDisease newDisease = new ChronicDisease();

                    if (chkDiseaseAsk.Checked)
                    {
                        if (txtDisease.Text == "")
                        {
                            MessageBox.Show("Enfermedad vacía", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            
                            for (int i = 0; i < Int32.Parse(dgvDisease.RowCount.ToString()); i++)
                            {
                                newDisease.DuiCitizen = txtDui.Text;
                                newDisease.ChronicDisease1 = dgvDisease.Rows[i].Cells[0].Value.ToString();
                                newDisease.IdDiseaseType = Int32.Parse(dgvDisease.Rows[i].Cells[2].Value.ToString());
                                diseases.Add(newDisease);
                                //diseases[i].ChronicDisease1 = dgvDisease.Rows[i].Cells[0].Value.ToString();
                                //diseases[i].IdDiseaseType = Int32.Parse(dgvDisease.Rows[i].Cells[2].Value.ToString());
                                db.Add(diseases[i]);
                                db.SaveChanges();
                                newDisease = null;
                            }
                        }
                    }

                    Clearing_Text();

                    // Falta guardar hora y fecha de la cita...


                }
                else
                {
                    MessageBox.Show("No pertenece a ningún grupo de prioridad", "´Registro de Vacunación", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("DUI, teléfono, email o identificador ya existen ", "´Registro de Vacunación", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
             


        }




        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new VaccinationDBContext();
            var types = db.DiseaseTypes.ToList();


            if (chkDiseaseAsk.Checked)
            {
                if (txtDisease.Text == "")
                {
                    MessageBox.Show("Enfermedad vacía", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    var result = types.Where(r => r.Id.Equals(cmbDisType.SelectedIndex+1)).ToList();

                    dgvDisease.Rows.Add(txtDisease.Text, result[0].DiseaseType1,
                        cmbDisType.SelectedIndex + 1);

                    MessageBox.Show("Enfermedad crónica añadida", "Proceso de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
                       
           
        }
    }
}
