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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnosZivotinje frm2 = new frmUnosZivotinje();
            frm2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPregledZivotinja frm3=new frmPregledZivotinja();
            frm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFiltriranje frm4=new frmFiltriranje();
            frm4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUdomi frm5 =new frmUdomi();
            frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStatistika frm6 =new frmStatistika();
            frm6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
