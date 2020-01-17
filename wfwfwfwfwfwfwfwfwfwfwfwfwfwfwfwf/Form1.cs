using HisseDagitim.DAL.Contexts.EfContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfwfwfwfwfwfwfwfwfwfwfwfwfwfwfwf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HisseDagitimEntities db = new HisseDagitimEntities();

            db.HisseSahipleri.ToList();
            db.HisseSenetleri.ToList();
            db.KarPayiPullari.ToList();
            db.YeniPayPullari.ToList();
            db.Kullanicilar.ToList();
            db.Log.ToList();
        }
    }
}
