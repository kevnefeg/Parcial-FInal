﻿
namespace Finalproject
{
    partial class FrmPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDateProcess = new System.Windows.Forms.TabPage();
            this.dgvDisease = new System.Windows.Forms.DataGridView();
            this.Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.chkDiseaseAsk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDisType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewInst = new System.Windows.Forms.Button();
            this.cmbInstitution = new System.Windows.Forms.ComboBox();
            this.chkInstQuestion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstitution = new System.Windows.Forms.Label();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabVaccination = new System.Windows.Forms.TabPage();
            this.lbltxt9 = new System.Windows.Forms.Label();
            this.lbltxt8 = new System.Windows.Forms.Label();
            this.lbltxt7 = new System.Windows.Forms.Label();
            this.lblplacevacun = new System.Windows.Forms.Label();
            this.lblfeha1 = new System.Windows.Forms.Label();
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.lbltxt6 = new System.Windows.Forms.Label();
            this.lbltxt5 = new System.Windows.Forms.Label();
            this.lbltxt4 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltxt3 = new System.Windows.Forms.Label();
            this.lbltxt2 = new System.Windows.Forms.Label();
            this.lbltxtx1 = new System.Windows.Forms.Label();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.llbimpdui = new System.Windows.Forms.Label();
            this.lblimpdui = new System.Windows.Forms.Label();
            this.lblimpname = new System.Windows.Forms.Label();
            this.tabDateFollowUp = new System.Windows.Forms.TabPage();
            this.btn_printDFU = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_showPlace = new System.Windows.Forms.Label();
            this.lbl_showDate = new System.Windows.Forms.Label();
            this.lbl_NameDFU = new System.Windows.Forms.Label();
            this.lbl_DateDFU = new System.Windows.Forms.Label();
            this.lbl_PlaceDFU = new System.Windows.Forms.Label();
            this.lbl_showname = new System.Windows.Forms.Label();
            this.txt_Dui = new System.Windows.Forms.TextBox();
            this.lbl_Dui = new System.Windows.Forms.Label();
            this.tabVaccinationProcess = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabDateProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisease)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabVaccination.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabDateFollowUp.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDateProcess);
            this.tabControl1.Controls.Add(this.tabVaccination);
            this.tabControl1.Controls.Add(this.tabDateFollowUp);
            this.tabControl1.Controls.Add(this.tabVaccinationProcess);
            this.tabControl1.Location = new System.Drawing.Point(2, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 701);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabDateProcess
            // 
            this.tabDateProcess.Controls.Add(this.dgvDisease);
            this.tabDateProcess.Controls.Add(this.groupBox3);
            this.tabDateProcess.Controls.Add(this.groupBox2);
            this.tabDateProcess.Controls.Add(this.groupBox1);
            this.tabDateProcess.Controls.Add(this.btnRegister);
            this.tabDateProcess.Location = new System.Drawing.Point(4, 29);
            this.tabDateProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDateProcess.Name = "tabDateProcess";
            this.tabDateProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDateProcess.Size = new System.Drawing.Size(864, 668);
            this.tabDateProcess.TabIndex = 0;
            this.tabDateProcess.Text = "Proceso de cita";
            this.tabDateProcess.UseVisualStyleBackColor = true;
            // 
            // dgvDisease
            // 
            this.dgvDisease.AllowUserToAddRows = false;
            this.dgvDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enfermedad,
            this.TipoEnfermedad,
            this.IdTipo});
            this.dgvDisease.Location = new System.Drawing.Point(504, 323);
            this.dgvDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDisease.Name = "dgvDisease";
            this.dgvDisease.ReadOnly = true;
            this.dgvDisease.RowHeadersWidth = 51;
            this.dgvDisease.RowTemplate.Height = 25;
            this.dgvDisease.Size = new System.Drawing.Size(347, 193);
            this.dgvDisease.TabIndex = 19;
            // 
            // Enfermedad
            // 
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.MinimumWidth = 6;
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.ReadOnly = true;
            this.Enfermedad.Width = 125;
            // 
            // TipoEnfermedad
            // 
            this.TipoEnfermedad.HeaderText = "Tipo de enfermedad";
            this.TipoEnfermedad.MinimumWidth = 6;
            this.TipoEnfermedad.Name = "TipoEnfermedad";
            this.TipoEnfermedad.ReadOnly = true;
            this.TipoEnfermedad.Width = 135;
            // 
            // IdTipo
            // 
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.MinimumWidth = 6;
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.ReadOnly = true;
            this.IdTipo.Visible = false;
            this.IdTipo.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(25, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(377, 376);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos generales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDui, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDui, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 333);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(79, 290);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(79, 234);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(110, 27);
            this.txtPhone.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 275);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 58);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email (opcional)";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 237);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Teléfono:";
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(3, 127);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 20);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 172);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 40);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(79, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(79, 179);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(110, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Location = new System.Drawing.Point(79, 69);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 27);
            this.txtAge.TabIndex = 6;
            // 
            // txtDui
            // 
            this.txtDui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDui.Location = new System.Drawing.Point(79, 14);
            this.txtDui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(110, 27);
            this.txtDui.TabIndex = 7;
            // 
            // lblage
            // 
            this.lblage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(3, 72);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(70, 20);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Edad:";
            // 
            // lblDui
            // 
            this.lblDui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(3, 17);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(70, 20);
            this.lblDui.TabIndex = 1;
            this.lblDui.Text = "DUI:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtDisease);
            this.groupBox2.Controls.Add(this.chkDiseaseAsk);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbDisType);
            this.groupBox2.Location = new System.Drawing.Point(439, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(413, 261);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enfermedad crónica (opcional)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar enfermedad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(166, 103);
            this.txtDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(233, 27);
            this.txtDisease.TabIndex = 17;
            // 
            // chkDiseaseAsk
            // 
            this.chkDiseaseAsk.AutoSize = true;
            this.chkDiseaseAsk.Location = new System.Drawing.Point(83, 49);
            this.chkDiseaseAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDiseaseAsk.Name = "chkDiseaseAsk";
            this.chkDiseaseAsk.Size = new System.Drawing.Size(269, 24);
            this.chkDiseaseAsk.TabIndex = 16;
            this.chkDiseaseAsk.Text = "¿Posee alguna enfermedad crónica?";
            this.chkDiseaseAsk.UseVisualStyleBackColor = true;
            this.chkDiseaseAsk.CheckedChanged += new System.EventHandler(this.chkDiseaseAsk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo de enfermedad:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enfermedad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbDisType
            // 
            this.cmbDisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisType.FormattingEnabled = true;
            this.cmbDisType.Location = new System.Drawing.Point(166, 161);
            this.cmbDisType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDisType.Name = "cmbDisType";
            this.cmbDisType.Size = new System.Drawing.Size(233, 28);
            this.cmbDisType.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewInst);
            this.groupBox1.Controls.Add(this.cmbInstitution);
            this.groupBox1.Controls.Add(this.chkInstQuestion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblInstitution);
            this.groupBox1.Controls.Add(this.txtIdentifier);
            this.groupBox1.Location = new System.Drawing.Point(25, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 221);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Institución (opcional)";
            // 
            // btnAddNewInst
            // 
            this.btnAddNewInst.Location = new System.Drawing.Point(321, 161);
            this.btnAddNewInst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewInst.Name = "btnAddNewInst";
            this.btnAddNewInst.Size = new System.Drawing.Size(110, 39);
            this.btnAddNewInst.TabIndex = 19;
            this.btnAddNewInst.Text = "Agregar";
            this.btnAddNewInst.UseVisualStyleBackColor = true;
            this.btnAddNewInst.Click += new System.EventHandler(this.btnAddNewInst_Click);
            // 
            // cmbInstitution
            // 
            this.cmbInstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitution.FormattingEnabled = true;
            this.cmbInstitution.Location = new System.Drawing.Point(119, 167);
            this.cmbInstitution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInstitution.Name = "cmbInstitution";
            this.cmbInstitution.Size = new System.Drawing.Size(196, 28);
            this.cmbInstitution.TabIndex = 18;
            // 
            // chkInstQuestion
            // 
            this.chkInstQuestion.AutoSize = true;
            this.chkInstQuestion.Location = new System.Drawing.Point(118, 45);
            this.chkInstQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInstQuestion.Name = "chkInstQuestion";
            this.chkInstQuestion.Size = new System.Drawing.Size(242, 24);
            this.chkInstQuestion.TabIndex = 16;
            this.chkInstQuestion.Text = "¿Pertenece a alguna institución?";
            this.chkInstQuestion.UseVisualStyleBackColor = true;
            this.chkInstQuestion.CheckedChanged += new System.EventHandler(this.chkInstQuestion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Institución:";
            // 
            // lblInstitution
            // 
            this.lblInstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.Location = new System.Drawing.Point(7, 104);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(102, 20);
            this.lblInstitution.TabIndex = 12;
            this.lblInstitution.Text = "Identificación:";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(118, 101);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(323, 27);
            this.txtIdentifier.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(694, 547);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 59);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabVaccination
            // 
            this.tabVaccination.Controls.Add(this.lbltxt9);
            this.tabVaccination.Controls.Add(this.lbltxt8);
            this.tabVaccination.Controls.Add(this.lbltxt7);
            this.tabVaccination.Controls.Add(this.lblplacevacun);
            this.tabVaccination.Controls.Add(this.lblfeha1);
            this.tabVaccination.Controls.Add(this.lblfecha2);
            this.tabVaccination.Controls.Add(this.lbltxt6);
            this.tabVaccination.Controls.Add(this.lbltxt5);
            this.tabVaccination.Controls.Add(this.lbltxt4);
            this.tabVaccination.Controls.Add(this.btnimprimir);
            this.tabVaccination.Controls.Add(this.lblfecha);
            this.tabVaccination.Controls.Add(this.lbltxt3);
            this.tabVaccination.Controls.Add(this.lbltxt2);
            this.tabVaccination.Controls.Add(this.lbltxtx1);
            this.tabVaccination.Controls.Add(this.lbltxt1);
            this.tabVaccination.Controls.Add(this.tableLayoutPanel2);
            this.tabVaccination.Location = new System.Drawing.Point(4, 29);
            this.tabVaccination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVaccination.Name = "tabVaccination";
            this.tabVaccination.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVaccination.Size = new System.Drawing.Size(864, 668);
            this.tabVaccination.TabIndex = 1;
            this.tabVaccination.Text = "Vaccination";
            this.tabVaccination.UseVisualStyleBackColor = true;
            // 
            // lbltxt9
            // 
            this.lbltxt9.AutoSize = true;
            this.lbltxt9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt9.Location = new System.Drawing.Point(151, 449);
            this.lbltxt9.Name = "lbltxt9";
            this.lbltxt9.Size = new System.Drawing.Size(566, 31);
            this.lbltxt9.TabIndex = 15;
            this.lbltxt9.Text = "La vacuna COVID-19 es universal, gratuita y voluntaria.";
            // 
            // lbltxt8
            // 
            this.lbltxt8.AutoSize = true;
            this.lbltxt8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt8.Location = new System.Drawing.Point(61, 369);
            this.lbltxt8.Name = "lbltxt8";
            this.lbltxt8.Size = new System.Drawing.Size(265, 31);
            this.lbltxt8.TabIndex = 14;
            this.lbltxt8.Text = "unico de identidad (DUI)";
            // 
            // lbltxt7
            // 
            this.lbltxt7.AutoSize = true;
            this.lbltxt7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt7.Location = new System.Drawing.Point(61, 338);
            this.lbltxt7.Name = "lbltxt7";
            this.lbltxt7.Size = new System.Drawing.Size(711, 31);
            this.lbltxt7.TabIndex = 13;
            this.lbltxt7.Text = "Debes de presentarte media hora antes de tu cita con tu documento";
            // 
            // lblplacevacun
            // 
            this.lblplacevacun.AutoSize = true;
            this.lblplacevacun.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblplacevacun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblplacevacun.Location = new System.Drawing.Point(196, 265);
            this.lblplacevacun.Name = "lblplacevacun";
            this.lblplacevacun.Size = new System.Drawing.Size(20, 31);
            this.lblplacevacun.TabIndex = 12;
            this.lblplacevacun.Text = " ";
            // 
            // lblfeha1
            // 
            this.lblfeha1.AutoSize = true;
            this.lblfeha1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfeha1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfeha1.Location = new System.Drawing.Point(285, 234);
            this.lblfeha1.Name = "lblfeha1";
            this.lblfeha1.Size = new System.Drawing.Size(20, 31);
            this.lblfeha1.TabIndex = 11;
            this.lblfeha1.Text = " ";
            // 
            // lblfecha2
            // 
            this.lblfecha2.AutoSize = true;
            this.lblfecha2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfecha2.Location = new System.Drawing.Point(483, 234);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(20, 31);
            this.lblfecha2.TabIndex = 10;
            this.lblfecha2.Text = " ";
            // 
            // lbltxt6
            // 
            this.lbltxt6.AutoSize = true;
            this.lbltxt6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt6.Location = new System.Drawing.Point(61, 265);
            this.lbltxt6.Name = "lbltxt6";
            this.lbltxt6.Size = new System.Drawing.Size(129, 31);
            this.lbltxt6.TabIndex = 9;
            this.lbltxt6.Text = "vacunacion";
            // 
            // lbltxt5
            // 
            this.lbltxt5.AutoSize = true;
            this.lbltxt5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt5.Location = new System.Drawing.Point(586, 234);
            this.lbltxt5.Name = "lbltxt5";
            this.lbltxt5.Size = new System.Drawing.Size(183, 31);
            this.lbltxt5.TabIndex = 8;
            this.lbltxt5.Text = ", en el centro de ";
            // 
            // lbltxt4
            // 
            this.lbltxt4.AutoSize = true;
            this.lbltxt4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt4.Location = new System.Drawing.Point(382, 234);
            this.lbltxt4.Name = "lbltxt4";
            this.lbltxt4.Size = new System.Drawing.Size(71, 31);
            this.lbltxt4.TabIndex = 7;
            this.lbltxt4.Text = ", a las";
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.White;
            this.btnimprimir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnimprimir.Location = new System.Drawing.Point(318, 541);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(168, 35);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.Text = "Imprimir cita";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha.Location = new System.Drawing.Point(279, 234);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 31);
            this.lblfecha.TabIndex = 5;
            // 
            // lbltxt3
            // 
            this.lbltxt3.AutoSize = true;
            this.lbltxt3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt3.Location = new System.Drawing.Point(61, 234);
            this.lbltxt3.Name = "lbltxt3";
            this.lbltxt3.Size = new System.Drawing.Size(221, 31);
            this.lbltxt3.TabIndex = 4;
            this.lbltxt3.Text = "Te esperamos el dia ";
            // 
            // lbltxt2
            // 
            this.lbltxt2.AutoSize = true;
            this.lbltxt2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt2.Location = new System.Drawing.Point(61, 203);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(112, 31);
            this.lbltxt2.TabIndex = 3;
            this.lbltxt2.Text = "COVID-19";
            // 
            // lbltxtx1
            // 
            this.lbltxtx1.AutoSize = true;
            this.lbltxtx1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxtx1.Location = new System.Drawing.Point(61, 172);
            this.lbltxtx1.Name = "lbltxtx1";
            this.lbltxtx1.Size = new System.Drawing.Size(708, 31);
            this.lbltxtx1.TabIndex = 2;
            this.lbltxtx1.Text = "Te confirmamos que ya esta agendado tu cita para recibir la vacuna ";
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltxt1.Location = new System.Drawing.Point(28, 172);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(0, 31);
            this.lbltxt1.TabIndex = 1;
            this.lbltxt1.Click += new System.EventHandler(this.label4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.llbimpdui, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblimpdui, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblimpname, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(793, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // llbimpdui
            // 
            this.llbimpdui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.llbimpdui.AutoSize = true;
            this.llbimpdui.Location = new System.Drawing.Point(531, 10);
            this.llbimpdui.Name = "llbimpdui";
            this.llbimpdui.Size = new System.Drawing.Size(259, 20);
            this.llbimpdui.TabIndex = 2;
            // 
            // lblimpdui
            // 
            this.lblimpdui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblimpdui.AutoSize = true;
            this.lblimpdui.Location = new System.Drawing.Point(267, 10);
            this.lblimpdui.Name = "lblimpdui";
            this.lblimpdui.Size = new System.Drawing.Size(258, 20);
            this.lblimpdui.TabIndex = 1;
            // 
            // lblimpname
            // 
            this.lblimpname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblimpname.AutoSize = true;
            this.lblimpname.Location = new System.Drawing.Point(3, 10);
            this.lblimpname.Name = "lblimpname";
            this.lblimpname.Size = new System.Drawing.Size(258, 20);
            this.lblimpname.TabIndex = 0;
            // 
            // tabDateFollowUp
            // 
            this.tabDateFollowUp.Controls.Add(this.btn_printDFU);
            this.tabDateFollowUp.Controls.Add(this.tableLayoutPanel3);
            this.tabDateFollowUp.Controls.Add(this.txt_Dui);
            this.tabDateFollowUp.Controls.Add(this.lbl_Dui);
            this.tabDateFollowUp.Location = new System.Drawing.Point(4, 29);
            this.tabDateFollowUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDateFollowUp.Name = "tabDateFollowUp";
            this.tabDateFollowUp.Size = new System.Drawing.Size(864, 668);
            this.tabDateFollowUp.TabIndex = 2;
            this.tabDateFollowUp.Text = "Date Follow Up";
            this.tabDateFollowUp.UseVisualStyleBackColor = true;
            // 
            // btn_printDFU
            // 
            this.btn_printDFU.Location = new System.Drawing.Point(320, 412);
            this.btn_printDFU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_printDFU.Name = "btn_printDFU";
            this.btn_printDFU.Size = new System.Drawing.Size(115, 56);
            this.btn_printDFU.TabIndex = 6;
            this.btn_printDFU.Text = "Print";
            this.btn_printDFU.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_showPlace, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_showDate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_NameDFU, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_DateDFU, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_PlaceDFU, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_showname, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(222, 141);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 224);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lbl_showPlace
            // 
            this.lbl_showPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showPlace.AutoSize = true;
            this.lbl_showPlace.Location = new System.Drawing.Point(98, 148);
            this.lbl_showPlace.Name = "lbl_showPlace";
            this.lbl_showPlace.Size = new System.Drawing.Size(216, 20);
            this.lbl_showPlace.TabIndex = 5;
            this.lbl_showPlace.Text = "label1";
            // 
            // lbl_showDate
            // 
            this.lbl_showDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showDate.AutoSize = true;
            this.lbl_showDate.Location = new System.Drawing.Point(98, 74);
            this.lbl_showDate.Name = "lbl_showDate";
            this.lbl_showDate.Size = new System.Drawing.Size(216, 20);
            this.lbl_showDate.TabIndex = 4;
            this.lbl_showDate.Text = "label1";
            // 
            // lbl_NameDFU
            // 
            this.lbl_NameDFU.AutoSize = true;
            this.lbl_NameDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameDFU.Location = new System.Drawing.Point(3, 0);
            this.lbl_NameDFU.Name = "lbl_NameDFU";
            this.lbl_NameDFU.Size = new System.Drawing.Size(68, 28);
            this.lbl_NameDFU.TabIndex = 0;
            this.lbl_NameDFU.Text = "Name:";
            // 
            // lbl_DateDFU
            // 
            this.lbl_DateDFU.AutoSize = true;
            this.lbl_DateDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateDFU.Location = new System.Drawing.Point(3, 74);
            this.lbl_DateDFU.Name = "lbl_DateDFU";
            this.lbl_DateDFU.Size = new System.Drawing.Size(57, 28);
            this.lbl_DateDFU.TabIndex = 1;
            this.lbl_DateDFU.Text = "Date:";
            // 
            // lbl_PlaceDFU
            // 
            this.lbl_PlaceDFU.AutoSize = true;
            this.lbl_PlaceDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PlaceDFU.Location = new System.Drawing.Point(3, 148);
            this.lbl_PlaceDFU.Name = "lbl_PlaceDFU";
            this.lbl_PlaceDFU.Size = new System.Drawing.Size(61, 28);
            this.lbl_PlaceDFU.TabIndex = 2;
            this.lbl_PlaceDFU.Text = "Place:";
            // 
            // lbl_showname
            // 
            this.lbl_showname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showname.AutoSize = true;
            this.lbl_showname.Location = new System.Drawing.Point(98, 0);
            this.lbl_showname.Name = "lbl_showname";
            this.lbl_showname.Size = new System.Drawing.Size(216, 20);
            this.lbl_showname.TabIndex = 3;
            this.lbl_showname.Text = "label1";
            // 
            // txt_Dui
            // 
            this.txt_Dui.Location = new System.Drawing.Point(256, 55);
            this.txt_Dui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Dui.Name = "txt_Dui";
            this.txt_Dui.Size = new System.Drawing.Size(110, 27);
            this.txt_Dui.TabIndex = 1;
            // 
            // lbl_Dui
            // 
            this.lbl_Dui.AutoSize = true;
            this.lbl_Dui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dui.Location = new System.Drawing.Point(185, 55);
            this.lbl_Dui.Name = "lbl_Dui";
            this.lbl_Dui.Size = new System.Drawing.Size(45, 25);
            this.lbl_Dui.TabIndex = 0;
            this.lbl_Dui.Text = "Dui:";
            // 
            // tabVaccinationProcess
            // 
            this.tabVaccinationProcess.Location = new System.Drawing.Point(4, 29);
            this.tabVaccinationProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabVaccinationProcess.Name = "tabVaccinationProcess";
            this.tabVaccinationProcess.Size = new System.Drawing.Size(864, 668);
            this.tabVaccinationProcess.TabIndex = 3;
            this.tabVaccinationProcess.Text = "Vaccine Process";
            this.tabVaccinationProcess.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 772);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDateProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisease)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabVaccination.ResumeLayout(false);
            this.tabVaccination.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabDateFollowUp.ResumeLayout(false);
            this.tabDateFollowUp.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDateProcess;
        private System.Windows.Forms.TabPage tabVaccination;
        private System.Windows.Forms.TabPage tabDateFollowUp;
        private System.Windows.Forms.TabPage tabVaccinationProcess;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Label lblInstitution;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btn_printDFU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_showPlace;
        private System.Windows.Forms.Label lbl_showDate;
        private System.Windows.Forms.Label lbl_NameDFU;
        private System.Windows.Forms.Label lbl_DateDFU;
        private System.Windows.Forms.Label lbl_PlaceDFU;
        private System.Windows.Forms.Label lbl_showname;
        private System.Windows.Forms.TextBox txt_Dui;
        private System.Windows.Forms.Label lbl_Dui;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkInstQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDiseaseAsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDisType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.ComboBox cmbInstitution;
        private System.Windows.Forms.Button btnAddNewInst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label llbimpdui;
        private System.Windows.Forms.Label lblimpdui;
        private System.Windows.Forms.Label lblimpname;
        private System.Windows.Forms.Label lbltxt1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltxt3;
        private System.Windows.Forms.Label lbltxt2;
        private System.Windows.Forms.Label lbltxtx1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label lblfecha2;
        private System.Windows.Forms.Label lbltxt6;
        private System.Windows.Forms.Label lbltxt5;
        private System.Windows.Forms.Label lbltxt4;
        private System.Windows.Forms.Label lbltxt9;
        private System.Windows.Forms.Label lbltxt8;
        private System.Windows.Forms.Label lbltxt7;
        private System.Windows.Forms.Label lblplacevacun;
        private System.Windows.Forms.Label lblfeha1;
    }
}