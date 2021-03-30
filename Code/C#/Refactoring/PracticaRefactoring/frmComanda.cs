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
        int index;

        public frmComanda()
        {
            InitializeComponent();
        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            lblRepresentant.Text = representant;
        }

        private void btnAddDetall_Click(object sender, EventArgs e)
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
            importMod = comanda.calcularBrut(Cistella, cmbClients.Text);
            modificarText(lblBrut, importMod, 2);
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            importMod = comanda.calcularIva(Cistella, cmbClients.Text);
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
            modificarText(lblTotal, importMod, 0);
            
            podemFinalitzar = true;
            grpResum.Visible = true;
        }
        #endregion

        private void modificarText(Control label, double preu, int posicio)
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
            //este if es para que se pueda cambiar de cliente
            //siempre y cuando no se haya añadido ningun producto a la cesta 
            if (Cistella.Count == 0)
            {
                novaComanda = true;
                contador = contador + 1;
                DadesComanda = new string[7];
                int dia = DateTime.Today.DayOfYear;
                numComanda = dia.ToString() + "-" + contador.ToString();
                lblComanda.Text = numComanda;
                DadesComanda[0] = numComanda;
                DadesComanda[1] = cmbClients.Text;
                index = cmbEstat.SelectedIndex;
            }
            else
            {
                cmbEstat.SelectedIndex = index;
                MessageBox.Show("No se puede cambiar de cliente cuando ya se ha iniciado uno");
            }
        }
        /*   Se ha comentado ya que no se podra hacer una cesta de dos clientes diferentes 
        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (novaComanda)
                DadesComanda[1] = cmbClients.Text;
        }*/

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
