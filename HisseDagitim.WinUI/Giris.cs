using HisseDagitim.BLL.DependencyResolvers.Ninject;
using HisseDagitim.BLL.Soyut;
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
    public partial class Giris : Form
    {
        private IKullaniciService _kullaniciService;
        private void Giris_Load(object sender, EventArgs e)
        {
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            //Enable-Migrations -ProjectName MyContextProjectNameHere -StartUpProjectName MyStartUpProjectNameHere -Verbose

        }

        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (_kullaniciService.GetKullanici(tbxKullaniciAdi.Text, tbxParola.Text)!=null&& _kullaniciService.GetKullanici(tbxKullaniciAdi.Text, tbxParola.Text).isGecerli)
            {
                IslemlerSayfasi islemForm = new IslemlerSayfasi(_kullaniciService.GetKullanici(tbxKullaniciAdi.Text, tbxParola.Text), this);
                islemForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Veya Deaktif Kullanıcı");
            }
            
        }
    }
}
