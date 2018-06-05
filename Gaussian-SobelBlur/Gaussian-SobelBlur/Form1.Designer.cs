namespace Gaussian_SobelBlur
{
    partial class Form1
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.btnGaussian = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatran = new System.Windows.Forms.TextBox();
            this.txtSigma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInput.Cursor = System.Windows.Forms.Cursors.No;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.Red;
            this.lblInput.Location = new System.Drawing.Point(219, 71);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(263, 66);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(908, 71);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(263, 66);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Output";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgInput
            // 
            this.imgInput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgInput.Location = new System.Drawing.Point(36, 181);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(643, 510);
            this.imgInput.TabIndex = 1;
            this.imgInput.TabStop = false;
            // 
            // imgOutput
            // 
            this.imgOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgOutput.Location = new System.Drawing.Point(714, 181);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(643, 510);
            this.imgOutput.TabIndex = 1;
            this.imgOutput.TabStop = false;
            // 
            // btnGaussian
            // 
            this.btnGaussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussian.ForeColor = System.Drawing.Color.Red;
            this.btnGaussian.Location = new System.Drawing.Point(959, 723);
            this.btnGaussian.Name = "btnGaussian";
            this.btnGaussian.Size = new System.Drawing.Size(201, 76);
            this.btnGaussian.TabIndex = 36;
            this.btnGaussian.Text = "Gaussian";
            this.btnGaussian.UseVisualStyleBackColor = true;
            this.btnGaussian.Click += new System.EventHandler(this.btnGaussian_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobel.ForeColor = System.Drawing.Color.Red;
            this.btnSobel.Location = new System.Drawing.Point(1166, 723);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(201, 76);
            this.btnSobel.TabIndex = 36;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.Red;
            this.btnLoadImage.Location = new System.Drawing.Point(219, 723);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(201, 76);
            this.btnLoadImage.TabIndex = 36;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nguyễn Xuân Hội - Trung Anh Jr";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(714, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ma trận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 774);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phương sai (Sigma)";
            // 
            // txtMatran
            // 
            this.txtMatran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatran.Location = new System.Drawing.Point(714, 732);
            this.txtMatran.Name = "txtMatran";
            this.txtMatran.Size = new System.Drawing.Size(213, 30);
            this.txtMatran.TabIndex = 39;
            // 
            // txtSigma
            // 
            this.txtSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma.Location = new System.Drawing.Point(714, 802);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(213, 30);
            this.txtSigma.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 845);
            this.Controls.Add(this.txtSigma);
            this.Controls.Add(this.txtMatran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.btnGaussian);
            this.Controls.Add(this.imgOutput);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.Button btnGaussian;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatran;
        private System.Windows.Forms.TextBox txtSigma;
    }
}

