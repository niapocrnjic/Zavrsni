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
    public partial class frmUdomi : Form
    {
        public frmUdomi()
        {
            InitializeComponent();
        }

        private void frmUdomi_Load(object sender, EventArgs e)
        {
            lstZiv = Admin.listaSvihZivotinja();
            textBox3.Text = lstZiv[i].Ime;
            textBox4.Text = lstZiv[i].Vrsta;
            textBox6.Text = lstZiv[i].Pasmina;
            textBox7.Text = lstZiv[i].Dob;
            if (System.IO.File.Exists(lstZiv[i].Slika))
                pictureBox1.Load( lstZiv[i].Slika);
            else
            {
                pictureBox1.Load("nema.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija = textBox1.Text + "|" + textBox2.Text + "|" + dateTimePicker1.Text;
            Admin.SpremiUdomitelje(linija);
            textBox1.Text = " "; 
            textBox2.Text = " ";
            MessageBox.Show("Uspješno udomljavanje!");
            lstZiv = Admin.listaSvihZivotinja();
            textBox3.Text = lstZiv[i].Ime;
            textBox4.Text = lstZiv[i].Vrsta;
            textBox6.Text = lstZiv[i].Pasmina;
            textBox7.Text=lstZiv[i].Dob;
            if (System.IO.File.Exists(lstZiv[i].Slika))
                pictureBox1.Load(lstZiv[i].Slika);
            else
            {
                pictureBox1.Load("nema.jpg");
            }


        }

        List<Zivotinja> lstZiv;
        int i = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            try
            {
                textBox3.Text = lstZiv[i].Ime;
                textBox4.Text = lstZiv[i].Vrsta;
                textBox6.Text = lstZiv[i].Pasmina;
                textBox7.Text = lstZiv[i].Dob;
                if (System.IO.File.Exists(lstZiv[i].Slika))
                    pictureBox1.Load(lstZiv[i].Slika);
                else
                {
                    pictureBox1.Load("nema.jpg");
                }
            }
            catch
            {
                MessageBox.Show("Nema više životinja");
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            try
            {
                textBox3.Text = lstZiv[i].Ime;
                textBox4.Text = lstZiv[i].Vrsta;
                textBox6.Text = lstZiv[i].Pasmina;
                textBox7.Text = lstZiv[i].Dob;
                if (System.IO.File.Exists(lstZiv[i].Slika))
                    pictureBox1.Load(lstZiv[i].Slika);
                else
                {
                    pictureBox1.Load("nema.jpg");
                }
            }
            catch
            {
                MessageBox.Show("Nema više životinja");
                i--;
            }

            }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
