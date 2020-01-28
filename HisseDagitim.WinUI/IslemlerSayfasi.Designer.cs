namespace HisseDagitim.WinUI
{
    partial class IslemlerSayfasi
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
            this.btnHSahipIslemleri = new System.Windows.Forms.Button();
            this.btnHSenetIslemleri = new System.Windows.Forms.Button();
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.btnIslemKaydi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHSahipIslemleri
            // 
            this.btnHSahipIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHSahipIslemleri.Location = new System.Drawing.Point(12, 12);
            this.btnHSahipIslemleri.Name = "btnHSahipIslemleri";
            this.btnHSahipIslemleri.Size = new System.Drawing.Size(420, 101);
            this.btnHSahipIslemleri.TabIndex = 0;
            this.btnHSahipIslemleri.Text = "Hisse Sahibi İşlemleri";
            this.btnHSahipIslemleri.UseVisualStyleBackColor = true;
            this.btnHSahipIslemleri.Click += new System.EventHandler(this.btnHSahipIslemleri_Click);
            // 
            // btnHSenetIslemleri
            // 
            this.btnHSenetIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHSenetIslemleri.Location = new System.Drawing.Point(12, 119);
            this.btnHSenetIslemleri.Name = "btnHSenetIslemleri";
            this.btnHSenetIslemleri.Size = new System.Drawing.Size(420, 101);
            this.btnHSenetIslemleri.TabIndex = 0;
            this.btnHSenetIslemleri.Text = "Hisse Senedi İşlemleri";
            this.btnHSenetIslemleri.UseVisualStyleBackColor = true;
            this.btnHSenetIslemleri.Click += new System.EventHandler(this.btnHSenetIslemleri_Click);
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(12, 226);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(420, 101);
            this.btnKullaniciIslemleri.TabIndex = 0;
            this.btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            this.btnKullaniciIslemleri.Click += new System.EventHandler(this.btnKullaniciIslemleri_Click);
            // 
            // btnIslemKaydi
            // 
            this.btnIslemKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIslemKaydi.Location = new System.Drawing.Point(12, 333);
            this.btnIslemKaydi.Name = "btnIslemKaydi";
            this.btnIslemKaydi.Size = new System.Drawing.Size(420, 101);
            this.btnIslemKaydi.TabIndex = 0;
            this.btnIslemKaydi.Text = "İşlem Kaydı Görüntüle";
            this.btnIslemKaydi.UseVisualStyleBackColor = true;
            this.btnIslemKaydi.Click += new System.EventHandler(this.btnIslemKaydi_Click);
            // 
            // IslemlerSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 443);
            this.Controls.Add(this.btnIslemKaydi);
            this.Controls.Add(this.btnKullaniciIslemleri);
            this.Controls.Add(this.btnHSenetIslemleri);
            this.Controls.Add(this.btnHSahipIslemleri);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 482);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 482);
            this.Name = "IslemlerSayfasi";
            this.Text = "IslemlerSayfasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IslemlerSayfasi_FormClosing);
            this.Load += new System.EventHandler(this.IslemlerSayfasi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHSahipIslemleri;
        private System.Windows.Forms.Button btnHSenetIslemleri;
        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Button btnIslemKaydi;
    }
}