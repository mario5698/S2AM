using System;

using System.Drawing;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Configuration;
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
        IPAddress address;
        Ping myPing = new Ping();
        TcpClient Client =null;
        PingReply reply;
        int[] ping = new int[10];
        List<Thread> hilos = new List<Thread>();
        Thread hilo1, hilo2, hilo3;
        NetworkStream NetStream;
        Stream stm; 
        public frmClient()
        {
            InitializeComponent();
           //permite usar funciones ilegales como hilos 
          // ejemplo: un hilo invoca a el texbox para darle un valor
         //   CheckForIllegalCrossThreadCalls = false;
        }
        #region botones formulario
        private void btn_config_Click(object sender, EventArgs e)
        {
          //  GuardarXml();
        }

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            CargarXML();
            ComprobarRed();
        }
        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            Client = new TcpClient(txb_ip.Text, Int32.Parse(txb_port.Text));
            NetStream = Client.GetStream();
            byte[] frase = Encoding.UTF8.GetBytes(txb_message.Text);
            NetStream.Write(frase,0,frase.Length);


        }
        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            foreach (Thread T in hilos) if (T.IsAlive) T.Abort();
            /*
            hilo1.Abort();
            hilo2.Abort();
            hilo3.Abort();
            */
        }
        #endregion

        #region Creador de Hilos
        private void CargarXML()
        {
            hilo1 = new Thread(IniciarHiloXML);
            hilos.Add(hilo1);
            hilo1.Start();
        }
        private void ComprobarRed()
        {
            hilo2 = new Thread(IniciarHiloRed);
            hilos.Add(hilo2);
            hilo2.Start();
        }  

        private void GuardarXml()
        {
            hilo3 = new Thread(IniciarHiloGuardado);
            hilos.Add(hilo3);
            hilo3.Start();
        }
        #endregion

        #region Invokes Si se requiere la invocaion del hilo esto lo permite
        private void IniciarHiloRed(){
            if (InvokeRequired)
            {
                Invoke(new Action(() => comprovarRed()));
            }
        }
       
        private void IniciarHiloXML() {
            if (InvokeRequired)
            {
                Invoke(new Action(() => cargarXml()));
            }
        }
     
        private void IniciarHiloGuardado()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(()=> guardarXml()));
            }
        }
        #endregion

        #region Funciones
        private void cargarXml() {
            XElement options = XElement.Load(".\\TCPSettings.xml");

            foreach (XElement xEle in options.Descendants("IP"))
            {
                txb_ip.Text = xEle.Value; 
            }
            foreach (XElement xEle in options.Descendants("Port"))
            {
                txb_port.Text = xEle.Value;
            }
        }

        

        private void guardarXml()
        {
            XElement IP = XElement.Load("TCPSettings.xml");
            IEnumerable<XElement> direccio = (from Direcion in IP.Elements("TCP")
                                                     select Direcion);

            direccio.First().Element("IP").Value = txb_ip.Text;
            direccio.First().Element("Port").Value = txb_ip.Text;
            IP.Save("TCPSettings.xml");
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
        #endregion
    }
}