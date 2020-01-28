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
    public partial class HisseSenediIslemleri : Form
    {
        private Kullanici _kullanici;
        private IslemlerSayfasi _islemlerSayfasiForm;
        private IHisseSahibiService _hisseSahibiService;
        private IHisseSenediService _hisseSenediService;
        private IKarPayiPuluService _karPayiPuluService;
        private IYeniPayPuluService _yeniPayPuluService;
        //private List<HisseSenedi> _hsList;

        public HisseSenediIslemleri(Kullanici kullanici, IslemlerSayfasi islemlerSayfasiForm)
        {
            _kullanici = kullanici;
            _islemlerSayfasiForm = islemlerSayfasiForm;
            InitializeComponent();
            GetServiceInstances();
        }

        private void GetServiceInstances()
        {
            _hisseSahibiService = InstanceFactory.GetInstance<IHisseSahibiService>();
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
            _karPayiPuluService = InstanceFactory.GetInstance<IKarPayiPuluService>();
            _yeniPayPuluService = InstanceFactory.GetInstance<IYeniPayPuluService>();
        }

        private void HisseSenediIslemleri_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
        }

        private void btnSenetAra_Click(object sender, EventArgs e)
        {
            dgwHisseView.DataSource = _hisseSenediService.GetAll().Where(p => p.HisseYili == (int)nudHisseYiliAra.Value && p.HisseTertipNo == (int)nudTertipNoAra.Value).ToList();
            nudBloksilTertip.Value = nudTertipNoAra.Value;
            nudBloksilYil.Value = nudHisseYiliAra.Value;
        }

        private void HisseSenediIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            _islemlerSayfasiForm.Show();
        }

        private void dgwHisseView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HisseSenedi_Sahipten senetForm = new HisseSenedi_Sahipten(_kullanici, this, _hisseSenediService.Get(Convert.ToInt32(dgwHisseView.CurrentRow.Cells[0].Value.ToString())));
            senetForm.Show();
            this.Hide();
        }

        

        private void btnBlokaj_Click(object sender, EventArgs e)
        {
            foreach (var item in _hisseSenediService.GetAll().Where(p => p.HisseYili == (int)nudHisseYiliAra.Value && p.HisseTertipNo == (int)nudTertipNoAra.Value).ToList())
            {
                item.isGecerli = false;
                _hisseSenediService.Update(item);
            }
        }



        private void btnYeniHisseOlustur_Click(object sender, EventArgs e)
        {
            foreach (var hsahip in _hisseSahibiService.GetAll())
            {

            }
        }

        private void btnTopluSilme_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _hisseSenediService.GetAll().Where(p => p.HisseYili == (int)nudHisseYiliAra.Value && p.HisseTertipNo == (int)nudTertipNoAra.Value).ToList())
                {
                    foreach (var karp in _karPayiPuluService.GetAll().Where(x => x.HisseSenediID == item.ID))
                    {
                        _karPayiPuluService.Delete(karp);
                    }
                    foreach (var yenip in _yeniPayPuluService.GetAll().Where(y => y.HisseSenediID == item.ID))
                    {
                        _yeniPayPuluService.Delete(yenip);
                    }
                    _hisseSenediService.Delete(item);
                }
                MessageBox.Show("Silme Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Silme Başarısız");;
            }
        }
    }
}
