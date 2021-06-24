
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Place = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lblNameVacc = new System.Windows.Forms.Label();
            this.lblDateVacc = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 526);
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
            this.tabDateProcess.Location = new System.Drawing.Point(4, 24);
            this.tabDateProcess.Name = "tabDateProcess";
            this.tabDateProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabDateProcess.Size = new System.Drawing.Size(755, 498);
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
            this.dgvDisease.Location = new System.Drawing.Point(441, 242);
            this.dgvDisease.Name = "dgvDisease";
            this.dgvDisease.ReadOnly = true;
            this.dgvDisease.RowTemplate.Height = 25;
            this.dgvDisease.Size = new System.Drawing.Size(304, 145);
            this.dgvDisease.TabIndex = 19;
            // 
            // Enfermedad
            // 
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.ReadOnly = true;
            this.Enfermedad.Width = 125;
            // 
            // TipoEnfermedad
            // 
            this.TipoEnfermedad.HeaderText = "Tipo de enfermedad";
            this.TipoEnfermedad.Name = "TipoEnfermedad";
            this.TipoEnfermedad.ReadOnly = true;
            this.TipoEnfermedad.Width = 135;
            // 
            // IdTipo
            // 
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.ReadOnly = true;
            this.IdTipo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(22, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 282);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 250);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(70, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(95, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(70, 173);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(95, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 30);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email (opcional)";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Teléfono:";
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(3, 95);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 15);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 136);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(70, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 23);
            this.txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(70, 132);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(95, 23);
            this.txtAddress.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Location = new System.Drawing.Point(70, 50);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(95, 23);
            this.txtAge.TabIndex = 6;
            // 
            // txtDui
            // 
            this.txtDui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDui.Location = new System.Drawing.Point(70, 9);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(95, 23);
            this.txtDui.TabIndex = 7;
            // 
            // lblage
            // 
            this.lblage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(3, 54);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(61, 15);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Edad:";
            // 
            // lblDui
            // 
            this.lblDui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(3, 13);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(61, 15);
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
            this.groupBox2.Location = new System.Drawing.Point(384, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 196);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enfermedad crónica (opcional)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar enfermedad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(145, 77);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(204, 23);
            this.txtDisease.TabIndex = 17;
            // 
            // chkDiseaseAsk
            // 
            this.chkDiseaseAsk.AutoSize = true;
            this.chkDiseaseAsk.Location = new System.Drawing.Point(73, 37);
            this.chkDiseaseAsk.Name = "chkDiseaseAsk";
            this.chkDiseaseAsk.Size = new System.Drawing.Size(215, 19);
            this.chkDiseaseAsk.TabIndex = 16;
            this.chkDiseaseAsk.Text = "¿Posee alguna enfermedad crónica?";
            this.chkDiseaseAsk.UseVisualStyleBackColor = true;
            this.chkDiseaseAsk.CheckedChanged += new System.EventHandler(this.chkDiseaseAsk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo de enfermedad:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enfermedad:";
            // 
            // cmbDisType
            // 
            this.cmbDisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisType.FormattingEnabled = true;
            this.cmbDisType.Location = new System.Drawing.Point(145, 121);
            this.cmbDisType.Name = "cmbDisType";
            this.cmbDisType.Size = new System.Drawing.Size(204, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Institución (opcional)";
            // 
            // btnAddNewInst
            // 
            this.btnAddNewInst.Location = new System.Drawing.Point(281, 121);
            this.btnAddNewInst.Name = "btnAddNewInst";
            this.btnAddNewInst.Size = new System.Drawing.Size(96, 29);
            this.btnAddNewInst.TabIndex = 19;
            this.btnAddNewInst.Text = "Agregar";
            this.btnAddNewInst.UseVisualStyleBackColor = true;
            this.btnAddNewInst.Click += new System.EventHandler(this.btnAddNewInst_Click);
            // 
            // cmbInstitution
            // 
            this.cmbInstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitution.FormattingEnabled = true;
            this.cmbInstitution.Location = new System.Drawing.Point(94, 125);
            this.cmbInstitution.Name = "cmbInstitution";
            this.cmbInstitution.Size = new System.Drawing.Size(172, 23);
            this.cmbInstitution.TabIndex = 18;
            // 
            // chkInstQuestion
            // 
            this.chkInstQuestion.AutoSize = true;
            this.chkInstQuestion.Location = new System.Drawing.Point(103, 34);
            this.chkInstQuestion.Name = "chkInstQuestion";
            this.chkInstQuestion.Size = new System.Drawing.Size(195, 19);
            this.chkInstQuestion.TabIndex = 16;
            this.chkInstQuestion.Text = "¿Pertenece a alguna institución?";
            this.chkInstQuestion.UseVisualStyleBackColor = true;
            this.chkInstQuestion.CheckedChanged += new System.EventHandler(this.chkInstQuestion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Institución:";
            // 
            // lblInstitution
            // 
            this.lblInstitution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.Location = new System.Drawing.Point(6, 78);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(82, 15);
            this.lblInstitution.TabIndex = 12;
            this.lblInstitution.Text = "Identificación:";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(94, 75);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(283, 23);
            this.txtIdentifier.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(607, 410);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(114, 44);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabVaccination
            // 
            this.tabVaccination.Controls.Add(this.btnPrint);
            this.tabVaccination.Controls.Add(this.tableLayoutPanel2);
            this.tabVaccination.Location = new System.Drawing.Point(4, 24);
            this.tabVaccination.Name = "tabVaccination";
            this.tabVaccination.Padding = new System.Windows.Forms.Padding(3);
            this.tabVaccination.Size = new System.Drawing.Size(755, 498);
            this.tabVaccination.TabIndex = 1;
            this.tabVaccination.Text = "Vaccination";
            this.tabVaccination.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(299, 289);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 42);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Place, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Date, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNameVacc, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDateVacc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPlace, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Name, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(213, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(277, 161);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl_Place
            // 
            this.lbl_Place.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Place.AutoSize = true;
            this.lbl_Place.Location = new System.Drawing.Point(86, 106);
            this.lbl_Place.Name = "lbl_Place";
            this.lbl_Place.Size = new System.Drawing.Size(188, 15);
            this.lbl_Place.TabIndex = 5;
            this.lbl_Place.Text = "label1";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(86, 53);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(188, 15);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "label1";
            // 
            // lblNameVacc
            // 
            this.lblNameVacc.AutoSize = true;
            this.lblNameVacc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameVacc.Location = new System.Drawing.Point(3, 0);
            this.lblNameVacc.Name = "lblNameVacc";
            this.lblNameVacc.Size = new System.Drawing.Size(55, 21);
            this.lblNameVacc.TabIndex = 0;
            this.lblNameVacc.Text = "Name:";
            // 
            // lblDateVacc
            // 
            this.lblDateVacc.AutoSize = true;
            this.lblDateVacc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateVacc.Location = new System.Drawing.Point(3, 53);
            this.lblDateVacc.Name = "lblDateVacc";
            this.lblDateVacc.Size = new System.Drawing.Size(45, 21);
            this.lblDateVacc.TabIndex = 1;
            this.lblDateVacc.Text = "Date:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlace.Location = new System.Drawing.Point(3, 106);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(49, 21);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "Place:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(86, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(188, 15);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "label1";
            // 
            // tabDateFollowUp
            // 
            this.tabDateFollowUp.Controls.Add(this.btn_printDFU);
            this.tabDateFollowUp.Controls.Add(this.tableLayoutPanel3);
            this.tabDateFollowUp.Controls.Add(this.txt_Dui);
            this.tabDateFollowUp.Controls.Add(this.lbl_Dui);
            this.tabDateFollowUp.Location = new System.Drawing.Point(4, 24);
            this.tabDateFollowUp.Name = "tabDateFollowUp";
            this.tabDateFollowUp.Size = new System.Drawing.Size(755, 498);
            this.tabDateFollowUp.TabIndex = 2;
            this.tabDateFollowUp.Text = "Date Follow Up";
            this.tabDateFollowUp.UseVisualStyleBackColor = true;
            // 
            // btn_printDFU
            // 
            this.btn_printDFU.Location = new System.Drawing.Point(280, 309);
            this.btn_printDFU.Name = "btn_printDFU";
            this.btn_printDFU.Size = new System.Drawing.Size(101, 42);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(194, 106);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 168);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lbl_showPlace
            // 
            this.lbl_showPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showPlace.AutoSize = true;
            this.lbl_showPlace.Location = new System.Drawing.Point(86, 112);
            this.lbl_showPlace.Name = "lbl_showPlace";
            this.lbl_showPlace.Size = new System.Drawing.Size(188, 15);
            this.lbl_showPlace.TabIndex = 5;
            this.lbl_showPlace.Text = "label1";
            // 
            // lbl_showDate
            // 
            this.lbl_showDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showDate.AutoSize = true;
            this.lbl_showDate.Location = new System.Drawing.Point(86, 56);
            this.lbl_showDate.Name = "lbl_showDate";
            this.lbl_showDate.Size = new System.Drawing.Size(188, 15);
            this.lbl_showDate.TabIndex = 4;
            this.lbl_showDate.Text = "label1";
            // 
            // lbl_NameDFU
            // 
            this.lbl_NameDFU.AutoSize = true;
            this.lbl_NameDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameDFU.Location = new System.Drawing.Point(3, 0);
            this.lbl_NameDFU.Name = "lbl_NameDFU";
            this.lbl_NameDFU.Size = new System.Drawing.Size(55, 21);
            this.lbl_NameDFU.TabIndex = 0;
            this.lbl_NameDFU.Text = "Name:";
            // 
            // lbl_DateDFU
            // 
            this.lbl_DateDFU.AutoSize = true;
            this.lbl_DateDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateDFU.Location = new System.Drawing.Point(3, 56);
            this.lbl_DateDFU.Name = "lbl_DateDFU";
            this.lbl_DateDFU.Size = new System.Drawing.Size(45, 21);
            this.lbl_DateDFU.TabIndex = 1;
            this.lbl_DateDFU.Text = "Date:";
            // 
            // lbl_PlaceDFU
            // 
            this.lbl_PlaceDFU.AutoSize = true;
            this.lbl_PlaceDFU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PlaceDFU.Location = new System.Drawing.Point(3, 112);
            this.lbl_PlaceDFU.Name = "lbl_PlaceDFU";
            this.lbl_PlaceDFU.Size = new System.Drawing.Size(49, 21);
            this.lbl_PlaceDFU.TabIndex = 2;
            this.lbl_PlaceDFU.Text = "Place:";
            // 
            // lbl_showname
            // 
            this.lbl_showname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showname.AutoSize = true;
            this.lbl_showname.Location = new System.Drawing.Point(86, 0);
            this.lbl_showname.Name = "lbl_showname";
            this.lbl_showname.Size = new System.Drawing.Size(188, 15);
            this.lbl_showname.TabIndex = 3;
            this.lbl_showname.Text = "label1";
            // 
            // txt_Dui
            // 
            this.txt_Dui.Location = new System.Drawing.Point(224, 41);
            this.txt_Dui.Name = "txt_Dui";
            this.txt_Dui.Size = new System.Drawing.Size(97, 23);
            this.txt_Dui.TabIndex = 1;
            // 
            // lbl_Dui
            // 
            this.lbl_Dui.AutoSize = true;
            this.lbl_Dui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dui.Location = new System.Drawing.Point(162, 41);
            this.lbl_Dui.Name = "lbl_Dui";
            this.lbl_Dui.Size = new System.Drawing.Size(35, 20);
            this.lbl_Dui.TabIndex = 0;
            this.lbl_Dui.Text = "Dui:";
            // 
            // tabVaccinationProcess
            // 
            this.tabVaccinationProcess.Location = new System.Drawing.Point(4, 24);
            this.tabVaccinationProcess.Name = "tabVaccinationProcess";
            this.tabVaccinationProcess.Size = new System.Drawing.Size(755, 498);
            this.tabVaccinationProcess.TabIndex = 3;
            this.tabVaccinationProcess.Text = "Vaccine Process";
            this.tabVaccinationProcess.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 589);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Place;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lblNameVacc;
        private System.Windows.Forms.Label lblDateVacc;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lbl_Name;
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
    }
}