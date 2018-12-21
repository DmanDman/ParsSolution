namespace ParsDashboard
{
    partial class FrmPicOnly
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
            this.GrpImages = new System.Windows.Forms.GroupBox();
            this.LstImageDesc = new System.Windows.Forms.ListBox();
            this.BtnImagePrev = new System.Windows.Forms.Button();
            this.BtnImageFirst = new System.Windows.Forms.Button();
            this.BtnImageNext = new System.Windows.Forms.Button();
            this.BtnImageLast = new System.Windows.Forms.Button();
            this.TxtImagesCount = new System.Windows.Forms.TextBox();
            this.LblGrpImageDesc = new System.Windows.Forms.Label();
            this.LstImages = new System.Windows.Forms.ListView();
            this.GrpImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpImages
            // 
            this.GrpImages.Controls.Add(this.LstImageDesc);
            this.GrpImages.Controls.Add(this.BtnImagePrev);
            this.GrpImages.Controls.Add(this.BtnImageFirst);
            this.GrpImages.Controls.Add(this.BtnImageNext);
            this.GrpImages.Controls.Add(this.BtnImageLast);
            this.GrpImages.Controls.Add(this.TxtImagesCount);
            this.GrpImages.Controls.Add(this.LblGrpImageDesc);
            this.GrpImages.Controls.Add(this.LstImages);
            this.GrpImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpImages.Location = new System.Drawing.Point(12, 46);
            this.GrpImages.Name = "GrpImages";
            this.GrpImages.Size = new System.Drawing.Size(725, 411);
            this.GrpImages.TabIndex = 18;
            this.GrpImages.TabStop = false;
            this.GrpImages.Text = "Images";
            // 
            // LstImageDesc
            // 
            this.LstImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstImageDesc.FormattingEnabled = true;
            this.LstImageDesc.ItemHeight = 16;
            this.LstImageDesc.Location = new System.Drawing.Point(9, 60);
            this.LstImageDesc.Name = "LstImageDesc";
            this.LstImageDesc.Size = new System.Drawing.Size(175, 324);
            this.LstImageDesc.TabIndex = 1;
            // 
            // BtnImagePrev
            // 
            this.BtnImagePrev.Location = new System.Drawing.Point(277, 34);
            this.BtnImagePrev.Name = "BtnImagePrev";
            this.BtnImagePrev.Size = new System.Drawing.Size(34, 23);
            this.BtnImagePrev.TabIndex = 3;
            this.BtnImagePrev.Text = "<";
            this.BtnImagePrev.UseVisualStyleBackColor = true;
            // 
            // BtnImageFirst
            // 
            this.BtnImageFirst.Location = new System.Drawing.Point(225, 32);
            this.BtnImageFirst.Name = "BtnImageFirst";
            this.BtnImageFirst.Size = new System.Drawing.Size(34, 23);
            this.BtnImageFirst.TabIndex = 2;
            this.BtnImageFirst.Text = "|<";
            this.BtnImageFirst.UseVisualStyleBackColor = true;
            // 
            // BtnImageNext
            // 
            this.BtnImageNext.Location = new System.Drawing.Point(616, 29);
            this.BtnImageNext.Name = "BtnImageNext";
            this.BtnImageNext.Size = new System.Drawing.Size(34, 23);
            this.BtnImageNext.TabIndex = 5;
            this.BtnImageNext.Text = ">";
            this.BtnImageNext.UseVisualStyleBackColor = true;
            // 
            // BtnImageLast
            // 
            this.BtnImageLast.Location = new System.Drawing.Point(669, 29);
            this.BtnImageLast.Name = "BtnImageLast";
            this.BtnImageLast.Size = new System.Drawing.Size(34, 23);
            this.BtnImageLast.TabIndex = 6;
            this.BtnImageLast.Text = ">|";
            this.BtnImageLast.UseVisualStyleBackColor = true;
            // 
            // TxtImagesCount
            // 
            this.TxtImagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImagesCount.Location = new System.Drawing.Point(417, 32);
            this.TxtImagesCount.Name = "TxtImagesCount";
            this.TxtImagesCount.Size = new System.Drawing.Size(101, 22);
            this.TxtImagesCount.TabIndex = 4;
            this.TxtImagesCount.Text = "10 of 10";
            this.TxtImagesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblGrpImageDesc
            // 
            this.LblGrpImageDesc.AutoSize = true;
            this.LblGrpImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrpImageDesc.Location = new System.Drawing.Point(6, 35);
            this.LblGrpImageDesc.Name = "LblGrpImageDesc";
            this.LblGrpImageDesc.Size = new System.Drawing.Size(122, 17);
            this.LblGrpImageDesc.TabIndex = 0;
            this.LblGrpImageDesc.Text = "Image Descriptors";
            // 
            // LstImages
            // 
            this.LstImages.Location = new System.Drawing.Point(225, 63);
            this.LstImages.Name = "LstImages";
            this.LstImages.Size = new System.Drawing.Size(478, 324);
            this.LstImages.TabIndex = 7;
            this.LstImages.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPicOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 793);
            this.ControlBox = false;
            this.Controls.Add(this.GrpImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPicOnly";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FrmPicOnly";
            this.Text = "Emailed Pics - Picture Only";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrpImages.ResumeLayout(false);
            this.GrpImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpImages;
        private System.Windows.Forms.ListBox LstImageDesc;
        private System.Windows.Forms.Button BtnImagePrev;
        private System.Windows.Forms.Button BtnImageFirst;
        private System.Windows.Forms.Button BtnImageNext;
        private System.Windows.Forms.Button BtnImageLast;
        private System.Windows.Forms.TextBox TxtImagesCount;
        private System.Windows.Forms.Label LblGrpImageDesc;
        private System.Windows.Forms.ListView LstImages;
    }
}