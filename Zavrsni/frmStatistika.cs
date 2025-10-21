using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            int brU = 0;
            StreamReader sr = new StreamReader("udomitelji.txt");
            string linija = sr.ReadLine();
            while (linija != null)
            {
                brU++;
                linija = sr.ReadLine();
            }
            int broj = 0;
            StreamReader sR = new StreamReader("zivotinje.txt");
            string linije=sR.ReadLine();
            while (linije != null)
            {
                broj++;
                linije = sR.ReadLine();
            }
            sR.Close();
            int brojOstatka= broj - brU;
            textBox1.Text = broj.ToString();
            textBox5.Text = brojOstatka.ToString();
            textBox4.Text = brU.ToString();
            textBox3.Text = Admin.ProsjecnaDob().ToString();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vrsta=comboBox1.Text;
            textBox2.Text = Admin.BrojVrste(vrsta).ToString();
        }
    }
}
