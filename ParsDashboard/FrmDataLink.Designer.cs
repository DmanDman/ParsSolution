namespace ParsDashboard
{
    partial class FrmDataLink
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
            this.CboLinkFromType = new System.Windows.Forms.ComboBox();
            this.LblLinkFromType = new System.Windows.Forms.Label();
            this.LblLinkFromDetail = new System.Windows.Forms.Label();
            this.CboLinkFromDetail = new System.Windows.Forms.ComboBox();
            this.GrpLinkFrom = new System.Windows.Forms.GroupBox();
            this.GrpLinkTo = new System.Windows.Forms.GroupBox();
            this.CboLinkToDetail = new System.Windows.Forms.ComboBox();
            this.LblLinkToDetail = new System.Windows.Forms.Label();
            this.LblLinkToType = new System.Windows.Forms.Label();
            this.CboLinkToType = new System.Windows.Forms.ComboBox();
            this.GrpCurrentlyLinked = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MnuDataLink = new System.Windows.Forms.MenuStrip();
            this.TSMnuDataLinkAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkBreak1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkRemoveLink = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkBreak2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkClearFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkBreak3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkClearTo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkBreak4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMnuDataLinkClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpLinkFrom.SuspendLayout();
            this.GrpLinkTo.SuspendLayout();
            this.GrpCurrentlyLinked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MnuDataLink.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboLinkFromType
            // 
            this.CboLinkFromType.AutoCompleteCustomSource.AddRange(new string[] {
            "Complication\n",
            "CPT",
            "\nDoctor",
            "\nDx\n",
            "Hospital\n",
            "Instrumentation",
            "\nLevel",
            "\nLocation\n",
            "Surgery"});
            this.CboLinkFromType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboLinkFromType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboLinkFromType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLinkFromType.FormattingEnabled = true;
            this.CboLinkFromType.Items.AddRange(new object[] {
            "Complication\n",
            "CPT",
            "\nDoctor\n",
            "Dx\n",
            "Hospital\n",
            "Instrumentation\n",
            "Level\n",
            "Location\n",
            "Surgery"});
            this.CboLinkFromType.Location = new System.Drawing.Point(6, 55);
            this.CboLinkFromType.Name = "CboLinkFromType";
            this.CboLinkFromType.Size = new System.Drawing.Size(254, 24);
            this.CboLinkFromType.TabIndex = 2;
            // 
            // LblLinkFromType
            // 
            this.LblLinkFromType.AutoSize = true;
            this.LblLinkFromType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinkFromType.Location = new System.Drawing.Point(6, 35);
            this.LblLinkFromType.Name = "LblLinkFromType";
            this.LblLinkFromType.Size = new System.Drawing.Size(40, 17);
            this.LblLinkFromType.TabIndex = 0;
            this.LblLinkFromType.Text = "Type";
            // 
            // LblLinkFromDetail
            // 
            this.LblLinkFromDetail.AutoSize = true;
            this.LblLinkFromDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinkFromDetail.Location = new System.Drawing.Point(6, 112);
            this.LblLinkFromDetail.Name = "LblLinkFromDetail";
            this.LblLinkFromDetail.Size = new System.Drawing.Size(44, 17);
            this.LblLinkFromDetail.TabIndex = 3;
            this.LblLinkFromDetail.Text = "Detail";
            // 
            // CboLinkFromDetail
            // 
            this.CboLinkFromDetail.AutoCompleteCustomSource.AddRange(new string[] {
            "Scoliosis\n",
            "Scoliosis--Adolescent Idiopathic\n",
            "Scoliosis--Adult Idiopathic\n",
            "Scoliosis--Congenital"});
            this.CboLinkFromDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboLinkFromDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboLinkFromDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLinkFromDetail.FormattingEnabled = true;
            this.CboLinkFromDetail.Items.AddRange(new object[] {
            "Scoliosis--Adolescent Idiopathic\n",
            "Scoliosis--Adult Idiopathic\n",
            "Scoliosis--Congenital",
            "Scoliosis\n"});
            this.CboLinkFromDetail.Location = new System.Drawing.Point(6, 132);
            this.CboLinkFromDetail.Name = "CboLinkFromDetail";
            this.CboLinkFromDetail.Size = new System.Drawing.Size(254, 24);
            this.CboLinkFromDetail.Sorted = true;
            this.CboLinkFromDetail.TabIndex = 1;
            this.CboLinkFromDetail.Text = "Scoliosis--Adolescent Idiopathic\n";
            // 
            // GrpLinkFrom
            // 
            this.GrpLinkFrom.Controls.Add(this.CboLinkFromDetail);
            this.GrpLinkFrom.Controls.Add(this.LblLinkFromDetail);
            this.GrpLinkFrom.Controls.Add(this.LblLinkFromType);
            this.GrpLinkFrom.Controls.Add(this.CboLinkFromType);
            this.GrpLinkFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLinkFrom.Location = new System.Drawing.Point(12, 46);
            this.GrpLinkFrom.Name = "GrpLinkFrom";
            this.GrpLinkFrom.Size = new System.Drawing.Size(276, 185);
            this.GrpLinkFrom.TabIndex = 0;
            this.GrpLinkFrom.TabStop = false;
            this.GrpLinkFrom.Text = "Link From";
            // 
            // GrpLinkTo
            // 
            this.GrpLinkTo.Controls.Add(this.CboLinkToDetail);
            this.GrpLinkTo.Controls.Add(this.LblLinkToDetail);
            this.GrpLinkTo.Controls.Add(this.LblLinkToType);
            this.GrpLinkTo.Controls.Add(this.CboLinkToType);
            this.GrpLinkTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLinkTo.Location = new System.Drawing.Point(330, 46);
            this.GrpLinkTo.Name = "GrpLinkTo";
            this.GrpLinkTo.Size = new System.Drawing.Size(276, 185);
            this.GrpLinkTo.TabIndex = 1;
            this.GrpLinkTo.TabStop = false;
            this.GrpLinkTo.Text = "Link To";
            // 
            // CboLinkToDetail
            // 
            this.CboLinkToDetail.AutoCompleteCustomSource.AddRange(new string[] {
            "Sasso"});
            this.CboLinkToDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboLinkToDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboLinkToDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLinkToDetail.FormattingEnabled = true;
            this.CboLinkToDetail.Items.AddRange(new object[] {
            "Sasso"});
            this.CboLinkToDetail.Location = new System.Drawing.Point(6, 132);
            this.CboLinkToDetail.Name = "CboLinkToDetail";
            this.CboLinkToDetail.Size = new System.Drawing.Size(254, 24);
            this.CboLinkToDetail.Sorted = true;
            this.CboLinkToDetail.TabIndex = 1;
            // 
            // LblLinkToDetail
            // 
            this.LblLinkToDetail.AutoSize = true;
            this.LblLinkToDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinkToDetail.Location = new System.Drawing.Point(6, 112);
            this.LblLinkToDetail.Name = "LblLinkToDetail";
            this.LblLinkToDetail.Size = new System.Drawing.Size(44, 17);
            this.LblLinkToDetail.TabIndex = 3;
            this.LblLinkToDetail.Text = "Detail";
            // 
            // LblLinkToType
            // 
            this.LblLinkToType.AutoSize = true;
            this.LblLinkToType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinkToType.Location = new System.Drawing.Point(6, 35);
            this.LblLinkToType.Name = "LblLinkToType";
            this.LblLinkToType.Size = new System.Drawing.Size(40, 17);
            this.LblLinkToType.TabIndex = 0;
            this.LblLinkToType.Text = "Type";
            // 
            // CboLinkToType
            // 
            this.CboLinkToType.AutoCompleteCustomSource.AddRange(new string[] {
            "Doctor"});
            this.CboLinkToType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboLinkToType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboLinkToType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLinkToType.FormattingEnabled = true;
            this.CboLinkToType.Items.AddRange(new object[] {
            "Doctor"});
            this.CboLinkToType.Location = new System.Drawing.Point(6, 55);
            this.CboLinkToType.Name = "CboLinkToType";
            this.CboLinkToType.Size = new System.Drawing.Size(254, 24);
            this.CboLinkToType.TabIndex = 2;
            // 
            // GrpCurrentlyLinked
            // 
            this.GrpCurrentlyLinked.Controls.Add(this.label5);
            this.GrpCurrentlyLinked.Controls.Add(this.label4);
            this.GrpCurrentlyLinked.Controls.Add(this.dataGridView1);
            this.GrpCurrentlyLinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCurrentlyLinked.Location = new System.Drawing.Point(12, 256);
            this.GrpCurrentlyLinked.Name = "GrpCurrentlyLinked";
            this.GrpCurrentlyLinked.Size = new System.Drawing.Size(910, 417);
            this.GrpCurrentlyLinked.TabIndex = 0;
            this.GrpCurrentlyLinked.TabStop = false;
            this.GrpCurrentlyLinked.Text = "Currently Linked Items";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Link To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Link From";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Last,
            this.First,
            this.Blank,
            this.PatientNum,
            this.DOB});
            this.dataGridView1.Location = new System.Drawing.Point(9, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // Last
            // 
            this.Last.HeaderText = "Type";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Width = 175;
            // 
            // First
            // 
            this.First.DividerWidth = 5;
            this.First.HeaderText = "Detail";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            this.First.Width = 175;
            // 
            // Blank
            // 
            this.Blank.DividerWidth = 5;
            this.Blank.HeaderText = "";
            this.Blank.MaxInputLength = 1;
            this.Blank.MinimumWidth = 2;
            this.Blank.Name = "Blank";
            this.Blank.ReadOnly = true;
            this.Blank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Blank.Width = 2;
            // 
            // PatientNum
            // 
            this.PatientNum.HeaderText = "Type";
            this.PatientNum.Name = "PatientNum";
            this.PatientNum.ReadOnly = true;
            this.PatientNum.Width = 175;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Detail";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 175;
            // 
            // MnuDataLink
            // 
            this.MnuDataLink.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuDataLink.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.MnuDataLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuDataLinkAddLink,
            this.TSMnuDataLinkBreak1,
            this.TSMnuDataLinkRemoveLink,
            this.TSMnuDataLinkBreak2,
            this.TSMnuDataLinkClearFrom,
            this.TSMnuDataLinkBreak3,
            this.TSMnuDataLinkClearTo,
            this.TSMnuDataLinkBreak4,
            this.TSMnuDataLinkClearAll});
            this.MnuDataLink.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MnuDataLink.Location = new System.Drawing.Point(0, 0);
            this.MnuDataLink.Name = "MnuDataLink";
            this.MnuDataLink.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MnuDataLink.Size = new System.Drawing.Size(1567, 28);
            this.MnuDataLink.TabIndex = 25;
            this.MnuDataLink.Text = "menuStrip1";
            // 
            // TSMnuDataLinkAddLink
            // 
            this.TSMnuDataLinkAddLink.Name = "TSMnuDataLinkAddLink";
            this.TSMnuDataLinkAddLink.Size = new System.Drawing.Size(79, 24);
            this.TSMnuDataLinkAddLink.Text = "Add Link";
            // 
            // TSMnuDataLinkBreak1
            // 
            this.TSMnuDataLinkBreak1.Enabled = false;
            this.TSMnuDataLinkBreak1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataLinkBreak1.Name = "TSMnuDataLinkBreak1";
            this.TSMnuDataLinkBreak1.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataLinkBreak1.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataLinkBreak1.Text = "|";
            // 
            // TSMnuDataLinkRemoveLink
            // 
            this.TSMnuDataLinkRemoveLink.Name = "TSMnuDataLinkRemoveLink";
            this.TSMnuDataLinkRemoveLink.Size = new System.Drawing.Size(105, 24);
            this.TSMnuDataLinkRemoveLink.Text = "Remove Link";
            // 
            // TSMnuDataLinkBreak2
            // 
            this.TSMnuDataLinkBreak2.Enabled = false;
            this.TSMnuDataLinkBreak2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataLinkBreak2.Name = "TSMnuDataLinkBreak2";
            this.TSMnuDataLinkBreak2.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataLinkBreak2.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataLinkBreak2.Text = "|";
            // 
            // TSMnuDataLinkClearFrom
            // 
            this.TSMnuDataLinkClearFrom.Name = "TSMnuDataLinkClearFrom";
            this.TSMnuDataLinkClearFrom.Size = new System.Drawing.Size(93, 24);
            this.TSMnuDataLinkClearFrom.Text = "Clear From";
            this.TSMnuDataLinkClearFrom.Click += new System.EventHandler(this.TSMnuDataLinkClearFrom_Click);
            // 
            // TSMnuDataLinkBreak3
            // 
            this.TSMnuDataLinkBreak3.Enabled = false;
            this.TSMnuDataLinkBreak3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataLinkBreak3.Name = "TSMnuDataLinkBreak3";
            this.TSMnuDataLinkBreak3.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataLinkBreak3.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataLinkBreak3.Text = "|";
            // 
            // TSMnuDataLinkClearTo
            // 
            this.TSMnuDataLinkClearTo.Name = "TSMnuDataLinkClearTo";
            this.TSMnuDataLinkClearTo.Size = new System.Drawing.Size(75, 24);
            this.TSMnuDataLinkClearTo.Text = "Clear To";
            this.TSMnuDataLinkClearTo.Click += new System.EventHandler(this.TSMnuDataLinkClearTo_Click);
            // 
            // TSMnuDataLinkBreak4
            // 
            this.TSMnuDataLinkBreak4.Enabled = false;
            this.TSMnuDataLinkBreak4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMnuDataLinkBreak4.Name = "TSMnuDataLinkBreak4";
            this.TSMnuDataLinkBreak4.Padding = new System.Windows.Forms.Padding(0);
            this.TSMnuDataLinkBreak4.Size = new System.Drawing.Size(18, 24);
            this.TSMnuDataLinkBreak4.Text = "|";
            // 
            // TSMnuDataLinkClearAll
            // 
            this.TSMnuDataLinkClearAll.Name = "TSMnuDataLinkClearAll";
            this.TSMnuDataLinkClearAll.Size = new System.Drawing.Size(77, 24);
            this.TSMnuDataLinkClearAll.Text = "Clear All";
            this.TSMnuDataLinkClearAll.Click += new System.EventHandler(this.TSMnuDataLinkClearAll_Click);
            // 
            // FrmDataLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 803);
            this.ControlBox = false;
            this.Controls.Add(this.MnuDataLink);
            this.Controls.Add(this.GrpCurrentlyLinked);
            this.Controls.Add(this.GrpLinkTo);
            this.Controls.Add(this.GrpLinkFrom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataLink";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmDataLink";
            this.Text = "Data - Link";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrpLinkFrom.ResumeLayout(false);
            this.GrpLinkFrom.PerformLayout();
            this.GrpLinkTo.ResumeLayout(false);
            this.GrpLinkTo.PerformLayout();
            this.GrpCurrentlyLinked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MnuDataLink.ResumeLayout(false);
            this.MnuDataLink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboLinkFromType;
        private System.Windows.Forms.Label LblLinkFromType;
        private System.Windows.Forms.Label LblLinkFromDetail;
        private System.Windows.Forms.ComboBox CboLinkFromDetail;
        private System.Windows.Forms.GroupBox GrpLinkFrom;
        private System.Windows.Forms.GroupBox GrpLinkTo;
        private System.Windows.Forms.ComboBox CboLinkToDetail;
        private System.Windows.Forms.Label LblLinkToDetail;
        private System.Windows.Forms.Label LblLinkToType;
        private System.Windows.Forms.ComboBox CboLinkToType;
        private System.Windows.Forms.GroupBox GrpCurrentlyLinked;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blank;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.MenuStrip MnuDataLink;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkAddLink;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkBreak1;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkRemoveLink;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkBreak2;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkClearFrom;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkBreak3;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkClearTo;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkBreak4;
        private System.Windows.Forms.ToolStripMenuItem TSMnuDataLinkClearAll;
    }
}