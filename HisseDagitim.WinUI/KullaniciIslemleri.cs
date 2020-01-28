using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
using HisseDagitim.Model.Enums;
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
    public partial class KullaniciIslemleri : Form
    {
        private Kullanici _kullanici;
        private IslemlerSayfasi _islemlerSayfasiForm;
        private IKullaniciService _kullaniciService;
        private ILogService _logService;
        private Kullanici inForm_kullanici; // kullanici işlemleri için
        public KullaniciIslemleri(Kullanici kullanici, IslemlerSayfasi islemlerSayfasiForm)
        {
            _kullanici = kullanici;
            _islemlerSayfasiForm = islemlerSayfasiForm;
            InitializeComponent();
            GetServiceInstances();
        }
        private void GetServiceInstances()
        {
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _logService = InstanceFactory.GetInstance<ILogService>();
        }


        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
            LoadDGWKullanici();
        }

        private void LoadDGWKullanici()
        {
            dgwKullanici.DataSource = _kullaniciService.GetAll();
        }


        private void dgwKullanici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            inForm_kullanici = _kullaniciService.GetKullaniciByID(Convert.ToInt32(dgwKullanici.CurrentRow.Cells[0].Value.ToString()));
            tbxKullaniciAktivasyon.Text = inForm_kullanici.KullaniciAdi;
            tbxKullaniciDeaktivasyon.Text = inForm_kullanici.KullaniciAdi;
            tbxGuncelAd.Text = inForm_kullanici.KullaniciAdi;
            tbxGuncelParola.Text = inForm_kullanici.Password;
            cbxGuncelAdmin.Checked = false;
            if (inForm_kullanici.Role == Roles.admin)
            {
                cbxGuncelAdmin.Checked = true;
            }
            _logService.Add( new Log
            {
                KullaniciID = _kullanici.ID,
                Aciklama = _kullanici.KullaniciAdi + " kullanıcısı, " + inForm_kullanici.KullaniciAdi + " kullanıcısını seçti"
            });
            
        }

        private void KullaniciIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            _islemlerSayfasiForm.Show();
        }

        private void btnEkleKullaniciYeni_Click(object sender, EventArgs e)
        {
            if (_kullaniciService.GetKullaniciByName(tbxKullaniciAdi.Text)==null && tbxKullaniciAdi.Text != string.Empty)
            {
                Roles role = Roles.normal;
                if (cbxAdminMi.Checked)
                {
                    role = Roles.admin;
                }
                _kullaniciService.Add(new Kullanici
                {
                    KullaniciAdi = tbxKullaniciAdi.Text,
                    Password = tbxParola.Text,
                    isGecerli = true,
                    Role = role
                });
                MessageBox.Show("Kullanıcı Eklendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı Ekleme Başarısız");
            }
            LoadDGWKullanici();
        }

        private void btnGuncelleKullanici_Click(object sender, EventArgs e)
        {
            string kAdiFormer = inForm_kullanici.KullaniciAdi;
            string kPasswordFormer = inForm_kullanici.Password;
            Roles kRoleFormer = inForm_kullanici.Role;
            bool kGecerliFormer = inForm_kullanici.isGecerli;
            
            inForm_kullanici.KullaniciAdi = tbxGuncelAd.Text;
            inForm_kullanici.Password = tbxGuncelParola.Text;
            inForm_kullanici.Role = Roles.normal;
            if (cbxGuncelAdmin.Checked)
            {
                inForm_kullanici.Role = Roles.admin;
            }
            _kullaniciService.Update(inForm_kullanici);
            _logService.Add(new Log
            {
                KullaniciID = _kullanici.ID,
                Aciklama = (_kullanici.KullaniciAdi + " kullanıcısı, " + kAdiFormer + "kullanıcısı hakkında işlem yaptı. " + " ; " + kAdiFormer + " --> " + inForm_kullanici.KullaniciAdi + " ; " + kPasswordFormer + " --> " + inForm_kullanici.Password + " ; " + kRoleFormer.ToString() + " --> " + inForm_kullanici.Role.ToString() + " ; " + kGecerliFormer.ToString() + " --> " + inForm_kullanici.isGecerli.ToString()) + " ; "
            });
            MessageBox.Show("Kullanıcı Güncellendi");
            LoadDGWKullanici();
        }

        private void tbxK_Ara_TextChanged(object sender, EventArgs e)
        {
            dgwKullanici.DataSource = _kullaniciService.GetAll().Where(p => p.KullaniciAdi.Contains(tbxK_Ara.Text)).ToList();
        }

        private void btnDeaktif_Click(object sender, EventArgs e)
        {
            inForm_kullanici.isGecerli = false;
            _kullaniciService.Update(inForm_kullanici);
            LoadDGWKullanici();
            _logService.Add(new Log
            {
                KullaniciID = _kullanici.ID,
                Aciklama = _kullanici.KullaniciAdi + " kullanıcısı, " + inForm_kullanici.KullaniciAdi + " kullanıcısını deaktive etti"
            });
            MessageBox.Show("Kullanıcı Deaktive Edildi");
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            inForm_kullanici.isGecerli = true;
            _kullaniciService.Update(inForm_kullanici);
            LoadDGWKullanici();
            _logService.Add(new Log
            {
                KullaniciID = _kullanici.ID,
                Aciklama = _kullanici.KullaniciAdi + " kullanıcısı, " + inForm_kullanici.KullaniciAdi + " kullanıcısını aktive etti"
            });
            MessageBox.Show("Kullanıcı Aktive Edildi");
        }
    }
}
