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
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();


        string FullPath;
        byte[] decryptedData;
        byte[] DataToDecrypt;
        

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
            decryptedData =  rsa.Decrypt(_DadesEnc, true);
            tbx_decrypted.Text = ByteConverter.GetString(decryptedData);
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            const string nameContainer= "RSA";
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
                    FullPath = path + "\\"+ nameContainer+".xml";
                    MessageBox.Show(FullPath);
                    tbx_routeXML.Text = FullPath;
                }
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string keyname;
            if (!(tbx_container.Text == null && tbx_container.Text == ""))
            {
                keyname = tbx_container.Text;
            }
            else
            {
                keyname = "RSA";
            }
            CspParameters Cspp = new CspParameters();
            Cspp.KeyContainerName = keyname; 
             rsa = new RSACryptoServiceProvider(Cspp);
            string publickey = rsa.ToXmlString(false);
            rsa.PersistKeyInCsp = true;
            File.WriteAllText(FullPath, publickey);
        }
    }
}
