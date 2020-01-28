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
        private IHisseSenediService _hisseSenediService;
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
            _hisseSenediService = InstanceFactory.GetInstance<IHisseSenediService>();
        }

        private void HisseSenediIslemleri_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
        }

        private void btnSenetAra_Click(object sender, EventArgs e)
        {
            dgwHisseView.DataSource = _hisseSenediService.GetAll().Where(p => p.HisseYili == (int)nudHisseYiliAra.Value && p.HisseTertipNo == (int)nudTertipNoAra.Value).ToList();

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
    }
}
