using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled=true;
            timer1.Interval = 300;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            number = number + 1;
            if (number == 100){
                Form f2 = new Form();
                f2.Show();
                timer1.Enabled =false;
                this.Close();
            }
            progressBar1.Value = number;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
