namespace ParsDashboard
{
    partial class f
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
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.TSMnuGotoPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuOpenCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddToCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.LblInfoDr = new System.Windows.Forms.Label();
            this.TxtInfoDr = new System.Windows.Forms.TextBox();
            this.LblInfoSurgeries = new System.Windows.Forms.Label();
            this.LblInfoImages = new System.Windows.Forms.Label();
            this.LblInfoPatients = new System.Windows.Forms.Label();
            this.TxtInfoSurgeries = new System.Windows.Forms.TextBox();
            this.TxtInfoImages = new System.Windows.Forms.TextBox();
            this.TxtInfoPatients = new System.Windows.Forms.TextBox();
            this.GrpRecent = new System.Windows.Forms.GroupBox();
            this.TxtRecentSurgeryAge = new System.Windows.Forms.TextBox();
            this.TxtRecentPatient = new System.Windows.Forms.TextBox();
            this.TxtRecentDate = new System.Windows.Forms.TextBox();
            this.LblRecentSurgeryAge = new System.Windows.Forms.Label();
            this.LblRecentPatient = new System.Windows.Forms.Label();
            this.LblRecentDate = new System.Windows.Forms.Label();
            this.TxtRecentName = new System.Windows.Forms.TextBox();
            this.LblRecentName = new System.Windows.Forms.Label();
            this.GrpCanvas = new System.Windows.Forms.GroupBox();
            this.TxtCanvammmmmmmmmmmmmmmm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpHighest = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblHighestCPT = new System.Windows.Forms.Label();
            this.LblHighestLevel = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblHighestHosptal = new System.Windows.Forms.Label();
            this.LblHighestDx = new System.Windows.Forms.Label();
            this.TxtHighestDx = new System.Windows.Forms.TextBox();
            this.LblHighestSurgery = new System.Windows.Forms.Label();
            this.TxtHightestSurgery = new System.Windows.Forms.TextBox();
            this.LblHighestInst = new System.Windows.Forms.Label();
            this.LblHighestComp = new System.Windows.Forms.Label();
            this.TxtHighestInst = new System.Windows.Forms.TextBox();
            this.TxtHighestComp = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.MnuMenu.SuspendLayout();
            this.GrpInfo.SuspendLayout();
            this.GrpRecent.SuspendLayout();
            this.GrpCanvas.SuspendLayout();
            this.GrpHighest.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuGotoPatient,
            this.TSMnuOpenCanvas,
            this.TSMnuAddToCanvas,
            this.TSMnuHelp});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuMenu.Size = new System.Drawing.Size(1307, 28);
            this.MnuMenu.TabIndex = 2;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // TSMnuGotoPatient
            // 
            this.TSMnuGotoPatient.Name = "TSMnuGotoPatient";
            this.TSMnuGotoPatient.Size = new System.Drawing.Size(103, 24);
            this.TSMnuGotoPatient.Tag = "FrmDashboard";
            this.TSMnuGotoPatient.Text = "Goto Patient";
            this.TSMnuGotoPatient.Click += new System.EventHandler(this.TSMnuGotoPatient_Click);
            // 
            // TSMnuOpenCanvas
            // 
            this.TSMnuOpenCanvas.Name = "TSMnuOpenCanvas";
            this.TSMnuOpenCanvas.Size = new System.Drawing.Size(107, 24);
            this.TSMnuOpenCanvas.Text = "Open Canvas";
            // 
            // TSMnuAddToCanvas
            // 
            this.TSMnuAddToCanvas.Name = "TSMnuAddToCanvas";
            this.TSMnuAddToCanvas.Size = new System.Drawing.Size(117, 24);
            this.TSMnuAddToCanvas.Text = "Add to Canvas";
            // 
            // TSMnuHelp
            // 
            this.TSMnuHelp.Name = "TSMnuHelp";
            this.TSMnuHelp.Size = new System.Drawing.Size(53, 24);
            this.TSMnuHelp.Text = "Help";
            // 
            // GrpInfo
            // 
            this.GrpInfo.Controls.Add(this.TxtInfoPatients);
            this.GrpInfo.Controls.Add(this.TxtInfoImages);
            this.GrpInfo.Controls.Add(this.TxtInfoSurgeries);
            this.GrpInfo.Controls.Add(this.LblInfoPatients);
            this.GrpInfo.Controls.Add(this.LblInfoImages);
            this.GrpInfo.Controls.Add(this.LblInfoSurgeries);
            this.GrpInfo.Controls.Add(this.TxtInfoDr);
            this.GrpInfo.Controls.Add(this.LblInfoDr);
            this.GrpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpInfo.Location = new System.Drawing.Point(12, 46);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(273, 187);
            this.GrpInfo.TabIndex = 3;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "Information";
            this.GrpInfo.Enter += new System.EventHandler(this.GrpInfo_Enter);
            // 
            // LblInfoDr
            // 
            this.LblInfoDr.AutoSize = true;
            this.LblInfoDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoDr.Location = new System.Drawing.Point(6, 35);
            this.LblInfoDr.Name = "LblInfoDr";
            this.LblInfoDr.Size = new System.Drawing.Size(50, 17);
            this.LblInfoDr.TabIndex = 0;
            this.LblInfoDr.Text = "Doctor";
            // 
            // TxtInfoDr
            // 
            this.TxtInfoDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoDr.Location = new System.Drawing.Point(98, 35);
            this.TxtInfoDr.Name = "TxtInfoDr";
            this.TxtInfoDr.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoDr.TabIndex = 1;
            this.TxtInfoDr.Text = "Rick Sasso";
            // 
            // LblInfoSurgeries
            // 
            this.LblInfoSurgeries.AutoSize = true;
            this.LblInfoSurgeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoSurgeries.Location = new System.Drawing.Point(6, 72);
            this.LblInfoSurgeries.Name = "LblInfoSurgeries";
            this.LblInfoSurgeries.Size = new System.Drawing.Size(69, 17);
            this.LblInfoSurgeries.TabIndex = 2;
            this.LblInfoSurgeries.Text = "Surgeries";
            // 
            // LblInfoImages
            // 
            this.LblInfoImages.AutoSize = true;
            this.LblInfoImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoImages.Location = new System.Drawing.Point(6, 109);
            this.LblInfoImages.Name = "LblInfoImages";
            this.LblInfoImages.Size = new System.Drawing.Size(53, 17);
            this.LblInfoImages.TabIndex = 3;
            this.LblInfoImages.Text = "Images";
            // 
            // LblInfoPatients
            // 
            this.LblInfoPatients.AutoSize = true;
            this.LblInfoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoPatients.Location = new System.Drawing.Point(6, 146);
            this.LblInfoPatients.Name = "LblInfoPatients";
            this.LblInfoPatients.Size = new System.Drawing.Size(59, 17);
            this.LblInfoPatients.TabIndex = 4;
            this.LblInfoPatients.Text = "Patients";
            // 
            // TxtInfoSurgeries
            // 
            this.TxtInfoSurgeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoSurgeries.Location = new System.Drawing.Point(98, 72);
            this.TxtInfoSurgeries.Name = "TxtInfoSurgeries";
            this.TxtInfoSurgeries.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoSurgeries.TabIndex = 5;
            // 
            // TxtInfoImages
            // 
            this.TxtInfoImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoImages.Location = new System.Drawing.Point(98, 109);
            this.TxtInfoImages.Name = "TxtInfoImages";
            this.TxtInfoImages.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoImages.TabIndex = 6;
            // 
            // TxtInfoPatients
            // 
            this.TxtInfoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoPatients.Location = new System.Drawing.Point(98, 146);
            this.TxtInfoPatients.Name = "TxtInfoPatients";
            this.TxtInfoPatients.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoPatients.TabIndex = 7;
            // 
            // GrpRecent
            // 
            this.GrpRecent.Controls.Add(this.TxtRecentSurgeryAge);
            this.GrpRecent.Controls.Add(this.TxtRecentPatient);
            this.GrpRecent.Controls.Add(this.TxtRecentDate);
            this.GrpRecent.Controls.Add(this.LblRecentSurgeryAge);
            this.GrpRecent.Controls.Add(this.LblRecentPatient);
            this.GrpRecent.Controls.Add(this.LblRecentDate);
            this.GrpRecent.Controls.Add(this.TxtRecentName);
            this.GrpRecent.Controls.Add(this.LblRecentName);
            this.GrpRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRecent.Location = new System.Drawing.Point(356, 46);
            this.GrpRecent.Name = "GrpRecent";
            this.GrpRecent.Size = new System.Drawing.Size(273, 187);
            this.GrpRecent.TabIndex = 8;
            this.GrpRecent.TabStop = false;
            this.GrpRecent.Text = "Most Recent Surgery";
            // 
            // TxtRecentSurgeryAge
            // 
            this.TxtRecentSurgeryAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentSurgeryAge.Location = new System.Drawing.Point(98, 146);
            this.TxtRecentSurgeryAge.Name = "TxtRecentSurgeryAge";
            this.TxtRecentSurgeryAge.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentSurgeryAge.TabIndex = 7;
            // 
            // TxtRecentPatient
            // 
            this.TxtRecentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentPatient.Location = new System.Drawing.Point(98, 109);
            this.TxtRecentPatient.Name = "TxtRecentPatient";
            this.TxtRecentPatient.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentPatient.TabIndex = 6;
            // 
            // TxtRecentDate
            // 
            this.TxtRecentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentDate.Location = new System.Drawing.Point(98, 72);
            this.TxtRecentDate.Name = "TxtRecentDate";
            this.TxtRecentDate.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentDate.TabIndex = 5;
            // 
            // LblRecentSurgeryAge
            // 
            this.LblRecentSurgeryAge.AutoSize = true;
            this.LblRecentSurgeryAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentSurgeryAge.Location = new System.Drawing.Point(6, 146);
            this.LblRecentSurgeryAge.Name = "LblRecentSurgeryAge";
            this.LblRecentSurgeryAge.Size = new System.Drawing.Size(87, 17);
            this.LblRecentSurgeryAge.TabIndex = 4;
            this.LblRecentSurgeryAge.Text = "Surgery Age";
            this.LblRecentSurgeryAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblRecentPatient
            // 
            this.LblRecentPatient.AutoSize = true;
            this.LblRecentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentPatient.Location = new System.Drawing.Point(6, 109);
            this.LblRecentPatient.Name = "LblRecentPatient";
            this.LblRecentPatient.Size = new System.Drawing.Size(52, 17);
            this.LblRecentPatient.TabIndex = 3;
            this.LblRecentPatient.Text = "Patient";
            // 
            // LblRecentDate
            // 
            this.LblRecentDate.AutoSize = true;
            this.LblRecentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentDate.Location = new System.Drawing.Point(6, 72);
            this.LblRecentDate.Name = "LblRecentDate";
            this.LblRecentDate.Size = new System.Drawing.Size(38, 17);
            this.LblRecentDate.TabIndex = 2;
            this.LblRecentDate.Text = "Date";
            // 
            // TxtRecentName
            // 
            this.TxtRecentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentName.Location = new System.Drawing.Point(98, 35);
            this.TxtRecentName.Name = "TxtRecentName";
            this.TxtRecentName.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentName.TabIndex = 1;
            this.TxtRecentName.Text = "Rick Sasso";
            // 
            // LblRecentName
            // 
            this.LblRecentName.AutoSize = true;
            this.LblRecentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentName.Location = new System.Drawing.Point(6, 35);
            this.LblRecentName.Name = "LblRecentName";
            this.LblRecentName.Size = new System.Drawing.Size(45, 17);
            this.LblRecentName.TabIndex = 0;
            this.LblRecentName.Text = "Name";
            // 
            // GrpCanvas
            // 
            this.GrpCanvas.Controls.Add(this.TxtCanvammmmmmmmmmmmmmmm);
            this.GrpCanvas.Controls.Add(this.label4);
            this.GrpCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCanvas.Location = new System.Drawing.Point(724, 46);
            this.GrpCanvas.Name = "GrpCanvas";
            this.GrpCanvas.Size = new System.Drawing.Size(273, 187);
            this.GrpCanvas.TabIndex = 9;
            this.GrpCanvas.TabStop = false;
            this.GrpCanvas.Text = "Recent Canvas";
            // 
            // TxtCanvammmmmmmmmmmmmmmm
            // 
            this.TxtCanvammmmmmmmmmmmmmmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCanvammmmmmmmmmmmmmmm.Location = new System.Drawing.Point(98, 35);
            this.TxtCanvammmmmmmmmmmmmmmm.Name = "TxtCanvammmmmmmmmmmmmmmm";
            this.TxtCanvammmmmmmmmmmmmmmm.Size = new System.Drawing.Size(161, 22);
            this.TxtCanvammmmmmmmmmmmmmmm.TabIndex = 1;
            this.TxtCanvammmmmmmmmmmmmmmm.Text = "Rick Sasso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // GrpHighest
            // 
            this.GrpHighest.Controls.Add(this.textBox12);
            this.GrpHighest.Controls.Add(this.textBox11);
            this.GrpHighest.Controls.Add(this.textBox10);
            this.GrpHighest.Controls.Add(this.textBox9);
            this.GrpHighest.Controls.Add(this.textBox8);
            this.GrpHighest.Controls.Add(this.textBox7);
            this.GrpHighest.Controls.Add(this.textBox6);
            this.GrpHighest.Controls.Add(this.textBox5);
            this.GrpHighest.Controls.Add(this.TxtHighestComp);
            this.GrpHighest.Controls.Add(this.TxtHighestInst);
            this.GrpHighest.Controls.Add(this.LblHighestComp);
            this.GrpHighest.Controls.Add(this.LblHighestInst);
            this.GrpHighest.Controls.Add(this.TxtHightestSurgery);
            this.GrpHighest.Controls.Add(this.LblHighestSurgery);
            this.GrpHighest.Controls.Add(this.TxtHighestDx);
            this.GrpHighest.Controls.Add(this.LblHighestDx);
            this.GrpHighest.Controls.Add(this.textBox1);
            this.GrpHighest.Controls.Add(this.textBox2);
            this.GrpHighest.Controls.Add(this.textBox3);
            this.GrpHighest.Controls.Add(this.LblHighestCPT);
            this.GrpHighest.Controls.Add(this.LblHighestLevel);
            this.GrpHighest.Controls.Add(this.sd);
            this.GrpHighest.Controls.Add(this.textBox4);
            this.GrpHighest.Controls.Add(this.LblHighestHosptal);
            this.GrpHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpHighest.Location = new System.Drawing.Point(12, 244);
            this.GrpHighest.Name = "GrpHighest";
            this.GrpHighest.Size = new System.Drawing.Size(364, 318);
            this.GrpHighest.TabIndex = 8;
            this.GrpHighest.TabStop = false;
            this.GrpHighest.Text = "Highest Counted";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(118, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 5;
            // 
            // LblHighestCPT
            // 
            this.LblHighestCPT.AutoSize = true;
            this.LblHighestCPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestCPT.Location = new System.Drawing.Point(6, 140);
            this.LblHighestCPT.Name = "LblHighestCPT";
            this.LblHighestCPT.Size = new System.Drawing.Size(35, 17);
            this.LblHighestCPT.TabIndex = 4;
            this.LblHighestCPT.Text = "CPT";
            // 
            // LblHighestLevel
            // 
            this.LblHighestLevel.AutoSize = true;
            this.LblHighestLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestLevel.Location = new System.Drawing.Point(6, 105);
            this.LblHighestLevel.Name = "LblHighestLevel";
            this.LblHighestLevel.Size = new System.Drawing.Size(42, 17);
            this.LblHighestLevel.TabIndex = 3;
            this.LblHighestLevel.Text = "Level";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.Location = new System.Drawing.Point(6, 70);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(62, 17);
            this.sd.TabIndex = 2;
            this.sd.Text = "Location";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(118, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Rick Sasso";
            // 
            // LblHighestHosptal
            // 
            this.LblHighestHosptal.AutoSize = true;
            this.LblHighestHosptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestHosptal.Location = new System.Drawing.Point(6, 35);
            this.LblHighestHosptal.Name = "LblHighestHosptal";
            this.LblHighestHosptal.Size = new System.Drawing.Size(59, 17);
            this.LblHighestHosptal.TabIndex = 0;
            this.LblHighestHosptal.Text = "Hospital";
            // 
            // LblHighestDx
            // 
            this.LblHighestDx.AutoSize = true;
            this.LblHighestDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestDx.Location = new System.Drawing.Point(6, 175);
            this.LblHighestDx.Name = "LblHighestDx";
            this.LblHighestDx.Size = new System.Drawing.Size(24, 17);
            this.LblHighestDx.TabIndex = 8;
            this.LblHighestDx.Text = "Dx";
            // 
            // TxtHighestDx
            // 
            this.TxtHighestDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestDx.Location = new System.Drawing.Point(118, 177);
            this.TxtHighestDx.Name = "TxtHighestDx";
            this.TxtHighestDx.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestDx.TabIndex = 9;
            // 
            // LblHighestSurgery
            // 
            this.LblHighestSurgery.AutoSize = true;
            this.LblHighestSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestSurgery.Location = new System.Drawing.Point(6, 210);
            this.LblHighestSurgery.Name = "LblHighestSurgery";
            this.LblHighestSurgery.Size = new System.Drawing.Size(58, 17);
            this.LblHighestSurgery.TabIndex = 10;
            this.LblHighestSurgery.Text = "Surgery";
            // 
            // TxtHightestSurgery
            // 
            this.TxtHightestSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHightestSurgery.Location = new System.Drawing.Point(118, 210);
            this.TxtHightestSurgery.Name = "TxtHightestSurgery";
            this.TxtHightestSurgery.Size = new System.Drawing.Size(161, 22);
            this.TxtHightestSurgery.TabIndex = 11;
            // 
            // LblHighestInst
            // 
            this.LblHighestInst.AutoSize = true;
            this.LblHighestInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestInst.Location = new System.Drawing.Point(6, 245);
            this.LblHighestInst.Name = "LblHighestInst";
            this.LblHighestInst.Size = new System.Drawing.Size(105, 17);
            this.LblHighestInst.TabIndex = 12;
            this.LblHighestInst.Text = "Instrumentation";
            this.LblHighestInst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHighestComp
            // 
            this.LblHighestComp.AutoSize = true;
            this.LblHighestComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestComp.Location = new System.Drawing.Point(6, 280);
            this.LblHighestComp.Name = "LblHighestComp";
            this.LblHighestComp.Size = new System.Drawing.Size(88, 17);
            this.LblHighestComp.TabIndex = 14;
            this.LblHighestComp.Text = "Complication";
            this.LblHighestComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtHighestInst
            // 
            this.TxtHighestInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestInst.Location = new System.Drawing.Point(118, 243);
            this.TxtHighestInst.Name = "TxtHighestInst";
            this.TxtHighestInst.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestInst.TabIndex = 15;
            // 
            // TxtHighestComp
            // 
            this.TxtHighestComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestComp.Location = new System.Drawing.Point(118, 282);
            this.TxtHighestComp.Name = "TxtHighestComp";
            this.TxtHighestComp.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestComp.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(295, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 22);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "12345";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(295, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 22);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "12345";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(295, 109);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 22);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "12345";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(295, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(55, 22);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "12345";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(295, 177);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 22);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = "12345";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(295, 210);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(55, 22);
            this.textBox10.TabIndex = 22;
            this.textBox10.Text = "12345";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(295, 245);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(55, 22);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "12345";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(295, 282);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(55, 22);
            this.textBox12.TabIndex = 24;
            this.textBox12.Text = "12345";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 660);
            this.Controls.Add(this.GrpHighest);
            this.Controls.Add(this.GrpCanvas);
            this.Controls.Add(this.GrpRecent);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.MnuMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "f";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmDashboard";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.GrpInfo.ResumeLayout(false);
            this.GrpInfo.PerformLayout();
            this.GrpRecent.ResumeLayout(false);
            this.GrpRecent.PerformLayout();
            this.GrpCanvas.ResumeLayout(false);
            this.GrpCanvas.PerformLayout();
            this.GrpHighest.ResumeLayout(false);
            this.GrpHighest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMnuGotoPatient;
        private System.Windows.Forms.ToolStripMenuItem TSMnuOpenCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddToCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuHelp;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.Label LblInfoSurgeries;
        private System.Windows.Forms.TextBox TxtInfoDr;
        private System.Windows.Forms.Label LblInfoDr;
        private System.Windows.Forms.TextBox TxtInfoPatients;
        private System.Windows.Forms.TextBox TxtInfoImages;
        private System.Windows.Forms.TextBox TxtInfoSurgeries;
        private System.Windows.Forms.Label LblInfoPatients;
        private System.Windows.Forms.Label LblInfoImages;
        private System.Windows.Forms.GroupBox GrpRecent;
        private System.Windows.Forms.TextBox TxtRecentSurgeryAge;
        private System.Windows.Forms.TextBox TxtRecentPatient;
        private System.Windows.Forms.TextBox TxtRecentDate;
        private System.Windows.Forms.Label LblRecentSurgeryAge;
        private System.Windows.Forms.Label LblRecentPatient;
        private System.Windows.Forms.Label LblRecentDate;
        private System.Windows.Forms.TextBox TxtRecentName;
        private System.Windows.Forms.Label LblRecentName;
        private System.Windows.Forms.GroupBox GrpCanvas;
        private System.Windows.Forms.TextBox TxtCanvammmmmmmmmmmmmmmm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrpHighest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblHighestCPT;
        private System.Windows.Forms.Label LblHighestLevel;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblHighestHosptal;
        private System.Windows.Forms.Label LblHighestDx;
        private System.Windows.Forms.TextBox TxtHighestDx;
        private System.Windows.Forms.TextBox TxtHighestComp;
        private System.Windows.Forms.TextBox TxtHighestInst;
        private System.Windows.Forms.Label LblHighestComp;
        private System.Windows.Forms.Label LblHighestInst;
        private System.Windows.Forms.TextBox TxtHightestSurgery;
        private System.Windows.Forms.Label LblHighestSurgery;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
    }
}