using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBCripto
{
    public partial class servidor_tcp : Form
    {
        Thread hilo1, hilo2;
        TcpListener Listener;
        TcpClient client;
        byte[] buffer = new byte[1024];
        NetworkStream str;
        String mensaje = null;


        public servidor_tcp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(ActivarListener);
            hilo1.Start(6700);

            hilo2 = new Thread(ActivarListener);
            hilo2.Start(6800);
        }
       

        private void ActivarListener(object port)
        {
            int puerto = (int)port;
            Listener = new TcpListener(IPAddress.Any, puerto);
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
                            lst_data.Invoke(new MethodInvoker(delegate () {
                                lst_data.Items.Add("port: " +port+": - Message "+mensaje);
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
    }
}
