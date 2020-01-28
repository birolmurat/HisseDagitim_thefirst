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
            GetServiceInstances();
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
            GetServiceInstances();
            HisseSenedi_Sahipten senetForm = new HisseSenedi_Sahipten(_kullanici, this, _hisseSenediService.Get(Convert.ToInt32(dgwHisseView.CurrentRow.Cells[0].Value.ToString())));
            senetForm.Show();
            this.Hide();
        }

        

        private void btnBlokaj_Click(object sender, EventArgs e)
        {
            GetServiceInstances();
            foreach (var item in _hisseSenediService.GetAll().Where(p => p.HisseYili == (int)nudHisseYiliAra.Value && p.HisseTertipNo == (int)nudTertipNoAra.Value).ToList())
            {
                item.isGecerli = false;
                _hisseSenediService.Update(item);
            }
        }



        private void btnYeniHisseOlustur_Click(object sender, EventArgs e)
        {
            GetServiceInstances();
            try
            {
                int seri = 1;
                foreach (var hsahip in _hisseSahibiService.GetAll())
                {
                    _hisseSenediService.Add(new HisseSenedi
                    {
                        HisseDegeri = hsahip.ToplamHisseDegeri,
                        HisseNo = seri,
                        HisseTertipNo = (int)nudYeniHisseTertip.Value,
                        HisseYili = (int)nudYeniHisseYil.Value,
                        HisseSahibiID = hsahip.ID,
                        isGecerli = true,
                    });
                    seri++;
                }
                MessageBox.Show("Hisseler Oluşturuldu");

                foreach (var senet in _hisseSenediService.GetAll().Where(d => d.HisseYili == (int)nudYeniHisseYil.Value && d.HisseTertipNo == (int)nudYeniHisseTertip.Value).ToList())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _karPayiPuluService.Add(new KarPayiPulu
                        {
                            Carpan = 0m,
                            HisseSenediID = senet.HisseSahibiID,
                            isDagitildi = false,
                            Yil = i + senet.HisseYili
                        });
                    }
                    for (int j = 0; j < 15; j++)
                    {
                        _yeniPayPuluService.Add(new YeniPayPulu
                        {
                            Carpan = 0m,
                            HisseSenediID = senet.ID,
                            isDagitildi = false,
                            PulNo = 1 + j
                        });
                    }
                }
                MessageBox.Show("Pullar Oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Senetler Oluşturma Hatalı");
            }
        }

        private void btnTopluSilme_Click(object sender, EventArgs e)
        {
            GetServiceInstances();
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
