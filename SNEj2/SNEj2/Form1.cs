using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SNEj2
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            //Primer paso es establecer una conexion, usamos IPEndPoint con el ip del sevidor y su puerto

            IPAddress direc = IPAddress.Parse("192.168.56.101"); //INDICAMOS IP
            IPEndPoint ipep = new IPEndPoint(direc, 9050); //INDICAMOS PUERTO

            //Creamos el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep); //Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion indicamos error y salimos del programa con un return
                MessageBox.Show("Conexion con servidor fallida");
                return;

            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexion
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if(cod1.Checked)
            {
                string mensaje = "1/" + gradostext.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("El resultado es: " + mensaje);
            }
            else if (cod2.Checked)
            {
                string mensaje = "2/" + gradostext.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("El resultado es: " + mensaje);
            }
        }
    }
}
