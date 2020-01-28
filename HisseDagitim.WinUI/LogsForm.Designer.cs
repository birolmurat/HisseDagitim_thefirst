namespace HisseDagitim.WinUI
{
    partial class LogsForm
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
            this.gbxLogArama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cbxTarih = new System.Windows.Forms.CheckBox();
            this.datepickBitis = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.datepickBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbxAciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dgwLogs = new System.Windows.Forms.DataGridView();
            this.gbxLogArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogArama
            // 
            this.gbxLogArama.Controls.Add(this.btnTemizle);
            this.gbxLogArama.Controls.Add(this.cbxTarih);
            this.gbxLogArama.Controls.Add(this.datepickBitis);
            this.gbxLogArama.Controls.Add(this.label6);
            this.gbxLogArama.Controls.Add(this.datepickBaslangic);
            this.gbxLogArama.Controls.Add(this.label4);
            this.gbxLogArama.Controls.Add(this.rtbxAciklama);
            this.gbxLogArama.Controls.Add(this.label3);
            this.gbxLogArama.Controls.Add(this.label2);
            this.gbxLogArama.Controls.Add(this.label1);
            this.gbxLogArama.Controls.Add(this.tbxKullaniciAdi);
            this.gbxLogArama.Location = new System.Drawing.Point(12, 12);
            this.gbxLogArama.Name = "gbxLogArama";
            this.gbxLogArama.Size = new System.Drawing.Size(437, 265);
            this.gbxLogArama.TabIndex = 0;
            this.gbxLogArama.TabStop = false;
            this.gbxLogArama.Text = "İşlem Kaydı Arama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(135, 222);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 26);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // cbxTarih
            // 
            this.cbxTarih.AutoSize = true;
            this.cbxTarih.Location = new System.Drawing.Point(6, 181);
            this.cbxTarih.Name = "cbxTarih";
            this.cbxTarih.Size = new System.Drawing.Size(117, 17);
            this.cbxTarih.TabIndex = 4;
            this.cbxTarih.Text = "Tarih Kısmını Kullan";
            this.cbxTarih.UseVisualStyleBackColor = true;
            this.cbxTarih.CheckedChanged += new System.EventHandler(this.cbxTarih_CheckedChanged);
            // 
            // datepickBitis
            // 
            this.datepickBitis.Location = new System.Drawing.Point(231, 182);
            this.datepickBitis.Name = "datepickBitis";
            this.datepickBitis.Size = new System.Drawing.Size(200, 20);
            this.datepickBitis.TabIndex = 3;
            this.datepickBitis.ValueChanged += new System.EventHandler(this.datepickBitis_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bitiş";
            // 
            // datepickBaslangic
            // 
            this.datepickBaslangic.Location = new System.Drawing.Point(231, 156);
            this.datepickBaslangic.Name = "datepickBaslangic";
            this.datepickBaslangic.Size = new System.Drawing.Size(200, 20);
            this.datepickBaslangic.TabIndex = 3;
            this.datepickBaslangic.ValueChanged += new System.EventHandler(this.datepickBaslangic_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Başlangıç";
            // 
            // rtbxAciklama
            // 
            this.rtbxAciklama.Location = new System.Drawing.Point(144, 48);
            this.rtbxAciklama.Name = "rtbxAciklama";
            this.rtbxAciklama.Size = new System.Drawing.Size(287, 96);
            this.rtbxAciklama.TabIndex = 2;
            this.rtbxAciklama.Text = "";
            this.rtbxAciklama.TextChanged += new System.EventHandler(this.rtbxAciklama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tarihe Göre Kısıtla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklamaya Göre Kısıtla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adına Göre Kısıtla";
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(144, 19);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(287, 20);
            this.tbxKullaniciAdi.TabIndex = 0;
            this.tbxKullaniciAdi.TextChanged += new System.EventHandler(this.tbxKullaniciAdi_TextChanged);
            // 
            // dgwLogs
            // 
            this.dgwLogs.AllowUserToAddRows = false;
            this.dgwLogs.AllowUserToDeleteRows = false;
            this.dgwLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLogs.Location = new System.Drawing.Point(455, 12);
            this.dgwLogs.Name = "dgwLogs";
            this.dgwLogs.Size = new System.Drawing.Size(961, 544);
            this.dgwLogs.TabIndex = 1;
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 568);
            this.Controls.Add(this.dgwLogs);
            this.Controls.Add(this.gbxLogArama);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1444, 607);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1444, 607);
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogsForm_FormClosing);
            this.Load += new System.EventHandler(this.LogsForm_Load);
            this.gbxLogArama.ResumeLayout(false);
            this.gbxLogArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogArama;
        private System.Windows.Forms.DateTimePicker datepickBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbxAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.DateTimePicker datepickBitis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxTarih;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgwLogs;
    }
}