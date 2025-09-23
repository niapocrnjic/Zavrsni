using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Zavrsni
{
    public partial class frmUnosZivotinje : Form
    {
        public frmUnosZivotinje()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spol;
            if(radioButton1.Checked=true)
            {
                spol="M";
            }
            else
            {
                spol="Z";
            }
            string cijepljen;
            if (checkBox1.Checked == true)
            {
                cijepljen="cijepljen";

            }
            else
            {
                               cijepljen="nije cijepljen";
            }
            string kastriran;
            if(checkBox2.Checked == true)
            {
                kastriran="kastriran";
            }
            else
            {
                kastriran="nije kastriran";
            }

            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + spol + "|" + numericUpDown1.Value + "|" + dateTimePicker1.Value + "|"+cijepljen+"|" +kastriran+"|"+textBox4.Text;    
            Admin.UnosUdatoteku(zapis);
            MessageBox.Show("Podaci su spremljeni");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            numericUpDown1.Value = 0;
            dateTimePicker1.Value = DateTime.Now;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
