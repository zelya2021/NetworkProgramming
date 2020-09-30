using ClassLib;
using DrawingDemo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crocodile
{
    public partial class Form1 : Form
    {
        List<PicturePath> picture = new List<PicturePath>();
        bool isDraw = false;
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        const string IP = "127.0.0.1";
        const int PORT = 55_555;
        User user = null;
        //конечная точка сервера
        IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
       
        public Form1()
        {
            InitializeComponent();
            clientSocket.Connect(ep);
            User user = new User(clientSocket);

            pictureBox.Paint += PictureBox_Paint;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseUp += PictureBox_MouseUp;
            pictureBox.MouseMove += PictureBox_MouseMove;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                picture.Last().Points.Add(new Point(e.X, e.Y));
                pictureBox.Invalidate();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Text = "Up";
            isDraw = false;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Text = "Down";
            picture.Add(new PicturePath(lblColor.BackColor, (float)Convert.ToDouble(nudStrokeWidth.Value)));
            isDraw = true;
        }


        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var path in picture)
            {
                if (path.Points.Count >= 2)
                {
                    e.Graphics.DrawCurve(new Pen(new SolidBrush(path.Color), path.Width), path.Points.ToArray());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picture.Clear();
            pictureBox.Invalidate();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = dlg.Color;
            }
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
