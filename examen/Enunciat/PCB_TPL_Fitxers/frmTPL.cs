using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCB_TPL_Fitxers
{
    public partial class frmTPL : Form
    {
        Thread hilo1 ;
        string lletresA=null;
        string ruta = Application.StartupPath + "\\";
        public frmTPL()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnTPL_Click(object sender, System.EventArgs e)
        {
            hilo1 = new Thread(new ThreadStart(StartProcess));
            hilo1.Start();
        }

        private void StartProcess()
        {
            string[] fitxers = new string[3] {"Lletres1.txt", "Lletres2.txt", "Lletres3.txt"};
            Label[] text = new Label[3] {label1,label2,label3 };
            string[] lletresAX = new string[fitxers.Length];            

            Parallel.For(0, fitxers.Length, (i, state)=>
            {
                llegirFitxer(fitxers[i], i + 1, text[i],lletresAX,i);
            });
            concatenarLetres(lletresAX);
        }

        private void llegirFitxer(string nomFitxer, int numero, Label label, string[] letrasAX, int posicion)
        {
            bool final = false;
            string caracter=null;
            string AX = "";
            StreamReader str = new StreamReader(ruta+nomFitxer); 
            FileStream fs = new FileStream(ruta +"\\LletresA"+numero+".txt", FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);

            while (!final)
            {
                caracter = Convert.ToString((char)str.Read());

                if (caracter == "\r")
                {
                    final = true;
                }
                else
                {
                    try
                    {
                        if (caracter == "A")
                        {
                            AX += caracter;
                            caracter = Convert.ToString((char)str.Read());
                            AX += caracter;
                            caracter = Convert.ToString((char)str.Read());
                            AX += caracter;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            label.Text = "Finish Read And Write Text";
            wr.WriteLine(AX);
            wr.Flush();
            wr.Close();
            fs.Close();
            letrasAX[posicion] = AX;
        }

        private void concatenarLetres(string[] AX)
        {
            foreach (string item in AX)
            {
                lletresA += item;
            }
            writeText();
        }
        private void writeText()
        {
            FileStream fs = new FileStream(ruta + "\\LletresA.txt", FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);
            wr.WriteLine(lletresA);
            wr.Flush();
            wr.Close();
            labelTOT.Text = "Write All text";
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            string rutaA=ruta+ "LletresA.txt";
            string rutaO = ruta + "LletresOriginal.txt";
            string streamA = File.ReadAllText(rutaA);
            string streamO = File.ReadAllText(rutaO);

            if (streamA == streamO)
            {
                lblresultat.Text = "True";
            }
            else
            {
                lblresultat.Text = "False";
            }
        }
    }
}
