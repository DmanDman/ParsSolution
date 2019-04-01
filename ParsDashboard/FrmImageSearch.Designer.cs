namespace ParsDashboard
{
    partial class FrmImageSearch
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
            this.GrpMetaData = new System.Windows.Forms.GroupBox();
            this.ChkMeataOnly = new System.Windows.Forms.CheckBox();
            this.RdoMetaOr = new System.Windows.Forms.RadioButton();
            this.RdoMetaAnd = new System.Windows.Forms.RadioButton();
            this.LstMetaDataSearchTerms = new System.Windows.Forms.ListBox();
            this.LblMetaSearch = new System.Windows.Forms.Label();
            this.CboMetaSearch = new System.Windows.Forms.ComboBox();
            this.LbMetaDataSearch = new System.Windows.Forms.Label();
            this.GrpPicInfo = new System.Windows.Forms.GroupBox();
            this.ChkPicInfoOnly = new System.Windows.Forms.CheckBox();
            this.RdoPicInfoOr = new System.Windows.Forms.RadioButton();
            this.RdoPicInfoAnd = new System.Windows.Forms.RadioButton();
            this.LstPicInfoSearchItems = new System.Windows.Forms.ListBox();
            this.LblPicInfoSearchItems = new System.Windows.Forms.Label();
            this.CboPicInfo = new System.Windows.Forms.ComboBox();
            this.LblPicInfo = new System.Windows.Forms.Label();
            this.MnuImagesSearch = new System.Windows.Forms.MenuStrip();
            this.TSMnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchMetaData = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchMetaDataAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchMetaDataRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchMetaDataSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsMnuImageSearchMetaDataRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMnuImageSearchBreak2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuSearchPicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuSearchPicInfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuSearchPicInfoRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuSearchPicInfoSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMnuSearchPicInfoRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpMetaData.SuspendLayout();
            this.GrpPicInfo.SuspendLayout();
            this.MnuImagesSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpMetaData
            // 
            this.GrpMetaData.Controls.Add(this.ChkMeataOnly);
            this.GrpMetaData.Controls.Add(this.RdoMetaOr);
            this.GrpMetaData.Controls.Add(this.RdoMetaAnd);
            this.GrpMetaData.Controls.Add(this.LstMetaDataSearchTerms);
            this.GrpMetaData.Controls.Add(this.LblMetaSearch);
            this.GrpMetaData.Controls.Add(this.CboMetaSearch);
            this.GrpMetaData.Controls.Add(this.LbMetaDataSearch);
            this.GrpMetaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMetaData.Location = new System.Drawing.Point(12, 46);
            this.GrpMetaData.Name = "GrpMetaData";
            this.GrpMetaData.Size = new System.Drawing.Size(780, 331);
            this.GrpMetaData.TabIndex = 5;
            this.GrpMetaData.TabStop = false;
            this.GrpMetaData.Text = "Meta Data";
            // 
            // ChkMeataOnly
            // 
            this.ChkMeataOnly.AutoSize = true;
            this.ChkMeataOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMeataOnly.Location = new System.Drawing.Point(711, 107);
            this.ChkMeataOnly.Name = "ChkMeataOnly";
            this.ChkMeataOnly.Size = new System.Drawing.Size(59, 21);
            this.ChkMeataOnly.TabIndex = 6;
            this.ChkMeataOnly.Text = "Only";
            this.ChkMeataOnly.UseVisualStyleBackColor = true;
            this.ChkMeataOnly.Click += new System.EventHandler(this.ChkMeataOnly_Click);
            // 
            // RdoMetaOr
            // 
            this.RdoMetaOr.AutoSize = true;
            this.RdoMetaOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoMetaOr.Location = new System.Drawing.Point(711, 80);
            this.RdoMetaOr.Name = "RdoMetaOr";
            this.RdoMetaOr.Size = new System.Drawing.Size(45, 21);
            this.RdoMetaOr.TabIndex = 5;
            this.RdoMetaOr.TabStop = true;
            this.RdoMetaOr.Text = "Or";
            this.RdoMetaOr.UseVisualStyleBackColor = true;
            this.RdoMetaOr.Click += new System.EventHandler(this.RdoMetaOr_Click);
            // 
            // RdoMetaAnd
            // 
            this.RdoMetaAnd.AutoSize = true;
            this.RdoMetaAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoMetaAnd.Location = new System.Drawing.Point(711, 53);
            this.RdoMetaAnd.Name = "RdoMetaAnd";
            this.RdoMetaAnd.Size = new System.Drawing.Size(54, 21);
            this.RdoMetaAnd.TabIndex = 4;
            this.RdoMetaAnd.TabStop = true;
            this.RdoMetaAnd.Text = "And";
            this.RdoMetaAnd.UseVisualStyleBackColor = true;
            this.RdoMetaAnd.Click += new System.EventHandler(this.RdoMetaAnd_Click);
            // 
            // LstMetaDataSearchTerms
            // 
            this.LstMetaDataSearchTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstMetaDataSearchTerms.FormattingEnabled = true;
            this.LstMetaDataSearchTerms.ItemHeight = 16;
            this.LstMetaDataSearchTerms.Location = new System.Drawing.Point(354, 55);
            this.LstMetaDataSearchTerms.Name = "LstMetaDataSearchTerms";
            this.LstMetaDataSearchTerms.Size = new System.Drawing.Size(351, 244);
            this.LstMetaDataSearchTerms.TabIndex = 3;
            this.LstMetaDataSearchTerms.DoubleClick += new System.EventHandler(this.LstMetaDataSearchTerms_DoubleClick);
            // 
            // LblMetaSearch
            // 
            this.LblMetaSearch.AutoSize = true;
            this.LblMetaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMetaSearch.Location = new System.Drawing.Point(351, 35);
            this.LblMetaSearch.Name = "LblMetaSearch";
            this.LblMetaSearch.Size = new System.Drawing.Size(90, 17);
            this.LblMetaSearch.TabIndex = 2;
            this.LblMetaSearch.Text = "Search Items";
            // 
            // CboMetaSearch
            // 
            this.CboMetaSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Lamin",
            "Laminar Screws",
            "Laminectomy",
            "Laminectomy/Foraminotomy/Facetectomy",
            "Laminectomy--Bilateral",
            "Laminectomy--Gill",
            "Laminectomy--Intradural",
            "Laminoforaminotomy",
            "Laminoplasty"});
            this.CboMetaSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboMetaSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboMetaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMetaSearch.FormattingEnabled = true;
            this.CboMetaSearch.Items.AddRange(new object[] {
            "Lamin",
            "Laminar Screws",
            "Laminectomy",
            "Laminectomy/Foraminotomy/Facetectomy",
            "Laminectomy--Bilateral",
            "Laminectomy--Gill",
            "Laminectomy--Intradural",
            "Laminoforaminotomy",
            "Laminoplasty"});
            this.CboMetaSearch.Location = new System.Drawing.Point(6, 55);
            this.CboMetaSearch.Name = "CboMetaSearch";
            this.CboMetaSearch.Size = new System.Drawing.Size(342, 24);
            this.CboMetaSearch.TabIndex = 1;
            this.CboMetaSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CboMetaSearch_KeyUp);
            // 
            // LbMetaDataSearch
            // 
            this.LbMetaDataSearch.AutoSize = true;
            this.LbMetaDataSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMetaDataSearch.Location = new System.Drawing.Point(6, 35);
            this.LbMetaDataSearch.Name = "LbMetaDataSearch";
            this.LbMetaDataSearch.Size = new System.Drawing.Size(135, 17);
            this.LbMetaDataSearch.TabIndex = 0;
            this.LbMetaDataSearch.Text = "Enter Search Terms";
            // 
            // GrpPicInfo
            // 
            this.GrpPicInfo.Controls.Add(this.ChkPicInfoOnly);
            this.GrpPicInfo.Controls.Add(this.RdoPicInfoOr);
            this.GrpPicInfo.Controls.Add(this.RdoPicInfoAnd);
            this.GrpPicInfo.Controls.Add(this.LstPicInfoSearchItems);
            this.GrpPicInfo.Controls.Add(this.LblPicInfoSearchItems);
            this.GrpPicInfo.Controls.Add(this.CboPicInfo);
            this.GrpPicInfo.Controls.Add(this.LblPicInfo);
            this.GrpPicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPicInfo.Location = new System.Drawing.Point(12, 398);
            this.GrpPicInfo.Name = "GrpPicInfo";
            this.GrpPicInfo.Size = new System.Drawing.Size(780, 331);
            this.GrpPicInfo.TabIndex = 7;
            this.GrpPicInfo.TabStop = false;
            this.GrpPicInfo.Text = "Picture Info";
            // 
            // ChkPicInfoOnly
            // 
            this.ChkPicInfoOnly.AutoSize = true;
            this.ChkPicInfoOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPicInfoOnly.Location = new System.Drawing.Point(711, 112);
            this.ChkPicInfoOnly.Name = "ChkPicInfoOnly";
            this.ChkPicInfoOnly.Size = new System.Drawing.Size(59, 21);
            this.ChkPicInfoOnly.TabIndex = 6;
            this.ChkPicInfoOnly.Text = "Only";
            this.ChkPicInfoOnly.UseVisualStyleBackColor = true;
            this.ChkPicInfoOnly.Click += new System.EventHandler(this.ChkPicInfoOnly_Click);
            // 
            // RdoPicInfoOr
            // 
            this.RdoPicInfoOr.AutoSize = true;
            this.RdoPicInfoOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoPicInfoOr.Location = new System.Drawing.Point(711, 85);
            this.RdoPicInfoOr.Name = "RdoPicInfoOr";
            this.RdoPicInfoOr.Size = new System.Drawing.Size(45, 21);
            this.RdoPicInfoOr.TabIndex = 5;
            this.RdoPicInfoOr.TabStop = true;
            this.RdoPicInfoOr.Text = "Or";
            this.RdoPicInfoOr.UseVisualStyleBackColor = true;
            this.RdoPicInfoOr.Click += new System.EventHandler(this.RdoPicInfoOr_Click);
            // 
            // RdoPicInfoAnd
            // 
            this.RdoPicInfoAnd.AutoSize = true;
            this.RdoPicInfoAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoPicInfoAnd.Location = new System.Drawing.Point(711, 58);
            this.RdoPicInfoAnd.Name = "RdoPicInfoAnd";
            this.RdoPicInfoAnd.Size = new System.Drawing.Size(54, 21);
            this.RdoPicInfoAnd.TabIndex = 4;
            this.RdoPicInfoAnd.TabStop = true;
            this.RdoPicInfoAnd.Text = "And";
            this.RdoPicInfoAnd.UseVisualStyleBackColor = true;
            this.RdoPicInfoAnd.Click += new System.EventHandler(this.RdoPicInfoAnd_Click);
            // 
            // LstPicInfoSearchItems
            // 
            this.LstPicInfoSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPicInfoSearchItems.FormattingEnabled = true;
            this.LstPicInfoSearchItems.ItemHeight = 16;
            this.LstPicInfoSearchItems.Location = new System.Drawing.Point(356, 55);
            this.LstPicInfoSearchItems.Name = "LstPicInfoSearchItems";
            this.LstPicInfoSearchItems.Size = new System.Drawing.Size(349, 244);
            this.LstPicInfoSearchItems.TabIndex = 3;
            this.LstPicInfoSearchItems.DoubleClick += new System.EventHandler(this.LstPicInfoSearchItems_DoubleClick);
            // 
            // LblPicInfoSearchItems
            // 
            this.LblPicInfoSearchItems.AutoSize = true;
            this.LblPicInfoSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPicInfoSearchItems.Location = new System.Drawing.Point(353, 35);
            this.LblPicInfoSearchItems.Name = "LblPicInfoSearchItems";
            this.LblPicInfoSearchItems.Size = new System.Drawing.Size(90, 17);
            this.LblPicInfoSearchItems.TabIndex = 2;
            this.LblPicInfoSearchItems.Text = "Search Items";
            // 
            // CboPicInfo
            // 
            this.CboPicInfo.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "First Surgery",
            "Oldest Female",
            "Oldest Male",
            "Oldest Patient",
            "Weirdest Case",
            "Worst Break",
            "Youngest Female",
            "Youngest Male"});
            this.CboPicInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboPicInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboPicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPicInfo.FormattingEnabled = true;
            this.CboPicInfo.Items.AddRange(new object[] {
            "Best Patient",
            "First Surgery",
            "Oldest Female",
            "Oldest Male",
            "Oldest Patient",
            "Weirdest Case",
            "Worst Break",
            "Youngest Female",
            "Youngest Male"});
            this.CboPicInfo.Location = new System.Drawing.Point(6, 55);
            this.CboPicInfo.Name = "CboPicInfo";
            this.CboPicInfo.Size = new System.Drawing.Size(342, 24);
            this.CboPicInfo.TabIndex = 1;
            this.CboPicInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CboPicInfo_KeyUp);
            // 
            // LblPicInfo
            // 
            this.LblPicInfo.AutoSize = true;
            this.LblPicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPicInfo.Location = new System.Drawing.Point(6, 35);
            this.LblPicInfo.Name = "LblPicInfo";
            this.LblPicInfo.Size = new System.Drawing.Size(79, 17);
            this.LblPicInfo.TabIndex = 0;
            this.LblPicInfo.Text = "Picture Info";
            // 
            // MnuImagesSearch
            // 
            this.MnuImagesSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuImagesSearch.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuImagesSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuSearch,
            this.TsMnuImageSearchBreak1,
            this.TsMnuImageSearchMetaData,
            this.TsMnuImageSearchBreak2,
            this.TSMnuSearchPicInfo});
            this.MnuImagesSearch.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuImagesSearch.Location = new System.Drawing.Point(0, 0);
            this.MnuImagesSearch.Name = "MnuImagesSearch";
            this.MnuImagesSearch.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuImagesSearch.Size = new System.Drawing.Size(1621, 28);
            this.MnuImagesSearch.TabIndex = 10;
            this.MnuImagesSearch.Text = "menuStrip1";
            // 
            // TSMnuSearch
            // 
            this.TSMnuSearch.Name = "TSMnuSearch";
            this.TSMnuSearch.Size = new System.Drawing.Size(65, 24);
            this.TSMnuSearch.Tag = "FrmDashboard";
            this.TSMnuSearch.Text = "&Search";
            this.TSMnuSearch.Click += new System.EventHandler(this.TSMnuSearch_Click);
            // 
            // TsMnuImageSearchBreak1
            // 
            this.TsMnuImageSearchBreak1.Enabled = false;
            this.TsMnuImageSearchBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TsMnuImageSearchBreak1.Name = "TsMnuImageSearchBreak1";
            this.TsMnuImageSearchBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TsMnuImageSearchBreak1.Size = new System.Drawing.Size(18, 24);
            this.TsMnuImageSearchBreak1.Text = "|";
            // 
            // TsMnuImageSearchMetaData
            // 
            this.TsMnuImageSearchMetaData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMnuImageSearchMetaDataAdd,
            this.TsMnuImageSearchMetaDataRemove,
            this.TsMnuImageSearchMetaDataSeparator1,
            this.TsMnuImageSearchMetaDataRemoveAll});
            this.TsMnuImageSearchMetaData.Name = "TsMnuImageSearchMetaData";
            this.TsMnuImageSearchMetaData.Size = new System.Drawing.Size(91, 24);
            this.TsMnuImageSearchMetaData.Text = "Meta Data";
            // 
            // TsMnuImageSearchMetaDataAdd
            // 
            this.TsMnuImageSearchMetaDataAdd.Name = "TsMnuImageSearchMetaDataAdd";
            this.TsMnuImageSearchMetaDataAdd.Size = new System.Drawing.Size(160, 26);
            this.TsMnuImageSearchMetaDataAdd.Text = "Add";
            this.TsMnuImageSearchMetaDataAdd.Click += new System.EventHandler(this.TsMnuImageSearchMetaDataAdd_Click);
            // 
            // TsMnuImageSearchMetaDataRemove
            // 
            this.TsMnuImageSearchMetaDataRemove.Name = "TsMnuImageSearchMetaDataRemove";
            this.TsMnuImageSearchMetaDataRemove.Size = new System.Drawing.Size(160, 26);
            this.TsMnuImageSearchMetaDataRemove.Text = "Remove";
            this.TsMnuImageSearchMetaDataRemove.Click += new System.EventHandler(this.TsMnuImageSearchMetaDataRemove_Click);
            // 
            // TsMnuImageSearchMetaDataSeparator1
            // 
            this.TsMnuImageSearchMetaDataSeparator1.Name = "TsMnuImageSearchMetaDataSeparator1";
            this.TsMnuImageSearchMetaDataSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // TsMnuImageSearchMetaDataRemoveAll
            // 
            this.TsMnuImageSearchMetaDataRemoveAll.Name = "TsMnuImageSearchMetaDataRemoveAll";
            this.TsMnuImageSearchMetaDataRemoveAll.Size = new System.Drawing.Size(160, 26);
            this.TsMnuImageSearchMetaDataRemoveAll.Text = "Remove All";
            this.TsMnuImageSearchMetaDataRemoveAll.Click += new System.EventHandler(this.TsMnuImageSearchMetaDataRemoveAll_Click);
            // 
            // TsMnuImageSearchBreak2
            // 
            this.TsMnuImageSearchBreak2.Enabled = false;
            this.TsMnuImageSearchBreak2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TsMnuImageSearchBreak2.Name = "TsMnuImageSearchBreak2";
            this.TsMnuImageSearchBreak2.Padding = new System.Windows.Forms.Padding(0);
            this.TsMnuImageSearchBreak2.Size = new System.Drawing.Size(18, 24);
            this.TsMnuImageSearchBreak2.Text = "|";
            // 
            // TSMnuSearchPicInfo
            // 
            this.TSMnuSearchPicInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuSearchPicInfoAdd,
            this.TSMnuSearchPicInfoRemove,
            this.TSMnuSearchPicInfoSeparator1,
            this.TSMnuSearchPicInfoRemoveAll});
            this.TSMnuSearchPicInfo.Name = "TSMnuSearchPicInfo";
            this.TSMnuSearchPicInfo.Size = new System.Drawing.Size(96, 24);
            this.TSMnuSearchPicInfo.Text = "Picture Info";
            // 
            // TSMnuSearchPicInfoAdd
            // 
            this.TSMnuSearchPicInfoAdd.Name = "TSMnuSearchPicInfoAdd";
            this.TSMnuSearchPicInfoAdd.Size = new System.Drawing.Size(160, 26);
            this.TSMnuSearchPicInfoAdd.Text = "Add";
            this.TSMnuSearchPicInfoAdd.Click += new System.EventHandler(this.TSMnuSearchPicInfoAdd_Click);
            // 
            // TSMnuSearchPicInfoRemove
            // 
            this.TSMnuSearchPicInfoRemove.Name = "TSMnuSearchPicInfoRemove";
            this.TSMnuSearchPicInfoRemove.Size = new System.Drawing.Size(160, 26);
            this.TSMnuSearchPicInfoRemove.Text = "Remove";
            this.TSMnuSearchPicInfoRemove.Click += new System.EventHandler(this.TSMnuSearchPicInfoRemove_Click);
            // 
            // TSMnuSearchPicInfoSeparator1
            // 
            this.TSMnuSearchPicInfoSeparator1.Name = "TSMnuSearchPicInfoSeparator1";
            this.TSMnuSearchPicInfoSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // TSMnuSearchPicInfoRemoveAll
            // 
            this.TSMnuSearchPicInfoRemoveAll.Name = "TSMnuSearchPicInfoRemoveAll";
            this.TSMnuSearchPicInfoRemoveAll.Size = new System.Drawing.Size(160, 26);
            this.TSMnuSearchPicInfoRemoveAll.Text = "Remove All";
            this.TSMnuSearchPicInfoRemoveAll.Click += new System.EventHandler(this.TSMnuSearchPicInfoRemoveAll_Click);
            // 
            // FrmImageSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 840);
            this.ControlBox = false;
            this.Controls.Add(this.MnuImagesSearch);
            this.Controls.Add(this.GrpPicInfo);
            this.Controls.Add(this.GrpMetaData);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImageSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmImageSearch";
            this.Text = "Images - Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImageSearch_Load);
            this.GrpMetaData.ResumeLayout(false);
            this.GrpMetaData.PerformLayout();
            this.GrpPicInfo.ResumeLayout(false);
            this.GrpPicInfo.PerformLayout();
            this.MnuImagesSearch.ResumeLayout(false);
            this.MnuImagesSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpMetaData;
        private System.Windows.Forms.ComboBox CboMetaSearch;
        private System.Windows.Forms.Label LbMetaDataSearch;
        private System.Windows.Forms.Label LblMetaSearch;
        private System.Windows.Forms.CheckBox ChkMeataOnly;
        private System.Windows.Forms.RadioButton RdoMetaOr;
        private System.Windows.Forms.RadioButton RdoMetaAnd;
        private System.Windows.Forms.ListBox LstMetaDataSearchTerms;
        private System.Windows.Forms.GroupBox GrpPicInfo;
        private System.Windows.Forms.CheckBox ChkPicInfoOnly;
        private System.Windows.Forms.RadioButton RdoPicInfoOr;
        private System.Windows.Forms.RadioButton RdoPicInfoAnd;
        private System.Windows.Forms.ListBox LstPicInfoSearchItems;
        private System.Windows.Forms.Label LblPicInfoSearchItems;
        private System.Windows.Forms.ComboBox CboPicInfo;
        private System.Windows.Forms.Label LblPicInfo;
        private System.Windows.Forms.MenuStrip MnuImagesSearch;
        private System.Windows.Forms.ToolStripMenuItem TSMnuSearch;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchBreak1;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchBreak2;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchMetaData;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchMetaDataAdd;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchMetaDataRemove;
        private System.Windows.Forms.ToolStripSeparator TsMnuImageSearchMetaDataSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsMnuImageSearchMetaDataRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem TSMnuSearchPicInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMnuSearchPicInfoAdd;
        private System.Windows.Forms.ToolStripMenuItem TSMnuSearchPicInfoRemove;
        private System.Windows.Forms.ToolStripSeparator TSMnuSearchPicInfoSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuSearchPicInfoRemoveAll;
    }
}