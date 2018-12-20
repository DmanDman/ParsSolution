namespace ParsDashboard
{
    partial class FrmMDCpt
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
            this.GrpNew = new System.Windows.Forms.GroupBox();
            this.TxtNew = new System.Windows.Forms.TextBox();
            this.GrpCpt = new System.Windows.Forms.GroupBox();
            this.CboCpt = new System.Windows.Forms.ComboBox();
            this.GrpRename = new System.Windows.Forms.GroupBox();
            this.TxtRename = new System.Windows.Forms.TextBox();
            this.GrpNew.SuspendLayout();
            this.GrpCpt.SuspendLayout();
            this.GrpRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpNew
            // 
            this.GrpNew.Controls.Add(this.TxtNew);
            this.GrpNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpNew.Location = new System.Drawing.Point(12, 46);
            this.GrpNew.Name = "GrpNew";
            this.GrpNew.Size = new System.Drawing.Size(276, 185);
            this.GrpNew.TabIndex = 2;
            this.GrpNew.TabStop = false;
            this.GrpNew.Text = "New";
            // 
            // TxtNew
            // 
            this.TxtNew.Location = new System.Drawing.Point(6, 35);
            this.TxtNew.Name = "TxtNew";
            this.TxtNew.Size = new System.Drawing.Size(264, 22);
            this.TxtNew.TabIndex = 0;
            // 
            // GrpCpt
            // 
            this.GrpCpt.Controls.Add(this.CboCpt);
            this.GrpCpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCpt.Location = new System.Drawing.Point(327, 46);
            this.GrpCpt.Name = "GrpCpt";
            this.GrpCpt.Size = new System.Drawing.Size(276, 185);
            this.GrpCpt.TabIndex = 3;
            this.GrpCpt.TabStop = false;
            this.GrpCpt.Text = "CPT";
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
            // GrpRename
            // 
            this.GrpRename.Controls.Add(this.TxtRename);
            this.GrpRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRename.Location = new System.Drawing.Point(653, 46);
            this.GrpRename.Name = "GrpRename";
            this.GrpRename.Size = new System.Drawing.Size(276, 185);
            this.GrpRename.TabIndex = 4;
            this.GrpRename.TabStop = false;
            this.GrpRename.Text = "Rename";
            // 
            // TxtRename
            // 
            this.TxtRename.Location = new System.Drawing.Point(6, 35);
            this.TxtRename.Name = "TxtRename";
            this.TxtRename.Size = new System.Drawing.Size(264, 22);
            this.TxtRename.TabIndex = 0;
            // 
            // FrmMDCpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 558);
            this.ControlBox = false;
            this.Controls.Add(this.GrpRename);
            this.Controls.Add(this.GrpCpt);
            this.Controls.Add(this.GrpNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMDCpt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmMDCpt";
            this.Text = "Meta Data - CPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrpNew.ResumeLayout(false);
            this.GrpNew.PerformLayout();
            this.GrpCpt.ResumeLayout(false);
            this.GrpRename.ResumeLayout(false);
            this.GrpRename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpNew;
        private System.Windows.Forms.TextBox TxtNew;
        private System.Windows.Forms.GroupBox GrpCpt;
        private System.Windows.Forms.ComboBox CboCpt;
        private System.Windows.Forms.GroupBox GrpRename;
        private System.Windows.Forms.TextBox TxtRename;
    }
}