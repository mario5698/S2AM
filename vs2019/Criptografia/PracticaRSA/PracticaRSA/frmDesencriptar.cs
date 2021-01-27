using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        string texto;
        string path;
        string FullPath;
        byte[] decryptedData;
        byte[] encryptedData ;
        

        private byte[] _DadesEnc;

        public byte[] DadesEnc
        {
            get { return _DadesEnc; }
            set { _DadesEnc = value; }
        }


        public frmDesencriptar()
        {
            InitializeComponent();
        }
        
        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData = _DadesEnc;
                decryptedData = RSA.Decrypt(encryptedData, false);

                tbx_decrypted.Text = ByteConverter.GetString(decryptedData);

            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    RSA.ImportParameters(RSAKeyInfo);
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            string path;
           
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                path = dialog.SelectedPath;
                if (!string.IsNullOrWhiteSpace(tbx_container.Text))
                {
                    FullPath = path + "\\" + tbx_container.Text + ".xml";
                    MessageBox.Show(FullPath);
                    tbx_routeXML.Text = FullPath;
                }
                else
                {
                    FullPath = path + "\\RSA.xml";
                    MessageBox.Show(FullPath);
                    tbx_routeXML.Text = FullPath;

                }
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string keyname = tbx_container.Text;
            CspParameters Cspp = new CspParameters();
            Cspp.KeyContainerName = keyname;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(Cspp);
            string publickey = rsa.ToXmlString(true);
            rsa.PersistKeyInCsp = true;
            File.WriteAllText(FullPath, publickey);
        }
    }
}
