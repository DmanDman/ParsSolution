namespace ParsDashboard
{
    partial class FrmDashboard
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
            this.TSMnuOpenCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddToCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.TxtInfoPatients = new System.Windows.Forms.TextBox();
            this.TxtInfoImages = new System.Windows.Forms.TextBox();
            this.TxtInfoSurgeries = new System.Windows.Forms.TextBox();
            this.LblInfoPatients = new System.Windows.Forms.Label();
            this.LblInfoImages = new System.Windows.Forms.Label();
            this.LblInfoSurgeries = new System.Windows.Forms.Label();
            this.TxtInfoDr = new System.Windows.Forms.TextBox();
            this.LblInfoDr = new System.Windows.Forms.Label();
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
            this.TxtRecentCanvas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpHighest = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TxtHighestComp = new System.Windows.Forms.TextBox();
            this.TxtHighestInst = new System.Windows.Forms.TextBox();
            this.LblHighestComp = new System.Windows.Forms.Label();
            this.LblHighestInst = new System.Windows.Forms.Label();
            this.TxtHightestSurgery = new System.Windows.Forms.TextBox();
            this.LblHighestSurgery = new System.Windows.Forms.Label();
            this.TxtHighestDx = new System.Windows.Forms.TextBox();
            this.LblHighestDx = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblHighestCPT = new System.Windows.Forms.Label();
            this.LblHighestLevel = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblHighestHosptal = new System.Windows.Forms.Label();
            this.GrpImages = new System.Windows.Forms.GroupBox();
            this.LstImageDesc = new System.Windows.Forms.ListBox();
            this.BtnImagePrev = new System.Windows.Forms.Button();
            this.BtnImageFirst = new System.Windows.Forms.Button();
            this.BtnImageNext = new System.Windows.Forms.Button();
            this.BtnImageLast = new System.Windows.Forms.Button();
            this.TxtImagesCount = new System.Windows.Forms.TextBox();
            this.LblGrpImageDesc = new System.Windows.Forms.Label();
            this.LstImages = new System.Windows.Forms.ListView();
            this.MnuMenu.SuspendLayout();
            this.GrpInfo.SuspendLayout();
            this.GrpRecent.SuspendLayout();
            this.GrpCanvas.SuspendLayout();
            this.GrpHighest.SuspendLayout();
            this.GrpImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuOpenCanvas,
            this.TSMnuAddToCanvas,
            this.TSMnuHelp});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuMenu.Size = new System.Drawing.Size(1249, 28);
            this.MnuMenu.TabIndex = 0;
            this.MnuMenu.Text = "menuStrip1";
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
            this.GrpInfo.TabIndex = 1;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "Information";
            // 
            // TxtInfoPatients
            // 
            this.TxtInfoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoPatients.Location = new System.Drawing.Point(98, 146);
            this.TxtInfoPatients.Name = "TxtInfoPatients";
            this.TxtInfoPatients.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoPatients.TabIndex = 7;
            // 
            // TxtInfoImages
            // 
            this.TxtInfoImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoImages.Location = new System.Drawing.Point(98, 109);
            this.TxtInfoImages.Name = "TxtInfoImages";
            this.TxtInfoImages.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoImages.TabIndex = 5;
            // 
            // TxtInfoSurgeries
            // 
            this.TxtInfoSurgeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoSurgeries.Location = new System.Drawing.Point(98, 72);
            this.TxtInfoSurgeries.Name = "TxtInfoSurgeries";
            this.TxtInfoSurgeries.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoSurgeries.TabIndex = 3;
            // 
            // LblInfoPatients
            // 
            this.LblInfoPatients.AutoSize = true;
            this.LblInfoPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoPatients.Location = new System.Drawing.Point(6, 146);
            this.LblInfoPatients.Name = "LblInfoPatients";
            this.LblInfoPatients.Size = new System.Drawing.Size(59, 17);
            this.LblInfoPatients.TabIndex = 6;
            this.LblInfoPatients.Text = "Patients";
            // 
            // LblInfoImages
            // 
            this.LblInfoImages.AutoSize = true;
            this.LblInfoImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoImages.Location = new System.Drawing.Point(6, 109);
            this.LblInfoImages.Name = "LblInfoImages";
            this.LblInfoImages.Size = new System.Drawing.Size(53, 17);
            this.LblInfoImages.TabIndex = 4;
            this.LblInfoImages.Text = "Images";
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
            // TxtInfoDr
            // 
            this.TxtInfoDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfoDr.Location = new System.Drawing.Point(98, 35);
            this.TxtInfoDr.Name = "TxtInfoDr";
            this.TxtInfoDr.Size = new System.Drawing.Size(161, 22);
            this.TxtInfoDr.TabIndex = 1;
            this.TxtInfoDr.Text = "Rick Sasso";
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
            this.GrpRecent.TabIndex = 2;
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
            this.TxtRecentPatient.TabIndex = 5;
            // 
            // TxtRecentDate
            // 
            this.TxtRecentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentDate.Location = new System.Drawing.Point(98, 72);
            this.TxtRecentDate.Name = "TxtRecentDate";
            this.TxtRecentDate.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentDate.TabIndex = 3;
            // 
            // LblRecentSurgeryAge
            // 
            this.LblRecentSurgeryAge.AutoSize = true;
            this.LblRecentSurgeryAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentSurgeryAge.Location = new System.Drawing.Point(6, 146);
            this.LblRecentSurgeryAge.Name = "LblRecentSurgeryAge";
            this.LblRecentSurgeryAge.Size = new System.Drawing.Size(87, 17);
            this.LblRecentSurgeryAge.TabIndex = 6;
            this.LblRecentSurgeryAge.Text = "Surgery Age";
            // 
            // LblRecentPatient
            // 
            this.LblRecentPatient.AutoSize = true;
            this.LblRecentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentPatient.Location = new System.Drawing.Point(6, 109);
            this.LblRecentPatient.Name = "LblRecentPatient";
            this.LblRecentPatient.Size = new System.Drawing.Size(52, 17);
            this.LblRecentPatient.TabIndex = 4;
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
            this.GrpCanvas.Controls.Add(this.TxtRecentCanvas);
            this.GrpCanvas.Controls.Add(this.label4);
            this.GrpCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCanvas.Location = new System.Drawing.Point(724, 46);
            this.GrpCanvas.Name = "GrpCanvas";
            this.GrpCanvas.Size = new System.Drawing.Size(273, 187);
            this.GrpCanvas.TabIndex = 3;
            this.GrpCanvas.TabStop = false;
            this.GrpCanvas.Text = "Recent Canvas";
            // 
            // TxtRecentCanvas
            // 
            this.TxtRecentCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecentCanvas.Location = new System.Drawing.Point(98, 35);
            this.TxtRecentCanvas.Name = "TxtRecentCanvas";
            this.TxtRecentCanvas.Size = new System.Drawing.Size(161, 22);
            this.TxtRecentCanvas.TabIndex = 1;
            this.TxtRecentCanvas.Text = "Rick Sasso";
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
            this.GrpHighest.TabIndex = 4;
            this.GrpHighest.TabStop = false;
            this.GrpHighest.Text = "Highest Counted";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(295, 282);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(55, 22);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "12345";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(295, 245);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(55, 22);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "12345";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(295, 210);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(55, 22);
            this.textBox10.TabIndex = 17;
            this.textBox10.Text = "12345";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(295, 177);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 22);
            this.textBox9.TabIndex = 14;
            this.textBox9.Text = "12345";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(295, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(55, 22);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "12345";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(295, 109);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 22);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "12345";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(295, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 22);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "12345";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(295, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "12345";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtHighestComp
            // 
            this.TxtHighestComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestComp.Location = new System.Drawing.Point(118, 282);
            this.TxtHighestComp.Name = "TxtHighestComp";
            this.TxtHighestComp.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestComp.TabIndex = 22;
            // 
            // TxtHighestInst
            // 
            this.TxtHighestInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestInst.Location = new System.Drawing.Point(118, 243);
            this.TxtHighestInst.Name = "TxtHighestInst";
            this.TxtHighestInst.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestInst.TabIndex = 19;
            // 
            // LblHighestComp
            // 
            this.LblHighestComp.AutoSize = true;
            this.LblHighestComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestComp.Location = new System.Drawing.Point(6, 280);
            this.LblHighestComp.Name = "LblHighestComp";
            this.LblHighestComp.Size = new System.Drawing.Size(88, 17);
            this.LblHighestComp.TabIndex = 21;
            this.LblHighestComp.Text = "Complication";
            this.LblHighestComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHighestInst
            // 
            this.LblHighestInst.AutoSize = true;
            this.LblHighestInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestInst.Location = new System.Drawing.Point(6, 245);
            this.LblHighestInst.Name = "LblHighestInst";
            this.LblHighestInst.Size = new System.Drawing.Size(105, 17);
            this.LblHighestInst.TabIndex = 18;
            this.LblHighestInst.Text = "Instrumentation";
            this.LblHighestInst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtHightestSurgery
            // 
            this.TxtHightestSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHightestSurgery.Location = new System.Drawing.Point(118, 210);
            this.TxtHightestSurgery.Name = "TxtHightestSurgery";
            this.TxtHightestSurgery.Size = new System.Drawing.Size(161, 22);
            this.TxtHightestSurgery.TabIndex = 16;
            // 
            // LblHighestSurgery
            // 
            this.LblHighestSurgery.AutoSize = true;
            this.LblHighestSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestSurgery.Location = new System.Drawing.Point(6, 210);
            this.LblHighestSurgery.Name = "LblHighestSurgery";
            this.LblHighestSurgery.Size = new System.Drawing.Size(58, 17);
            this.LblHighestSurgery.TabIndex = 15;
            this.LblHighestSurgery.Text = "Surgery";
            // 
            // TxtHighestDx
            // 
            this.TxtHighestDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighestDx.Location = new System.Drawing.Point(118, 177);
            this.TxtHighestDx.Name = "TxtHighestDx";
            this.TxtHighestDx.Size = new System.Drawing.Size(161, 22);
            this.TxtHighestDx.TabIndex = 13;
            // 
            // LblHighestDx
            // 
            this.LblHighestDx.AutoSize = true;
            this.LblHighestDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestDx.Location = new System.Drawing.Point(6, 175);
            this.LblHighestDx.Name = "LblHighestDx";
            this.LblHighestDx.Size = new System.Drawing.Size(24, 17);
            this.LblHighestDx.TabIndex = 12;
            this.LblHighestDx.Text = "Dx";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(118, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 4;
            // 
            // LblHighestCPT
            // 
            this.LblHighestCPT.AutoSize = true;
            this.LblHighestCPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestCPT.Location = new System.Drawing.Point(6, 140);
            this.LblHighestCPT.Name = "LblHighestCPT";
            this.LblHighestCPT.Size = new System.Drawing.Size(35, 17);
            this.LblHighestCPT.TabIndex = 9;
            this.LblHighestCPT.Text = "CPT";
            // 
            // LblHighestLevel
            // 
            this.LblHighestLevel.AutoSize = true;
            this.LblHighestLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHighestLevel.Location = new System.Drawing.Point(6, 105);
            this.LblHighestLevel.Name = "LblHighestLevel";
            this.LblHighestLevel.Size = new System.Drawing.Size(42, 17);
            this.LblHighestLevel.TabIndex = 6;
            this.LblHighestLevel.Text = "Level";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.Location = new System.Drawing.Point(6, 70);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(62, 17);
            this.sd.TabIndex = 3;
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
            this.GrpImages.Location = new System.Drawing.Point(404, 244);
            this.GrpImages.Name = "GrpImages";
            this.GrpImages.Size = new System.Drawing.Size(593, 318);
            this.GrpImages.TabIndex = 5;
            this.GrpImages.TabStop = false;
            this.GrpImages.Text = "Images";
            // 
            // LstImageDesc
            // 
            this.LstImageDesc.FormattingEnabled = true;
            this.LstImageDesc.ItemHeight = 16;
            this.LstImageDesc.Location = new System.Drawing.Point(9, 60);
            this.LstImageDesc.Name = "LstImageDesc";
            this.LstImageDesc.Size = new System.Drawing.Size(175, 244);
            this.LstImageDesc.TabIndex = 1;
            // 
            // BtnImagePrev
            // 
            this.BtnImagePrev.Location = new System.Drawing.Point(277, 30);
            this.BtnImagePrev.Name = "BtnImagePrev";
            this.BtnImagePrev.Size = new System.Drawing.Size(34, 23);
            this.BtnImagePrev.TabIndex = 3;
            this.BtnImagePrev.Text = "<";
            this.BtnImagePrev.UseVisualStyleBackColor = true;
            // 
            // BtnImageFirst
            // 
            this.BtnImageFirst.Location = new System.Drawing.Point(225, 30);
            this.BtnImageFirst.Name = "BtnImageFirst";
            this.BtnImageFirst.Size = new System.Drawing.Size(34, 23);
            this.BtnImageFirst.TabIndex = 2;
            this.BtnImageFirst.Text = "|<";
            this.BtnImageFirst.UseVisualStyleBackColor = true;
            // 
            // BtnImageNext
            // 
            this.BtnImageNext.Location = new System.Drawing.Point(492, 30);
            this.BtnImageNext.Name = "BtnImageNext";
            this.BtnImageNext.Size = new System.Drawing.Size(34, 23);
            this.BtnImageNext.TabIndex = 5;
            this.BtnImageNext.Text = ">";
            this.BtnImageNext.UseVisualStyleBackColor = true;
            // 
            // BtnImageLast
            // 
            this.BtnImageLast.Location = new System.Drawing.Point(545, 30);
            this.BtnImageLast.Name = "BtnImageLast";
            this.BtnImageLast.Size = new System.Drawing.Size(34, 23);
            this.BtnImageLast.TabIndex = 6;
            this.BtnImageLast.Text = ">|";
            this.BtnImageLast.UseVisualStyleBackColor = true;
            // 
            // TxtImagesCount
            // 
            this.TxtImagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagesCount.Location = new System.Drawing.Point(356, 30);
            this.TxtImagesCount.Name = "TxtImagesCount";
            this.TxtImagesCount.Size = new System.Drawing.Size(101, 22);
            this.TxtImagesCount.TabIndex = 4;
            this.TxtImagesCount.Text = "10 of 10";
            this.TxtImagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblGrpImageDesc
            // 
            this.LblGrpImageDesc.AutoSize = true;
            this.LblGrpImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrpImageDesc.Location = new System.Drawing.Point(6, 35);
            this.LblGrpImageDesc.Name = "LblGrpImageDesc";
            this.LblGrpImageDesc.Size = new System.Drawing.Size(122, 17);
            this.LblGrpImageDesc.TabIndex = 0;
            this.LblGrpImageDesc.Text = "Image Descriptors";
            // 
            // LstImages
            // 
            this.LstImages.Location = new System.Drawing.Point(225, 63);
            this.LstImages.Name = "LstImages";
            this.LstImages.Size = new System.Drawing.Size(354, 244);
            this.LstImages.TabIndex = 7;
            this.LstImages.UseCompatibleStateImageBehavior = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 792);
            this.ControlBox = false;
            this.Controls.Add(this.GrpImages);
            this.Controls.Add(this.GrpHighest);
            this.Controls.Add(this.GrpCanvas);
            this.Controls.Add(this.GrpRecent);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.MnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.GrpImages.ResumeLayout(false);
            this.GrpImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
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
        private System.Windows.Forms.TextBox TxtRecentCanvas;
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
        private System.Windows.Forms.GroupBox GrpImages;
        private System.Windows.Forms.ListBox LstImageDesc;
        private System.Windows.Forms.Button BtnImagePrev;
        private System.Windows.Forms.Button BtnImageFirst;
        private System.Windows.Forms.Button BtnImageNext;
        private System.Windows.Forms.Button BtnImageLast;
        private System.Windows.Forms.TextBox TxtImagesCount;
        private System.Windows.Forms.Label LblGrpImageDesc;
        private System.Windows.Forms.ListView LstImages;
    }
}