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
    public partial class HisseSenedi_Sahipten : Form
    {
        private IHisseSenediService _hisseSenediService;
        private IYeniPayPuluService _yeniPayPuluService;
        private IKarPayiPuluService _karPayiPuluService;
        private IHisseSahibiService _hisseSahibiService;
        private Kullanici _kullanici;
        private Form _form;
        private HisseSenedi _hisseSenedi;
        private ILogService _logService;
        private KarPayiPulu _kpp;
        private YeniPayPulu _ypp;


        public HisseSenedi_Sahipten(Kullanici kullanici, Form form, HisseSenedi hisseSenedi)
        {
            

            _form = form;
            _kullanici = kullanici;
            _hisseSenedi = hisseSenedi;

            GetServiceInstances();
            InitializeComponent();
        }

        private void GetServiceInstances()
        {
            _karPayiPuluService = InstanceFactory.GetInstance<IKarPayiPuluService>();
            _yeniPayPuluService = InstanceFactory.GetInstance<IYeniPayPuluService>();
            _logService = InstanceFactory.GetInstance<ILogService>();
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
            _hisseSahibiService = InstanceFactory.GetInstance<IHisseSahibiService>();
        }
        
        private void HisseSenedi_Sahipten_Load(object sender, EventArgs e)
        {
            GetServiceInstances();

            nudHSDeger.Value = _hisseSenedi.HisseDegeri;
            nudSene.Value = _hisseSenedi.HisseYili;
            nudTertip.Value = _hisseSenedi.HisseTertipNo;
            nudHisseNo.Value = _hisseSenedi.HisseNo;
            cbxBlokaj.Checked = _hisseSenedi.isGecerli;

            LoadDGWs();
        }

        private void LoadDGWs()
        {
            dgwKar.DataSource = _karPayiPuluService.GetAll().Where(p=>p.HisseSenediID == _hisseSenedi.ID).ToList();
            dgwYeni.DataSource = _yeniPayPuluService.GetAll().Where(p => p.HisseSenediID == _hisseSenedi.ID).ToList();
        }

        private void HisseSenedi_Sahipten_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                _logService.Add(new Log
                {
                    KullaniciID = _kullanici.ID,
                    Aciklama = _kullanici.KullaniciAdi + ", " + _hisseSenedi.HisseSahibi.ToString() + " kişisine ait " + _hisseSenedi.ID.ToString() + " ID sine sahip hisseyi günelledi." + _hisseSenedi.HisseDegeri.ToString() + "-" + nudHSDeger.Value.ToString() + " ; " + _hisseSenedi.HisseYili.ToString() + "-" + nudSene.Value.ToString() + " ; " +
                    _hisseSenedi.HisseTertipNo.ToString() + "-" + nudTertip.Value.ToString() + " ; " +
                    _hisseSenedi.HisseNo.ToString() + "-" + nudHisseNo.Value.ToString() + " ; " +
                    _hisseSenedi.isGecerli.ToString() + "-" + cbxBlokaj.Checked.ToString()
                });
                HisseSenedi hsen = _hisseSenediService.Get(_hisseSenedi.ID);

                //_hisseSenediService.Update(new HisseSenedi
                //{
                //    ID = _hisseSenedi.ID,
                //    HisseSahibiID = _hisseSenedi.HisseSahibi.ID,
                //    HisseDegeri = nudHSDeger.Value,
                //    HisseYili = (int)nudSene.Value,
                //    HisseTertipNo = (int)nudTertip.Value,
                //    HisseNo = (int)nudHisseNo.Value,
                //    isGecerli = cbxBlokaj.Checked,
                //});;

                hsen.HisseDegeri = nudHSDeger.Value;
                hsen.HisseYili = (int)nudSene.Value;
                hsen.HisseTertipNo = (int)nudTertip.Value;
                hsen.HisseNo = (int)nudHisseNo.Value;
                hsen.isGecerli = cbxBlokaj.Checked;
                _hisseSenediService.Update(hsen);
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Başarısız");
            }
        }


        private void dgwKar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _kpp = _karPayiPuluService.GetKarPayi(Convert.ToInt32(dgwKar.CurrentRow.Cells[0].Value.ToString()));
            nudKarSenesi.Value = _kpp.Yil;
            nudKarCarpan.Value = _kpp.Carpan;
        }

        private void dgwYeni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ypp = _yeniPayPuluService.GetYeniPay(Convert.ToInt32(dgwYeni.CurrentRow.Cells[0].Value.ToString()));
            nudPayNo.Value = _ypp.PulNo;
            nudPayCarpan.Value = _ypp.Carpan;
        }
       
        private void btnKarPayiDagit_Click(object sender, EventArgs e)
        {
            DialogResult d_res = MessageBox.Show("Bu işlem geri alınamaz", "Onayla", MessageBoxButtons.OKCancel);
            if (d_res == DialogResult.OK)
            {
                _kpp.isDagitildi = cbxKar.Checked;
                _kpp.Carpan = nudKarCarpan.Value;
                _logService.Add(new Log{ 
                    KullaniciID=_kullanici.ID,
                    Aciklama = (_kullanici.KullaniciAdi + " kullanıcısı, " + _hisseSenedi.ID.ToString() + " hisse IDsine sahip hissenin, " + _kpp.Yil.ToString() + " senesine ait kar payını güncelledi. " + " Çarpan: " + _kpp.Carpan.ToString() + " Dağıtılma durumu: " + _kpp.isDagitildi.ToString())
                });
                _karPayiPuluService.Update(_kpp);
                GetServiceInstances();
                LoadDGWs();
            }
            else
            {
                GetServiceInstances();
                LoadDGWs();
            }
        }


        private void btnPayDagit_Click(object sender, EventArgs e)
        {
            DialogResult d_res = MessageBox.Show("Bu işlem geri alınamaz", "Onayla", MessageBoxButtons.OKCancel);
            if (d_res == DialogResult.OK)
            {
                _ypp.isDagitildi = cbxYeni.Checked;
                _ypp.Carpan = nudPayCarpan.Value;
                _logService.Add(new Log
                {
                    KullaniciID = _kullanici.ID,
                    Aciklama = (_kullanici.KullaniciAdi + " kullanıcısı, " + _hisseSenedi.ID.ToString() + " hisse IDsine sahip hissenin, " + _ypp.PulNo.ToString() + " senesine ait yeni pay pulunu güncelledi. " + " Çarpan: " + _ypp.Carpan.ToString() + " Dağıtılma durumu: " + _ypp.isDagitildi.ToString())
                });
                _yeniPayPuluService.Update(_ypp);
                GetServiceInstances();
                LoadDGWs();
            }
            else
            {
                GetServiceInstances();
                LoadDGWs();
            }
        }
    }
}
