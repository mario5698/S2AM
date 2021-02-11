using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Flis_i_fitxers
{
    public partial class Form1 : Form
    {
        List<string> Vocals = new List<string>();
        ArrayList Numeros = new ArrayList();
        List<codificacio> codificacion = new List<codificacio>();
        Queue Cola = new Queue();
        Thread hilo1,hilo2;
        bool FilesCreated = false;
        bool Codi_Create = false; 
        
        public Form1()
        {
            InitializeComponent();
            Add_vocals_list();
            Add_Numeros_arraylist();
        }
        
        private void Add_Codificacio()
        {
            for (int i = 0; i < Vocals.Count; i++)
            {
                string vocal = Vocals[i];
                string numero = gen_num_random();
                codificacio frase = new codificacio();
                frase.Letra = vocal;
                frase.Numero = numero;
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
            Codi_Create = true;

        }
       
        public class codificacio {
          public  string Letra;
           public    string Numero;
        }

        private void btn_gen_Fitxers_Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(Crear_documentos);
            hilo1.Start();
            hilo2 = new Thread(Comprimir_Documentos);
            hilo2.Start();
        }

        private void Comprimir_Documentos()
        {
            hilo1.Join();
            if (FilesCreated)
            {
                string ComprimirArxius = @"..\FitxersAComprimir";
                string GuardarCompress = @"..\FitxersComprimits\";
                string nombreCompress = "ArxiusComprimits.zip";
                File.Delete(GuardarCompress + nombreCompress);
                ZipFile.CreateFromDirectory(ComprimirArxius, GuardarCompress + nombreCompress);
                MessageBox.Show("Compressed");
            }
        }

        
        private void Crear_documentos()
        {
            string tbx_fit = txb_num_fitxers.Text;
            string tbx_lle = tbx_num_lletres.Text;
            if (Codi_Create)
            {
                if (tbx_fit != "" && tbx_lle != "")
                {
                    int numero = Int32.Parse(tbx_fit);
                    int letras = Int32.Parse(tbx_lle);
                    if (numero >= 100 && letras >= 1000)
                    {
                        Parallel.For(1, numero + 1, (i) =>
                        {
                            string fileName = @"..\FitxersAComprimir\Fitxer" + i + ".txt";
                            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate,
                            FileAccess.Write);
                            StreamWriter writer = new StreamWriter(stream);


                            for (int count = 0; count < (letras / 5); count++)
                            {
                                foreach (codificacio item in codificacion)
                                {
                                    writer.WriteLine(item.Letra + ": " + item.Numero);
                                }
                            }
                            writer.Close();                        
                        });
                        FilesCreated = true;

                        MessageBox.Show("Files Created");
                    }
                    else
                    {
                        MessageBox.Show("El numero de fitxer a de ser major a 100");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primer s´ha de generar una codificacio");
            }
        }
    }
}
