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
using System.Xml;

namespace PracticaRSA
{

    public partial class frmEncriptar : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        OpenFileDialog dialog = new OpenFileDialog();

        byte[] dataToEncrypt;
        byte[] encryptedData;
        public frmEncriptar()
        {
            InitializeComponent();
        }

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(File.ReadAllText(dialog.FileName));
                string publickey = RSA.ToXmlString(false);
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            dataToEncrypt = ByteConverter.GetBytes(tbx_original.Text);
                encryptedData = RSA.Encrypt(dataToEncrypt, true);
                tbx_crypted.Text =  ByteConverter.GetString(encryptedData);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {

                if (frm.Name == "frmDesencriptar")
                {
                    foreach (Control ctr in frm.Controls)
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

        private void btn_showKey_Click(object sender, EventArgs e)
        {
            tbx_pubkey.Text = File.ReadAllText(dialog.FileName);
        }

        
    }
}
