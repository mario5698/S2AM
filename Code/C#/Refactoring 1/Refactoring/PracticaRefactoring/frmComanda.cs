using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticaRefactoring
{
    public partial class frmComanda : Form
    {
        List<Detall> Cistella = new List<Detall>();
        Comanda comanda = new Comanda();
        bool podemFinalitzar = false;
        string numComanda;
        string[] DadesComanda;
        int contador = 0;
        public string representant;
        public string zona;
        bool novaComanda = false;
        double importMod;

        public frmComanda()
        {
            InitializeComponent();
        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }

        private void btnDetall_Click(object sender, EventArgs e)
        {
            Detall compra = new Detall();
            compra.Producte = cmbProductes.Text;
            compra.preu = double.Parse(txtPreu.Text);
            compra.quantitat = int.Parse(txtQuantitat.Text);
            Cistella.Add(compra);
            dtgProductes.DataSource = null;
            dtgProductes.DataSource = Cistella;
            txtPreu.Text = "";
            txtQuantitat.Text = "";
        }

        #region BotonesCalcular
        private void btnBrut_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularBrut(Cistella);
            modificarText(lblBrut, importMod, 2);
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularIva(Cistella);
            modificarText(lblIva, importMod, 3);
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularDespesa(Cistella, cmbClients.Text);
            modificarText(lblDespesa, importMod, 4);
        }

        private void btnDescompte_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularDescompte(Cistella, cmbClients.Text);
            modificarText(lbldescompte, importMod, 5);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularTotal(Cistella, cmbClients.Text);
            modificarText(lblTotal, importMod);
            
            podemFinalitzar = true;
            grpResum.Visible = true;
        }
        #endregion

        private void modificarText(Control label, double preu, int posicio=0)
        {
            double import = 0;
            if (posicio != 0)
            {
                import = Math.Round(preu, 2, MidpointRounding.AwayFromZero);
                label.Text = import.ToString();
                DadesComanda[posicio] = import.ToString();
            }
            else
            {
                import = Math.Round(preu, 2, MidpointRounding.AwayFromZero);
                lblTotal.Text = import.ToString();
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
                novaComanda = true;
                contador = contador + 1;
                DadesComanda = new string[7];
                int dia = DateTime.Today.DayOfYear;
                numComanda = dia.ToString() + "-" + contador.ToString();
                lblComanda.Text = numComanda;
                DadesComanda[0] = numComanda;
                DadesComanda[1] = cmbClients.Text;
            
        }
        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (novaComanda)
                DadesComanda[1] = cmbClients.Text;
        }

        #region Estados
        private void cmbEstat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstat.SelectedIndex == 0)
                Estat("En Espera");// EstatEnEspera();

            if (cmbEstat.SelectedIndex == 1)
                Estat("Retingut");//EstatRetingut();

            if (cmbEstat.SelectedIndex == 2)
                Estat("Condicionat");//EstatCondicionat();

            if (cmbEstat.SelectedIndex == 3)
                Estat("Confirmat");//EstatConfirmat();
        }

        private void Estat(string estat)
        {
            DadesComanda[6] = estat;
        }
        #endregion

        private void btnResum_Click(object sender, EventArgs e)
        {
            frmResum frm = new frmResum();
            frm.zona = zona;
            frm.detall = Cistella;
            frm.dades = DadesComanda;
            frm.Show();
        }
    }
}
