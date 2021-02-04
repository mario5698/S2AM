using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace TCPClient
{
    public partial class frmClient : Form
    {
        bool network;
        String protocolo = "TCP", configuracion = "Protocol", Xml_IP= "IP", Xml_Port= "Port", leerXml = "TCPSettings.xml";
        int[] ping = new int[10];
        IPAddress address;
        Ping myPing = new Ping();
        TcpClient Client =null;
        PingReply reply;
        List<Thread> hilos = new List<Thread>();
        Thread  hilo1;
        NetworkStream NetStream;
        public frmClient()
        {
            InitializeComponent();
        }
        #region botones formulario
        private void btn_config_Click(object sender, EventArgs e)
        {
            guardarXml();
        }

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            cargarXml();
            ComprobarRed();
        }
        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            enviar();
        }
     
        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            foreach (Thread T in hilos) if (T.IsAlive) T.Abort();
        }
        #endregion

        #region Creador de Hilos
      
        private void ComprobarRed()
        {
            hilo1 = new Thread(IniciarHiloRed);
            hilos.Add(hilo1);
            hilo1.Start();
        }  
        #endregion

        #region Invokes Si se requiere la invocaion del hilo esto lo permite
        private void IniciarHiloRed(){
            if (InvokeRequired)
            {
                Invoke(new Action( () => comprovarRed()));
            }
        }
       
        #endregion

        #region Funciones
        private void cargarXml() {
            XElement options = XElement.Load(leerXml);
            IEnumerable<XElement> dades = (from Direcion in options.Element(configuracion).Elements(protocolo)
                                               select Direcion);

            txb_ip.Text = dades.First().Element(Xml_IP).Value;
            txb_port.Text = dades.First().Element(Xml_Port).Value;
        }

        private void guardarXml()
        {
            XElement IP = XElement.Load(leerXml);
            IEnumerable<XElement> direccion = (from Direcion in IP.Element(configuracion).Elements(protocolo)
                                               select Direcion);

            direccion.First().Element(Xml_IP).Value = txb_ip.Text;
            direccion.First().Element(Xml_Port).Value =  txb_port.Text;
            IP.Save(leerXml);
        }

        private void comprovarRed()
        {
            pnl_status.BackColor = Color.Yellow;
            network = NetworkInterface.GetIsNetworkAvailable();

            if (network)
            {
                address = IPAddress.Parse("192.168.1.1");
                reply = myPing.Send(address, 80);
                for (int i = 1; i <= 10; i++)
                {
                    try
                    {
                        reply = myPing.Send(address, 80);
                        if (reply != null)
                        {
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

        private void enviar()
        {
            Client = new TcpClient(txb_ip.Text, Int32.Parse(txb_port.Text));
            NetStream = Client.GetStream();
            byte[] frase = Encoding.UTF8.GetBytes(txb_message.Text);
            NetStream.Write(frase, 0, frase.Length);
        }
        #endregion
    }
}