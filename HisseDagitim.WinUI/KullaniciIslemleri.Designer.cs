namespace HisseDagitim.WinUI
{
    partial class KullaniciIslemleri
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
            this.brpbxKullanici = new System.Windows.Forms.GroupBox();
            this.gbxAktivasyon = new System.Windows.Forms.GroupBox();
            this.btnAktif = new System.Windows.Forms.Button();
            this.tbxKullaniciAktivasyon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDeaktivasyon = new System.Windows.Forms.GroupBox();
            this.btnDeaktif = new System.Windows.Forms.Button();
            this.tbxKullaniciDeaktivasyon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.cbxGuncelAdmin = new System.Windows.Forms.CheckBox();
            this.btnGuncelleKullanici = new System.Windows.Forms.Button();
            this.tbxGuncelAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGuncelParola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbxYeniKullanici = new System.Windows.Forms.GroupBox();
            this.cbxAdminMi = new System.Windows.Forms.CheckBox();
            this.btnEkleKullaniciYeni = new System.Windows.Forms.Button();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwKullanici = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxK_Ara = new System.Windows.Forms.TextBox();
            this.brpbxKullanici.SuspendLayout();
            this.gbxAktivasyon.SuspendLayout();
            this.gbxDeaktivasyon.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            this.grpbxYeniKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // brpbxKullanici
            // 
            this.brpbxKullanici.Controls.Add(this.gbxAktivasyon);
            this.brpbxKullanici.Controls.Add(this.gbxDeaktivasyon);
            this.brpbxKullanici.Controls.Add(this.gbxGuncelle);
            this.brpbxKullanici.Controls.Add(this.grpbxYeniKullanici);
            this.brpbxKullanici.Location = new System.Drawing.Point(12, 12);
            this.brpbxKullanici.Name = "brpbxKullanici";
            this.brpbxKullanici.Size = new System.Drawing.Size(318, 512);
            this.brpbxKullanici.TabIndex = 0;
            this.brpbxKullanici.TabStop = false;
            this.brpbxKullanici.Text = "Kullanıcı İşlemleri";
            // 
            // gbxAktivasyon
            // 
            this.gbxAktivasyon.Controls.Add(this.btnAktif);
            this.gbxAktivasyon.Controls.Add(this.tbxKullaniciAktivasyon);
            this.gbxAktivasyon.Controls.Add(this.label3);
            this.gbxAktivasyon.Location = new System.Drawing.Point(6, 264);
            this.gbxAktivasyon.Name = "gbxAktivasyon";
            this.gbxAktivasyon.Size = new System.Drawing.Size(306, 92);
            this.gbxAktivasyon.TabIndex = 2;
            this.gbxAktivasyon.TabStop = false;
            this.gbxAktivasyon.Text = "Kullanıcı Aktivasyon";
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(6, 58);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(293, 23);
            this.btnAktif.TabIndex = 2;
            this.btnAktif.Text = "Kullanıcı Aktivasyon";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // tbxKullaniciAktivasyon
            // 
            this.tbxKullaniciAktivasyon.Location = new System.Drawing.Point(92, 32);
            this.tbxKullaniciAktivasyon.Name = "tbxKullaniciAktivasyon";
            this.tbxKullaniciAktivasyon.Size = new System.Drawing.Size(186, 20);
            this.tbxKullaniciAktivasyon.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // gbxDeaktivasyon
            // 
            this.gbxDeaktivasyon.Controls.Add(this.btnDeaktif);
            this.gbxDeaktivasyon.Controls.Add(this.tbxKullaniciDeaktivasyon);
            this.gbxDeaktivasyon.Controls.Add(this.label6);
            this.gbxDeaktivasyon.Location = new System.Drawing.Point(6, 166);
            this.gbxDeaktivasyon.Name = "gbxDeaktivasyon";
            this.gbxDeaktivasyon.Size = new System.Drawing.Size(306, 92);
            this.gbxDeaktivasyon.TabIndex = 2;
            this.gbxDeaktivasyon.TabStop = false;
            this.gbxDeaktivasyon.Text = "Kullanıcı Deaktivasyon";
            // 
            // btnDeaktif
            // 
            this.btnDeaktif.Location = new System.Drawing.Point(6, 58);
            this.btnDeaktif.Name = "btnDeaktif";
            this.btnDeaktif.Size = new System.Drawing.Size(293, 23);
            this.btnDeaktif.TabIndex = 2;
            this.btnDeaktif.Text = "Kullanıcı Deaktivasyon";
            this.btnDeaktif.UseVisualStyleBackColor = true;
            this.btnDeaktif.Click += new System.EventHandler(this.btnDeaktif_Click);
            // 
            // tbxKullaniciDeaktivasyon
            // 
            this.tbxKullaniciDeaktivasyon.Location = new System.Drawing.Point(92, 32);
            this.tbxKullaniciDeaktivasyon.Name = "tbxKullaniciDeaktivasyon";
            this.tbxKullaniciDeaktivasyon.Size = new System.Drawing.Size(186, 20);
            this.tbxKullaniciDeaktivasyon.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.cbxGuncelAdmin);
            this.gbxGuncelle.Controls.Add(this.btnGuncelleKullanici);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelAd);
            this.gbxGuncelle.Controls.Add(this.label4);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelParola);
            this.gbxGuncelle.Controls.Add(this.label5);
            this.gbxGuncelle.Location = new System.Drawing.Point(6, 362);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(306, 141);
            this.gbxGuncelle.TabIndex = 2;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Kullanıcı Güncelle";
            // 
            // cbxGuncelAdmin
            // 
            this.cbxGuncelAdmin.AutoSize = true;
            this.cbxGuncelAdmin.Location = new System.Drawing.Point(92, 85);
            this.cbxGuncelAdmin.Name = "cbxGuncelAdmin";
            this.cbxGuncelAdmin.Size = new System.Drawing.Size(55, 17);
            this.cbxGuncelAdmin.TabIndex = 3;
            this.cbxGuncelAdmin.Text = "Admin";
            this.cbxGuncelAdmin.UseVisualStyleBackColor = true;
            // 
            // btnGuncelleKullanici
            // 
            this.btnGuncelleKullanici.Location = new System.Drawing.Point(5, 108);
            this.btnGuncelleKullanici.Name = "btnGuncelleKullanici";
            this.btnGuncelleKullanici.Size = new System.Drawing.Size(293, 23);
            this.btnGuncelleKullanici.TabIndex = 2;
            this.btnGuncelleKullanici.Text = "Kullanıcıyı Güncelle";
            this.btnGuncelleKullanici.UseVisualStyleBackColor = true;
            this.btnGuncelleKullanici.Click += new System.EventHandler(this.btnGuncelleKullanici_Click);
            // 
            // tbxGuncelAd
            // 
            this.tbxGuncelAd.Location = new System.Drawing.Point(92, 32);
            this.tbxGuncelAd.Name = "tbxGuncelAd";
            this.tbxGuncelAd.Size = new System.Drawing.Size(186, 20);
            this.tbxGuncelAd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parola";
            // 
            // tbxGuncelParola
            // 
            this.tbxGuncelParola.Location = new System.Drawing.Point(92, 58);
            this.tbxGuncelParola.Name = "tbxGuncelParola";
            this.tbxGuncelParola.Size = new System.Drawing.Size(186, 20);
            this.tbxGuncelParola.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // grpbxYeniKullanici
            // 
            this.grpbxYeniKullanici.Controls.Add(this.cbxAdminMi);
            this.grpbxYeniKullanici.Controls.Add(this.btnEkleKullaniciYeni);
            this.grpbxYeniKullanici.Controls.Add(this.tbxKullaniciAdi);
            this.grpbxYeniKullanici.Controls.Add(this.label2);
            this.grpbxYeniKullanici.Controls.Add(this.tbxParola);
            this.grpbxYeniKullanici.Controls.Add(this.label1);
            this.grpbxYeniKullanici.Location = new System.Drawing.Point(6, 19);
            this.grpbxYeniKullanici.Name = "grpbxYeniKullanici";
            this.grpbxYeniKullanici.Size = new System.Drawing.Size(306, 141);
            this.grpbxYeniKullanici.TabIndex = 2;
            this.grpbxYeniKullanici.TabStop = false;
            this.grpbxYeniKullanici.Text = "Yeni Kullanıcı";
            // 
            // cbxAdminMi
            // 
            this.cbxAdminMi.AutoSize = true;
            this.cbxAdminMi.Location = new System.Drawing.Point(92, 85);
            this.cbxAdminMi.Name = "cbxAdminMi";
            this.cbxAdminMi.Size = new System.Drawing.Size(55, 17);
            this.cbxAdminMi.TabIndex = 3;
            this.cbxAdminMi.Text = "Admin";
            this.cbxAdminMi.UseVisualStyleBackColor = true;
            // 
            // btnEkleKullaniciYeni
            // 
            this.btnEkleKullaniciYeni.Location = new System.Drawing.Point(6, 108);
            this.btnEkleKullaniciYeni.Name = "btnEkleKullaniciYeni";
            this.btnEkleKullaniciYeni.Size = new System.Drawing.Size(293, 23);
            this.btnEkleKullaniciYeni.TabIndex = 2;
            this.btnEkleKullaniciYeni.Text = "Kullanıcı Ekle";
            this.btnEkleKullaniciYeni.UseVisualStyleBackColor = true;
            this.btnEkleKullaniciYeni.Click += new System.EventHandler(this.btnEkleKullaniciYeni_Click);
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(92, 32);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(186, 20);
            this.tbxKullaniciAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // tbxParola
            // 
            this.tbxParola.Location = new System.Drawing.Point(92, 58);
            this.tbxParola.Name = "tbxParola";
            this.tbxParola.Size = new System.Drawing.Size(186, 20);
            this.tbxParola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // dgwKullanici
            // 
            this.dgwKullanici.AllowUserToAddRows = false;
            this.dgwKullanici.AllowUserToDeleteRows = false;
            this.dgwKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanici.Location = new System.Drawing.Point(336, 63);
            this.dgwKullanici.MultiSelect = false;
            this.dgwKullanici.Name = "dgwKullanici";
            this.dgwKullanici.ReadOnly = true;
            this.dgwKullanici.Size = new System.Drawing.Size(362, 461);
            this.dgwKullanici.TabIndex = 1;
            this.dgwKullanici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanici_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kullanıcı Ara";
            // 
            // tbxK_Ara
            // 
            this.tbxK_Ara.Location = new System.Drawing.Point(463, 28);
            this.tbxK_Ara.MaximumSize = new System.Drawing.Size(186, 20);
            this.tbxK_Ara.MinimumSize = new System.Drawing.Size(186, 20);
            this.tbxK_Ara.Name = "tbxK_Ara";
            this.tbxK_Ara.Size = new System.Drawing.Size(186, 20);
            this.tbxK_Ara.TabIndex = 0;
            this.tbxK_Ara.TextChanged += new System.EventHandler(this.tbxK_Ara_TextChanged);
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 532);
            this.Controls.Add(this.dgwKullanici);
            this.Controls.Add(this.brpbxKullanici);
            this.Controls.Add(this.tbxK_Ara);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 571);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 571);
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            this.brpbxKullanici.ResumeLayout(false);
            this.gbxAktivasyon.ResumeLayout(false);
            this.gbxAktivasyon.PerformLayout();
            this.gbxDeaktivasyon.ResumeLayout(false);
            this.gbxDeaktivasyon.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.grpbxYeniKullanici.ResumeLayout(false);
            this.grpbxYeniKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox brpbxKullanici;
        private System.Windows.Forms.DataGridView dgwKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxParola;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.GroupBox grpbxYeniKullanici;
        private System.Windows.Forms.Button btnEkleKullaniciYeni;
        private System.Windows.Forms.GroupBox gbxDeaktivasyon;
        private System.Windows.Forms.Button btnDeaktif;
        private System.Windows.Forms.TextBox tbxKullaniciDeaktivasyon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxAktivasyon;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.TextBox tbxKullaniciAktivasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxAdminMi;
        private System.Windows.Forms.CheckBox cbxGuncelAdmin;
        private System.Windows.Forms.Button btnGuncelleKullanici;
        private System.Windows.Forms.TextBox tbxGuncelAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGuncelParola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxK_Ara;
    }
}