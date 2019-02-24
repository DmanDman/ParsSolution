namespace ParsDashboard
{
    partial class FrmDataDefaultHosp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtOrigDr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboAvaliHosp = new System.Windows.Forms.ComboBox();
            this.MnuDataDefaultHosp = new System.Windows.Forms.MenuStrip();
            this.TSMnuDataDefaultHospSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataDefaultHospBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataDefaultHospRemoveDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataDefaultHospBreak2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataDefaultHospClear = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MnuDataDefaultHosp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOrigDr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Default Hospital";
            // 
            // TxtOrigDr
            // 
            this.TxtOrigDr.Enabled = false;
            this.TxtOrigDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrigDr.Location = new System.Drawing.Point(6, 55);
            this.TxtOrigDr.Name = "TxtOrigDr";
            this.TxtOrigDr.ReadOnly = true;
            this.TxtOrigDr.Size = new System.Drawing.Size(234, 22);
            this.TxtOrigDr.TabIndex = 3;
            this.TxtOrigDr.Text = "St Vincent 86th St";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboAvaliHosp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(303, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Avaliable Hospital";
            // 
            // CboAvaliHosp
            // 
            this.CboAvaliHosp.AutoCompleteCustomSource.AddRange(new string[] {
            "St Francis Hops BG\n",
            "St Joseph Hospital\n",
            "St Vincent 86th St",
            "\nSt Vincent Carmel"});
            this.CboAvaliHosp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboAvaliHosp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboAvaliHosp.FormattingEnabled = true;
            this.CboAvaliHosp.Items.AddRange(new object[] {
            "Lamin",
            "Laminar Screws",
            "Laminectomy",
            "Laminectomy--Bilateral",
            "Laminectomy--Gill",
            "Laminectomy--Intradural",
            "Laminectomy/Foraminotomy/Facetectomy",
            "Laminoforaminotomy",
            "Laminoplasty"});
            this.CboAvaliHosp.Location = new System.Drawing.Point(6, 55);
            this.CboAvaliHosp.Name = "CboAvaliHosp";
            this.CboAvaliHosp.Size = new System.Drawing.Size(232, 24);
            this.CboAvaliHosp.Sorted = true;
            this.CboAvaliHosp.TabIndex = 2;
            // 
            // MnuDataDefaultHosp
            // 
            this.MnuDataDefaultHosp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuDataDefaultHosp.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuDataDefaultHosp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDataDefaultHospSave,
            this.TSMnuDataDefaultHospBreak1,
            this.TSMnuDataDefaultHospRemoveDefault,
            this.TSMnuDataDefaultHospBreak2,
            this.TSMnuDataDefaultHospClear});
            this.MnuDataDefaultHosp.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuDataDefaultHosp.Location = new System.Drawing.Point(0, 0);
            this.MnuDataDefaultHosp.Name = "MnuDataDefaultHosp";
            this.MnuDataDefaultHosp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuDataDefaultHosp.Size = new System.Drawing.Size(1567, 28);
            this.MnuDataDefaultHosp.TabIndex = 23;
            this.MnuDataDefaultHosp.Text = "menuStrip1";
            // 
            // TSMnuDataDefaultHospSave
            // 
            this.TSMnuDataDefaultHospSave.Name = "TSMnuDataDefaultHospSave";
            this.TSMnuDataDefaultHospSave.Size = new System.Drawing.Size(52, 24);
            this.TSMnuDataDefaultHospSave.Text = "Save";
            // 
            // TSMnuDataDefaultHospBreak1
            // 
            this.TSMnuDataDefaultHospBreak1.Enabled = false;
            this.TSMnuDataDefaultHospBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataDefaultHospBreak1.Name = "TSMnuDataDefaultHospBreak1";
            this.TSMnuDataDefaultHospBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataDefaultHospBreak1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataDefaultHospBreak1.Text = "|";
            // 
            // TSMnuDataDefaultHospRemoveDefault
            // 
            this.TSMnuDataDefaultHospRemoveDefault.Name = "TSMnuDataDefaultHospRemoveDefault";
            this.TSMnuDataDefaultHospRemoveDefault.Size = new System.Drawing.Size(128, 24);
            this.TSMnuDataDefaultHospRemoveDefault.Text = "Remove Default";
            // 
            // TSMnuDataDefaultHospBreak2
            // 
            this.TSMnuDataDefaultHospBreak2.Enabled = false;
            this.TSMnuDataDefaultHospBreak2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataDefaultHospBreak2.Name = "TSMnuDataDefaultHospBreak2";
            this.TSMnuDataDefaultHospBreak2.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataDefaultHospBreak2.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataDefaultHospBreak2.Text = "|";
            // 
            // TSMnuDataDefaultHospClear
            // 
            this.TSMnuDataDefaultHospClear.Name = "TSMnuDataDefaultHospClear";
            this.TSMnuDataDefaultHospClear.Size = new System.Drawing.Size(55, 24);
            this.TSMnuDataDefaultHospClear.Text = "Clear";
            this.TSMnuDataDefaultHospClear.Click += new System.EventHandler(this.TSMnuDataDefaultHospClear_Click);
            // 
            // FrmDataDefaultHosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 803);
            this.ControlBox = false;
            this.Controls.Add(this.MnuDataDefaultHosp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataDefaultHosp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmDataDefaultHosp";
            this.Text = "Data - Default Hospital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.MnuDataDefaultHosp.ResumeLayout(false);
            this.MnuDataDefaultHosp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOrigDr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboAvaliHosp;
        private System.Windows.Forms.MenuStrip MnuDataDefaultHosp;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataDefaultHospSave;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataDefaultHospBreak1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataDefaultHospRemoveDefault;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataDefaultHospBreak2;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataDefaultHospClear;
    }
}