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
    public partial class kerven : Form
    {
        public kerven()
        {
            InitializeComponent();
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

        private void kerven_Load(object sender, EventArgs e)
        {

        }
    }
}
