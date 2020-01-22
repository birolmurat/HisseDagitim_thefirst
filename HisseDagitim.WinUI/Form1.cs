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
    public partial class Form1 : Form
    {
        private IHisseSahibiService _hsahipService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _hsahipService = InstanceFactory.GetInstance<IHisseSahibiService>();

            dataGridView1.DataSource = _hsahipService.GetAll();

        }
    }
}
