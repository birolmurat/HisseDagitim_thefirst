namespace HisseDagitim.WinUI
{
    partial class HisseSenediIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSenetAra = new System.Windows.Forms.Button();
            this.nudTertipNoAra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHisseYiliAra = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwHisseView = new System.Windows.Forms.DataGridView();
            this.gbxTopluIslem = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYeniHisseOlustur = new System.Windows.Forms.Button();
            this.btnTopluSil = new System.Windows.Forms.Button();
            this.btnBlokaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudYeniHisseYil = new System.Windows.Forms.NumericUpDown();
            this.nudBloksilYil = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudYeniHisseTertip = new System.Windows.Forms.NumericUpDown();
            this.nudBloksilTertip = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertipNoAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseYiliAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHisseView)).BeginInit();
            this.gbxTopluIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniHisseYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloksilYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniHisseTertip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloksilTertip)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSenetAra);
            this.groupBox1.Controls.Add(this.nudTertipNoAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudHisseYiliAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hisse Arama";
            // 
            // btnSenetAra
            // 
            this.btnSenetAra.Location = new System.Drawing.Point(71, 76);
            this.btnSenetAra.Name = "btnSenetAra";
            this.btnSenetAra.Size = new System.Drawing.Size(136, 23);
            this.btnSenetAra.TabIndex = 3;
            this.btnSenetAra.Text = "Hisse Senedi Ara";
            this.btnSenetAra.UseVisualStyleBackColor = true;
            this.btnSenetAra.Click += new System.EventHandler(this.btnSenetAra_Click);
            // 
            // nudTertipNoAra
            // 
            this.nudTertipNoAra.Location = new System.Drawing.Point(178, 50);
            this.nudTertipNoAra.Name = "nudTertipNoAra";
            this.nudTertipNoAra.Size = new System.Drawing.Size(120, 20);
            this.nudTertipNoAra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hisse Tertip No";
            // 
            // nudHisseYiliAra
            // 
            this.nudHisseYiliAra.Location = new System.Drawing.Point(178, 24);
            this.nudHisseYiliAra.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudHisseYiliAra.Name = "nudHisseYiliAra";
            this.nudHisseYiliAra.Size = new System.Drawing.Size(120, 20);
            this.nudHisseYiliAra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hisse Yılı";
            // 
            // dgwHisseView
            // 
            this.dgwHisseView.AllowUserToAddRows = false;
            this.dgwHisseView.AllowUserToDeleteRows = false;
            this.dgwHisseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHisseView.Location = new System.Drawing.Point(322, 12);
            this.dgwHisseView.MultiSelect = false;
            this.dgwHisseView.Name = "dgwHisseView";
            this.dgwHisseView.ReadOnly = true;
            this.dgwHisseView.Size = new System.Drawing.Size(466, 622);
            this.dgwHisseView.TabIndex = 1;
            this.dgwHisseView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHisseView_CellDoubleClick);
            // 
            // gbxTopluIslem
            // 
            this.gbxTopluIslem.Controls.Add(this.label9);
            this.gbxTopluIslem.Controls.Add(this.label8);
            this.gbxTopluIslem.Controls.Add(this.btnYeniHisseOlustur);
            this.gbxTopluIslem.Controls.Add(this.btnTopluSil);
            this.gbxTopluIslem.Controls.Add(this.btnBlokaj);
            this.gbxTopluIslem.Controls.Add(this.label7);
            this.gbxTopluIslem.Controls.Add(this.label4);
            this.gbxTopluIslem.Controls.Add(this.nudYeniHisseYil);
            this.gbxTopluIslem.Controls.Add(this.nudBloksilYil);
            this.gbxTopluIslem.Controls.Add(this.label6);
            this.gbxTopluIslem.Controls.Add(this.label5);
            this.gbxTopluIslem.Controls.Add(this.nudYeniHisseTertip);
            this.gbxTopluIslem.Controls.Add(this.nudBloksilTertip);
            this.gbxTopluIslem.Location = new System.Drawing.Point(12, 131);
            this.gbxTopluIslem.Name = "gbxTopluIslem";
            this.gbxTopluIslem.Size = new System.Drawing.Size(304, 279);
            this.gbxTopluIslem.TabIndex = 2;
            this.gbxTopluIslem.TabStop = false;
            this.gbxTopluIslem.Text = "Toplu Hisse İşlemleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Yeni Hisse İşlemi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Blokaj ve Silme İşlemi";
            // 
            // btnYeniHisseOlustur
            // 
            this.btnYeniHisseOlustur.Location = new System.Drawing.Point(71, 244);
            this.btnYeniHisseOlustur.Name = "btnYeniHisseOlustur";
            this.btnYeniHisseOlustur.Size = new System.Drawing.Size(136, 23);
            this.btnYeniHisseOlustur.TabIndex = 3;
            this.btnYeniHisseOlustur.Text = "Hisseleri Oluştur";
            this.btnYeniHisseOlustur.UseVisualStyleBackColor = true;
            this.btnYeniHisseOlustur.Click += new System.EventHandler(this.btnYeniHisseOlustur_Click);
            // 
            // btnTopluSil
            // 
            this.btnTopluSil.Location = new System.Drawing.Point(71, 119);
            this.btnTopluSil.Name = "btnTopluSil";
            this.btnTopluSil.Size = new System.Drawing.Size(136, 23);
            this.btnTopluSil.TabIndex = 3;
            this.btnTopluSil.Text = "Hisseleri Sil";
            this.btnTopluSil.UseVisualStyleBackColor = true;
            this.btnTopluSil.Click += new System.EventHandler(this.btnTopluSilme_Click);
            // 
            // btnBlokaj
            // 
            this.btnBlokaj.Location = new System.Drawing.Point(71, 90);
            this.btnBlokaj.Name = "btnBlokaj";
            this.btnBlokaj.Size = new System.Drawing.Size(136, 23);
            this.btnBlokaj.TabIndex = 3;
            this.btnBlokaj.Text = "Hisseleri Bloke Et";
            this.btnBlokaj.UseVisualStyleBackColor = true;
            this.btnBlokaj.Click += new System.EventHandler(this.btnBlokaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hisse Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hisse Yılı";
            // 
            // nudYeniHisseYil
            // 
            this.nudYeniHisseYil.Location = new System.Drawing.Point(178, 192);
            this.nudYeniHisseYil.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudYeniHisseYil.Name = "nudYeniHisseYil";
            this.nudYeniHisseYil.Size = new System.Drawing.Size(120, 20);
            this.nudYeniHisseYil.TabIndex = 2;
            // 
            // nudBloksilYil
            // 
            this.nudBloksilYil.Enabled = false;
            this.nudBloksilYil.Location = new System.Drawing.Point(178, 38);
            this.nudBloksilYil.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudBloksilYil.Name = "nudBloksilYil";
            this.nudBloksilYil.Size = new System.Drawing.Size(120, 20);
            this.nudBloksilYil.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hisse Tertip No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hisse Tertip No";
            // 
            // nudYeniHisseTertip
            // 
            this.nudYeniHisseTertip.Location = new System.Drawing.Point(178, 218);
            this.nudYeniHisseTertip.Name = "nudYeniHisseTertip";
            this.nudYeniHisseTertip.Size = new System.Drawing.Size(120, 20);
            this.nudYeniHisseTertip.TabIndex = 2;
            // 
            // nudBloksilTertip
            // 
            this.nudBloksilTertip.Enabled = false;
            this.nudBloksilTertip.Location = new System.Drawing.Point(178, 64);
            this.nudBloksilTertip.Name = "nudBloksilTertip";
            this.nudBloksilTertip.Size = new System.Drawing.Size(120, 20);
            this.nudBloksilTertip.TabIndex = 2;
            // 
            // HisseSenediIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.gbxTopluIslem);
            this.Controls.Add(this.dgwHisseView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 685);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 685);
            this.Name = "HisseSenediIslemleri";
            this.Text = "HisseSenediIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HisseSenediIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.HisseSenediIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertipNoAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseYiliAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHisseView)).EndInit();
            this.gbxTopluIslem.ResumeLayout(false);
            this.gbxTopluIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniHisseYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloksilYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniHisseTertip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBloksilTertip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSenetAra;
        private System.Windows.Forms.NumericUpDown nudTertipNoAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHisseYiliAra;
        private System.Windows.Forms.DataGridView dgwHisseView;
        private System.Windows.Forms.GroupBox gbxTopluIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBloksilYil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBloksilTertip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYeniHisseOlustur;
        private System.Windows.Forms.Button btnBlokaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudYeniHisseYil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudYeniHisseTertip;
        private System.Windows.Forms.Button btnTopluSil;
    }
}