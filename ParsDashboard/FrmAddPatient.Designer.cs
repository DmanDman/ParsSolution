namespace ParsDashboard
{
    partial class FrmAddPatient
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
            this.MnuAddNew = new System.Windows.Forms.MenuStrip();
            this.TSMnuAddNewBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddNewClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpPatient = new System.Windows.Forms.GroupBox();
            this.TabPatient = new System.Windows.Forms.TabControl();
            this.TabPatientPersonal = new System.Windows.Forms.TabPage();
            this.GrpPersonal = new System.Windows.Forms.GroupBox();
            this.MTxtssn = new System.Windows.Forms.MaskedTextBox();
            this.TxtPatNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TabPatientHome = new System.Windows.Forms.TabPage();
            this.GrpHome = new System.Windows.Forms.GroupBox();
            this.MTxtCell = new System.Windows.Forms.MaskedTextBox();
            this.MTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.MTxtZip = new System.Windows.Forms.MaskedTextBox();
            this.CboState = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TabPatientSurgery = new System.Windows.Forms.TabPage();
            this.GrpSurgery = new System.Windows.Forms.GroupBox();
            this.DtFiscalYear = new System.Windows.Forms.DateTimePicker();
            this.DtSurgeryDate = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.DtStart = new System.Windows.Forms.DateTimePicker();
            this.LblDob = new System.Windows.Forms.Label();
            this.MnuAddNew.SuspendLayout();
            this.GrpPatient.SuspendLayout();
            this.TabPatient.SuspendLayout();
            this.TabPatientPersonal.SuspendLayout();
            this.GrpPersonal.SuspendLayout();
            this.TabPatientHome.SuspendLayout();
            this.GrpHome.SuspendLayout();
            this.TabPatientSurgery.SuspendLayout();
            this.GrpSurgery.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuAddNew
            // 
            this.MnuAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuAddNew.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuAddNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuAddNewSave,
            this.TSMnuAddNewBreak1,
            this.TSMnuAddNewClear});
            this.MnuAddNew.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuAddNew.Location = new System.Drawing.Point(0, 0);
            this.MnuAddNew.Name = "MnuAddNew";
            this.MnuAddNew.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuAddNew.Size = new System.Drawing.Size(1549, 28);
            this.MnuAddNew.TabIndex = 38;
            this.MnuAddNew.Text = "menuStrip1";
            // 
            // TSMnuAddNewBreak1
            // 
            this.TSMnuAddNewBreak1.Enabled = false;
            this.TSMnuAddNewBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuAddNewBreak1.Name = "TSMnuAddNewBreak1";
            this.TSMnuAddNewBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuAddNewBreak1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuAddNewBreak1.Text = "|";
            // 
            // TSMnuAddNewClear
            // 
            this.TSMnuAddNewClear.Name = "TSMnuAddNewClear";
            this.TSMnuAddNewClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.TSMnuAddNewClear.Size = new System.Drawing.Size(55, 24);
            this.TSMnuAddNewClear.Text = "Clea&r";
            // 
            // TSMnuAddNewSave
            // 
            this.TSMnuAddNewSave.Name = "TSMnuAddNewSave";
            this.TSMnuAddNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.TSMnuAddNewSave.Size = new System.Drawing.Size(52, 24);
            this.TSMnuAddNewSave.Text = "&Save";
            // 
            // GrpPatient
            // 
            this.GrpPatient.Controls.Add(this.TabPatient);
            this.GrpPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPatient.Location = new System.Drawing.Point(27, 58);
            this.GrpPatient.Name = "GrpPatient";
            this.GrpPatient.Size = new System.Drawing.Size(419, 486);
            this.GrpPatient.TabIndex = 39;
            this.GrpPatient.TabStop = false;
            this.GrpPatient.Text = "Patient";
            // 
            // TabPatient
            // 
            this.TabPatient.Controls.Add(this.TabPatientPersonal);
            this.TabPatient.Controls.Add(this.TabPatientHome);
            this.TabPatient.Controls.Add(this.TabPatientSurgery);
            this.TabPatient.Location = new System.Drawing.Point(15, 31);
            this.TabPatient.Name = "TabPatient";
            this.TabPatient.SelectedIndex = 0;
            this.TabPatient.Size = new System.Drawing.Size(387, 428);
            this.TabPatient.TabIndex = 0;
            // 
            // TabPatientPersonal
            // 
            this.TabPatientPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPatientPersonal.Controls.Add(this.GrpPersonal);
            this.TabPatientPersonal.Location = new System.Drawing.Point(4, 25);
            this.TabPatientPersonal.Name = "TabPatientPersonal";
            this.TabPatientPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.TabPatientPersonal.Size = new System.Drawing.Size(379, 399);
            this.TabPatientPersonal.TabIndex = 0;
            this.TabPatientPersonal.Text = "Personal Info";
            this.TabPatientPersonal.UseVisualStyleBackColor = true;
            // 
            // GrpPersonal
            // 
            this.GrpPersonal.Controls.Add(this.LblDob);
            this.GrpPersonal.Controls.Add(this.DtStart);
            this.GrpPersonal.Controls.Add(this.MTxtssn);
            this.GrpPersonal.Controls.Add(this.TxtPatNum);
            this.GrpPersonal.Controls.Add(this.label3);
            this.GrpPersonal.Controls.Add(this.label4);
            this.GrpPersonal.Controls.Add(this.label5);
            this.GrpPersonal.Controls.Add(this.label6);
            this.GrpPersonal.Controls.Add(this.label18);
            this.GrpPersonal.Controls.Add(this.RdoFemale);
            this.GrpPersonal.Controls.Add(this.RdoMale);
            this.GrpPersonal.Controls.Add(this.TxtFirstName);
            this.GrpPersonal.Controls.Add(this.TxtLastName);
            this.GrpPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPersonal.Location = new System.Drawing.Point(21, 17);
            this.GrpPersonal.Name = "GrpPersonal";
            this.GrpPersonal.Size = new System.Drawing.Size(310, 369);
            this.GrpPersonal.TabIndex = 0;
            this.GrpPersonal.TabStop = false;
            this.GrpPersonal.Tag = "GrpBoxPersonal";
            this.GrpPersonal.Text = "Personal Info";
            // 
            // MTxtssn
            // 
            this.MTxtssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtssn.Location = new System.Drawing.Point(123, 239);
            this.MTxtssn.Mask = "000-00-0000";
            this.MTxtssn.Name = "MTxtssn";
            this.MTxtssn.Size = new System.Drawing.Size(161, 22);
            this.MTxtssn.TabIndex = 14;
            // 
            // TxtPatNum
            // 
            this.TxtPatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatNum.Location = new System.Drawing.Point(123, 117);
            this.TxtPatNum.Name = "TxtPatNum";
            this.TxtPatNum.Size = new System.Drawing.Size(166, 22);
            this.TxtPatNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "First Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 35);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Last Name";
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoFemale.Location = new System.Drawing.Point(189, 198);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(75, 21);
            this.RdoFemale.TabIndex = 12;
            this.RdoFemale.TabStop = true;
            this.RdoFemale.Text = "Female";
            this.RdoFemale.UseVisualStyleBackColor = true;
            // 
            // RdoMale
            // 
            this.RdoMale.AutoSize = true;
            this.RdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoMale.Location = new System.Drawing.Point(123, 198);
            this.RdoMale.Name = "RdoMale";
            this.RdoMale.Size = new System.Drawing.Size(59, 21);
            this.RdoMale.TabIndex = 11;
            this.RdoMale.TabStop = true;
            this.RdoMale.Text = "Male";
            this.RdoMale.UseVisualStyleBackColor = true;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(123, 76);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(166, 22);
            this.TxtFirstName.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(123, 35);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(166, 22);
            this.TxtLastName.TabIndex = 1;
            // 
            // TabPatientHome
            // 
            this.TabPatientHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPatientHome.Controls.Add(this.GrpHome);
            this.TabPatientHome.Location = new System.Drawing.Point(4, 25);
            this.TabPatientHome.Name = "TabPatientHome";
            this.TabPatientHome.Padding = new System.Windows.Forms.Padding(3);
            this.TabPatientHome.Size = new System.Drawing.Size(379, 399);
            this.TabPatientHome.TabIndex = 1;
            this.TabPatientHome.Text = "Home";
            this.TabPatientHome.UseVisualStyleBackColor = true;
            // 
            // GrpHome
            // 
            this.GrpHome.Controls.Add(this.MTxtCell);
            this.GrpHome.Controls.Add(this.MTxtPhone);
            this.GrpHome.Controls.Add(this.MTxtZip);
            this.GrpHome.Controls.Add(this.CboState);
            this.GrpHome.Controls.Add(this.label19);
            this.GrpHome.Controls.Add(this.label20);
            this.GrpHome.Controls.Add(this.label21);
            this.GrpHome.Controls.Add(this.label22);
            this.GrpHome.Controls.Add(this.label23);
            this.GrpHome.Controls.Add(this.label24);
            this.GrpHome.Controls.Add(this.label25);
            this.GrpHome.Controls.Add(this.TxtCity);
            this.GrpHome.Controls.Add(this.TxtAddress2);
            this.GrpHome.Controls.Add(this.TxtAddress1);
            this.GrpHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpHome.Location = new System.Drawing.Point(21, 17);
            this.GrpHome.Name = "GrpHome";
            this.GrpHome.Size = new System.Drawing.Size(310, 369);
            this.GrpHome.TabIndex = 0;
            this.GrpHome.TabStop = false;
            this.GrpHome.Tag = "GrpBoxPersonal";
            this.GrpHome.Text = "Home";
            // 
            // MTxtCell
            // 
            this.MTxtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtCell.Location = new System.Drawing.Point(123, 281);
            this.MTxtCell.Mask = "(000) 000-0000";
            this.MTxtCell.Name = "MTxtCell";
            this.MTxtCell.Size = new System.Drawing.Size(161, 22);
            this.MTxtCell.TabIndex = 13;
            // 
            // MTxtPhone
            // 
            this.MTxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtPhone.Location = new System.Drawing.Point(123, 240);
            this.MTxtPhone.Mask = "(000) 000-0000";
            this.MTxtPhone.Name = "MTxtPhone";
            this.MTxtPhone.Size = new System.Drawing.Size(161, 22);
            this.MTxtPhone.TabIndex = 11;
            // 
            // MTxtZip
            // 
            this.MTxtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtZip.Location = new System.Drawing.Point(123, 199);
            this.MTxtZip.Mask = "00000";
            this.MTxtZip.Name = "MTxtZip";
            this.MTxtZip.Size = new System.Drawing.Size(161, 22);
            this.MTxtZip.TabIndex = 9;
            // 
            // CboState
            // 
            this.CboState.AutoCompleteCustomSource.AddRange(new string[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.CboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboState.FormattingEnabled = true;
            this.CboState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.CboState.Location = new System.Drawing.Point(123, 158);
            this.CboState.MaxLength = 2;
            this.CboState.Name = "CboState";
            this.CboState.Size = new System.Drawing.Size(75, 24);
            this.CboState.Sorted = true;
            this.CboState.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 281);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Cell";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 240);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "Phone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 199);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "Zip";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 158);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 17);
            this.label22.TabIndex = 6;
            this.label22.Text = "State";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 117);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 17);
            this.label23.TabIndex = 4;
            this.label23.Text = "City";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 76);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 17);
            this.label24.TabIndex = 2;
            this.label24.Text = "Address 2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 35);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Address 1";
            // 
            // TxtCity
            // 
            this.TxtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.Location = new System.Drawing.Point(123, 117);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(166, 22);
            this.TxtCity.TabIndex = 5;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress2.Location = new System.Drawing.Point(123, 76);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(166, 22);
            this.TxtAddress2.TabIndex = 3;
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress1.Location = new System.Drawing.Point(123, 35);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(166, 22);
            this.TxtAddress1.TabIndex = 1;
            // 
            // TabPatientSurgery
            // 
            this.TabPatientSurgery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPatientSurgery.Controls.Add(this.GrpSurgery);
            this.TabPatientSurgery.Location = new System.Drawing.Point(4, 25);
            this.TabPatientSurgery.Name = "TabPatientSurgery";
            this.TabPatientSurgery.Padding = new System.Windows.Forms.Padding(3);
            this.TabPatientSurgery.Size = new System.Drawing.Size(379, 399);
            this.TabPatientSurgery.TabIndex = 2;
            this.TabPatientSurgery.Text = "Surgery";
            this.TabPatientSurgery.UseVisualStyleBackColor = true;
            // 
            // GrpSurgery
            // 
            this.GrpSurgery.Controls.Add(this.DtFiscalYear);
            this.GrpSurgery.Controls.Add(this.DtSurgeryDate);
            this.GrpSurgery.Controls.Add(this.label33);
            this.GrpSurgery.Controls.Add(this.label34);
            this.GrpSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSurgery.Location = new System.Drawing.Point(21, 17);
            this.GrpSurgery.Name = "GrpSurgery";
            this.GrpSurgery.Size = new System.Drawing.Size(310, 369);
            this.GrpSurgery.TabIndex = 0;
            this.GrpSurgery.TabStop = false;
            this.GrpSurgery.Tag = "GrpBoxSurgery";
            this.GrpSurgery.Text = "Surgery";
            // 
            // DtFiscalYear
            // 
            this.DtFiscalYear.CustomFormat = "yyyy";
            this.DtFiscalYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFiscalYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFiscalYear.Location = new System.Drawing.Point(123, 76);
            this.DtFiscalYear.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DtFiscalYear.Name = "DtFiscalYear";
            this.DtFiscalYear.ShowUpDown = true;
            this.DtFiscalYear.Size = new System.Drawing.Size(166, 22);
            this.DtFiscalYear.TabIndex = 3;
            this.DtFiscalYear.Value = new System.DateTime(2019, 1, 13, 17, 43, 52, 0);
            // 
            // DtSurgeryDate
            // 
            this.DtSurgeryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtSurgeryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtSurgeryDate.Location = new System.Drawing.Point(123, 35);
            this.DtSurgeryDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DtSurgeryDate.Name = "DtSurgeryDate";
            this.DtSurgeryDate.Size = new System.Drawing.Size(166, 22);
            this.DtSurgeryDate.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 76);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 17);
            this.label33.TabIndex = 2;
            this.label33.Text = "Fiscal Year";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 35);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 17);
            this.label34.TabIndex = 0;
            this.label34.Text = "Surgery Date";
            // 
            // DtStart
            // 
            this.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtStart.Location = new System.Drawing.Point(123, 158);
            this.DtStart.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(166, 22);
            this.DtStart.TabIndex = 15;
            // 
            // LblDob
            // 
            this.LblDob.AutoSize = true;
            this.LblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDob.Location = new System.Drawing.Point(7, 158);
            this.LblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDob.Name = "LblDob";
            this.LblDob.Size = new System.Drawing.Size(87, 17);
            this.LblDob.TabIndex = 16;
            this.LblDob.Text = "Date of Birth";
            // 
            // FrmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 756);
            this.ControlBox = false;
            this.Controls.Add(this.GrpPatient);
            this.Controls.Add(this.MnuAddNew);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmAddPatient";
            this.Text = "Patient - Add New Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuAddNew.ResumeLayout(false);
            this.MnuAddNew.PerformLayout();
            this.GrpPatient.ResumeLayout(false);
            this.TabPatient.ResumeLayout(false);
            this.TabPatientPersonal.ResumeLayout(false);
            this.GrpPersonal.ResumeLayout(false);
            this.GrpPersonal.PerformLayout();
            this.TabPatientHome.ResumeLayout(false);
            this.GrpHome.ResumeLayout(false);
            this.GrpHome.PerformLayout();
            this.TabPatientSurgery.ResumeLayout(false);
            this.GrpSurgery.ResumeLayout(false);
            this.GrpSurgery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuAddNew;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddNewBreak1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddNewClear;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddNewSave;
        private System.Windows.Forms.GroupBox GrpPatient;
        private System.Windows.Forms.TabControl TabPatient;
        private System.Windows.Forms.TabPage TabPatientPersonal;
        private System.Windows.Forms.GroupBox GrpPersonal;
        private System.Windows.Forms.MaskedTextBox MTxtssn;
        private System.Windows.Forms.TextBox TxtPatNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TabPage TabPatientHome;
        private System.Windows.Forms.GroupBox GrpHome;
        private System.Windows.Forms.MaskedTextBox MTxtCell;
        private System.Windows.Forms.MaskedTextBox MTxtPhone;
        private System.Windows.Forms.MaskedTextBox MTxtZip;
        private System.Windows.Forms.ComboBox CboState;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.TabPage TabPatientSurgery;
        private System.Windows.Forms.GroupBox GrpSurgery;
        private System.Windows.Forms.DateTimePicker DtFiscalYear;
        private System.Windows.Forms.DateTimePicker DtSurgeryDate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label LblDob;
        private System.Windows.Forms.DateTimePicker DtStart;
    }
}