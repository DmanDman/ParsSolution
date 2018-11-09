namespace ParsDashboard
{
    partial class FrmImages
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
            this.TSMnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuGoToPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpImage = new System.Windows.Forms.GroupBox();
            this.CboEndYear = new System.Windows.Forms.ComboBox();
            this.CboEndMonth = new System.Windows.Forms.ComboBox();
            this.LblDatePicEnd = new System.Windows.Forms.Label();
            this.CboStartYear = new System.Windows.Forms.ComboBox();
            this.CboStartMonth = new System.Windows.Forms.ComboBox();
            this.LblDatePicStart = new System.Windows.Forms.Label();
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
            this.GrpImage.SuspendLayout();
            this.GrpImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDisplay,
            this.TSMnuGoToPatient,
            this.TSMnuClearAll});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuMenu.Size = new System.Drawing.Size(1033, 28);
            this.MnuMenu.TabIndex = 1;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // TSMnuDisplay
            // 
            this.TSMnuDisplay.Name = "TSMnuDisplay";
            this.TSMnuDisplay.Size = new System.Drawing.Size(70, 24);
            this.TSMnuDisplay.Tag = "FrmDashboard";
            this.TSMnuDisplay.Text = "Display";
            this.TSMnuDisplay.Click += new System.EventHandler(this.TSMnuGotoPatient_Click);
            // 
            // TSMnuGoToPatient
            // 
            this.TSMnuGoToPatient.Name = "TSMnuGoToPatient";
            this.TSMnuGoToPatient.Size = new System.Drawing.Size(109, 24);
            this.TSMnuGoToPatient.Text = "Go To Patient";
            // 
            // TSMnuClearAll
            // 
            this.TSMnuClearAll.Name = "TSMnuClearAll";
            this.TSMnuClearAll.Size = new System.Drawing.Size(77, 24);
            this.TSMnuClearAll.Text = "Clear All";
            // 
            // GrpImage
            // 
            this.GrpImage.Controls.Add(this.CboEndYear);
            this.GrpImage.Controls.Add(this.CboEndMonth);
            this.GrpImage.Controls.Add(this.LblDatePicEnd);
            this.GrpImage.Controls.Add(this.CboStartYear);
            this.GrpImage.Controls.Add(this.CboStartMonth);
            this.GrpImage.Controls.Add(this.LblDatePicStart);
            this.GrpImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImage.Location = new System.Drawing.Point(12, 46);
            this.GrpImage.Name = "GrpImage";
            this.GrpImage.Size = new System.Drawing.Size(242, 176);
            this.GrpImage.TabIndex = 4;
            this.GrpImage.TabStop = false;
            this.GrpImage.Text = "Date Picture Entered";
            // 
            // CboEndYear
            // 
            this.CboEndYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CboEndYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboEndYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboEndYear.FormattingEnabled = true;
            this.CboEndYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CboEndYear.Location = new System.Drawing.Point(146, 112);
            this.CboEndYear.Name = "CboEndYear";
            this.CboEndYear.Size = new System.Drawing.Size(77, 24);
            this.CboEndYear.TabIndex = 5;
            // 
            // CboEndMonth
            // 
            this.CboEndMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboEndMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboEndMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboEndMonth.FormattingEnabled = true;
            this.CboEndMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboEndMonth.Location = new System.Drawing.Point(6, 112);
            this.CboEndMonth.Name = "CboEndMonth";
            this.CboEndMonth.Size = new System.Drawing.Size(121, 24);
            this.CboEndMonth.TabIndex = 4;
            // 
            // LblDatePicEnd
            // 
            this.LblDatePicEnd.AutoSize = true;
            this.LblDatePicEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatePicEnd.Location = new System.Drawing.Point(6, 92);
            this.LblDatePicEnd.Name = "LblDatePicEnd";
            this.LblDatePicEnd.Size = new System.Drawing.Size(33, 17);
            this.LblDatePicEnd.TabIndex = 3;
            this.LblDatePicEnd.Text = "End";
            // 
            // CboStartYear
            // 
            this.CboStartYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CboStartYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboStartYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboStartYear.FormattingEnabled = true;
            this.CboStartYear.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CboStartYear.Location = new System.Drawing.Point(146, 55);
            this.CboStartYear.Name = "CboStartYear";
            this.CboStartYear.Size = new System.Drawing.Size(77, 24);
            this.CboStartYear.TabIndex = 2;
            // 
            // CboStartMonth
            // 
            this.CboStartMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboStartMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboStartMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboStartMonth.FormattingEnabled = true;
            this.CboStartMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CboStartMonth.Location = new System.Drawing.Point(6, 55);
            this.CboStartMonth.Name = "CboStartMonth";
            this.CboStartMonth.Size = new System.Drawing.Size(121, 24);
            this.CboStartMonth.TabIndex = 1;
            // 
            // LblDatePicStart
            // 
            this.LblDatePicStart.AutoSize = true;
            this.LblDatePicStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatePicStart.Location = new System.Drawing.Point(6, 35);
            this.LblDatePicStart.Name = "LblDatePicStart";
            this.LblDatePicStart.Size = new System.Drawing.Size(38, 17);
            this.LblDatePicStart.TabIndex = 0;
            this.LblDatePicStart.Text = "Start";
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
            this.GrpImages.Location = new System.Drawing.Point(271, 46);
            this.GrpImages.Name = "GrpImages";
            this.GrpImages.Size = new System.Drawing.Size(725, 411);
            this.GrpImages.TabIndex = 6;
            this.GrpImages.TabStop = false;
            this.GrpImages.Text = "Images";
            // 
            // LstImageDesc
            // 
            this.LstImageDesc.FormattingEnabled = true;
            this.LstImageDesc.ItemHeight = 16;
            this.LstImageDesc.Location = new System.Drawing.Point(9, 60);
            this.LstImageDesc.Name = "LstImageDesc";
            this.LstImageDesc.Size = new System.Drawing.Size(175, 324);
            this.LstImageDesc.TabIndex = 1;
            // 
            // BtnImagePrev
            // 
            this.BtnImagePrev.Location = new System.Drawing.Point(277, 34);
            this.BtnImagePrev.Name = "BtnImagePrev";
            this.BtnImagePrev.Size = new System.Drawing.Size(34, 23);
            this.BtnImagePrev.TabIndex = 3;
            this.BtnImagePrev.Text = "<";
            this.BtnImagePrev.UseVisualStyleBackColor = true;
            // 
            // BtnImageFirst
            // 
            this.BtnImageFirst.Location = new System.Drawing.Point(225, 32);
            this.BtnImageFirst.Name = "BtnImageFirst";
            this.BtnImageFirst.Size = new System.Drawing.Size(34, 23);
            this.BtnImageFirst.TabIndex = 2;
            this.BtnImageFirst.Text = "|<";
            this.BtnImageFirst.UseVisualStyleBackColor = true;
            // 
            // BtnImageNext
            // 
            this.BtnImageNext.Location = new System.Drawing.Point(616, 29);
            this.BtnImageNext.Name = "BtnImageNext";
            this.BtnImageNext.Size = new System.Drawing.Size(34, 23);
            this.BtnImageNext.TabIndex = 5;
            this.BtnImageNext.Text = ">";
            this.BtnImageNext.UseVisualStyleBackColor = true;
            // 
            // BtnImageLast
            // 
            this.BtnImageLast.Location = new System.Drawing.Point(669, 29);
            this.BtnImageLast.Name = "BtnImageLast";
            this.BtnImageLast.Size = new System.Drawing.Size(34, 23);
            this.BtnImageLast.TabIndex = 6;
            this.BtnImageLast.Text = ">|";
            this.BtnImageLast.UseVisualStyleBackColor = true;
            // 
            // TxtImagesCount
            // 
            this.TxtImagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagesCount.Location = new System.Drawing.Point(417, 32);
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
            this.LstImages.Size = new System.Drawing.Size(478, 324);
            this.LstImages.TabIndex = 7;
            this.LstImages.UseCompatibleStateImageBehavior = false;
            // 
            // FrmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 661);
            this.Controls.Add(this.GrpImages);
            this.Controls.Add(this.GrpImage);
            this.Controls.Add(this.MnuMenu);
            this.Name = "FrmImages";
            this.Tag = "FrmImages";
            this.Text = "Images";
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.GrpImage.ResumeLayout(false);
            this.GrpImage.PerformLayout();
            this.GrpImages.ResumeLayout(false);
            this.GrpImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDisplay;
        private System.Windows.Forms.ToolStripMenuItem TSMnuGoToPatient;
        private System.Windows.Forms.ToolStripMenuItem TSMnuClearAll;
        private System.Windows.Forms.GroupBox GrpImage;
        private System.Windows.Forms.Label LblDatePicStart;
        private System.Windows.Forms.ComboBox CboStartYear;
        private System.Windows.Forms.ComboBox CboStartMonth;
        private System.Windows.Forms.ComboBox CboEndYear;
        private System.Windows.Forms.ComboBox CboEndMonth;
        private System.Windows.Forms.Label LblDatePicEnd;
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