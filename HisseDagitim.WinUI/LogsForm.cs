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
    public partial class LogsForm : Form
    {
        private Kullanici _kullanici;
        private IslemlerSayfasi _form;
        private ILogService _logService;

        //public List<Log> logListCrossReference = new List<Log>(); 

        public LogsForm(Kullanici kullanici, IslemlerSayfasi form)
        {
            _kullanici = kullanici;
            _form = form;
            InitializeComponent();
            GetServiceInstances();
        }

        private void DGWShowNeededOnly()
        {
            dgwLogs.Columns.Remove("KullaniciID");
            dgwLogs.Columns.Remove("Kullanici");
            dgwLogs.Columns[1].Width = 700;
        }

        private void GetServiceInstances()
        {
            _logService = InstanceFactory.GetInstance<ILogService>();

        }

        private void LoadLogDGW(string kAdi, string lAciklama, DateTime basla , DateTime bitis )
        {

            if (cbxTarih.Checked)
            {
                List<Log> logList = new List<Log>();
                foreach (var item in _logService.GetAll().Where(p => p.Kullanici.KullaniciAdi.Contains(kAdi) && p.Aciklama.Contains(rtbxAciklama.Text) && p.OlusturmaTarihi > bitis && p.OlusturmaTarihi < basla).Reverse<Log>())
                {
                    logList.Add(item);
                    if (logList.Count == 40)
                    {
                        break;
                    }
                }
                dgwLogs.DataSource = logList.ToList();
                DGWShowNeededOnly();
            }
            else
            {
                List<Log> logList = new List<Log>();
                foreach (var item in _logService.GetAll().Where(p => p.Kullanici.KullaniciAdi.Contains(kAdi) && p.Aciklama.Contains(rtbxAciklama.Text)).Reverse<Log>())
                {
                    logList.Add(item);
                    if (logList.Count == 40)
                    {
                        break;
                    }
                }
                dgwLogs.DataSource = logList.ToList();
                DGWShowNeededOnly();
            }

            
            
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            GetServiceInstances();
            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
        }

        private void LogsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Show();
        }


        private void tbxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
            //List<Log> logList = new List<Log>();

            //foreach (var item in _logService.GetAll().Where(p => p.Kullanici.KullaniciAdi.Contains(tbxKullaniciAdi.Text)).Reverse<Log>())
            //{
            //    logList.Add(item);
            //    if (logList.Count == 40)
            //    {
            //        break;
            //    }
            //}
            //dgwLogs.DataSource = logList.ToList();
        }

        private void cbxTarih_CheckedChanged(object sender, EventArgs e)
        {

            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
        }

        private void rtbxAciklama_TextChanged(object sender, EventArgs e)
        {

            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
        }

        private void datepickBaslangic_ValueChanged(object sender, EventArgs e)
        {

            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
        }

        private void datepickBitis_ValueChanged(object sender, EventArgs e)
        {

            LoadLogDGW(tbxKullaniciAdi.Text, rtbxAciklama.Text, datepickBaslangic.Value, datepickBitis.Value);
        }
    }
}
