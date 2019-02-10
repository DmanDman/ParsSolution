namespace ParsDashboard
{
    partial class FrmRptDynamic
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
            this.MnuRptDynamic = new System.Windows.Forms.MenuStrip();
            this.TSMnuRptDynamicRun = new System.Windows.Forms.ToolStripMenuItem();
            this.LblComingSoon = new System.Windows.Forms.Label();
            this.MnuRptDynamic.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuRptDynamic
            // 
            this.MnuRptDynamic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuRptDynamic.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuRptDynamic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuRptDynamicRun});
            this.MnuRptDynamic.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuRptDynamic.Location = new System.Drawing.Point(0, 0);
            this.MnuRptDynamic.Name = "MnuRptDynamic";
            this.MnuRptDynamic.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuRptDynamic.Size = new System.Drawing.Size(1531, 28);
            this.MnuRptDynamic.TabIndex = 27;
            this.MnuRptDynamic.Text = "menuStrip1";
            // 
            // TSMnuRptDynamicRun
            // 
            this.TSMnuRptDynamicRun.Name = "TSMnuRptDynamicRun";
            this.TSMnuRptDynamicRun.Size = new System.Drawing.Size(46, 24);
            this.TSMnuRptDynamicRun.Text = "Run";
            // 
            // LblComingSoon
            // 
            this.LblComingSoon.AutoSize = true;
            this.LblComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComingSoon.Location = new System.Drawing.Point(12, 46);
            this.LblComingSoon.Name = "LblComingSoon";
            this.LblComingSoon.Size = new System.Drawing.Size(231, 17);
            this.LblComingSoon.TabIndex = 28;
            this.LblComingSoon.Text = "Dynamic Reports Coming Soon";
            // 
            // FrmRptDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 605);
            this.ControlBox = false;
            this.Controls.Add(this.LblComingSoon);
            this.Controls.Add(this.MnuRptDynamic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRptDynamic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmRptDynamic";
            this.Text = "Report - Dynamic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuRptDynamic.ResumeLayout(false);
            this.MnuRptDynamic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuRptDynamic;
        private System.Windows.Forms.ToolStripMenuItem TSMnuRptDynamicRun;
        private System.Windows.Forms.Label LblComingSoon;
    }
}