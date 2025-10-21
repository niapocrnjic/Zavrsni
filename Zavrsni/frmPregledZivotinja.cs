using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class frmPregledZivotinja : Form
    {
        public frmPregledZivotinja()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmPregledZivotinja_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.Svi();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ziv = comboBox1.Text;
            listBox1.DataSource = Admin.Vrsta(ziv);
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string linija = listBox1.SelectedItem.ToString();
            if(linija!=null)
            {
                string[]dijelovi=linija.Split('|');
                if(dijelovi.Length>9)
                {
                    string putanjaSlike = dijelovi[9].Trim();
                    if(System.IO.File.Exists(putanjaSlike))
                    {
                        pictureBox1.Image = Image.FromFile(putanjaSlike);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
        }

    }
       
}
