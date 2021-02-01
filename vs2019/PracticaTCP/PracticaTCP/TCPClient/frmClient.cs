using System;

using System.Drawing;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Configuration;


namespace TCPClient
{
    public partial class frmClient : Form
    {

        bool network;
        IPAddress address;
        Ping myPing = new Ping();
        PingReply reply;
        int[] ping = new int[10];
      //  ThreadStart delegado;
        //Thread hilo1;

        public frmClient()
        {
            InitializeComponent();
        }
        private string obtenerconfig(string key)
        {
            string value;
            b var appSettings = ConfigurationManager.AppSettings;
             value = appSettings[key];

            return value;
        }


        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            
            string ip = obtenerconfig("IP");
            string port = obtenerconfig("PORT");
            txb_ip.Text = ip;
            txb_port.Text = port;
          //  comprovarRed();
            //usar hilo para comprobar que hay conexion a internet
            /* delegado = new ThreadStart(comprovarRed);
             hilo1 = new Thread(delegado);
             hilo1.Interrupt();

             hilo1.Start();*/
        }



        private void comprovarRed()
        {
            pnl_status.BackColor = Color.Yellow;
            network = NetworkInterface.GetIsNetworkAvailable();

            if (network)
            {
                address = IPAddress.Parse("8.8.8.8");
                reply = myPing.Send(address, 80);
                for (int i = 1; i <= 10; i++)
                {
                    try
                    {
                        reply = myPing.Send(address, 80);

                        if (reply != null)
                        {
                           // MessageBox.Show("hola");
                            lbx_console.Items.Add("ping" + i + "-" + reply.Status.ToString());
                        }
                        label5.Text = "Connexio Correcta";
                        pnl_status.BackColor = Color.Green;
                    }
                    catch (Exception)
                    {
                        if (reply == null)
                        {
                            lbx_console.Items.Add("ping" + i + "-" + reply.Status.ToString());
                        }
                        label5.Text = "Xarxa no disponible";
                        pnl_status.BackColor = Color.Red;
                    }

                }
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            CambiarConfiguracio("IP", txb_ip.Text);
            CambiarConfiguracio("PORT", txb_port.Text);
        }


        private void CambiarConfiguracio(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}