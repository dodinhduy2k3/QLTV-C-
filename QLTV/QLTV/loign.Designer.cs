namespace QLTV
{
    partial class loign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loign));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtus = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnloign = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu :";
            // 
            // txtus
            // 
            this.txtus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtus.Location = new System.Drawing.Point(213, 156);
            this.txtus.Name = "txtus";
            this.txtus.Size = new System.Drawing.Size(179, 31);
            this.txtus.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(213, 208);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(179, 31);
            this.txtpass.TabIndex = 1;
            // 
            // btnloign
            // 
            this.btnloign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnloign.BackgroundImage")));
            this.btnloign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnloign.Location = new System.Drawing.Point(230, 311);
            this.btnloign.Name = "btnloign";
            this.btnloign.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnloign.Size = new System.Drawing.Size(150, 51);
            this.btnloign.TabIndex = 2;
            this.btnloign.UseVisualStyleBackColor = true;
            this.btnloign.Click += new System.EventHandler(this.btnloign_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Location = new System.Drawing.Point(26, 311);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthoat.Size = new System.Drawing.Size(150, 51);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // loign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 525);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnloign);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "loign";
            this.Text = "loign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtus;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnloign;
        private System.Windows.Forms.Button btnthoat;
    }
}