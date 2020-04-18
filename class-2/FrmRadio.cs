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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RDORed_CheckedChanged(object sender, EventArgs e)
        {
            if (RDORed.Checked == true)

            {
                RDORed.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
                RDORed.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RDOGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOGreen.Checked == true)

            {
                RDOGreen.ForeColor = Color.FromName("green");
            }
            else
                RDOGreen.ForeColor = Color.FromName("black");
        }

        private void RDOBlue_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (RDOBlue.Checked == true)
                    RDOBlue.ForeColor = Color.FromName("Blue");
                else
                    RDOBlue.ForeColor = Color.FromName("Black");
            }
        }

        private void RDOYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOYellow.Checked == true)
                RDOYellow.ForeColor = Color.FromName("Yellow");
            else
                RDOYellow.ForeColor = Color.FromName("Black");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RDOYellow.ForeColor = Color.FromName("Black");
            RDOBlue.ForeColor = Color.FromName("Black");
            RDOGreen.ForeColor = Color.FromName("Black");
            RDORed.ForeColor = Color.FromName("Black");
            RDOYellow2.ForeColor = Color.FromName("Black");
            RDOBlue2.ForeColor = Color.FromName("Black");
            RDOGreen2.ForeColor = Color.FromName("Black");
            RDORed2.ForeColor = Color.FromName("Black");



        }

        private void RDORed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDORed2.Checked == true)

            {
                RDORed2.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
                RDORed2.ForeColor = Color.FromArgb(255, 0, 0);


        }

        private void RDOGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOGreen2.Checked == true)

            {
                RDOGreen2.ForeColor = Color.FromName("green");
            }
            else
                RDOGreen2.ForeColor = Color.FromName("black");

        }

        private void RDOBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOBlue2.Checked == true)
                RDOBlue2.ForeColor = Color.FromName("Blue");
            else
                RDOBlue2.ForeColor = Color.FromName("Black");

        }

        private void RDOYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOYellow2.Checked == true)
                RDOYellow2.ForeColor = Color.FromName("Yellow");
            else
                RDOYellow2.ForeColor = Color.FromName("Black");

        }
    }
    }
