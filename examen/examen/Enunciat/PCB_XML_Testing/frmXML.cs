using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PCB_XML_Testing
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CalculsClient calculs = new CalculsClient();
            int total = calculs.CalculaTotal(int.Parse(txtClient.Text));
          
            txtTotal.Text = total.ToString();
           
        }

        private void btnPremis_Click(object sender, EventArgs e)
        {
            CalculsClient calculs = new CalculsClient();
            int total = calculs.CalculaPremis(int.Parse(txtClient.Text));

            txtPremis.Text = total.ToString();
        }

        private void btnFidelitat_Click(object sender, EventArgs e)
        {
            CalculsClient calculs = new CalculsClient();
            int total = calculs.CalculaFidelitat(int.Parse(txtClient.Text));

            txtFidelitat.Text = total.ToString();
        }


        // Es recullen els valors del idClient i els diferents imports calculats
        // i s'emmagatzemen en una List<int> que es passarà a la funció GravaDades
        // No cal cap comprovació que els camps estan plens ni cap gestió d'errors

        private void btnGrava_Click(object sender, EventArgs e)
        {
            CalculsClient calculs = new CalculsClient();
            //Aquí caldrà crera una List<int> amb els valors del client
            // i els imports calculats i passar-la a la funció GravaDades

            List<int> grabar = new List<int>();

            grabar.Add(int.Parse(txtClient.Text));
            grabar.Add(int.Parse(txtTotal.Text));
            grabar.Add(int.Parse(txtPremis.Text));
            grabar.Add(int.Parse(txtFidelitat.Text));

            calculs.GravaDades(grabar);

        }
    }
}
