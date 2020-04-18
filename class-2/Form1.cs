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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();

        }


        string username = "Atif";
        string myPassword = "1234"; 
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (TxtUser.Text != username)
                    {
                        
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   
                       		
                        if (TxtPassword.Text != myPassword)
                        {
                            
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            
                            attempt = 1; 
                            loggedIn = true;
                            MessageBox.Show("Hi " + username + ", your login successful");

                          

                            BtnLogin.Text = "Logout";
                           
                            break; 
                        }

                    }
                }
            }
            else
            {
                BtnLogin.Text = "Login";
                
                loggedIn = false;

                TxtUser.Clear();
                TxtPassword.Clear();

                
            }

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        
        private void BtnCombo_Click_1(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            Frmcheck frm = new Frmcheck();
            frm.ShowDialog();

        }

        private void BtnGeneraterand_Click(object sender, EventArgs e)
        {
            frmrandomcombo frm = new frmrandomcombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            Frmpick01 frm = new Frmpick01();
            frm.ShowDialog();

        }

        private void Array_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void BtnTalk_Click(object sender, EventArgs e)
        {

        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {

        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {

        }

        private void BtnGroupieApp_Click(object sender, EventArgs e)
        {

        }

        private void BtnProgress_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelfieApp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

