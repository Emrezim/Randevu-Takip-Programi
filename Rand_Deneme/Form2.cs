using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rand_Deneme
{
    public partial class Form2 : Form
    {
        public Form2(DateTime randevuZamani, string isim, string detay)
        {
            InitializeComponent();
            labelTarih.Text =  randevuZamani.ToString("dd/MM/yyyy HH:mm");
            labelIsim.Text =  isim;
            labelDetay.Text =  detay;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
