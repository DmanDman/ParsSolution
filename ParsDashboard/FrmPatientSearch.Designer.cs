namespace ParsDashboard
{
    partial class FrmPatientSearch
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
            this.TabSearch = new System.Windows.Forms.TabControl();
            this.TabPersonal = new System.Windows.Forms.TabPage();
            this.GrpBoxPersonal = new System.Windows.Forms.GroupBox();
            this.MTxtssn = new System.Windows.Forms.MaskedTextBox();
            this.TxtPatientNum = new System.Windows.Forms.TextBox();
            this.LblPatientNum = new System.Windows.Forms.Label();
            this.LblSSN = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.ChkAge = new System.Windows.Forms.CheckBox();
            this.ChkDOB = new System.Windows.Forms.CheckBox();
            this.ChkSurgeryDate = new System.Windows.Forms.CheckBox();
            this.LblSex = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtDob = new System.Windows.Forms.TextBox();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.TxtSurgeryDate = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MTxtZip = new System.Windows.Forms.MaskedTextBox();
            this.MTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.MTxtCell = new System.Windows.Forms.MaskedTextBox();
            this.LblCell = new System.Windows.Forms.Label();
            this.CboState = new System.Windows.Forms.ComboBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblAddress2 = new System.Windows.Forms.Label();
            this.LblAddress1 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.MnuPatientSearch = new System.Windows.Forms.MenuStrip();
            this.TSMnuPatientSrchSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuBlank1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuPatientSrchClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TabSearch.SuspendLayout();
            this.TabPersonal.SuspendLayout();
            this.GrpBoxPersonal.SuspendLayout();
            this.TabHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MnuPatientSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.TabPersonal);
            this.TabSearch.Controls.Add(this.TabHome);
            this.TabSearch.Location = new System.Drawing.Point(12, 46);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.SelectedIndex = 0;
            this.TabSearch.Size = new System.Drawing.Size(387, 428);
            this.TabSearch.TabIndex = 0;
            this.TabSearch.SelectedIndexChanged += new System.EventHandler(this.TabSearch_SelectedIndexChanged);
            // 
            // TabPersonal
            // 
            this.TabPersonal.Controls.Add(this.GrpBoxPersonal);
            this.TabPersonal.Location = new System.Drawing.Point(4, 25);
            this.TabPersonal.Name = "TabPersonal";
            this.TabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.TabPersonal.Size = new System.Drawing.Size(379, 399);
            this.TabPersonal.TabIndex = 0;
            this.TabPersonal.Text = "Personal Info";
            this.TabPersonal.UseVisualStyleBackColor = true;
            // 
            // GrpBoxPersonal
            // 
            this.GrpBoxPersonal.Controls.Add(this.MTxtssn);
            this.GrpBoxPersonal.Controls.Add(this.TxtPatientNum);
            this.GrpBoxPersonal.Controls.Add(this.LblPatientNum);
            this.GrpBoxPersonal.Controls.Add(this.LblSSN);
            this.GrpBoxPersonal.Controls.Add(this.TxtAge);
            this.GrpBoxPersonal.Controls.Add(this.ChkAge);
            this.GrpBoxPersonal.Controls.Add(this.ChkDOB);
            this.GrpBoxPersonal.Controls.Add(this.ChkSurgeryDate);
            this.GrpBoxPersonal.Controls.Add(this.LblSex);
            this.GrpBoxPersonal.Controls.Add(this.LblFirstName);
            this.GrpBoxPersonal.Controls.Add(this.LblLastName);
            this.GrpBoxPersonal.Controls.Add(this.TxtDob);
            this.GrpBoxPersonal.Controls.Add(this.RdoFemale);
            this.GrpBoxPersonal.Controls.Add(this.RdoMale);
            this.GrpBoxPersonal.Controls.Add(this.TxtSurgeryDate);
            this.GrpBoxPersonal.Controls.Add(this.TxtFirstName);
            this.GrpBoxPersonal.Controls.Add(this.TxtLastName);
            this.GrpBoxPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxPersonal.Location = new System.Drawing.Point(21, 17);
            this.GrpBoxPersonal.Name = "GrpBoxPersonal";
            this.GrpBoxPersonal.Size = new System.Drawing.Size(310, 369);
            this.GrpBoxPersonal.TabIndex = 0;
            this.GrpBoxPersonal.TabStop = false;
            this.GrpBoxPersonal.Tag = "GrpBoxPersonal";
            this.GrpBoxPersonal.Text = "Personal Info";
            // 
            // MTxtssn
            // 
            this.MTxtssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtssn.Location = new System.Drawing.Point(123, 327);
            this.MTxtssn.Mask = "000-00-0000";
            this.MTxtssn.Name = "MTxtssn";
            this.MTxtssn.Size = new System.Drawing.Size(161, 22);
            this.MTxtssn.TabIndex = 16;
            // 
            // TxtPatientNum
            // 
            this.TxtPatientNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatientNum.Location = new System.Drawing.Point(123, 115);
            this.TxtPatientNum.Name = "TxtPatientNum";
            this.TxtPatientNum.Size = new System.Drawing.Size(166, 22);
            this.TxtPatientNum.TabIndex = 5;
            // 
            // LblPatientNum
            // 
            this.LblPatientNum.AutoSize = true;
            this.LblPatientNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientNum.Location = new System.Drawing.Point(6, 115);
            this.LblPatientNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPatientNum.Name = "LblPatientNum";
            this.LblPatientNum.Size = new System.Drawing.Size(85, 17);
            this.LblPatientNum.TabIndex = 4;
            this.LblPatientNum.Text = "Patient Num";
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSN.Location = new System.Drawing.Point(6, 327);
            this.LblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(36, 17);
            this.LblSSN.TabIndex = 15;
            this.LblSSN.Text = "SSN";
            // 
            // TxtAge
            // 
            this.TxtAge.Enabled = false;
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(123, 243);
            this.TxtAge.Multiline = true;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(166, 22);
            this.TxtAge.TabIndex = 11;
            // 
            // ChkAge
            // 
            this.ChkAge.AutoSize = true;
            this.ChkAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAge.Location = new System.Drawing.Point(6, 243);
            this.ChkAge.Name = "ChkAge";
            this.ChkAge.Size = new System.Drawing.Size(55, 21);
            this.ChkAge.TabIndex = 10;
            this.ChkAge.Text = "Age";
            this.ChkAge.UseVisualStyleBackColor = true;
            this.ChkAge.CheckedChanged += new System.EventHandler(this.ChkAge_CheckedChanged);
            this.ChkAge.Click += new System.EventHandler(this.ChkAge_Click);
            // 
            // ChkDOB
            // 
            this.ChkDOB.AutoSize = true;
            this.ChkDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDOB.Location = new System.Drawing.Point(6, 199);
            this.ChkDOB.Name = "ChkDOB";
            this.ChkDOB.Size = new System.Drawing.Size(72, 21);
            this.ChkDOB.TabIndex = 8;
            this.ChkDOB.Text = "D.O.B.";
            this.ChkDOB.UseVisualStyleBackColor = true;
            this.ChkDOB.CheckedChanged += new System.EventHandler(this.ChkDOB_CheckedChanged);
            this.ChkDOB.Click += new System.EventHandler(this.ChkDOB_Click);
            // 
            // ChkSurgeryDate
            // 
            this.ChkSurgeryDate.AutoSize = true;
            this.ChkSurgeryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSurgeryDate.Location = new System.Drawing.Point(6, 155);
            this.ChkSurgeryDate.Name = "ChkSurgeryDate";
            this.ChkSurgeryDate.Size = new System.Drawing.Size(114, 21);
            this.ChkSurgeryDate.TabIndex = 6;
            this.ChkSurgeryDate.Text = "Surgery Date";
            this.ChkSurgeryDate.UseVisualStyleBackColor = true;
            this.ChkSurgeryDate.CheckedChanged += new System.EventHandler(this.ChkSurgeryDate_CheckedChanged);
            this.ChkSurgeryDate.Click += new System.EventHandler(this.ChkSurgeryDate_Click);
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSex.Location = new System.Drawing.Point(6, 287);
            this.LblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(31, 17);
            this.LblSex.TabIndex = 12;
            this.LblSex.Text = "Sex";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(6, 75);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(76, 17);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(6, 35);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(76, 17);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Last Name";
            // 
            // TxtDob
            // 
            this.TxtDob.Enabled = false;
            this.TxtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDob.Location = new System.Drawing.Point(123, 199);
            this.TxtDob.Multiline = true;
            this.TxtDob.Name = "TxtDob";
            this.TxtDob.Size = new System.Drawing.Size(166, 22);
            this.TxtDob.TabIndex = 9;
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoFemale.Location = new System.Drawing.Point(189, 287);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(75, 21);
            this.RdoFemale.TabIndex = 14;
            this.RdoFemale.TabStop = true;
            this.RdoFemale.Text = "Female";
            this.RdoFemale.UseVisualStyleBackColor = true;
            // 
            // RdoMale
            // 
            this.RdoMale.AutoSize = true;
            this.RdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoMale.Location = new System.Drawing.Point(123, 287);
            this.RdoMale.Name = "RdoMale";
            this.RdoMale.Size = new System.Drawing.Size(59, 21);
            this.RdoMale.TabIndex = 13;
            this.RdoMale.TabStop = true;
            this.RdoMale.Text = "Male";
            this.RdoMale.UseVisualStyleBackColor = true;
            // 
            // TxtSurgeryDate
            // 
            this.TxtSurgeryDate.Enabled = false;
            this.TxtSurgeryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurgeryDate.Location = new System.Drawing.Point(123, 155);
            this.TxtSurgeryDate.Multiline = true;
            this.TxtSurgeryDate.Name = "TxtSurgeryDate";
            this.TxtSurgeryDate.Size = new System.Drawing.Size(166, 22);
            this.TxtSurgeryDate.TabIndex = 7;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(123, 75);
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
            // TabHome
            // 
            this.TabHome.Controls.Add(this.groupBox1);
            this.TabHome.Location = new System.Drawing.Point(4, 25);
            this.TabHome.Name = "TabHome";
            this.TabHome.Padding = new System.Windows.Forms.Padding(3);
            this.TabHome.Size = new System.Drawing.Size(379, 399);
            this.TabHome.TabIndex = 1;
            this.TabHome.Text = "Home";
            this.TabHome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MTxtZip);
            this.groupBox1.Controls.Add(this.MTxtPhone);
            this.groupBox1.Controls.Add(this.MTxtCell);
            this.groupBox1.Controls.Add(this.LblCell);
            this.groupBox1.Controls.Add(this.CboState);
            this.groupBox1.Controls.Add(this.LblPhone);
            this.groupBox1.Controls.Add(this.LblZip);
            this.groupBox1.Controls.Add(this.LblState);
            this.groupBox1.Controls.Add(this.LblCity);
            this.groupBox1.Controls.Add(this.LblAddress2);
            this.groupBox1.Controls.Add(this.LblAddress1);
            this.groupBox1.Controls.Add(this.TxtCity);
            this.groupBox1.Controls.Add(this.TxtAddress2);
            this.groupBox1.Controls.Add(this.TxtAddress1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "GrpBoxPersonal";
            this.groupBox1.Text = "Home";
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
            // MTxtPhone
            // 
            this.MTxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtPhone.Location = new System.Drawing.Point(123, 243);
            this.MTxtPhone.Mask = "(000) 000-0000";
            this.MTxtPhone.Name = "MTxtPhone";
            this.MTxtPhone.Size = new System.Drawing.Size(161, 22);
            this.MTxtPhone.TabIndex = 11;
            // 
            // MTxtCell
            // 
            this.MTxtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtCell.Location = new System.Drawing.Point(123, 282);
            this.MTxtCell.Mask = "(000) 000-0000";
            this.MTxtCell.Name = "MTxtCell";
            this.MTxtCell.Size = new System.Drawing.Size(161, 22);
            this.MTxtCell.TabIndex = 13;
            // 
            // LblCell
            // 
            this.LblCell.AutoSize = true;
            this.LblCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCell.Location = new System.Drawing.Point(7, 282);
            this.LblCell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCell.Name = "LblCell";
            this.LblCell.Size = new System.Drawing.Size(31, 17);
            this.LblCell.TabIndex = 12;
            this.LblCell.Text = "Cell";
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
            this.CboState.Location = new System.Drawing.Point(123, 155);
            this.CboState.MaxLength = 2;
            this.CboState.Name = "CboState";
            this.CboState.Size = new System.Drawing.Size(75, 24);
            this.CboState.Sorted = true;
            this.CboState.TabIndex = 7;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(6, 240);
            this.LblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(49, 17);
            this.LblPhone.TabIndex = 10;
            this.LblPhone.Text = "Phone";
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblZip.Location = new System.Drawing.Point(6, 199);
            this.LblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(28, 17);
            this.LblZip.TabIndex = 8;
            this.LblZip.Text = "Zip";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblState.Location = new System.Drawing.Point(6, 158);
            this.LblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 17);
            this.LblState.TabIndex = 6;
            this.LblState.Text = "State";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(6, 117);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(31, 17);
            this.LblCity.TabIndex = 4;
            this.LblCity.Text = "City";
            // 
            // LblAddress2
            // 
            this.LblAddress2.AutoSize = true;
            this.LblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress2.Location = new System.Drawing.Point(6, 76);
            this.LblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress2.Name = "LblAddress2";
            this.LblAddress2.Size = new System.Drawing.Size(72, 17);
            this.LblAddress2.TabIndex = 2;
            this.LblAddress2.Text = "Address 2";
            // 
            // LblAddress1
            // 
            this.LblAddress1.AutoSize = true;
            this.LblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress1.Location = new System.Drawing.Point(5, 38);
            this.LblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress1.Name = "LblAddress1";
            this.LblAddress1.Size = new System.Drawing.Size(72, 17);
            this.LblAddress1.TabIndex = 0;
            this.LblAddress1.Text = "Address 1";
            // 
            // TxtCity
            // 
            this.TxtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.Location = new System.Drawing.Point(123, 115);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(166, 22);
            this.TxtCity.TabIndex = 5;
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress2.Location = new System.Drawing.Point(123, 75);
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
            // MnuPatientSearch
            // 
            this.MnuPatientSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuPatientSearch.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuPatientSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuPatientSrchSearch,
            this.TSMnuBlank1,
            this.TSMnuPatientSrchClear});
            this.MnuPatientSearch.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuPatientSearch.Location = new System.Drawing.Point(0, 0);
            this.MnuPatientSearch.Name = "MnuPatientSearch";
            this.MnuPatientSearch.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuPatientSearch.Size = new System.Drawing.Size(1368, 28);
            this.MnuPatientSearch.TabIndex = 15;
            this.MnuPatientSearch.Text = "menuStrip1";
            // 
            // TSMnuPatientSrchSearch
            // 
            this.TSMnuPatientSrchSearch.Name = "TSMnuPatientSrchSearch";
            this.TSMnuPatientSrchSearch.Size = new System.Drawing.Size(65, 24);
            this.TSMnuPatientSrchSearch.Text = "Search";
            this.TSMnuPatientSrchSearch.Click += new System.EventHandler(this.TSMnuPatientSrchSearch_Click);
            // 
            // TSMnuBlank1
            // 
            this.TSMnuBlank1.Enabled = false;
            this.TSMnuBlank1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuBlank1.Name = "TSMnuBlank1";
            this.TSMnuBlank1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuBlank1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuBlank1.Text = "|";
            // 
            // TSMnuPatientSrchClear
            // 
            this.TSMnuPatientSrchClear.Name = "TSMnuPatientSrchClear";
            this.TSMnuPatientSrchClear.Size = new System.Drawing.Size(55, 24);
            this.TSMnuPatientSrchClear.Text = "Clear";
            this.TSMnuPatientSrchClear.Click += new System.EventHandler(this.TSMnuPatientSrchClear_Click);
            // 
            // FrmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 840);
            this.ControlBox = false;
            this.Controls.Add(this.MnuPatientSearch);
            this.Controls.Add(this.TabSearch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmPatientSearch";
            this.Text = "Patient - Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TabSearch.ResumeLayout(false);
            this.TabPersonal.ResumeLayout(false);
            this.GrpBoxPersonal.ResumeLayout(false);
            this.GrpBoxPersonal.PerformLayout();
            this.TabHome.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MnuPatientSearch.ResumeLayout(false);
            this.MnuPatientSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabSearch;
        private System.Windows.Forms.TabPage TabPersonal;
        private System.Windows.Forms.GroupBox GrpBoxPersonal;
        private System.Windows.Forms.TextBox TxtDob;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
        private System.Windows.Forms.TextBox TxtSurgeryDate;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TabPage TabHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblSex;
        private System.Windows.Forms.CheckBox ChkDOB;
        private System.Windows.Forms.CheckBox ChkSurgeryDate;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.CheckBox ChkAge;
        private System.Windows.Forms.TextBox TxtPatientNum;
        private System.Windows.Forms.Label LblPatientNum;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblAddress2;
        private System.Windows.Forms.Label LblAddress1;
        private System.Windows.Forms.ComboBox CboState;
        private System.Windows.Forms.Label LblCell;
        private System.Windows.Forms.MaskedTextBox MTxtssn;
        private System.Windows.Forms.MaskedTextBox MTxtZip;
        private System.Windows.Forms.MaskedTextBox MTxtPhone;
        private System.Windows.Forms.MaskedTextBox MTxtCell;
        private System.Windows.Forms.MenuStrip MnuPatientSearch;
        private System.Windows.Forms.ToolStripMenuItem TSMnuPatientSrchSearch;
        private System.Windows.Forms.ToolStripMenuItem TSMnuBlank1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuPatientSrchClear;
    }
}