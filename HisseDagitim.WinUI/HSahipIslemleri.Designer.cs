namespace HisseDagitim.WinUI
{
    partial class HSahipIslemleri
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
            this.tbxIsimAra = new System.Windows.Forms.TextBox();
            this.grpbxArama = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNoAra = new System.Windows.Forms.TextBox();
            this.dgwHSahip = new System.Windows.Forms.DataGridView();
            this.dgwKisiHisse = new System.Windows.Forms.DataGridView();
            this.grpbxHisseSahibi = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbxTuzel = new System.Windows.Forms.CheckBox();
            this.rtbxAdres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTC_Vergi = new System.Windows.Forms.TextBox();
            this.tbxEMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxHSIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHisseSec = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHisseOlustur = new System.Windows.Forms.Button();
            this.grpbxArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHSahip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKisiHisse)).BeginInit();
            this.grpbxHisseSahibi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxIsimAra
            // 
            this.tbxIsimAra.Location = new System.Drawing.Point(130, 19);
            this.tbxIsimAra.Name = "tbxIsimAra";
            this.tbxIsimAra.Size = new System.Drawing.Size(220, 20);
            this.tbxIsimAra.TabIndex = 0;
            this.tbxIsimAra.TextChanged += new System.EventHandler(this.tbxIsimAra_TextChanged);
            // 
            // grpbxArama
            // 
            this.grpbxArama.Controls.Add(this.label2);
            this.grpbxArama.Controls.Add(this.label1);
            this.grpbxArama.Controls.Add(this.tbxNoAra);
            this.grpbxArama.Controls.Add(this.tbxIsimAra);
            this.grpbxArama.Location = new System.Drawing.Point(12, 12);
            this.grpbxArama.Name = "grpbxArama";
            this.grpbxArama.Size = new System.Drawing.Size(365, 78);
            this.grpbxArama.TabIndex = 1;
            this.grpbxArama.TabStop = false;
            this.grpbxArama.Text = "Hisse Sahibi Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TCKN - Vergi No ile Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsme Göre Ara";
            // 
            // tbxNoAra
            // 
            this.tbxNoAra.Location = new System.Drawing.Point(130, 45);
            this.tbxNoAra.Name = "tbxNoAra";
            this.tbxNoAra.Size = new System.Drawing.Size(220, 20);
            this.tbxNoAra.TabIndex = 0;
            this.tbxNoAra.TextChanged += new System.EventHandler(this.tbxNoAra_TextChanged);
            // 
            // dgwHSahip
            // 
            this.dgwHSahip.AllowUserToAddRows = false;
            this.dgwHSahip.AllowUserToDeleteRows = false;
            this.dgwHSahip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHSahip.Location = new System.Drawing.Point(12, 96);
            this.dgwHSahip.MultiSelect = false;
            this.dgwHSahip.Name = "dgwHSahip";
            this.dgwHSahip.ReadOnly = true;
            this.dgwHSahip.Size = new System.Drawing.Size(365, 615);
            this.dgwHSahip.TabIndex = 2;
            this.dgwHSahip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHSahip_CellDoubleClick);
            // 
            // dgwKisiHisse
            // 
            this.dgwKisiHisse.AllowUserToAddRows = false;
            this.dgwKisiHisse.AllowUserToDeleteRows = false;
            this.dgwKisiHisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKisiHisse.Location = new System.Drawing.Point(383, 96);
            this.dgwKisiHisse.MultiSelect = false;
            this.dgwKisiHisse.Name = "dgwKisiHisse";
            this.dgwKisiHisse.ReadOnly = true;
            this.dgwKisiHisse.Size = new System.Drawing.Size(365, 233);
            this.dgwKisiHisse.TabIndex = 3;
            this.dgwKisiHisse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKisiHisse_CellDoubleClick);
            // 
            // grpbxHisseSahibi
            // 
            this.grpbxHisseSahibi.Controls.Add(this.btnSil);
            this.grpbxHisseSahibi.Controls.Add(this.btnDuzenle);
            this.grpbxHisseSahibi.Controls.Add(this.btnEkle);
            this.grpbxHisseSahibi.Controls.Add(this.cbxTuzel);
            this.grpbxHisseSahibi.Controls.Add(this.rtbxAdres);
            this.grpbxHisseSahibi.Controls.Add(this.label5);
            this.grpbxHisseSahibi.Controls.Add(this.tbxTC_Vergi);
            this.grpbxHisseSahibi.Controls.Add(this.tbxEMail);
            this.grpbxHisseSahibi.Controls.Add(this.label8);
            this.grpbxHisseSahibi.Controls.Add(this.tbxTelefon);
            this.grpbxHisseSahibi.Controls.Add(this.label7);
            this.grpbxHisseSahibi.Controls.Add(this.tbxHSIsim);
            this.grpbxHisseSahibi.Controls.Add(this.label4);
            this.grpbxHisseSahibi.Controls.Add(this.label6);
            this.grpbxHisseSahibi.Location = new System.Drawing.Point(384, 364);
            this.grpbxHisseSahibi.Name = "grpbxHisseSahibi";
            this.grpbxHisseSahibi.Size = new System.Drawing.Size(364, 347);
            this.grpbxHisseSahibi.TabIndex = 5;
            this.grpbxHisseSahibi.TabStop = false;
            this.grpbxHisseSahibi.Text = "Hisse Sahibi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(126, 313);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(126, 284);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(126, 255);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbxTuzel
            // 
            this.cbxTuzel.AutoSize = true;
            this.cbxTuzel.Location = new System.Drawing.Point(169, 231);
            this.cbxTuzel.Name = "cbxTuzel";
            this.cbxTuzel.Size = new System.Drawing.Size(92, 17);
            this.cbxTuzel.TabIndex = 9;
            this.cbxTuzel.Text = "Tüzel Durumu";
            this.cbxTuzel.UseVisualStyleBackColor = true;
            // 
            // rtbxAdres
            // 
            this.rtbxAdres.Location = new System.Drawing.Point(169, 74);
            this.rtbxAdres.Name = "rtbxAdres";
            this.rtbxAdres.Size = new System.Drawing.Size(189, 96);
            this.rtbxAdres.TabIndex = 8;
            this.rtbxAdres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TCKN - Vergi No";
            // 
            // tbxTC_Vergi
            // 
            this.tbxTC_Vergi.Location = new System.Drawing.Point(169, 45);
            this.tbxTC_Vergi.Name = "tbxTC_Vergi";
            this.tbxTC_Vergi.Size = new System.Drawing.Size(189, 20);
            this.tbxTC_Vergi.TabIndex = 0;
            // 
            // tbxEMail
            // 
            this.tbxEMail.Location = new System.Drawing.Point(169, 202);
            this.tbxEMail.Name = "tbxEMail";
            this.tbxEMail.Size = new System.Drawing.Size(189, 20);
            this.tbxEMail.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "E-Mail";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(169, 176);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(189, 20);
            this.tbxTelefon.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefon";
            // 
            // tbxHSIsim
            // 
            this.tbxHSIsim.Location = new System.Drawing.Point(169, 19);
            this.tbxHSIsim.Name = "tbxHSIsim";
            this.tbxHSIsim.Size = new System.Drawing.Size(189, 20);
            this.tbxHSIsim.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İsim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adres";
            // 
            // btnHisseSec
            // 
            this.btnHisseSec.Location = new System.Drawing.Point(510, 335);
            this.btnHisseSec.Name = "btnHisseSec";
            this.btnHisseSec.Size = new System.Drawing.Size(75, 23);
            this.btnHisseSec.TabIndex = 6;
            this.btnHisseSec.Text = "Hisse Seç";
            this.btnHisseSec.UseVisualStyleBackColor = true;
            this.btnHisseSec.Click += new System.EventHandler(this.btnHisseSec_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(642, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 23);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHisseOlustur
            // 
            this.btnHisseOlustur.Location = new System.Drawing.Point(642, 41);
            this.btnHisseOlustur.Name = "btnHisseOlustur";
            this.btnHisseOlustur.Size = new System.Drawing.Size(114, 23);
            this.btnHisseOlustur.TabIndex = 7;
            this.btnHisseOlustur.Text = "Kişiye Hisse Oluştur";
            this.btnHisseOlustur.UseVisualStyleBackColor = true;
            this.btnHisseOlustur.Click += new System.EventHandler(this.btnHisseOlustur_Click);
            // 
            // HSahipIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 721);
            this.Controls.Add(this.btnHisseOlustur);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHisseSec);
            this.Controls.Add(this.grpbxHisseSahibi);
            this.Controls.Add(this.dgwKisiHisse);
            this.Controls.Add(this.dgwHSahip);
            this.Controls.Add(this.grpbxArama);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 760);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 760);
            this.Name = "HSahipIslemleri";
            this.Text = "HSahipIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HSahipIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.HSahipIslemleri_Load);
            this.grpbxArama.ResumeLayout(false);
            this.grpbxArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHSahip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKisiHisse)).EndInit();
            this.grpbxHisseSahibi.ResumeLayout(false);
            this.grpbxHisseSahibi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIsimAra;
        private System.Windows.Forms.GroupBox grpbxArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNoAra;
        private System.Windows.Forms.DataGridView dgwHSahip;
        private System.Windows.Forms.DataGridView dgwKisiHisse;
        private System.Windows.Forms.GroupBox grpbxHisseSahibi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTC_Vergi;
        private System.Windows.Forms.TextBox tbxHSIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbxAdres;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxTuzel;
        private System.Windows.Forms.TextBox tbxEMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnHisseSec;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHisseOlustur;
    }
}