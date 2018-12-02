namespace ParsDashboard
{
    partial class FrmFilterDate
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RdoFilterBetween = new System.Windows.Forms.RadioButton();
            this.RdoFilterEqualTo = new System.Windows.Forms.RadioButton();
            this.RdoFilterGreaterThan = new System.Windows.Forms.RadioButton();
            this.RdoFilterLessThan = new System.Windows.Forms.RadioButton();
            this.DtStart = new System.Windows.Forms.DateTimePicker();
            this.LblAnd = new System.Windows.Forms.Label();
            this.DtEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(246, 120);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(82, 41);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(135, 120);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 41);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RdoFilterBetween
            // 
            this.RdoFilterBetween.AutoSize = true;
            this.RdoFilterBetween.Location = new System.Drawing.Point(21, 130);
            this.RdoFilterBetween.Name = "RdoFilterBetween";
            this.RdoFilterBetween.Size = new System.Drawing.Size(83, 21);
            this.RdoFilterBetween.TabIndex = 3;
            this.RdoFilterBetween.TabStop = true;
            this.RdoFilterBetween.Text = "Between";
            this.RdoFilterBetween.UseVisualStyleBackColor = true;
            this.RdoFilterBetween.CheckedChanged += new System.EventHandler(this.RdoFilterBetween_CheckedChanged);
            // 
            // RdoFilterEqualTo
            // 
            this.RdoFilterEqualTo.AutoSize = true;
            this.RdoFilterEqualTo.Location = new System.Drawing.Point(21, 16);
            this.RdoFilterEqualTo.Name = "RdoFilterEqualTo";
            this.RdoFilterEqualTo.Size = new System.Drawing.Size(86, 21);
            this.RdoFilterEqualTo.TabIndex = 0;
            this.RdoFilterEqualTo.TabStop = true;
            this.RdoFilterEqualTo.Text = "Equal To";
            this.RdoFilterEqualTo.UseVisualStyleBackColor = true;
            this.RdoFilterEqualTo.CheckedChanged += new System.EventHandler(this.RdoFilterEqualTo_CheckedChanged);
            // 
            // RdoFilterGreaterThan
            // 
            this.RdoFilterGreaterThan.AutoSize = true;
            this.RdoFilterGreaterThan.Location = new System.Drawing.Point(21, 54);
            this.RdoFilterGreaterThan.Name = "RdoFilterGreaterThan";
            this.RdoFilterGreaterThan.Size = new System.Drawing.Size(115, 21);
            this.RdoFilterGreaterThan.TabIndex = 1;
            this.RdoFilterGreaterThan.TabStop = true;
            this.RdoFilterGreaterThan.Text = "Greater Than";
            this.RdoFilterGreaterThan.UseVisualStyleBackColor = true;
            this.RdoFilterGreaterThan.CheckedChanged += new System.EventHandler(this.RdoFilterGreaterThan_CheckedChanged);
            // 
            // RdoFilterLessThan
            // 
            this.RdoFilterLessThan.AutoSize = true;
            this.RdoFilterLessThan.Location = new System.Drawing.Point(21, 92);
            this.RdoFilterLessThan.Name = "RdoFilterLessThan";
            this.RdoFilterLessThan.Size = new System.Drawing.Size(96, 21);
            this.RdoFilterLessThan.TabIndex = 2;
            this.RdoFilterLessThan.TabStop = true;
            this.RdoFilterLessThan.Text = "Less Than";
            this.RdoFilterLessThan.UseVisualStyleBackColor = true;
            this.RdoFilterLessThan.CheckedChanged += new System.EventHandler(this.RdoFilterLessThan_CheckedChanged);
            // 
            // DtStart
            // 
            this.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtStart.Location = new System.Drawing.Point(176, 16);
            this.DtStart.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(112, 22);
            this.DtStart.TabIndex = 4;
            // 
            // LblAnd
            // 
            this.LblAnd.AutoSize = true;
            this.LblAnd.Location = new System.Drawing.Point(209, 47);
            this.LblAnd.Name = "LblAnd";
            this.LblAnd.Size = new System.Drawing.Size(32, 17);
            this.LblAnd.TabIndex = 5;
            this.LblAnd.Text = "and";
            this.LblAnd.Visible = false;
            // 
            // DtEnd
            // 
            this.DtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtEnd.Location = new System.Drawing.Point(176, 73);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Size = new System.Drawing.Size(112, 22);
            this.DtEnd.TabIndex = 6;
            this.DtEnd.Visible = false;
            // 
            // FrmFilterDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 176);
            this.Controls.Add(this.DtEnd);
            this.Controls.Add(this.LblAnd);
            this.Controls.Add(this.DtStart);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.RdoFilterBetween);
            this.Controls.Add(this.RdoFilterEqualTo);
            this.Controls.Add(this.RdoFilterGreaterThan);
            this.Controls.Add(this.RdoFilterLessThan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilterDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Filter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RdoFilterBetween;
        private System.Windows.Forms.RadioButton RdoFilterEqualTo;
        private System.Windows.Forms.RadioButton RdoFilterGreaterThan;
        private System.Windows.Forms.RadioButton RdoFilterLessThan;
        private System.Windows.Forms.DateTimePicker DtStart;
        private System.Windows.Forms.Label LblAnd;
        private System.Windows.Forms.DateTimePicker DtEnd;
    }
}