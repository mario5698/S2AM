using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flis_i_fitxers
{
    public partial class Form1 : Form
    {
        List<string> Vocals = new List<string>();
        ArrayList Numeros = new ArrayList();
        List<codificacio> codificacion = new List<codificacio>();
        Queue Cola = new Queue();
        public Form1()
        {
            InitializeComponent();
            Add_vocals_list();
            Add_Numeros_arraylist();
        }
        
        private void Add_Codificacio(){

            for (int i = 0; i < Vocals.Count; i++)
            {
                string vocal = Vocals[i];
                string numero = gen_num_random();

                codificacio frase = new codificacio();

                frase.Letra = vocal;
                frase.Numero = numero;
                MessageBox.Show(numero);
                codificacion.Add(frase);
            }
        }
        private string gen_num_random()
        {
            int minimo = 0;
            int maximo = 10;
            int numeros = 10;
            int numero ;
            RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();
            ArrayList num = Numeros;

            for (int i = 0; i <= 9; i++)
            {
                var bytes = new byte[numeros];
                csp.GetBytes(bytes);
                numero = ClampDigit(bytes, minimo, maximo);
                Cola.Enqueue(num[numero]);
                num.RemoveAt(numero);
                maximo--;
            }

            string numerofinal = "";

            for (int i = 0; i <= 9; i++)
            {
                numerofinal += Cola.Dequeue();
            }
            Add_Numeros_arraylist();
            return numerofinal;
        }

        int ModuloLimit(int modulo) => 256 - (256 % modulo);

        int ClampDigit(byte[] bytes, int minimo, int maximo)
        {
            var result = -1;
            var modulo = maximo - minimo;
            var upperLimit = ModuloLimit(modulo);

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] < upperLimit)
                {
                    result = bytes[i] % modulo + minimo;
                }
            }

            if (result == -1)
            {
                result = bytes[bytes[0] % bytes.Length] % modulo + minimo;
            }

            return result;
        }
        private void Add_Numeros_arraylist()
        {
            for (int i = 0; i <= 9; i++)
            {
                Numeros.Add(i);
            }
        }

        private void Add_vocals_list()
        {
            Vocals.Add("A");
            Vocals.Add("E");
            Vocals.Add("I");
            Vocals.Add("O");
            Vocals.Add("U");
        }

        private void btn_gen_Codificacio_Click(object sender, EventArgs e)
        {
            Add_Codificacio();
        }
       

        private void btn_gen_Fitxers_Click(object sender, EventArgs e)
        {

        }
        public class codificacio {
          public  string Letra;
           public    string Numero;
        }

        private void tbx_num_lletres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
