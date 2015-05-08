namespace WindowsFormsApplication1
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
            this.btnMatrixMultiply = new System.Windows.Forms.Button();
            this.txtMatrixSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMatrixMultiply
            // 
            this.btnMatrixMultiply.Location = new System.Drawing.Point(114, 192);
            this.btnMatrixMultiply.Name = "btnMatrixMultiply";
            this.btnMatrixMultiply.Size = new System.Drawing.Size(158, 35);
            this.btnMatrixMultiply.TabIndex = 0;
            this.btnMatrixMultiply.Text = "Matrisleri Çarp";
            this.btnMatrixMultiply.UseVisualStyleBackColor = true;
            this.btnMatrixMultiply.Click += new System.EventHandler(this.btnMatrixMultiply_Click);
            // 
            // txtMatrixSize
            // 
            this.txtMatrixSize.Location = new System.Drawing.Point(142, 134);
            this.txtMatrixSize.Name = "txtMatrixSize";
            this.txtMatrixSize.Size = new System.Drawing.Size(100, 22);
            this.txtMatrixSize.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(101, 80);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(192, 17);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Kare Matris Boyutunu Giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 331);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtMatrixSize);
            this.Controls.Add(this.btnMatrixMultiply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatrixMultiply;
        private System.Windows.Forms.TextBox txtMatrixSize;
        private System.Windows.Forms.Label lblSize;
    }
}

