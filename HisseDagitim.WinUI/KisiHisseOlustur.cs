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
    public partial class KisiHisseOlustur : Form
    {
        private Kullanici _kullanici;
        private Form _form;
        private HisseSahibi _hisseSahibi;
        private IHisseSenediService _hisseSenediService;
        private IHisseSahibiService _hisseSahibiService;
        private IKarPayiPuluService _karPayiPuluService;
        private IYeniPayPuluService _yeniPayPuluService;
        private ILogService _logService;


        public KisiHisseOlustur(Kullanici kullanici, Form form, HisseSahibi hisseSahibi)
        {
            _kullanici = kullanici;
            _form = form;
            _hisseSahibi = hisseSahibi;
            GetServiceInstances();
            InitializeComponent();
        }

        private void GetServiceInstances()
        {
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
            _hisseSahibiService = InstanceFactory.GetInstance<IHisseSahibiService>();
            _karPayiPuluService = InstanceFactory.GetInstance<IKarPayiPuluService>();
            _yeniPayPuluService = InstanceFactory.GetInstance<IYeniPayPuluService>();
            _logService = InstanceFactory.GetInstance<ILogService>();
        }

        private void KisiHisseOlustur_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                HisseSenedi hsen = new HisseSenedi
                {
                    HisseDegeri = nudHSDeger.Value,
                    HisseSahibiID = _hisseSahibi.ID,
                    HisseTertipNo = (int)nudTertip.Value,
                    isGecerli = cbxBlokaj.Checked, //true >>> geçerli hisse, false >>> geçersiz hisse
                    HisseYili = (int)nudSene.Value,
                    HisseNo = (int)nudHisseNo.Value
                };

                _hisseSenediService.Add(hsen);
                MessageBox.Show("Hisse Eklendi");

                hsen = _hisseSenediService.GetLastHisse();

                for (int i = 0; i < 10; i++)
                {
                    _karPayiPuluService.Add(new KarPayiPulu 
                    {
                        HisseSenediID = hsen.ID,
                        isDagitildi = false,
                        Yil= hsen.HisseYili + i,
                        Carpan = 0m
                    });
                }
                MessageBox.Show("Kar Payı Pulları Eklendi");
                
                
                for (int j = 0; j < 15; j++)
                {
                    _yeniPayPuluService.Add(new YeniPayPulu 
                    { 
                        HisseSenediID = hsen.ID,
                        isDagitildi =false,
                        PulNo = 1 + j,
                        Carpan = 0m
                    });
                }
                MessageBox.Show("Yeni Pay Pulları Eklendi");

                _logService.Add(new Log 
                {
                    KullaniciID = _kullanici.ID,
                    Aciklama = _kullanici.KullaniciAdi + " , " + hsen.HisseDegeri.ToString() + " değerli, " + hsen.HisseYili.ToString() + " seneli, " + hsen.HisseTertipNo.ToString() + " tertip nolu, "+ hsen.HisseNo.ToString()+ " seri nolu hisseyi, " + _hisseSahibi.HSahipAdi + " hisse sahibine ekledi."
                });


            }
            catch (Exception)
            {
                MessageBox.Show("Hisse Ekleme Başarısız");;
            }
        }
    }
}
