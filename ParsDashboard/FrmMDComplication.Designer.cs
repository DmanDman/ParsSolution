namespace ParsDashboard
{
    partial class FrmMD
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
            this.GrpComp = new System.Windows.Forms.GroupBox();
            this.GrpCompRename = new System.Windows.Forms.GroupBox();
            this.TxtCompRename = new System.Windows.Forms.TextBox();
            this.GrpCompComp = new System.Windows.Forms.GroupBox();
            this.CboComp = new System.Windows.Forms.ComboBox();
            this.GrpCompNew = new System.Windows.Forms.GroupBox();
            this.TxtCompNew = new System.Windows.Forms.TextBox();
            this.GrpImageDesc = new System.Windows.Forms.GroupBox();
            this.GrpImageDescRename = new System.Windows.Forms.GroupBox();
            this.TxtImageDescRename = new System.Windows.Forms.TextBox();
            this.GrpImageDescImageDesc = new System.Windows.Forms.GroupBox();
            this.CboImageDesc = new System.Windows.Forms.ComboBox();
            this.GrpImageDescNew = new System.Windows.Forms.GroupBox();
            this.TxtImageDescNew = new System.Windows.Forms.TextBox();
            this.GrpCpt = new System.Windows.Forms.GroupBox();
            this.GrpCptRename = new System.Windows.Forms.GroupBox();
            this.TxtCptRename = new System.Windows.Forms.TextBox();
            this.GrpCptCpt = new System.Windows.Forms.GroupBox();
            this.CboCpt = new System.Windows.Forms.ComboBox();
            this.GrpCptNew = new System.Windows.Forms.GroupBox();
            this.TxtCptNew = new System.Windows.Forms.TextBox();
            this.GrpDx = new System.Windows.Forms.GroupBox();
            this.GrpDxRename = new System.Windows.Forms.GroupBox();
            this.TxtDxRename = new System.Windows.Forms.TextBox();
            this.GrpDxDx = new System.Windows.Forms.GroupBox();
            this.CobDx = new System.Windows.Forms.ComboBox();
            this.GrpDxNew = new System.Windows.Forms.GroupBox();
            this.TxtDxNew = new System.Windows.Forms.TextBox();
            this.GrpComp.SuspendLayout();
            this.GrpCompRename.SuspendLayout();
            this.GrpCompComp.SuspendLayout();
            this.GrpCompNew.SuspendLayout();
            this.GrpImageDesc.SuspendLayout();
            this.GrpImageDescRename.SuspendLayout();
            this.GrpImageDescImageDesc.SuspendLayout();
            this.GrpImageDescNew.SuspendLayout();
            this.GrpCpt.SuspendLayout();
            this.GrpCptRename.SuspendLayout();
            this.GrpCptCpt.SuspendLayout();
            this.GrpCptNew.SuspendLayout();
            this.GrpDx.SuspendLayout();
            this.GrpDxRename.SuspendLayout();
            this.GrpDxDx.SuspendLayout();
            this.GrpDxNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpComp
            // 
            this.GrpComp.Controls.Add(this.GrpCompRename);
            this.GrpComp.Controls.Add(this.GrpCompComp);
            this.GrpComp.Controls.Add(this.GrpCompNew);
            this.GrpComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpComp.Location = new System.Drawing.Point(12, 46);
            this.GrpComp.Name = "GrpComp";
            this.GrpComp.Size = new System.Drawing.Size(985, 324);
            this.GrpComp.TabIndex = 3;
            this.GrpComp.TabStop = false;
            this.GrpComp.Text = "Complication";
            // 
            // GrpCompRename
            // 
            this.GrpCompRename.Controls.Add(this.TxtCompRename);
            this.GrpCompRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCompRename.Location = new System.Drawing.Point(662, 35);
            this.GrpCompRename.Name = "GrpCompRename";
            this.GrpCompRename.Size = new System.Drawing.Size(276, 185);
            this.GrpCompRename.TabIndex = 6;
            this.GrpCompRename.TabStop = false;
            this.GrpCompRename.Text = "Rename";
            // 
            // TxtCompRename
            // 
            this.TxtCompRename.Location = new System.Drawing.Point(6, 35);
            this.TxtCompRename.Name = "TxtCompRename";
            this.TxtCompRename.Size = new System.Drawing.Size(264, 22);
            this.TxtCompRename.TabIndex = 0;
            // 
            // GrpCompComp
            // 
            this.GrpCompComp.Controls.Add(this.CboComp);
            this.GrpCompComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCompComp.Location = new System.Drawing.Point(336, 35);
            this.GrpCompComp.Name = "GrpCompComp";
            this.GrpCompComp.Size = new System.Drawing.Size(276, 185);
            this.GrpCompComp.TabIndex = 5;
            this.GrpCompComp.TabStop = false;
            this.GrpCompComp.Text = "Complication";
            // 
            // CboComp
            // 
            this.CboComp.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "\nFirst Surgery",
            "\nOldest Female\n",
            "Oldest Male\n",
            "Oldest Patient\n",
            "Weirdest Case",
            "\nWorst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboComp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboComp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboComp.FormattingEnabled = true;
            this.CboComp.Items.AddRange(new object[] {
            "\nOldest Female",
            "\nOldest Male\n",
            "\nWeirdest Case\n",
            "Best Patient\n",
            "First Surgery",
            "Oldest Patient",
            "Worst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboComp.Location = new System.Drawing.Point(6, 35);
            this.CboComp.Name = "CboComp";
            this.CboComp.Size = new System.Drawing.Size(254, 24);
            this.CboComp.Sorted = true;
            this.CboComp.TabIndex = 0;
            // 
            // GrpCompNew
            // 
            this.GrpCompNew.Controls.Add(this.TxtCompNew);
            this.GrpCompNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCompNew.Location = new System.Drawing.Point(21, 35);
            this.GrpCompNew.Name = "GrpCompNew";
            this.GrpCompNew.Size = new System.Drawing.Size(276, 185);
            this.GrpCompNew.TabIndex = 4;
            this.GrpCompNew.TabStop = false;
            this.GrpCompNew.Text = "New";
            // 
            // TxtCompNew
            // 
            this.TxtCompNew.Location = new System.Drawing.Point(6, 35);
            this.TxtCompNew.Name = "TxtCompNew";
            this.TxtCompNew.Size = new System.Drawing.Size(264, 22);
            this.TxtCompNew.TabIndex = 0;
            // 
            // GrpImageDesc
            // 
            this.GrpImageDesc.Controls.Add(this.GrpImageDescRename);
            this.GrpImageDesc.Controls.Add(this.GrpImageDescImageDesc);
            this.GrpImageDesc.Controls.Add(this.GrpImageDescNew);
            this.GrpImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImageDesc.Location = new System.Drawing.Point(12, 46);
            this.GrpImageDesc.Name = "GrpImageDesc";
            this.GrpImageDesc.Size = new System.Drawing.Size(985, 324);
            this.GrpImageDesc.TabIndex = 8;
            this.GrpImageDesc.TabStop = false;
            this.GrpImageDesc.Text = "Image Descriptors";
            // 
            // GrpImageDescRename
            // 
            this.GrpImageDescRename.Controls.Add(this.TxtImageDescRename);
            this.GrpImageDescRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImageDescRename.Location = new System.Drawing.Point(662, 35);
            this.GrpImageDescRename.Name = "GrpImageDescRename";
            this.GrpImageDescRename.Size = new System.Drawing.Size(276, 185);
            this.GrpImageDescRename.TabIndex = 6;
            this.GrpImageDescRename.TabStop = false;
            this.GrpImageDescRename.Text = "Rename";
            // 
            // TxtImageDescRename
            // 
            this.TxtImageDescRename.Location = new System.Drawing.Point(6, 35);
            this.TxtImageDescRename.Name = "TxtImageDescRename";
            this.TxtImageDescRename.Size = new System.Drawing.Size(264, 22);
            this.TxtImageDescRename.TabIndex = 0;
            // 
            // GrpImageDescImageDesc
            // 
            this.GrpImageDescImageDesc.Controls.Add(this.CboImageDesc);
            this.GrpImageDescImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImageDescImageDesc.Location = new System.Drawing.Point(336, 35);
            this.GrpImageDescImageDesc.Name = "GrpImageDescImageDesc";
            this.GrpImageDescImageDesc.Size = new System.Drawing.Size(276, 185);
            this.GrpImageDescImageDesc.TabIndex = 5;
            this.GrpImageDescImageDesc.TabStop = false;
            this.GrpImageDescImageDesc.Text = "Image Description";
            // 
            // CboImageDesc
            // 
            this.CboImageDesc.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "\nFirst Surgery",
            "\nOldest Female\n",
            "Oldest Male\n",
            "Oldest Patient\n",
            "Weirdest Case",
            "\nWorst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboImageDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboImageDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboImageDesc.FormattingEnabled = true;
            this.CboImageDesc.Items.AddRange(new object[] {
            "\nOldest Female",
            "\nOldest Male\n",
            "\nWeirdest Case\n",
            "Best Patient\n",
            "First Surgery",
            "Oldest Patient",
            "Worst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboImageDesc.Location = new System.Drawing.Point(6, 35);
            this.CboImageDesc.Name = "CboImageDesc";
            this.CboImageDesc.Size = new System.Drawing.Size(254, 24);
            this.CboImageDesc.Sorted = true;
            this.CboImageDesc.TabIndex = 0;
            // 
            // GrpImageDescNew
            // 
            this.GrpImageDescNew.Controls.Add(this.TxtImageDescNew);
            this.GrpImageDescNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImageDescNew.Location = new System.Drawing.Point(21, 35);
            this.GrpImageDescNew.Name = "GrpImageDescNew";
            this.GrpImageDescNew.Size = new System.Drawing.Size(276, 185);
            this.GrpImageDescNew.TabIndex = 4;
            this.GrpImageDescNew.TabStop = false;
            this.GrpImageDescNew.Text = "New";
            // 
            // TxtImageDescNew
            // 
            this.TxtImageDescNew.Location = new System.Drawing.Point(6, 35);
            this.TxtImageDescNew.Name = "TxtImageDescNew";
            this.TxtImageDescNew.Size = new System.Drawing.Size(264, 22);
            this.TxtImageDescNew.TabIndex = 0;
            // 
            // GrpCpt
            // 
            this.GrpCpt.Controls.Add(this.GrpCptRename);
            this.GrpCpt.Controls.Add(this.GrpCptCpt);
            this.GrpCpt.Controls.Add(this.GrpCptNew);
            this.GrpCpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCpt.Location = new System.Drawing.Point(12, 46);
            this.GrpCpt.Name = "GrpCpt";
            this.GrpCpt.Size = new System.Drawing.Size(985, 324);
            this.GrpCpt.TabIndex = 7;
            this.GrpCpt.TabStop = false;
            this.GrpCpt.Text = "CPT";
            // 
            // GrpCptRename
            // 
            this.GrpCptRename.Controls.Add(this.TxtCptRename);
            this.GrpCptRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptRename.Location = new System.Drawing.Point(662, 35);
            this.GrpCptRename.Name = "GrpCptRename";
            this.GrpCptRename.Size = new System.Drawing.Size(276, 185);
            this.GrpCptRename.TabIndex = 7;
            this.GrpCptRename.TabStop = false;
            this.GrpCptRename.Text = "Rename";
            // 
            // TxtCptRename
            // 
            this.TxtCptRename.Location = new System.Drawing.Point(6, 35);
            this.TxtCptRename.Name = "TxtCptRename";
            this.TxtCptRename.Size = new System.Drawing.Size(264, 22);
            this.TxtCptRename.TabIndex = 0;
            // 
            // GrpCptCpt
            // 
            this.GrpCptCpt.Controls.Add(this.CboCpt);
            this.GrpCptCpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptCpt.Location = new System.Drawing.Point(336, 35);
            this.GrpCptCpt.Name = "GrpCptCpt";
            this.GrpCptCpt.Size = new System.Drawing.Size(276, 185);
            this.GrpCptCpt.TabIndex = 6;
            this.GrpCptCpt.TabStop = false;
            this.GrpCptCpt.Text = "CPT";
            // 
            // CboCpt
            // 
            this.CboCpt.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "\nFirst Surgery",
            "\nOldest Female\n",
            "Oldest Male\n",
            "Oldest Patient\n",
            "Weirdest Case",
            "\nWorst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboCpt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboCpt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboCpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCpt.FormattingEnabled = true;
            this.CboCpt.Items.AddRange(new object[] {
            "\nOldest Female",
            "\nOldest Male\n",
            "\nWeirdest Case\n",
            "Best Patient\n",
            "First Surgery",
            "Oldest Patient",
            "Worst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboCpt.Location = new System.Drawing.Point(6, 35);
            this.CboCpt.Name = "CboCpt";
            this.CboCpt.Size = new System.Drawing.Size(254, 24);
            this.CboCpt.Sorted = true;
            this.CboCpt.TabIndex = 0;
            // 
            // GrpCptNew
            // 
            this.GrpCptNew.Controls.Add(this.TxtCptNew);
            this.GrpCptNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptNew.Location = new System.Drawing.Point(21, 35);
            this.GrpCptNew.Name = "GrpCptNew";
            this.GrpCptNew.Size = new System.Drawing.Size(276, 185);
            this.GrpCptNew.TabIndex = 5;
            this.GrpCptNew.TabStop = false;
            this.GrpCptNew.Text = "New";
            // 
            // TxtCptNew
            // 
            this.TxtCptNew.Location = new System.Drawing.Point(6, 35);
            this.TxtCptNew.Name = "TxtCptNew";
            this.TxtCptNew.Size = new System.Drawing.Size(264, 22);
            this.TxtCptNew.TabIndex = 0;
            // 
            // GrpDx
            // 
            this.GrpDx.Controls.Add(this.GrpDxRename);
            this.GrpDx.Controls.Add(this.GrpDxDx);
            this.GrpDx.Controls.Add(this.GrpDxNew);
            this.GrpDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDx.Location = new System.Drawing.Point(12, 46);
            this.GrpDx.Name = "GrpDx";
            this.GrpDx.Size = new System.Drawing.Size(985, 324);
            this.GrpDx.TabIndex = 9;
            this.GrpDx.TabStop = false;
            this.GrpDx.Text = "Dx";
            // 
            // GrpDxRename
            // 
            this.GrpDxRename.Controls.Add(this.TxtDxRename);
            this.GrpDxRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDxRename.Location = new System.Drawing.Point(662, 35);
            this.GrpDxRename.Name = "GrpDxRename";
            this.GrpDxRename.Size = new System.Drawing.Size(276, 185);
            this.GrpDxRename.TabIndex = 6;
            this.GrpDxRename.TabStop = false;
            this.GrpDxRename.Text = "Rename";
            // 
            // TxtDxRename
            // 
            this.TxtDxRename.Location = new System.Drawing.Point(6, 35);
            this.TxtDxRename.Name = "TxtDxRename";
            this.TxtDxRename.Size = new System.Drawing.Size(264, 22);
            this.TxtDxRename.TabIndex = 0;
            // 
            // GrpDxDx
            // 
            this.GrpDxDx.Controls.Add(this.CobDx);
            this.GrpDxDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDxDx.Location = new System.Drawing.Point(336, 35);
            this.GrpDxDx.Name = "GrpDxDx";
            this.GrpDxDx.Size = new System.Drawing.Size(276, 185);
            this.GrpDxDx.TabIndex = 5;
            this.GrpDxDx.TabStop = false;
            this.GrpDxDx.Text = "Dx";
            // 
            // CobDx
            // 
            this.CobDx.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "\nFirst Surgery",
            "\nOldest Female\n",
            "Oldest Male\n",
            "Oldest Patient\n",
            "Weirdest Case",
            "\nWorst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CobDx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CobDx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CobDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobDx.FormattingEnabled = true;
            this.CobDx.Items.AddRange(new object[] {
            "\nOldest Female",
            "\nOldest Male\n",
            "\nWeirdest Case\n",
            "Best Patient\n",
            "First Surgery",
            "Oldest Patient",
            "Worst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CobDx.Location = new System.Drawing.Point(6, 35);
            this.CobDx.Name = "CobDx";
            this.CobDx.Size = new System.Drawing.Size(254, 24);
            this.CobDx.Sorted = true;
            this.CobDx.TabIndex = 0;
            // 
            // GrpDxNew
            // 
            this.GrpDxNew.Controls.Add(this.TxtDxNew);
            this.GrpDxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDxNew.Location = new System.Drawing.Point(21, 35);
            this.GrpDxNew.Name = "GrpDxNew";
            this.GrpDxNew.Size = new System.Drawing.Size(276, 185);
            this.GrpDxNew.TabIndex = 4;
            this.GrpDxNew.TabStop = false;
            this.GrpDxNew.Text = "New";
            // 
            // TxtDxNew
            // 
            this.TxtDxNew.Location = new System.Drawing.Point(6, 35);
            this.TxtDxNew.Name = "TxtDxNew";
            this.TxtDxNew.Size = new System.Drawing.Size(264, 22);
            this.TxtDxNew.TabIndex = 0;
            // 
            // FrmMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 605);
            this.ControlBox = false;
            this.Controls.Add(this.GrpDx);
            this.Controls.Add(this.GrpComp);
            this.Controls.Add(this.GrpImageDesc);
            this.Controls.Add(this.GrpCpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmMD";
            this.Text = "Meta Data - Complication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrpComp.ResumeLayout(false);
            this.GrpCompRename.ResumeLayout(false);
            this.GrpCompRename.PerformLayout();
            this.GrpCompComp.ResumeLayout(false);
            this.GrpCompNew.ResumeLayout(false);
            this.GrpCompNew.PerformLayout();
            this.GrpImageDesc.ResumeLayout(false);
            this.GrpImageDescRename.ResumeLayout(false);
            this.GrpImageDescRename.PerformLayout();
            this.GrpImageDescImageDesc.ResumeLayout(false);
            this.GrpImageDescNew.ResumeLayout(false);
            this.GrpImageDescNew.PerformLayout();
            this.GrpCpt.ResumeLayout(false);
            this.GrpCptRename.ResumeLayout(false);
            this.GrpCptRename.PerformLayout();
            this.GrpCptCpt.ResumeLayout(false);
            this.GrpCptNew.ResumeLayout(false);
            this.GrpCptNew.PerformLayout();
            this.GrpDx.ResumeLayout(false);
            this.GrpDxRename.ResumeLayout(false);
            this.GrpDxRename.PerformLayout();
            this.GrpDxDx.ResumeLayout(false);
            this.GrpDxNew.ResumeLayout(false);
            this.GrpDxNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpComp;
        private System.Windows.Forms.GroupBox GrpCompRename;
        private System.Windows.Forms.TextBox TxtCompRename;
        private System.Windows.Forms.GroupBox GrpCompComp;
        private System.Windows.Forms.ComboBox CboComp;
        private System.Windows.Forms.GroupBox GrpCompNew;
        private System.Windows.Forms.TextBox TxtCompNew;
        private System.Windows.Forms.GroupBox GrpCpt;
        private System.Windows.Forms.GroupBox GrpCptRename;
        private System.Windows.Forms.TextBox TxtCptRename;
        private System.Windows.Forms.GroupBox GrpCptCpt;
        private System.Windows.Forms.ComboBox CboCpt;
        private System.Windows.Forms.GroupBox GrpCptNew;
        private System.Windows.Forms.TextBox TxtCptNew;
        private System.Windows.Forms.GroupBox GrpImageDesc;
        private System.Windows.Forms.GroupBox GrpImageDescRename;
        private System.Windows.Forms.TextBox TxtImageDescRename;
        private System.Windows.Forms.GroupBox GrpImageDescImageDesc;
        private System.Windows.Forms.ComboBox CboImageDesc;
        private System.Windows.Forms.GroupBox GrpImageDescNew;
        private System.Windows.Forms.TextBox TxtImageDescNew;
        private System.Windows.Forms.GroupBox GrpDx;
        private System.Windows.Forms.GroupBox GrpDxRename;
        private System.Windows.Forms.TextBox TxtDxRename;
        private System.Windows.Forms.GroupBox GrpDxDx;
        private System.Windows.Forms.ComboBox CobDx;
        private System.Windows.Forms.GroupBox GrpDxNew;
        private System.Windows.Forms.TextBox TxtDxNew;
    }
}