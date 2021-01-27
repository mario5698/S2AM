using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{

    public partial class frmEncriptar : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        byte[] dataToEncrypt;
        byte[] encryptedData;

        public frmEncriptar()
        {
            InitializeComponent();
        }

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                path = dialog.FileName;
                MessageBox.Show(path);
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            dataToEncrypt = ByteConverter.GetBytes(tbx_original.Text);
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData =RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                tbx_crypted.Text =  ByteConverter.GetString(encryptedData);
            }
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach ( Form frm in Application.OpenForms)
            {

                if (frm.Name == "frmDesencriptar")
                {
                    foreach (Control ctr  in frm.Controls)
                    {
                        if (ctr.Name == "tbx_crypted")
                        {
                            ((PracticaRSA.frmDesencriptar)frm).DadesEnc = encryptedData;
                            ctr.Text = tbx_crypted.Text;
                        }
                    }

                   
                }


            }
        }

        private void tbx_crypted_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
