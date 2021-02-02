using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        Thread hilo1;
        List<Thread> hilos = new List<Thread>();
        TcpListener Listener;
        IPAddress address = IPAddress.Parse("127.0.0.1");
        int port;
        TcpClient client;
        byte[] buffer = new byte[1024];
        NetworkStream Net;
                
        public frmServer()
        {
            InitializeComponent();
        }
        #region Botones formulario
        private void btn_connect_Click(object sender, EventArgs e)
        {
            activarListener();
            port =Int32.Parse( txb_port.Text);

        }
        #endregion
        
        private void activarListener() {
            hilo1 = new Thread(ActivarListener);
            hilos.Add(hilo1);
            hilo1.Start();
        }
    
    
        private void ActivarListener()
        {
            
            Listener = new TcpListener(address, port);
            Listener.Start();
            client = Listener.AcceptTcpClient();
            Net = client.GetStream();
            Socket s = Listener.AcceptSocket();

            int k = s.Receive(buffer);
            char caracter;
            for (int i = 0; i < k; i++)
            {
                caracter=Convert.ToChar(buffer[i]);
            lbx_Missatges.Text += caracter;
            }
           
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            Net.Close();
            client.Close();
            Listener.Stop();
        }

        private void lbx_Missatges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
