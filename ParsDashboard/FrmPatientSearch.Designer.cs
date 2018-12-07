﻿namespace ParsDashboard
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
            this.TxtSsn = new System.Windows.Forms.TextBox();
            this.TxtDob = new System.Windows.Forms.TextBox();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.TxtSurgeryDate = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.TabSearch.SuspendLayout();
            this.TabPersonal.SuspendLayout();
            this.GrpBoxPersonal.SuspendLayout();
            this.TabHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.TabPersonal);
            this.TabSearch.Controls.Add(this.TabHome);
            this.TabSearch.Location = new System.Drawing.Point(12, 27);
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
            this.GrpBoxPersonal.Controls.Add(this.TxtSsn);
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
            // TxtSsn
            // 
            this.TxtSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSsn.Location = new System.Drawing.Point(123, 327);
            this.TxtSsn.Multiline = true;
            this.TxtSsn.Name = "TxtSsn";
            this.TxtSsn.Size = new System.Drawing.Size(166, 22);
            this.TxtSsn.TabIndex = 16;
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
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 322);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "GrpBoxPersonal";
            this.groupBox1.Text = "Home";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(123, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(123, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 22);
            this.textBox6.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(123, 243);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(123, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 22);
            this.textBox3.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(6, 240);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 21);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Phone";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(6, 199);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(50, 21);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Zip";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(6, 158);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(63, 21);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "State";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(6, 117);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(53, 21);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "City";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(123, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(123, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 22);
            this.textBox5.TabIndex = 1;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(6, 76);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(94, 21);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Address 2";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(6, 35);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(94, 21);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Address 1";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // FrmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 793);
            this.ControlBox = false;
            this.Controls.Add(this.TabSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 117);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSearch;
        private System.Windows.Forms.TabPage TabPersonal;
        private System.Windows.Forms.GroupBox GrpBoxPersonal;
        private System.Windows.Forms.TextBox TxtSsn;
        private System.Windows.Forms.TextBox TxtDob;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
        private System.Windows.Forms.TextBox TxtSurgeryDate;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TabPage TabHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
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
    }
}