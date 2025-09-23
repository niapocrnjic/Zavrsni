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
    }
}
