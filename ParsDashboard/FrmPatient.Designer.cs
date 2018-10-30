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
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.TSMnuDash = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuOpenCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddToCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDash,
            this.TSMnuOpenCanvas,
            this.TSMnuAddToCanvas,
            this.TSMnuHelp});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Size = new System.Drawing.Size(800, 25);
            this.MnuMenu.TabIndex = 3;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // TSMnuDash
            // 
            this.TSMnuDash.Name = "TSMnuDash";
            this.TSMnuDash.Size = new System.Drawing.Size(82, 21);
            this.TSMnuDash.Text = "Goto Dash";
            this.TSMnuDash.Click += new System.EventHandler(this.TSMnuDash_Click);
            // 
            // TSMnuOpenCanvas
            // 
            this.TSMnuOpenCanvas.Name = "TSMnuOpenCanvas";
            this.TSMnuOpenCanvas.Size = new System.Drawing.Size(97, 21);
            this.TSMnuOpenCanvas.Text = "Open Canvas";
            // 
            // TSMnuAddToCanvas
            // 
            this.TSMnuAddToCanvas.Name = "TSMnuAddToCanvas";
            this.TSMnuAddToCanvas.Size = new System.Drawing.Size(105, 21);
            this.TSMnuAddToCanvas.Text = "Add to Canvas";
            // 
            // TSMnuHelp
            // 
            this.TSMnuHelp.Name = "TSMnuHelp";
            this.TSMnuHelp.Size = new System.Drawing.Size(47, 21);
            this.TSMnuHelp.Text = "Help";
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MnuMenu);
            this.Name = "FrmPatient";
            this.Tag = "FrmPatient";
            this.Text = "Patient";
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDash;
        private System.Windows.Forms.ToolStripMenuItem TSMnuOpenCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddToCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuHelp;
    }
}