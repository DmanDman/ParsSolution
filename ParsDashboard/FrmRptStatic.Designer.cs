namespace ParsDashboard
{
    partial class FrmRptStatic
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
            this.MnuRptStatic = new System.Windows.Forms.MenuStrip();
            this.TSMnuRptStaticRun = new System.Windows.Forms.ToolStripMenuItem();
            this.LblComingSoon = new System.Windows.Forms.Label();
            this.MnuRptStatic.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuRptStatic
            // 
            this.MnuRptStatic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuRptStatic.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuRptStatic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuRptStaticRun});
            this.MnuRptStatic.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuRptStatic.Location = new System.Drawing.Point(0, 0);
            this.MnuRptStatic.Name = "MnuRptStatic";
            this.MnuRptStatic.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuRptStatic.Size = new System.Drawing.Size(1549, 28);
            this.MnuRptStatic.TabIndex = 26;
            this.MnuRptStatic.Text = "menuStrip1";
            // 
            // TSMnuRptStaticRun
            // 
            this.TSMnuRptStaticRun.Name = "TSMnuRptStaticRun";
            this.TSMnuRptStaticRun.Size = new System.Drawing.Size(46, 24);
            this.TSMnuRptStaticRun.Text = "Run";
            // 
            // LblComingSoon
            // 
            this.LblComingSoon.AutoSize = true;
            this.LblComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComingSoon.Location = new System.Drawing.Point(12, 46);
            this.LblComingSoon.Name = "LblComingSoon";
            this.LblComingSoon.Size = new System.Drawing.Size(211, 17);
            this.LblComingSoon.TabIndex = 27;
            this.LblComingSoon.Text = "Static Reports Coming Soon";
            // 
            // FrmRptStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 652);
            this.ControlBox = false;
            this.Controls.Add(this.LblComingSoon);
            this.Controls.Add(this.MnuRptStatic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRptStatic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmRptStatic";
            this.Text = "Report - Static";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuRptStatic.ResumeLayout(false);
            this.MnuRptStatic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuRptStatic;
        private System.Windows.Forms.ToolStripMenuItem TSMnuRptStaticRun;
        private System.Windows.Forms.Label LblComingSoon;
    }
}