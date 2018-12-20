namespace ParsDashboard
{
    partial class FrmMDComplication
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
            this.GrpCpt = new System.Windows.Forms.GroupBox();
            this.GrpCptRename = new System.Windows.Forms.GroupBox();
            this.TxtCptRename = new System.Windows.Forms.TextBox();
            this.GrpCptCpt = new System.Windows.Forms.GroupBox();
            this.CboCpt = new System.Windows.Forms.ComboBox();
            this.GrpCptNew = new System.Windows.Forms.GroupBox();
            this.TxtCptNew = new System.Windows.Forms.TextBox();
            this.GrpComp.SuspendLayout();
            this.GrpCompRename.SuspendLayout();
            this.GrpCompComp.SuspendLayout();
            this.GrpCompNew.SuspendLayout();
            this.GrpCpt.SuspendLayout();
            this.GrpCptRename.SuspendLayout();
            this.GrpCptCpt.SuspendLayout();
            this.GrpCptNew.SuspendLayout();
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
            this.GrpCompRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GrpCompComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GrpCompNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.GrpCptRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptRename.Location = new System.Drawing.Point(663, 55);
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
            this.GrpCptCpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptCpt.Location = new System.Drawing.Point(337, 55);
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
            this.GrpCptNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCptNew.Location = new System.Drawing.Point(22, 55);
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
            // FrmMDComplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 605);
            this.ControlBox = false;
            this.Controls.Add(this.GrpCpt);
            this.Controls.Add(this.GrpComp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMDComplication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmMDComplication";
            this.Text = "Meta Data - Complication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrpComp.ResumeLayout(false);
            this.GrpCompRename.ResumeLayout(false);
            this.GrpCompRename.PerformLayout();
            this.GrpCompComp.ResumeLayout(false);
            this.GrpCompNew.ResumeLayout(false);
            this.GrpCompNew.PerformLayout();
            this.GrpCpt.ResumeLayout(false);
            this.GrpCptRename.ResumeLayout(false);
            this.GrpCptRename.PerformLayout();
            this.GrpCptCpt.ResumeLayout(false);
            this.GrpCptNew.ResumeLayout(false);
            this.GrpCptNew.PerformLayout();
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
    }
}