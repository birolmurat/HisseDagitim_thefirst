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
    public partial class IslemlerSayfasi : Form
    {
        private Kullanici _kullanici;
        private Giris _girisform;
        private IHisseSenediService _hisseSenediService;
        private IKarPayiPuluService _karPayiPuluService;
        private IYeniPayPuluService _yeniPayPuluService;
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
    }
}
