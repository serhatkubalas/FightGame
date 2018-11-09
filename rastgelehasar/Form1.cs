using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgelehasar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBoxLeftHealth.Visible = false;
            pictureBoxRightHealth.Visible = false;
            labelRightHasar.Text = "Can Kaldı :" + progressBarRight.Value.ToString();
            labelLeftHasar.Text = "Can Kaldı :" + progressBarLeft.Value.ToString();

            
      
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
           
            if (progressBarRight.Value <= 19)
            {
                progressBarLeft.Value -= progressBarLeft.Value;
                progressBarLeft.Value = 100;
                progressBarRight.Value = 100;
                Form1 kapatilacak = new Form1();
                kapatilacak.Close();
                razon ac = new razon();
                ac.Show();
                this.Hide();

            }
            labelRightHasar.Visible = true;
            Random vuracak = new Random();
            int vur = vuracak.Next(1, 20);
            progressBarRight.Value -= vur;
          
            progressBarRight.Refresh();

            int progresright = progressBarRight.Value;
            labelRightHasar.Text = "Can Kaldı : " +progresright.ToString();
            buttonLeft.Enabled = false;
            buttonLeft.Text = "Rakibin Sırası";
            buttonRight.Enabled = true;
            buttonRight.Text = "Saldır";

            this.Invalidate();



            //soldaki razon
            //sağdaki kerven
        }

     

        private void buttonRight_Click(object sender, EventArgs e)
        {
            
           
           
             if (progressBarLeft.Value <= 19)
            {
                progressBarLeft.Value -= progressBarLeft.Value;
                progressBarLeft.Value = 100;
                progressBarRight.Value = 100;
                Form1 kapatilacak = new Form1();
                kapatilacak.Close();
                kerven ac = new kerven();
                ac.Show();
                this.Hide();
            }

            
            labelLeftHasar.Visible = true;
            Random vuracak = new Random();
            int vur = vuracak.Next(1, 20);
            progressBarLeft.Value -= vur;

            progressBarLeft.Refresh();

            int progresleft = progressBarLeft.Value;
            labelLeftHasar.Text = "Can Kaldı : " + progresleft.ToString();
            buttonRight.Enabled = false;
            buttonRight.Text = "Rakibin Sırası";
            buttonLeft.Enabled = true;
            buttonLeft.Text = "Saldır";

            this.Invalidate();

            // 19 Olayını Çöz (Yani 19 dan sonra direk hit atmasın rastgele devam brom gleince ayarla)

        }
        int hak = 1;
        int hak2 = 1;
        private void pictureBoxRightHealth_Click(object sender, EventArgs e)
        {

            
            if (hak == 1)
            {
                progressBarRight.Value = 100;
                pictureBoxRightHealth.Visible = false;
                labelRightHasar.Refresh();
                this.Refresh();
                int progresright = progressBarRight.Value;
                labelRightHasar.Text = "Can Kaldı : " + progresright.ToString();
            }
          
            else
	        {
                pictureBoxRightHealth.Visible = false;
            }
            int progresleft = progressBarLeft.Value;
            labelLeftHasar.Text = "Can Kaldı : " + progresleft.ToString();
            buttonRight.Enabled = false;
            buttonRight.Text = "Rakibin Sırası";
            buttonLeft.Enabled = true;
            buttonLeft.Text = "Saldır";
            hak--;
        }

        private void pictureBoxLeftHealth_Click(object sender, EventArgs e)
        {
            
            if (hak2 == 1)
            {
                progressBarLeft.Value = 100;
                pictureBoxLeftHealth.Visible = false;
                labelLeftHasar.Refresh();
                this.Refresh();
                int progresleft = progressBarLeft.Value;
                labelLeftHasar.Text = "Can Kaldı : " + progresleft.ToString();
            }
            else
            {
                pictureBoxLeftHealth.Visible = false;
            }
            hak2--;
            progressBarRight.Refresh();

            int progresright = progressBarRight.Value;
            labelRightHasar.Text = "Can Kaldı : " + progresright.ToString();
            buttonLeft.Enabled = false;
            buttonLeft.Text = "Rakibin Sırası";
            buttonRight.Enabled = true;
            buttonRight.Text = "Saldır";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarLeft.Value < 40 )
            {
                pictureBoxLeftHealth.Visible = true;
            }
             if (progressBarRight.Value < 40)
            {
                pictureBoxRightHealth.Visible = true;
            }
            if (hak == 0)
            {
                pictureBoxRightHealth.Visible = false;
            }
             if (hak2 == 0)
            {
                pictureBoxLeftHealth.Visible = false;
            }
            if (buttonLeft.Enabled == false)
            {
                pictureBoxLeftHealth.Enabled = false;

            }
            else
            {
                pictureBoxLeftHealth.Enabled = true;
            }
            if (buttonRight.Enabled == false)
            {
                pictureBoxRightHealth.Enabled = false;
            }
            else
            {
                pictureBoxRightHealth.Enabled = true;
            }
        }
    }
}
