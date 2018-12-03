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
            this.tabDate = new System.Windows.Forms.TabPage();
            this.cboLastNameLetter = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.GrpImage.SuspendLayout();
            this.TabDisplay.SuspendLayout();
            this.tabLastName.SuspendLayout();
            this.tabDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpImage
            // 
            this.GrpImage.Controls.Add(this.TabDisplay);
            this.GrpImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImage.Location = new System.Drawing.Point(12, 46);
            this.GrpImage.Name = "GrpImage";
            this.GrpImage.Size = new System.Drawing.Size(425, 323);
            this.GrpImage.TabIndex = 5;
            this.GrpImage.TabStop = false;
            this.GrpImage.Text = "Display By: Last Name / Date";
            // 
            // TabDisplay
            // 
            this.TabDisplay.Controls.Add(this.tabLastName);
            this.TabDisplay.Controls.Add(this.tabDate);
            this.TabDisplay.Location = new System.Drawing.Point(20, 34);
            this.TabDisplay.Name = "TabDisplay";
            this.TabDisplay.SelectedIndex = 0;
            this.TabDisplay.Size = new System.Drawing.Size(388, 274);
            this.TabDisplay.TabIndex = 0;
            // 
            // tabLastName
            // 
            this.tabLastName.Controls.Add(this.label2);
            this.tabLastName.Controls.Add(this.label1);
            this.tabLastName.Controls.Add(this.comboBox1);
            this.tabLastName.Controls.Add(this.cboLastNameLetter);
            this.tabLastName.Location = new System.Drawing.Point(4, 25);
            this.tabLastName.Name = "tabLastName";
            this.tabLastName.Padding = new System.Windows.Forms.Padding(3);
            this.tabLastName.Size = new System.Drawing.Size(380, 245);
            this.tabLastName.TabIndex = 0;
            this.tabLastName.Text = "Last Name";
            this.tabLastName.UseVisualStyleBackColor = true;
            // 
            // tabDate
            // 
            this.tabDate.Controls.Add(this.comboBox3);
            this.tabDate.Controls.Add(this.comboBox2);
            this.tabDate.Controls.Add(this.label4);
            this.tabDate.Controls.Add(this.label3);
            this.tabDate.Location = new System.Drawing.Point(4, 25);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDate.Size = new System.Drawing.Size(318, 245);
            this.tabDate.TabIndex = 1;
            this.tabDate.Text = "Year / Month";
            this.tabDate.UseVisualStyleBackColor = true;
            // 
            // cboLastNameLetter
            // 
            this.cboLastNameLetter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLastNameLetter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLastNameLetter.FormattingEnabled = true;
            this.cboLastNameLetter.Items.AddRange(new object[] {
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
            this.cboLastNameLetter.Location = new System.Drawing.Point(19, 41);
            this.cboLastNameLetter.Name = "cboLastNameLetter";
            this.cboLastNameLetter.Size = new System.Drawing.Size(65, 24);
            this.cboLastNameLetter.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(116, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starts With";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Month";
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
            this.comboBox2.Location = new System.Drawing.Point(19, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "January",
            "Februray",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Spetember",
            "Octomer",
            "November",
            "December"});
            this.comboBox3.Location = new System.Drawing.Point(116, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 840);
            this.ControlBox = false;
            this.Controls.Add(this.GrpImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(19, 41);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmPatient";
            this.Text = "Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.GrpImage.ResumeLayout(false);
            this.TabDisplay.ResumeLayout(false);
            this.tabLastName.ResumeLayout(false);
            this.tabLastName.PerformLayout();
            this.tabDate.ResumeLayout(false);
            this.tabDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpImage;
        private System.Windows.Forms.TabControl TabDisplay;
        private System.Windows.Forms.TabPage tabLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboLastNameLetter;
        private System.Windows.Forms.TabPage tabDate;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}