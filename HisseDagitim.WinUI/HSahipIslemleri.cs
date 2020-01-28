using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.Model.Somut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HisseDagitim.WinUI
{
    public partial class HSahipIslemleri : Form
    {
        private Kullanici _kullanici;
        private IslemlerSayfasi _islemlerSayfasi;
        private IHisseSahibiService _hisseSahibiService;
        private IHisseSenediService _hisseSenediService;
        private ILogService _logService;
        public HSahipIslemleri(Kullanici kullanici, IslemlerSayfasi islemlerSayfasi)
        {
            _kullanici = kullanici;
            _islemlerSayfasi = islemlerSayfasi;
            GetInstancesToRefresh();
            InitializeComponent();
        }

        private void GetInstancesToRefresh()
        {

            _logService = InstanceFactory.GetInstance<ILogService>();
            _hisseSahibiService = InstanceFactory.GetInstance<IHisseSahibiService>();
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
        }

        private void HSahipIslemleri_Load(object sender, EventArgs e)
        {
            GetInstancesToRefresh();
            LoadDGWHSahip();
        }

        private void LoadDGWHSahip()
        {
            GetInstancesToRefresh();
            dgwHSahip.DataSource = _hisseSahibiService.GetAll();
            ShowNeededOnlyDGWHSahip();
        }

        private void tbxIsimAra_TextChanged(object sender, EventArgs e)
        {
            dgwHSahip.DataSource = _hisseSahibiService.GetHisseSahibiByName(tbxIsimAra.Text);
            ShowNeededOnlyDGWHSahip();
        }

        private void ShowNeededOnlyDGWHSahip()
        {
            dgwHSahip.Columns.Remove("ID");
            dgwHSahip.Columns.Remove("Adres");
            dgwHSahip.Columns.Remove("Telefon");
            dgwHSahip.Columns.Remove("Email");
            dgwHSahip.Columns.Remove("OlusturmaTarihi");
            dgwHSahip.Columns[0].HeaderText = "Hisse Sahibi";
            dgwHSahip.Columns[1].HeaderText = "TCKN - Vergi No";
            dgwHSahip.Columns[2].HeaderText = "Tüzel Durumu";
        }

        private void tbxNoAra_TextChanged(object sender, EventArgs e)
        {
            GetInstancesToRefresh();
            dgwHSahip.DataSource = _hisseSahibiService.GetHisseSahibiByTCKN_VergiNo(tbxNoAra.Text);
            ShowNeededOnlyDGWHSahip();
        }

        private void HSahipIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            _islemlerSayfasi.Show();
        }

        
        private void dgwHSahip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInstancesToRefresh();
            HisseSahibi hs = _hisseSahibiService.GetAll().FirstOrDefault(p => p.HSahipAdi == dgwHSahip.CurrentRow.Cells[0].Value.ToString());
            if (hs.Hisseler.ToList() != null)
            {
                dgwKisiHisse.DataSource = _hisseSenediService.GetAll().Where(p=>p.HisseSahibiID == hs.ID).ToList();
                tbxHSIsim.Text = hs.HSahipAdi;
                tbxEMail.Text = hs.Email;
                rtbxAdres.Text = hs.Adres;
                tbxTelefon.Text = hs.Telefon;
                tbxTC_Vergi.Text = hs.TCKN_VergiNo;
                cbxTuzel.Checked = hs.isTuzel;
            }
            else
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HisseSahibi hs = new HisseSahibi();
            hs.HSahipAdi = tbxHSIsim.Text;
            hs.Email = tbxEMail.Text;
            hs.Adres = rtbxAdres.Text;
            hs.Telefon = tbxTelefon.Text;
            hs.TCKN_VergiNo = tbxTC_Vergi.Text;
            hs.isTuzel = cbxTuzel.Checked;
            if (_hisseSahibiService.GetSahibi(tbxHSIsim.Text) == null)
            {
                _hisseSahibiService.Add(hs);
                //Log log_t = new Log();

                //log_t.Aciklama = _kullanici.KullaniciAdi + " , " + hs.HSahipAdi + " adlı hisse sahibini ekledi.";
                //log_t.KullaniciID = _kullanici.ID;

                _logService.Add(new Log
                {
                    KullaniciID = _kullanici.ID,
                    Aciklama = _kullanici.KullaniciAdi + " , " + hs.HSahipAdi + " adlı hisse sahibini ekledi.",
                }); ;

                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Bu hisse sahibi zaten bulunmaktadır.");
            }
            LoadDGWHSahip();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (_hisseSahibiService.GetSahibi(tbxHSIsim.Text)!=null)
            {
                
                try
                {
                    HisseSahibi hs = _hisseSahibiService.GetSahibi(tbxHSIsim.Text);
                    _logService.Add(new Log
                    {
                        KullaniciID = _kullanici.ID,
                        Aciklama = _kullanici.KullaniciAdi + " , " + _hisseSahibiService.GetSahibi(tbxHSIsim.Text).HSahipAdi.ToString() + " adlı hisse sahibini güncelledi."
                    });

                    hs.HSahipAdi = tbxHSIsim.Text;
                    hs.Email = tbxEMail.Text;
                    hs.Adres = rtbxAdres.Text;
                    hs.Telefon = tbxTelefon.Text;
                    hs.TCKN_VergiNo = tbxTC_Vergi.Text;
                    hs.isTuzel = cbxTuzel.Checked;
                    MessageBox.Show("Güncellendi");
                    _hisseSahibiService.Update(hs);
                    LoadDGWHSahip();
                }
                catch (Exception)
                {

                    MessageBox.Show("Düzenleme Başarısız");;
                }
            }
            else
            {
                MessageBox.Show("Bu hisse sahibi bulunmamaktadır.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_hisseSahibiService.GetSahibi(tbxHSIsim.Text) != null)
            {

                try
                {
                    _logService.Add(new Log
                    {
                        KullaniciID = _kullanici.ID,
                        Aciklama = _kullanici.KullaniciAdi + " , " + _hisseSahibiService.GetSahibi(tbxHSIsim.Text).HSahipAdi + " adlı hisse sahibini sildi.",
                    });
                    _hisseSahibiService.Delete(_hisseSahibiService.GetSahibi(tbxHSIsim.Text));
                    LoadDGWHSahip();
                    MessageBox.Show("Silindi");

                }
                catch (Exception)
                {
                    MessageBox.Show("Silme Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Bu hisse sahibi bulunmamaktadır.");
            }
            LoadDGWHSahip();
        }

        private void dgwKisiHisse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            HisseSenedi_Sahipten senetForm = new HisseSenedi_Sahipten(_kullanici, this, _hisseSenediService.Get(Convert.ToInt32(dgwKisiHisse.CurrentRow.Cells[0].Value.ToString())));
            senetForm.Show();
            this.Hide();
        }

        private void btnHisseSec_Click(object sender, EventArgs e)
        {
            HisseSenedi_Sahipten senetForm = new HisseSenedi_Sahipten(_kullanici, this, _hisseSenediService.Get(Convert.ToInt32(dgwKisiHisse.CurrentRow.Cells[0].Value.ToString())));
            senetForm.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxEMail.Text = string.Empty;
            tbxHSIsim.Text = string.Empty;
            tbxIsimAra.Text = string.Empty;
            tbxNoAra.Text = string.Empty;
            tbxTC_Vergi.Text = string.Empty;
            tbxTelefon.Text = string.Empty;
            rtbxAdres.Text = string.Empty;
            LoadDGWHSahip();
        }

        private void btnHisseOlustur_Click(object sender, EventArgs e)
        {
            if (_hisseSahibiService.GetSahibi(tbxHSIsim.Text)!=null)
            {
                KisiHisseOlustur kisiHisseOlusturForm = new KisiHisseOlustur(_kullanici, this, _hisseSahibiService.GetSahibi(tbxHSIsim.Text));
                kisiHisseOlusturForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Kişi Seçiniz");
            }
        }
    }
}
