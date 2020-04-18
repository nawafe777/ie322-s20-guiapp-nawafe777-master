using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void FrmRandom_Load(object sender, EventArgs e)
        {
            
        }

        private void btngeneraterandom_Click(object sender, EventArgs e)
        {
            btngeneraterandom.Text = Convert.ToString(y.Next(1, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngrn_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            label1.Text = Convert.ToString(r) + "_" + Convert.ToString(g) + "_" + Convert.ToString(b);
            btngrn.BackColor = Color.FromArgb(r, g, b);

        }
    }
}
