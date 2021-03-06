﻿namespace ParsDashboard
{
    partial class FrmDataPicInfo
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
            this.GrpPicInfo = new System.Windows.Forms.GroupBox();
            this.CboPicInfo = new System.Windows.Forms.ComboBox();
            this.GrpRename = new System.Windows.Forms.GroupBox();
            this.TxtRename = new System.Windows.Forms.TextBox();
            this.MnuDataPicInfo = new System.Windows.Forms.MenuStrip();
            this.TSMnuDataPicInfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataPicInfoBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataPicInfoDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataPicInfoBreak2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataPicInfoRename = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpNew.SuspendLayout();
            this.GrpPicInfo.SuspendLayout();
            this.GrpRename.SuspendLayout();
            this.MnuDataPicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpNew
            // 
            this.GrpNew.Controls.Add(this.TxtNew);
            this.GrpNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpNew.Location = new System.Drawing.Point(12, 46);
            this.GrpNew.Name = "GrpNew";
            this.GrpNew.Size = new System.Drawing.Size(276, 185);
            this.GrpNew.TabIndex = 0;
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
            // GrpPicInfo
            // 
            this.GrpPicInfo.Controls.Add(this.CboPicInfo);
            this.GrpPicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPicInfo.Location = new System.Drawing.Point(327, 46);
            this.GrpPicInfo.Name = "GrpPicInfo";
            this.GrpPicInfo.Size = new System.Drawing.Size(276, 185);
            this.GrpPicInfo.TabIndex = 1;
            this.GrpPicInfo.TabStop = false;
            this.GrpPicInfo.Text = "Pcture Information";
            // 
            // CboPicInfo
            // 
            this.CboPicInfo.AutoCompleteCustomSource.AddRange(new string[] {
            "Best Patient",
            "\nFirst Surgery",
            "\nOldest Female\n",
            "Oldest Male\n",
            "Oldest Patient\n",
            "Weirdest Case",
            "\nWorst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboPicInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboPicInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboPicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPicInfo.FormattingEnabled = true;
            this.CboPicInfo.Items.AddRange(new object[] {
            "\nOldest Female",
            "\nOldest Male\n",
            "\nWeirdest Case\n",
            "Best Patient\n",
            "First Surgery",
            "Oldest Patient",
            "Worst Break\n",
            "Youngest Female\n",
            "Youngest Male"});
            this.CboPicInfo.Location = new System.Drawing.Point(6, 35);
            this.CboPicInfo.Name = "CboPicInfo";
            this.CboPicInfo.Size = new System.Drawing.Size(254, 24);
            this.CboPicInfo.Sorted = true;
            this.CboPicInfo.TabIndex = 0;
            // 
            // GrpRename
            // 
            this.GrpRename.Controls.Add(this.TxtRename);
            this.GrpRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRename.Location = new System.Drawing.Point(653, 46);
            this.GrpRename.Name = "GrpRename";
            this.GrpRename.Size = new System.Drawing.Size(276, 185);
            this.GrpRename.TabIndex = 2;
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
            // MnuDataPicInfo
            // 
            this.MnuDataPicInfo.AllowMerge = false;
            this.MnuDataPicInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuDataPicInfo.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuDataPicInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDataPicInfoAdd,
            this.TSMnuDataPicInfoBreak1,
            this.TSMnuDataPicInfoDelete,
            this.TSMnuDataPicInfoBreak2,
            this.TSMnuDataPicInfoRename});
            this.MnuDataPicInfo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuDataPicInfo.Location = new System.Drawing.Point(0, 0);
            this.MnuDataPicInfo.Name = "MnuDataPicInfo";
            this.MnuDataPicInfo.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuDataPicInfo.Size = new System.Drawing.Size(1567, 28);
            this.MnuDataPicInfo.TabIndex = 26;
            this.MnuDataPicInfo.Text = "menuStrip1";
            // 
            // TSMnuDataPicInfoAdd
            // 
            this.TSMnuDataPicInfoAdd.Name = "TSMnuDataPicInfoAdd";
            this.TSMnuDataPicInfoAdd.Size = new System.Drawing.Size(53, 24);
            this.TSMnuDataPicInfoAdd.Text = "Add ";
            // 
            // TSMnuDataPicInfoBreak1
            // 
            this.TSMnuDataPicInfoBreak1.Enabled = false;
            this.TSMnuDataPicInfoBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataPicInfoBreak1.Name = "TSMnuDataPicInfoBreak1";
            this.TSMnuDataPicInfoBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataPicInfoBreak1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataPicInfoBreak1.Text = "|";
            // 
            // TSMnuDataPicInfoDelete
            // 
            this.TSMnuDataPicInfoDelete.Name = "TSMnuDataPicInfoDelete";
            this.TSMnuDataPicInfoDelete.Size = new System.Drawing.Size(65, 24);
            this.TSMnuDataPicInfoDelete.Text = "Delete";
            // 
            // TSMnuDataPicInfoBreak2
            // 
            this.TSMnuDataPicInfoBreak2.Enabled = false;
            this.TSMnuDataPicInfoBreak2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataPicInfoBreak2.Name = "TSMnuDataPicInfoBreak2";
            this.TSMnuDataPicInfoBreak2.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataPicInfoBreak2.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataPicInfoBreak2.Text = "|";
            // 
            // TSMnuDataPicInfoRename
            // 
            this.TSMnuDataPicInfoRename.Name = "TSMnuDataPicInfoRename";
            this.TSMnuDataPicInfoRename.Size = new System.Drawing.Size(75, 24);
            this.TSMnuDataPicInfoRename.Text = "Rename";
            // 
            // FrmDataPicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 803);
            this.ControlBox = false;
            this.Controls.Add(this.MnuDataPicInfo);
            this.Controls.Add(this.GrpRename);
            this.Controls.Add(this.GrpPicInfo);
            this.Controls.Add(this.GrpNew);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataPicInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmDataPicInfo";
            this.Text = "Data - Picture Information";
            this.GrpNew.ResumeLayout(false);
            this.GrpNew.PerformLayout();
            this.GrpPicInfo.ResumeLayout(false);
            this.GrpRename.ResumeLayout(false);
            this.GrpRename.PerformLayout();
            this.MnuDataPicInfo.ResumeLayout(false);
            this.MnuDataPicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpNew;
        private System.Windows.Forms.TextBox TxtNew;
        private System.Windows.Forms.GroupBox GrpPicInfo;
        private System.Windows.Forms.ComboBox CboPicInfo;
        private System.Windows.Forms.GroupBox GrpRename;
        private System.Windows.Forms.TextBox TxtRename;
        private System.Windows.Forms.MenuStrip MnuDataPicInfo;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataPicInfoAdd;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataPicInfoBreak1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataPicInfoDelete;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataPicInfoBreak2;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataPicInfoRename;
    }
}