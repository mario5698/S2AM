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
        TcpListener Listener;
        int port;
        TcpClient client;
        byte[] buffer = new byte[1024];
        NetworkStream str;
        String mensaje = null;
        bool listenerStrat = false;


        public frmServer()
        {
            InitializeComponent();
        }

        #region Botones formulario
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!listenerStrat)
            {
                activarListener();
                listenerStrat = true;
            }
            else
            {
                lbx_Missatges.Items.Add("The listener is activated");
            }
            
            port =Int32.Parse(txb_port.Text);
        }
        #endregion
        
        private void activarListener() {
            hilo1 = new Thread(ActivarListener);    
            hilo1.Start();
        }
    
        private void ActivarListener()
        {
            Listener = new TcpListener(IPAddress.Any, port);
            Listener.Start();
            
            byte[] recive = new byte[256];
            while (true)
            {
                try
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        str = client.GetStream();
                        Int32 bytes = str.Read(recive, 0, recive.Length);
                        mensaje = Encoding.UTF8.GetString(recive, 0, bytes);
                        
                        if (InvokeRequired)
                        {
                            lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                                        lbx_Missatges.Items.Add(mensaje);
                                    }
                                )
                            );   
                        }
                        str.Close();
                        client.Close();
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }                        
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {

            Listener.Stop();
            hilo1.Abort();
            listenerStrat = false;

            lbx_Missatges.Items.Clear();                
        }
    }
}
