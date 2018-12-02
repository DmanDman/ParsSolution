namespace ParsDashboard
{
    partial class FrmFilterAge
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
            this.RdoFilterLessThan = new System.Windows.Forms.RadioButton();
            this.RdoFilterGreaterThan = new System.Windows.Forms.RadioButton();
            this.RdoFilterEqualTo = new System.Windows.Forms.RadioButton();
            this.RdoFilterBetween = new System.Windows.Forms.RadioButton();
            this.NumLess = new System.Windows.Forms.NumericUpDown();
            this.LblAnd = new System.Windows.Forms.Label();
            this.NumGreater = new System.Windows.Forms.NumericUpDown();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumLess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreater)).BeginInit();
            this.SuspendLayout();
            // 
            // RdoFilterLessThan
            // 
            this.RdoFilterLessThan.AutoSize = true;
            this.RdoFilterLessThan.Location = new System.Drawing.Point(12, 12);
            this.RdoFilterLessThan.Name = "RdoFilterLessThan";
            this.RdoFilterLessThan.Size = new System.Drawing.Size(96, 21);
            this.RdoFilterLessThan.TabIndex = 0;
            this.RdoFilterLessThan.TabStop = true;
            this.RdoFilterLessThan.Text = "Less Than";
            this.RdoFilterLessThan.UseVisualStyleBackColor = true;
            this.RdoFilterLessThan.CheckedChanged += new System.EventHandler(this.RdoFilterLessThan_CheckedChanged);
            // 
            // RdoFilterGreaterThan
            // 
            this.RdoFilterGreaterThan.AutoSize = true;
            this.RdoFilterGreaterThan.Location = new System.Drawing.Point(12, 50);
            this.RdoFilterGreaterThan.Name = "RdoFilterGreaterThan";
            this.RdoFilterGreaterThan.Size = new System.Drawing.Size(115, 21);
            this.RdoFilterGreaterThan.TabIndex = 1;
            this.RdoFilterGreaterThan.TabStop = true;
            this.RdoFilterGreaterThan.Text = "Greater Than";
            this.RdoFilterGreaterThan.UseVisualStyleBackColor = true;
            this.RdoFilterGreaterThan.CheckedChanged += new System.EventHandler(this.RdoFilterGreaterThan_CheckedChanged);
            // 
            // RdoFilterEqualTo
            // 
            this.RdoFilterEqualTo.AutoSize = true;
            this.RdoFilterEqualTo.Location = new System.Drawing.Point(12, 88);
            this.RdoFilterEqualTo.Name = "RdoFilterEqualTo";
            this.RdoFilterEqualTo.Size = new System.Drawing.Size(86, 21);
            this.RdoFilterEqualTo.TabIndex = 2;
            this.RdoFilterEqualTo.TabStop = true;
            this.RdoFilterEqualTo.Text = "Equal To";
            this.RdoFilterEqualTo.UseVisualStyleBackColor = true;
            this.RdoFilterEqualTo.CheckedChanged += new System.EventHandler(this.RdoFilterEqualTo_CheckedChanged);
            // 
            // RdoFilterBetween
            // 
            this.RdoFilterBetween.AutoSize = true;
            this.RdoFilterBetween.Location = new System.Drawing.Point(12, 126);
            this.RdoFilterBetween.Name = "RdoFilterBetween";
            this.RdoFilterBetween.Size = new System.Drawing.Size(83, 21);
            this.RdoFilterBetween.TabIndex = 3;
            this.RdoFilterBetween.TabStop = true;
            this.RdoFilterBetween.Text = "Between";
            this.RdoFilterBetween.UseVisualStyleBackColor = true;
            this.RdoFilterBetween.CheckedChanged += new System.EventHandler(this.RdoFilterBetween_CheckedChanged);
            // 
            // NumLess
            // 
            this.NumLess.Location = new System.Drawing.Point(144, 11);
            this.NumLess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLess.Name = "NumLess";
            this.NumLess.Size = new System.Drawing.Size(51, 22);
            this.NumLess.TabIndex = 4;
            this.NumLess.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumLess.Visible = false;
            // 
            // LblAnd
            // 
            this.LblAnd.AutoSize = true;
            this.LblAnd.Location = new System.Drawing.Point(218, 14);
            this.LblAnd.Name = "LblAnd";
            this.LblAnd.Size = new System.Drawing.Size(32, 17);
            this.LblAnd.TabIndex = 5;
            this.LblAnd.Text = "and";
            this.LblAnd.Visible = false;
            // 
            // NumGreater
            // 
            this.NumGreater.Location = new System.Drawing.Point(273, 11);
            this.NumGreater.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumGreater.Name = "NumGreater";
            this.NumGreater.Size = new System.Drawing.Size(51, 22);
            this.NumGreater.TabIndex = 6;
            this.NumGreater.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NumGreater.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(144, 116);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 41);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(242, 116);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(82, 41);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmFilterAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 172);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.NumGreater);
            this.Controls.Add(this.LblAnd);
            this.Controls.Add(this.NumLess);
            this.Controls.Add(this.RdoFilterBetween);
            this.Controls.Add(this.RdoFilterEqualTo);
            this.Controls.Add(this.RdoFilterGreaterThan);
            this.Controls.Add(this.RdoFilterLessThan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilterAge";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Filter";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NumLess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumGreater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdoFilterLessThan;
        private System.Windows.Forms.RadioButton RdoFilterGreaterThan;
        private System.Windows.Forms.RadioButton RdoFilterEqualTo;
        private System.Windows.Forms.RadioButton RdoFilterBetween;
        private System.Windows.Forms.NumericUpDown NumLess;
        private System.Windows.Forms.Label LblAnd;
        private System.Windows.Forms.NumericUpDown NumGreater;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}