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
            this.CboMetaSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.CboMetaSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(303, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Avaliable Hospital";
            // 
            // CboMetaSearch
            // 
            this.CboMetaSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "St Francis Hops BG\n",
            "St Joseph Hospital\n",
            "St Vincent 86th St",
            "\nSt Vincent Carmel"});
            this.CboMetaSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboMetaSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboMetaSearch.FormattingEnabled = true;
            this.CboMetaSearch.Items.AddRange(new object[] {
            "Lamin",
            "Laminar Screws",
            "Laminectomy",
            "Laminectomy--Bilateral",
            "Laminectomy--Gill",
            "Laminectomy--Intradural",
            "Laminectomy/Foraminotomy/Facetectomy",
            "Laminoforaminotomy",
            "Laminoplasty"});
            this.CboMetaSearch.Location = new System.Drawing.Point(6, 55);
            this.CboMetaSearch.Name = "CboMetaSearch";
            this.CboMetaSearch.Size = new System.Drawing.Size(232, 24);
            this.CboMetaSearch.Sorted = true;
            this.CboMetaSearch.TabIndex = 2;
            // 
            // FrmDataDefaultHosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 746);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOrigDr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboMetaSearch;
    }
}