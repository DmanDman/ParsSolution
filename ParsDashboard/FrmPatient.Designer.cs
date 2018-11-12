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
            this.TSMnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDisplay,
            this.TSMnuClear});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuMenu.Size = new System.Drawing.Size(1067, 28);
            this.MnuMenu.TabIndex = 3;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // TSMnuDisplay
            // 
            this.TSMnuDisplay.Name = "TSMnuDisplay";
            this.TSMnuDisplay.Size = new System.Drawing.Size(70, 24);
            this.TSMnuDisplay.Text = "Display";
            this.TSMnuDisplay.Click += new System.EventHandler(this.TSMnuDash_Click);
            // 
            // TSMnuClear
            // 
            this.TSMnuClear.Name = "TSMnuClear";
            this.TSMnuClear.Size = new System.Drawing.Size(55, 24);
            this.TSMnuClear.Text = "Clear";
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.MnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmPatient";
            this.Text = "Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDisplay;
        private System.Windows.Forms.ToolStripMenuItem TSMnuClear;
    }
}