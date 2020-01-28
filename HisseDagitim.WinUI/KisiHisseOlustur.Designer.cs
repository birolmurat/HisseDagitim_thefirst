namespace HisseDagitim.WinUI
{
    partial class KisiHisseOlustur
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudSene = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTertip = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHisseNo = new System.Windows.Forms.NumericUpDown();
            this.cbxBlokaj = new System.Windows.Forms.CheckBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSDeger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hisse Değeri";
            // 
            // nudHSDeger
            // 
            this.nudHSDeger.DecimalPlaces = 2;
            this.nudHSDeger.Location = new System.Drawing.Point(99, 7);
            this.nudHSDeger.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudHSDeger.Name = "nudHSDeger";
            this.nudHSDeger.Size = new System.Drawing.Size(138, 20);
            this.nudHSDeger.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HisseYılı";
            // 
            // nudSene
            // 
            this.nudSene.Location = new System.Drawing.Point(99, 33);
            this.nudSene.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudSene.Name = "nudSene";
            this.nudSene.Size = new System.Drawing.Size(138, 20);
            this.nudSene.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tertip No";
            // 
            // nudTertip
            // 
            this.nudTertip.Location = new System.Drawing.Point(99, 59);
            this.nudTertip.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudTertip.Name = "nudTertip";
            this.nudTertip.Size = new System.Drawing.Size(138, 20);
            this.nudTertip.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hisse No";
            // 
            // nudHisseNo
            // 
            this.nudHisseNo.Location = new System.Drawing.Point(99, 85);
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
            this.cbxBlokaj.Location = new System.Drawing.Point(99, 111);
            this.cbxBlokaj.Name = "cbxBlokaj";
            this.cbxBlokaj.Size = new System.Drawing.Size(138, 17);
            this.cbxBlokaj.TabIndex = 3;
            this.cbxBlokaj.Text = "Hisse Geçerlilik Durumu";
            this.cbxBlokaj.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(15, 134);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(219, 23);
            this.btnOlustur.TabIndex = 6;
            this.btnOlustur.Text = "Hisse Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // KisiHisseOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHSDeger);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTertip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudHisseNo);
            this.Controls.Add(this.cbxBlokaj);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 217);
            this.Name = "KisiHisseOlustur";
            this.Text = "KisiHisseOlustur";
            this.Load += new System.EventHandler(this.KisiHisseOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHSDeger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHisseNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHSDeger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTertip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHisseNo;
        private System.Windows.Forms.CheckBox cbxBlokaj;
        private System.Windows.Forms.Button btnOlustur;
    }
}