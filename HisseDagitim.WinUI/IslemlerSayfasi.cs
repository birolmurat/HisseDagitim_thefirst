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
    public partial class IslemlerSayfasi : Form
    {
        private Kullanici _kullanici;
        private Giris _girisform;
        private IHisseSenediService _hisseSenediService;
        private IKarPayiPuluService _karPayiPuluService;
        private IYeniPayPuluService _yeniPayPuluService;
        private ILogService _logService;
        public IslemlerSayfasi(Kullanici kullanici, Giris girisform)
        {
            _kullanici = kullanici;
            _girisform = girisform;
            InitializeComponent();
            GetServiceInstances();
        }

        private void IslemlerSayfasi_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
        }

        private void GetServiceInstances()
        {
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
            _karPayiPuluService = InstanceFactory.GetInstance<IKarPayiPuluService>();
            _yeniPayPuluService = InstanceFactory.GetInstance<IYeniPayPuluService>();
            _logService = InstanceFactory.GetInstance<ILogService>();
        }

        private void btnHSahipIslemleri_Click(object sender, EventArgs e)
        {
            HSahipIslemleri hSahipIslem = new HSahipIslemleri(_kullanici, this);
            hSahipIslem.Show();
            this.Hide();
        }

        private void IslemlerSayfasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            _girisform.Show();
        }

        private void btnHSenetIslemleri_Click(object sender, EventArgs e)
        {
            HisseSenediIslemleri hSenetIslemForm = new HisseSenediIslemleri(_kullanici,this);
            hSenetIslemForm.Show();
            this.Hide();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            if (_kullanici.Role == Roles.admin)
            {

                KullaniciIslemleri kullaniciIslemleriForm = new KullaniciIslemleri(_kullanici, this);
                kullaniciIslemleriForm.Show();
                this.Hide();
                _logService.Add(new Log
                {
                    KullaniciID = _kullanici.ID,
                    Aciklama = _kullanici.KullaniciAdi + " kullanıcısı kullanıcı işlemlerine giriş yaptı."
                });
            }
        }

        private void btnIslemKaydi_Click(object sender, EventArgs e)
        {
            if (_kullanici.Role == Roles.admin)
            {

                LogsForm logsForm = new LogsForm(_kullanici, this);
                logsForm.Show();
                this.Hide();
            }
        }
    }
}
