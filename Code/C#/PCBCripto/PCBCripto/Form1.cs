using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBCripto
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        RSACryptoServiceProvider rsaprivate;

        string FullPath,FullPathex;
        private byte[] _DadesEnc;
        byte[] decryptedData;

        public byte[] DadesEnc
        {
            get { return _DadesEnc; }
            set { _DadesEnc = value; }
        }
        byte[] dataToEncrypt;
        public Form1()
        {
            InitializeComponent();
            servidor_tcp tcp = new servidor_tcp();
            tcp.Show();
            FullPath = Application.StartupPath + "\\Keys\\RSA.xml";
            FullPathex = Application.StartupPath + "\\Keys\\privateKey.xml";

            comboBox1.Items.Add("6700");
            comboBox1.Items.Add("6800");
        }
        #region encript data

        private void btn_genKey_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox6.Text = "";
            string keyname;
            keyname = "PCB";
            string privatekey;

            CspParameters Cspp = new CspParameters();
            Cspp.KeyContainerName = keyname;
            rsa = new RSACryptoServiceProvider(Cspp);
            privatekey = rsa.ToXmlString(false);
            rsa.PersistKeyInCsp = true;
            File.WriteAllText(FullPath, privatekey);
}

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            textBox6.Text = File.ReadAllText(FullPath);
            dataToEncrypt = Encoding.UTF8.GetBytes(tbx_original.Text);
            _DadesEnc = rsa.Encrypt(dataToEncrypt, true);
            tbx_encriptat.Text = Encoding.UTF8.GetString(_DadesEnc);
        }
        
        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            decryptedData = rsa.Decrypt(_DadesEnc, true);
            tbx_desencriptat.Text = Encoding.UTF8.GetString(decryptedData);
        }
        #endregion

        private void lbl_exKey_Click(object sender, EventArgs e)
        {
            rsaprivate = new RSACryptoServiceProvider();
            string xmlPublicKey = File.ReadAllText(FullPathex);
            rsaprivate.FromXmlString(xmlPublicKey);
        }

        private void btn_exEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                dataToEncrypt = Encoding.UTF8.GetBytes(tbx_exOringinal.Text);
                _DadesEnc = rsaprivate.Encrypt(dataToEncrypt, false);
                tbx_exEncriptar.Text = Encoding.UTF8.GetString(_DadesEnc);

                textBox8.Text = File.ReadAllText(FullPathex);
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
                
            }    
        
        }
        private void btn_exDecrypt_Click(object sender, EventArgs e)
        {
            decryptedData = rsaprivate.Decrypt(_DadesEnc, false);
            tbx_exDesencriptar.Text = Encoding.UTF8.GetString(decryptedData);
        }
        #region tcpIp 
        private void button8_Click(object sender, EventArgs e)
        {
            NetworkStream NetStream;
            int port = int.Parse( comboBox1.SelectedItem.ToString());
            string message = textBox2.Text;
            TcpClient Client = null;
            string ip="127.0.0.1";

            Client = new TcpClient(ip, port);
            NetStream = Client.GetStream();
            byte[] frase = Encoding.UTF8.GetBytes(message);
            NetStream.Write(frase, 0, frase.Length);
        }

       
#endregion
    }
}
