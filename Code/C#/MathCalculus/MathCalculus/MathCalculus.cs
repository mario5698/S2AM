using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MathCalculus
{
    public partial class MathCalculus : Form
    {
        int numero1 = 0, numero2 = 0;
        Calculus clc = new Calculus();
        public MathCalculus()
        {
            InitializeComponent();
            lbl_ResultCMD.Text = " ";
            LBL_Result_MCM.Text = " ";
        }

        private void btn_Number_Click(object sender, EventArgs e)
        {
            var seed = Environment.TickCount;
            var random = new Random();
            lbl_Num1.Text = random.Next(0, 10).ToString();
            lbl_num2.Text = random.Next(0, 40).ToString();
            numero1 =  int.Parse(lbl_Num1.Text);
            numero2 = int.Parse(lbl_num2.Text);
            lbl_ResultCMD.Text = " ";
            LBL_Result_MCM.Text = " ";
            lst_Results.DataSource = null;
        }

        private void btn_CMD_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_ResultCMD.Text = clc.getMCD(numero1, numero2).ToString();
            }
            catch (DivideByZeroException x )
            {
                MessageBox.Show(x.Message, "DivideByZeroException");
            }
        }

        private void btn_MCM_Click(object sender, EventArgs e)
        {
            try
            {
                LBL_Result_MCM.Text = clc.getMCM(numero1, numero2).ToString();
            }
            catch (DivideByZeroException x)
            {
                MessageBox.Show( x.ToString(), "DivideByZeroException");
            }
        }
        private void btn_Calculs_Click(object sender, EventArgs e)
        {
            if (butonsPressed())
            {

                List<int> listaCalculs = new List<int>();
                listaCalculs = clc.setCalculs(numero1, numero2);
                lst_Results.DataSource = listaCalculs;
            }
           
        }

        private bool butonsPressed()
        {
            bool butonPressed = false;
            if (lbl_ResultCMD.Text != " " && LBL_Result_MCM.Text != " ")
            {
                butonPressed = true;
            }
            return butonPressed;
        }
    }
}
