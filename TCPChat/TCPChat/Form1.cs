using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChat
{
    public partial class Form1 : Form
    {
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        const string IP = "127.0.0.1";
        const int PORT = 55_555;
        //User user = null;
        //конечная точка сервера
        IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
        public Form1()
        {
            InitializeComponent();
            clientSocket.Connect(ep);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data1 = Encoding.UTF8.GetBytes(tbText.Text);
            //отправка сообщения на сервер
            clientSocket.Send(data1);

            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        try
                        {
                            byte[] data = new byte[64];
                            StringBuilder builder = new StringBuilder();
                            int bytes = 0;
                            do
                            {
                                bytes = clientSocket.Receive(data);
                                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                            }
                            while (clientSocket.Available > 0);
                            lbChatClients.Items.Add(builder.ToString());
                        }
                        catch
                        {
                            lbChatClients.Items.Add("Error");
                        }
                    }
                }
                catch
                {
                    lbChatClients.Items.Add("Exit");
                }
            });

            tbText.Text = "";
        }
    }
}
