namespace HisseDagitim.WinUI
{
    partial class HisseSenedi_Sahipten
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudHSDeger = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTertip = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSene = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHisseNo = new System.Windows.Forms.NumericUpDown();
            this.cbxBlokaj = new System.Windows.Forms.CheckBox();
            this.dgwKar = new System.Windows.Forms.DataGridView();
            this.dgwYeni = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKarPayiDagit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudKarSenesi = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudKarCarpan = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPayNo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudPayCarpan = new System.Windows.Forms.NumericUpDown();
            this.btnPayDagit = new System.Windows.Forms.Button();
            this.cbxKar = new System.Windows.Forms.CheckBox();
            this.cbxYeni = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarSenesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarCarpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayCarpan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hisse Değeri";
            // 
            // nudHSDeger
            // 
            this.nudHSDeger.DecimalPlaces = 2;
            this.nudHSDeger.Location = new System.Drawing.Point(99, 12);
            this.nudHSDeger.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudHSDeger.Name = "nudHSDeger";
            this.nudHSDeger.Size = new System.Drawing.Size(138, 20);
            this.nudHSDeger.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tertip No";
            // 
            // nudTertip
            // 
            this.nudTertip.Location = new System.Drawing.Point(99, 64);
            this.nudTertip.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudTertip.Name = "nudTertip";
            this.nudTertip.Size = new System.Drawing.Size(138, 20);
            this.nudTertip.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HisseYılı";
            // 
            // nudSene
            // 
            this.nudSene.Location = new System.Drawing.Point(99, 38);
            this.nudSene.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudSene.Name = "nudSene";
            this.nudSene.Size = new System.Drawing.Size(138, 20);
            this.nudSene.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hisse No";
            // 
            // nudHisseNo
            // 
            this.nudHisseNo.Location = new System.Drawing.Point(99, 90);
            this.nudHisseNo.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudHisseNo.Name = "nudHisseNo";
            this.nudHisseNo.Size = new System.Drawing.Size(138, 20);
            this.nudHisseNo.TabIndex = 2;
            // 
            // cbxBlokaj
            // 
            this.cbxBlokaj.AutoSize = true;
            this.cbxBlokaj.Location = new System.Drawing.Point(99, 116);
            this.cbxBlokaj.Name = "cbxBlokaj";
            this.cbxBlokaj.Size = new System.Drawing.Size(138, 17);
            this.cbxBlokaj.TabIndex = 3;
            this.cbxBlokaj.Text = "Hisse Geçerlilik Durumu";
            this.cbxBlokaj.UseVisualStyleBackColor = true;
            // 
            // dgwKar
            // 
            this.dgwKar.AllowUserToAddRows = false;
            this.dgwKar.AllowUserToDeleteRows = false;
            this.dgwKar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKar.Location = new System.Drawing.Point(243, 38);
            this.dgwKar.MultiSelect = false;
            this.dgwKar.Name = "dgwKar";
            this.dgwKar.ReadOnly = true;
            this.dgwKar.ShowEditingIcon = false;
            this.dgwKar.Size = new System.Drawing.Size(338, 422);
            this.dgwKar.TabIndex = 5;
            this.dgwKar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKar_CellDoubleClick);
            // 
            // dgwYeni
            // 
            this.dgwYeni.AllowUserToAddRows = false;
            this.dgwYeni.AllowUserToDeleteRows = false;
            this.dgwYeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYeni.Location = new System.Drawing.Point(587, 38);
            this.dgwYeni.MultiSelect = false;
            this.dgwYeni.Name = "dgwYeni";
            this.dgwYeni.ReadOnly = true;
            this.dgwYeni.ShowEditingIcon = false;
            this.dgwYeni.Size = new System.Drawing.Size(335, 422);
            this.dgwYeni.TabIndex = 5;
            this.dgwYeni.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYeni_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kar Payı Pulları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yeni Pay Pulları";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(15, 139);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(219, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKarPayiDagit
            // 
            this.btnKarPayiDagit.Location = new System.Drawing.Point(12, 270);
            this.btnKarPayiDagit.Name = "btnKarPayiDagit";
            this.btnKarPayiDagit.Size = new System.Drawing.Size(222, 23);
            this.btnKarPayiDagit.TabIndex = 6;
            this.btnKarPayiDagit.Text = "Kar Payı Güncelle";
            this.btnKarPayiDagit.UseVisualStyleBackColor = true;
            this.btnKarPayiDagit.Click += new System.EventHandler(this.btnKarPayiDagit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kar Payı Senesi";
            // 
            // nudKarSenesi
            // 
            this.nudKarSenesi.Location = new System.Drawing.Point(99, 195);
            this.nudKarSenesi.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudKarSenesi.Name = "nudKarSenesi";
            this.nudKarSenesi.Size = new System.Drawing.Size(138, 20);
            this.nudKarSenesi.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Çarpan";
            // 
            // nudKarCarpan
            // 
            this.nudKarCarpan.Location = new System.Drawing.Point(99, 221);
            this.nudKarCarpan.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudKarCarpan.Name = "nudKarCarpan";
            this.nudKarCarpan.Size = new System.Drawing.Size(138, 20);
            this.nudKarCarpan.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yeni Pay Pul No";
            // 
            // nudPayNo
            // 
            this.nudPayNo.Location = new System.Drawing.Point(99, 310);
            this.nudPayNo.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPayNo.Name = "nudPayNo";
            this.nudPayNo.Size = new System.Drawing.Size(138, 20);
            this.nudPayNo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Çarpan";
            // 
            // nudPayCarpan
            // 
            this.nudPayCarpan.Location = new System.Drawing.Point(99, 336);
            this.nudPayCarpan.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPayCarpan.Name = "nudPayCarpan";
            this.nudPayCarpan.Size = new System.Drawing.Size(138, 20);
            this.nudPayCarpan.TabIndex = 2;
            // 
            // btnPayDagit
            // 
            this.btnPayDagit.Location = new System.Drawing.Point(12, 385);
            this.btnPayDagit.Name = "btnPayDagit";
            this.btnPayDagit.Size = new System.Drawing.Size(222, 23);
            this.btnPayDagit.TabIndex = 6;
            this.btnPayDagit.Text = "Yeni Pay Güncelle";
            this.btnPayDagit.UseVisualStyleBackColor = true;
            this.btnPayDagit.Click += new System.EventHandler(this.btnPayDagit_Click);
            // 
            // cbxKar
            // 
            this.cbxKar.AutoSize = true;
            this.cbxKar.Location = new System.Drawing.Point(99, 247);
            this.cbxKar.Name = "cbxKar";
            this.cbxKar.Size = new System.Drawing.Size(82, 17);
            this.cbxKar.TabIndex = 3;
            this.cbxKar.Text = "Kar Dağıtıldı";
            this.cbxKar.UseVisualStyleBackColor = true;
            // 
            // cbxYeni
            // 
            this.cbxYeni.AutoSize = true;
            this.cbxYeni.Location = new System.Drawing.Point(99, 362);
            this.cbxYeni.Name = "cbxYeni";
            this.cbxYeni.Size = new System.Drawing.Size(84, 17);
            this.cbxYeni.TabIndex = 3;
            this.cbxYeni.Text = "Pay Dağıtıldı";
            this.cbxYeni.UseVisualStyleBackColor = true;
            // 
            // HisseSenedi_Sahipten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 498);
            this.Controls.Add(this.btnPayDagit);
            this.Controls.Add(this.btnKarPayiDagit);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgwYeni);
            this.Controls.Add(this.dgwKar);
            this.Controls.Add(this.nudPayCarpan);
            this.Controls.Add(this.cbxYeni);
            this.Controls.Add(this.cbxKar);
            this.Controls.Add(this.cbxBlokaj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudKarCarpan);
            this.Controls.Add(this.nudPayNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudKarSenesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudHisseNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTertip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHSDeger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(972, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(972, 537);
            this.Name = "HisseSenedi_Sahipten";
            this.Text = "HisseSenedi_Sahipten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HisseSenedi_Sahipten_FormClosing);
            this.Load += new System.EventHandler(this.HisseSenedi_Sahipten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHSDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarSenesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarCarpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayCarpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHSDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTertip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSene;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHisseNo;
        private System.Windows.Forms.CheckBox cbxBlokaj;
        private System.Windows.Forms.DataGridView dgwKar;
        private System.Windows.Forms.DataGridView dgwYeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKarPayiDagit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudKarSenesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudKarCarpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPayNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPayCarpan;
        private System.Windows.Forms.Button btnPayDagit;
        private System.Windows.Forms.CheckBox cbxKar;
        private System.Windows.Forms.CheckBox cbxYeni;
    }
}