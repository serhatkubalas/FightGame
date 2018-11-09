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
    public partial class razon : Form
    {
        public razon()
        {
            InitializeComponent();
        }

       

        private void razon_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            if (sayac == 3)
            {
                Application.Exit();
            }
        }
    }
}
