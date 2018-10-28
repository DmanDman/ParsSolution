namespace ParsDashboard
{
    partial class FrmDashboard
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
            this.TSMnuGotoPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuOpenCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuAddToCanvas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.Label1Dash = new System.Windows.Forms.Label();
            this.PnlPatient = new System.Windows.Forms.Panel();
            this.LlbPatientSearch = new System.Windows.Forms.Label();
            this.LblPatientAdd = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlData = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PnlSurgery = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PnlImages = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PnlRpt = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MnuMenu.SuspendLayout();
            this.PnlDashboard.SuspendLayout();
            this.PnlPatient.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlData.SuspendLayout();
            this.PnlSurgery.SuspendLayout();
            this.PnlImages.SuspendLayout();
            this.PnlRpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuGotoPatient,
            this.TSMnuOpenCanvas,
            this.TSMnuAddToCanvas,
            this.TSMnuHelp});
            this.MnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Size = new System.Drawing.Size(800, 25);
            this.MnuMenu.TabIndex = 1;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // TSMnuGotoPatient
            // 
            this.TSMnuGotoPatient.Name = "TSMnuGotoPatient";
            this.TSMnuGotoPatient.Size = new System.Drawing.Size(92, 21);
            this.TSMnuGotoPatient.Text = "Goto Patient";
            this.TSMnuGotoPatient.Click += new System.EventHandler(this.TSMnuGotoPatient_Click);
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
            // PnlDashboard
            // 
            this.PnlDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnlDashboard.Controls.Add(this.Label1Dash);
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashboard.Location = new System.Drawing.Point(2, 2);
            this.PnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDashboard.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(150, 28);
            this.PnlDashboard.TabIndex = 1;
            this.PnlDashboard.Click += new System.EventHandler(this.PnlDashboard_Click);
            // 
            // Label1Dash
            // 
            this.Label1Dash.AutoEllipsis = true;
            this.Label1Dash.BackColor = System.Drawing.Color.Silver;
            this.Label1Dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1Dash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label1Dash.Location = new System.Drawing.Point(0, 0);
            this.Label1Dash.Name = "Label1Dash";
            this.Label1Dash.Size = new System.Drawing.Size(150, 26);
            this.Label1Dash.TabIndex = 0;
            this.Label1Dash.Text = "Dashboard";
            this.Label1Dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1Dash.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PnlPatient
            // 
            this.PnlPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlPatient.Controls.Add(this.LlbPatientSearch);
            this.PnlPatient.Controls.Add(this.LblPatientAdd);
            this.PnlPatient.Controls.Add(this.Label2);
            this.PnlPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlPatient.Location = new System.Drawing.Point(2, 117);
            this.PnlPatient.Margin = new System.Windows.Forms.Padding(0);
            this.PnlPatient.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlPatient.Name = "PnlPatient";
            this.PnlPatient.Size = new System.Drawing.Size(150, 88);
            this.PnlPatient.TabIndex = 2;
            this.PnlPatient.Click += new System.EventHandler(this.PnlPatient_Click);
            // 
            // LlbPatientSearch
            // 
            this.LlbPatientSearch.AutoSize = true;
            this.LlbPatientSearch.Location = new System.Drawing.Point(10, 63);
            this.LlbPatientSearch.Name = "LlbPatientSearch";
            this.LlbPatientSearch.Size = new System.Drawing.Size(46, 15);
            this.LlbPatientSearch.TabIndex = 3;
            this.LlbPatientSearch.Text = "Search";
            // 
            // LblPatientAdd
            // 
            this.LblPatientAdd.AutoSize = true;
            this.LblPatientAdd.Location = new System.Drawing.Point(10, 37);
            this.LblPatientAdd.Name = "LblPatientAdd";
            this.LblPatientAdd.Size = new System.Drawing.Size(28, 15);
            this.LblPatientAdd.TabIndex = 2;
            this.LblPatientAdd.Text = "Add";
            // 
            // Label2
            // 
            this.Label2.AutoEllipsis = true;
            this.Label2.BackColor = System.Drawing.Color.Silver;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 26);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Patient";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PnlData, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PnlSurgery, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PnlDashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlPatient, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PnlImages, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlRpt, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 406);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlData.Controls.Add(this.label11);
            this.PnlData.Controls.Add(this.label12);
            this.PnlData.Controls.Add(this.label13);
            this.PnlData.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlData.Location = new System.Drawing.Point(2, 389);
            this.PnlData.Margin = new System.Windows.Forms.Padding(0);
            this.PnlData.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(150, 15);
            this.PnlData.TabIndex = 7;
            this.PnlData.Click += new System.EventHandler(this.PnlData_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Add";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Data";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlSurgery
            // 
            this.PnlSurgery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlSurgery.Controls.Add(this.label8);
            this.PnlSurgery.Controls.Add(this.label9);
            this.PnlSurgery.Controls.Add(this.label10);
            this.PnlSurgery.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSurgery.Location = new System.Drawing.Point(2, 207);
            this.PnlSurgery.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSurgery.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlSurgery.Name = "PnlSurgery";
            this.PnlSurgery.Size = new System.Drawing.Size(150, 88);
            this.PnlSurgery.TabIndex = 6;
            this.PnlSurgery.Click += new System.EventHandler(this.PnlSurgery_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Add";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Surgery";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlImages
            // 
            this.PnlImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlImages.Controls.Add(this.label1);
            this.PnlImages.Controls.Add(this.label4);
            this.PnlImages.Controls.Add(this.label5);
            this.PnlImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlImages.Location = new System.Drawing.Point(2, 32);
            this.PnlImages.Margin = new System.Windows.Forms.Padding(0);
            this.PnlImages.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlImages.Name = "PnlImages";
            this.PnlImages.Size = new System.Drawing.Size(150, 83);
            this.PnlImages.TabIndex = 4;
            this.PnlImages.Click += new System.EventHandler(this.PnlImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Images";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlRpt
            // 
            this.PnlRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlRpt.Controls.Add(this.label3);
            this.PnlRpt.Controls.Add(this.label6);
            this.PnlRpt.Controls.Add(this.label7);
            this.PnlRpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlRpt.Location = new System.Drawing.Point(2, 297);
            this.PnlRpt.Margin = new System.Windows.Forms.Padding(0);
            this.PnlRpt.MinimumSize = new System.Drawing.Size(150, 0);
            this.PnlRpt.Name = "PnlRpt";
            this.PnlRpt.Size = new System.Drawing.Size(150, 88);
            this.PnlRpt.TabIndex = 5;
            this.PnlRpt.Click += new System.EventHandler(this.PnlRpt_Click);
            this.PnlRpt.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRpt_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Add";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reports";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MnuMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuMenu;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.PnlDashboard.ResumeLayout(false);
            this.PnlPatient.ResumeLayout(false);
            this.PnlPatient.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.PnlSurgery.ResumeLayout(false);
            this.PnlSurgery.PerformLayout();
            this.PnlImages.ResumeLayout(false);
            this.PnlImages.PerformLayout();
            this.PnlRpt.ResumeLayout(false);
            this.PnlRpt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMnuGotoPatient;
        private System.Windows.Forms.ToolStripMenuItem TSMnuOpenCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuAddToCanvas;
        private System.Windows.Forms.ToolStripMenuItem TSMnuHelp;
        internal System.Windows.Forms.Panel PnlDashboard;
        internal System.Windows.Forms.Label Label1Dash;
        internal System.Windows.Forms.Panel PnlPatient;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LlbPatientSearch;
        private System.Windows.Forms.Label LblPatientAdd;
        internal System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Panel PnlSurgery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Panel PnlImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Panel PnlRpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
    }
}

