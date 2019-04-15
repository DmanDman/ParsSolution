namespace ParsDashboard
{
    partial class FrmPatient
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
            this.GrpImage = new System.Windows.Forms.GroupBox();
            this.TabDisplay = new System.Windows.Forms.TabControl();
            this.tabLastName = new System.Windows.Forms.TabPage();
            this.UpDwnLastNameLetter = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboFullName = new System.Windows.Forms.ComboBox();
            this.tabDate = new System.Windows.Forms.TabPage();
            this.UpDwnYear = new System.Windows.Forms.DomainUpDown();
            this.UpDwnMonth = new System.Windows.Forms.DomainUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surgeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpImages = new System.Windows.Forms.GroupBox();
            this.LstImageDesc = new System.Windows.Forms.ListBox();
            this.BtnImagePrev = new System.Windows.Forms.Button();
            this.BtnImageFirst = new System.Windows.Forms.Button();
            this.BtnImageNext = new System.Windows.Forms.Button();
            this.BtnImageLast = new System.Windows.Forms.Button();
            this.TxtImagesCount = new System.Windows.Forms.TextBox();
            this.LblGrpImageDesc = new System.Windows.Forms.Label();
            this.LstImages = new System.Windows.Forms.ListView();
            this.MnuPatient = new System.Windows.Forms.MenuStrip();
            this.TSMnuPatientDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuPatientBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuPatientClear = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpImage.SuspendLayout();
            this.TabDisplay.SuspendLayout();
            this.tabLastName.SuspendLayout();
            this.tabDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrpImages.SuspendLayout();
            this.MnuPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpImage
            // 
            this.GrpImage.Controls.Add(this.TabDisplay);
            this.GrpImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImage.Location = new System.Drawing.Point(12, 46);
            this.GrpImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrpImage.Name = "GrpImage";
            this.GrpImage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrpImage.Size = new System.Drawing.Size(403, 164);
            this.GrpImage.TabIndex = 0;
            this.GrpImage.TabStop = false;
            this.GrpImage.Text = "Display By: Last Name / Date";
            // 
            // TabDisplay
            // 
            this.TabDisplay.Controls.Add(this.tabLastName);
            this.TabDisplay.Controls.Add(this.tabDate);
            this.TabDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDisplay.Location = new System.Drawing.Point(6, 37);
            this.TabDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabDisplay.Name = "TabDisplay";
            this.TabDisplay.SelectedIndex = 0;
            this.TabDisplay.Size = new System.Drawing.Size(379, 121);
            this.TabDisplay.TabIndex = 0;
            this.TabDisplay.SelectedIndexChanged += new System.EventHandler(this.TabDisplay_SelectedIndexChanged);
            // 
            // tabLastName
            // 
            this.tabLastName.Controls.Add(this.UpDwnLastNameLetter);
            this.tabLastName.Controls.Add(this.label2);
            this.tabLastName.Controls.Add(this.label1);
            this.tabLastName.Controls.Add(this.CboFullName);
            this.tabLastName.Location = new System.Drawing.Point(4, 25);
            this.tabLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLastName.Name = "tabLastName";
            this.tabLastName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLastName.Size = new System.Drawing.Size(371, 92);
            this.tabLastName.TabIndex = 0;
            this.tabLastName.Text = "Last Name";
            this.tabLastName.UseVisualStyleBackColor = true;
            // 
            // UpDwnLastNameLetter
            // 
            this.UpDwnLastNameLetter.Items.Add("A");
            this.UpDwnLastNameLetter.Items.Add("B");
            this.UpDwnLastNameLetter.Items.Add("C");
            this.UpDwnLastNameLetter.Items.Add("D");
            this.UpDwnLastNameLetter.Items.Add("E");
            this.UpDwnLastNameLetter.Items.Add("F");
            this.UpDwnLastNameLetter.Items.Add("G");
            this.UpDwnLastNameLetter.Items.Add("H");
            this.UpDwnLastNameLetter.Items.Add("I");
            this.UpDwnLastNameLetter.Items.Add("J");
            this.UpDwnLastNameLetter.Items.Add("K");
            this.UpDwnLastNameLetter.Items.Add("L");
            this.UpDwnLastNameLetter.Items.Add("M");
            this.UpDwnLastNameLetter.Items.Add("N");
            this.UpDwnLastNameLetter.Items.Add("O");
            this.UpDwnLastNameLetter.Items.Add("P");
            this.UpDwnLastNameLetter.Items.Add("Q");
            this.UpDwnLastNameLetter.Items.Add("R");
            this.UpDwnLastNameLetter.Items.Add("S");
            this.UpDwnLastNameLetter.Items.Add("T");
            this.UpDwnLastNameLetter.Items.Add("U");
            this.UpDwnLastNameLetter.Items.Add("V");
            this.UpDwnLastNameLetter.Items.Add("W");
            this.UpDwnLastNameLetter.Items.Add("X");
            this.UpDwnLastNameLetter.Items.Add("Y");
            this.UpDwnLastNameLetter.Items.Add("Z");
            this.UpDwnLastNameLetter.Location = new System.Drawing.Point(9, 41);
            this.UpDwnLastNameLetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpDwnLastNameLetter.Name = "UpDwnLastNameLetter";
            this.UpDwnLastNameLetter.ReadOnly = true;
            this.UpDwnLastNameLetter.Size = new System.Drawing.Size(65, 22);
            this.UpDwnLastNameLetter.Sorted = true;
            this.UpDwnLastNameLetter.TabIndex = 2;
            this.UpDwnLastNameLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starts With";
            // 
            // CboFullName
            // 
            this.CboFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboFullName.FormattingEnabled = true;
            this.CboFullName.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CboFullName.Location = new System.Drawing.Point(103, 41);
            this.CboFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboFullName.Name = "CboFullName";
            this.CboFullName.Size = new System.Drawing.Size(247, 24);
            this.CboFullName.TabIndex = 3;
            // 
            // tabDate
            // 
            this.tabDate.Controls.Add(this.UpDwnYear);
            this.tabDate.Controls.Add(this.UpDwnMonth);
            this.tabDate.Controls.Add(this.comboBox2);
            this.tabDate.Controls.Add(this.label4);
            this.tabDate.Controls.Add(this.label3);
            this.tabDate.Location = new System.Drawing.Point(4, 25);
            this.tabDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDate.Size = new System.Drawing.Size(371, 92);
            this.tabDate.TabIndex = 1;
            this.tabDate.Text = "Date";
            this.tabDate.UseVisualStyleBackColor = true;
            // 
            // UpDwnYear
            // 
            this.UpDwnYear.Items.Add("1980");
            this.UpDwnYear.Items.Add("1981");
            this.UpDwnYear.Items.Add("1982");
            this.UpDwnYear.Items.Add("1983");
            this.UpDwnYear.Items.Add("1984");
            this.UpDwnYear.Items.Add("1985");
            this.UpDwnYear.Items.Add("1986");
            this.UpDwnYear.Items.Add("1987");
            this.UpDwnYear.Items.Add("1988");
            this.UpDwnYear.Items.Add("1989");
            this.UpDwnYear.Items.Add("1990");
            this.UpDwnYear.Items.Add("1991");
            this.UpDwnYear.Items.Add("1992");
            this.UpDwnYear.Items.Add("1993");
            this.UpDwnYear.Items.Add("1994");
            this.UpDwnYear.Items.Add("1995");
            this.UpDwnYear.Items.Add("1996");
            this.UpDwnYear.Items.Add("1997");
            this.UpDwnYear.Items.Add("1998");
            this.UpDwnYear.Items.Add("1999");
            this.UpDwnYear.Items.Add("2000");
            this.UpDwnYear.Items.Add("2001");
            this.UpDwnYear.Items.Add("2002");
            this.UpDwnYear.Items.Add("2003");
            this.UpDwnYear.Items.Add("2004");
            this.UpDwnYear.Items.Add("2005");
            this.UpDwnYear.Items.Add("2006");
            this.UpDwnYear.Items.Add("2007");
            this.UpDwnYear.Items.Add("2008");
            this.UpDwnYear.Items.Add("2009");
            this.UpDwnYear.Items.Add("2010");
            this.UpDwnYear.Items.Add("2011");
            this.UpDwnYear.Items.Add("2012");
            this.UpDwnYear.Items.Add("2013");
            this.UpDwnYear.Items.Add("2014");
            this.UpDwnYear.Items.Add("2015");
            this.UpDwnYear.Items.Add("2016");
            this.UpDwnYear.Items.Add("2017");
            this.UpDwnYear.Items.Add("2018");
            this.UpDwnYear.Items.Add("2019");
            this.UpDwnYear.Location = new System.Drawing.Point(9, 41);
            this.UpDwnYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpDwnYear.Name = "UpDwnYear";
            this.UpDwnYear.ReadOnly = true;
            this.UpDwnYear.Size = new System.Drawing.Size(65, 22);
            this.UpDwnYear.TabIndex = 2;
            this.UpDwnYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpDwnMonth
            // 
            this.UpDwnMonth.Items.Add("Jan");
            this.UpDwnMonth.Items.Add("Feb");
            this.UpDwnMonth.Items.Add("Mar");
            this.UpDwnMonth.Items.Add("Apr");
            this.UpDwnMonth.Items.Add("May");
            this.UpDwnMonth.Items.Add("Jun");
            this.UpDwnMonth.Items.Add("Jul");
            this.UpDwnMonth.Items.Add("Aug");
            this.UpDwnMonth.Items.Add("Sep");
            this.UpDwnMonth.Items.Add("Oct");
            this.UpDwnMonth.Items.Add("Nov");
            this.UpDwnMonth.Items.Add("Dec");
            this.UpDwnMonth.Location = new System.Drawing.Point(103, 41);
            this.UpDwnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpDwnMonth.Name = "UpDwnMonth";
            this.UpDwnMonth.ReadOnly = true;
            this.UpDwnMonth.Size = new System.Drawing.Size(65, 22);
            this.UpDwnMonth.TabIndex = 3;
            this.UpDwnMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2004",
            "\n2005\n",
            "2006",
            "\n2007",
            "\n2008",
            "\n2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBox2.Location = new System.Drawing.Point(187, 41);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(763, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(63, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Patient - 9359  |  Pics - 7455  |  Procedures - 11835";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Totals:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Last,
            this.First,
            this.PatientNum,
            this.DOB,
            this.Sex,
            this.Surgeries});
            this.dataGridView1.Location = new System.Drawing.Point(9, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // Last
            // 
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            // 
            // First
            // 
            this.First.HeaderText = "First";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            // 
            // PatientNum
            // 
            this.PatientNum.HeaderText = "Patient Num";
            this.PatientNum.Name = "PatientNum";
            this.PatientNum.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 75;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 40;
            // 
            // Surgeries
            // 
            this.Surgeries.HeaderText = "Surgeries";
            this.Surgeries.Name = "Surgeries";
            this.Surgeries.ReadOnly = true;
            this.Surgeries.Width = 75;
            // 
            // GrpImages
            // 
            this.GrpImages.Controls.Add(this.LstImageDesc);
            this.GrpImages.Controls.Add(this.BtnImagePrev);
            this.GrpImages.Controls.Add(this.BtnImageFirst);
            this.GrpImages.Controls.Add(this.BtnImageNext);
            this.GrpImages.Controls.Add(this.BtnImageLast);
            this.GrpImages.Controls.Add(this.TxtImagesCount);
            this.GrpImages.Controls.Add(this.LblGrpImageDesc);
            this.GrpImages.Controls.Add(this.LstImages);
            this.GrpImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImages.Location = new System.Drawing.Point(811, 240);
            this.GrpImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrpImages.Name = "GrpImages";
            this.GrpImages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrpImages.Size = new System.Drawing.Size(725, 411);
            this.GrpImages.TabIndex = 1;
            this.GrpImages.TabStop = false;
            this.GrpImages.Text = "Images";
            // 
            // LstImageDesc
            // 
            this.LstImageDesc.FormattingEnabled = true;
            this.LstImageDesc.ItemHeight = 16;
            this.LstImageDesc.Location = new System.Drawing.Point(9, 60);
            this.LstImageDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstImageDesc.Name = "LstImageDesc";
            this.LstImageDesc.Size = new System.Drawing.Size(175, 324);
            this.LstImageDesc.TabIndex = 1;
            // 
            // BtnImagePrev
            // 
            this.BtnImagePrev.Location = new System.Drawing.Point(277, 34);
            this.BtnImagePrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImagePrev.Name = "BtnImagePrev";
            this.BtnImagePrev.Size = new System.Drawing.Size(35, 23);
            this.BtnImagePrev.TabIndex = 3;
            this.BtnImagePrev.Text = "<";
            this.BtnImagePrev.UseVisualStyleBackColor = true;
            // 
            // BtnImageFirst
            // 
            this.BtnImageFirst.Location = new System.Drawing.Point(225, 32);
            this.BtnImageFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImageFirst.Name = "BtnImageFirst";
            this.BtnImageFirst.Size = new System.Drawing.Size(35, 23);
            this.BtnImageFirst.TabIndex = 2;
            this.BtnImageFirst.Text = "|<";
            this.BtnImageFirst.UseVisualStyleBackColor = true;
            // 
            // BtnImageNext
            // 
            this.BtnImageNext.Location = new System.Drawing.Point(616, 30);
            this.BtnImageNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImageNext.Name = "BtnImageNext";
            this.BtnImageNext.Size = new System.Drawing.Size(35, 23);
            this.BtnImageNext.TabIndex = 5;
            this.BtnImageNext.Text = ">";
            this.BtnImageNext.UseVisualStyleBackColor = true;
            // 
            // BtnImageLast
            // 
            this.BtnImageLast.Location = new System.Drawing.Point(669, 30);
            this.BtnImageLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnImageLast.Name = "BtnImageLast";
            this.BtnImageLast.Size = new System.Drawing.Size(35, 23);
            this.BtnImageLast.TabIndex = 6;
            this.BtnImageLast.Text = ">|";
            this.BtnImageLast.UseVisualStyleBackColor = true;
            // 
            // TxtImagesCount
            // 
            this.TxtImagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagesCount.Location = new System.Drawing.Point(417, 32);
            this.TxtImagesCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtImagesCount.Name = "TxtImagesCount";
            this.TxtImagesCount.ReadOnly = true;
            this.TxtImagesCount.Size = new System.Drawing.Size(101, 22);
            this.TxtImagesCount.TabIndex = 4;
            this.TxtImagesCount.Text = "10 of 10";
            this.TxtImagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblGrpImageDesc
            // 
            this.LblGrpImageDesc.AutoSize = true;
            this.LblGrpImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrpImageDesc.Location = new System.Drawing.Point(5, 34);
            this.LblGrpImageDesc.Name = "LblGrpImageDesc";
            this.LblGrpImageDesc.Size = new System.Drawing.Size(122, 17);
            this.LblGrpImageDesc.TabIndex = 0;
            this.LblGrpImageDesc.Text = "Image Descriptors";
            // 
            // LstImages
            // 
            this.LstImages.Location = new System.Drawing.Point(225, 63);
            this.LstImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstImages.Name = "LstImages";
            this.LstImages.Size = new System.Drawing.Size(479, 324);
            this.LstImages.TabIndex = 7;
            this.LstImages.UseCompatibleStateImageBehavior = false;
            // 
            // MnuPatient
            // 
            this.MnuPatient.AllowMerge = false;
            this.MnuPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuPatient.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuPatientDisplay,
            this.TSMnuPatientBreak1,
            this.TSMnuPatientClear});
            this.MnuPatient.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuPatient.Location = new System.Drawing.Point(0, 0);
            this.MnuPatient.Name = "MnuPatient";
            this.MnuPatient.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuPatient.Size = new System.Drawing.Size(1368, 28);
            this.MnuPatient.TabIndex = 12;
            this.MnuPatient.Text = "menuStrip1";
            // 
            // TSMnuPatientDisplay
            // 
            this.TSMnuPatientDisplay.Name = "TSMnuPatientDisplay";
            this.TSMnuPatientDisplay.Size = new System.Drawing.Size(70, 24);
            this.TSMnuPatientDisplay.Text = "Display";
            // 
            // TSMnuPatientBreak1
            // 
            this.TSMnuPatientBreak1.Enabled = false;
            this.TSMnuPatientBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuPatientBreak1.Name = "TSMnuPatientBreak1";
            this.TSMnuPatientBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuPatientBreak1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuPatientBreak1.Text = "|";
            // 
            // TSMnuPatientClear
            // 
            this.TSMnuPatientClear.Name = "TSMnuPatientClear";
            this.TSMnuPatientClear.Size = new System.Drawing.Size(55, 24);
            this.TSMnuPatientClear.Text = "Clear";
            this.TSMnuPatientClear.Click += new System.EventHandler(this.TSMnuPatientClear_Click);
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 840);
            this.ControlBox = false;
            this.Controls.Add(this.MnuPatient);
            this.Controls.Add(this.GrpImages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.GrpImage.ResumeLayout(false);
            this.TabDisplay.ResumeLayout(false);
            this.tabLastName.ResumeLayout(false);
            this.tabLastName.PerformLayout();
            this.tabDate.ResumeLayout(false);
            this.tabDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrpImages.ResumeLayout(false);
            this.GrpImages.PerformLayout();
            this.MnuPatient.ResumeLayout(false);
            this.MnuPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpImage;
        private System.Windows.Forms.TabControl TabDisplay;
        private System.Windows.Forms.TabPage tabLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboFullName;
        private System.Windows.Forms.TabPage tabDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surgeries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DomainUpDown UpDwnLastNameLetter;
        private System.Windows.Forms.DomainUpDown UpDwnMonth;
        private System.Windows.Forms.DomainUpDown UpDwnYear;
        private System.Windows.Forms.GroupBox GrpImages;
        private System.Windows.Forms.ListBox LstImageDesc;
        private System.Windows.Forms.Button BtnImagePrev;
        private System.Windows.Forms.Button BtnImageFirst;
        private System.Windows.Forms.Button BtnImageNext;
        private System.Windows.Forms.Button BtnImageLast;
        private System.Windows.Forms.TextBox TxtImagesCount;
        private System.Windows.Forms.Label LblGrpImageDesc;
        private System.Windows.Forms.ListView LstImages;
        private System.Windows.Forms.MenuStrip MnuPatient;
        private System.Windows.Forms.ToolStripMenuItem TSMnuPatientDisplay;
        private System.Windows.Forms.ToolStripMenuItem TSMnuPatientBreak1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuPatientClear;
    }
}