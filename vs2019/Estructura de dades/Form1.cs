using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_dades
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cordenadas = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {
         generarDicionario();
        }
        private void generarDicionario()
        {
            Dictionary<string, string> coordanates = new Dictionary<string, string>();
            string dicionario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool comprobar = true;
            int vueltas = 0;
            string num_format;
            for (int i = 0; i < dicionario.Length; i++)
            {
                string caracter = dicionario.Substring(i, 1);
                num_format = Agregar_Num();
                while (comprobar)
                {
                    vueltas = vueltas + 1;
                    comprobar = coordanates.ContainsValue(num_format);
                    if (comprobar)
                    {
                        num_format = Agregar_Num();
                    }
                    else
                    {
                        comprobar = false;
                    }
                }
                comprobar = true;
                cordenadas = coordanates;
                coordanates.Add(caracter, num_format);
            }
        }
        private string Agregar_Num()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 99999);
            string num_format = dar_formato_random(r);
            return num_format;
        }

        private string dar_formato_random(int r)
        {
            string ran = r.ToString();
            int longitud = ran.Length;
            for (int i = longitud; i < 5; i++)
            {
                ran = "0" + ran;
            }
            return ran;
        }

        private void bnt_Mos_Click(object sender, EventArgs e)
        {
            cleanlistbox();
            mostrarDicionari();
            sequencia();

        }

        private void cleanlistbox()
        {
            ltb_lletres.Items.Clear();
            lst_num.Items.Clear();
        }
        private void mostrarDicionari()
        {
            foreach (KeyValuePair<string, string> item in cordenadas)
            {
                ltb_lletres.Items.Add(item.Key);
                lst_num.Items.Add(item.Value);
            }
        }

        private void sequencia()
        {
            string texto = txb_seq.Text;
            texto = texto.ToUpper();

            if (txb_seq.Text.Length >= 0 && txb_seq.Text.Length < 21)
            {
                for (int i = 0; i < txb_seq.Text.Length; i++)
                {
                    string caracter = texto.Substring(i, 1);
                    foreach (KeyValuePair<string, string> item in cordenadas)
                    {
                        if (caracter == item.Key)
                        {
                            listBox1.Items.Add(item.Value);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El numero maximo de letras es de 20");
            }
        }

        private void bnt_inv_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                foreach (KeyValuePair<string, string> valor in cordenadas)
                {
                    if (item == valor.Value)
                    {
                        textBox3.Text += valor.Key;
                    }
                }
            }
        }

        private void bnt_Esb_Click(object sender, EventArgs e)
        {
            string vocals = "AEIOU";
            cleanlistbox();
            for (int i = 0; i < vocals.Length; i++)
            {
                string caracter = vocals.Substring(i, 1);    
                cordenadas.Remove(caracter);
            }
            mostrarDicionari();
        }
    }
}
