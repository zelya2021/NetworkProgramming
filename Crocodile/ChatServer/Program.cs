using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";
            const string IP = "127.0.0.1";
            const int PORT = 55_555;
            //конечная точка сервера
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            List<Socket> clients = new List<Socket>();

            try
            {
                socket.Bind(ep);
                //прослушка подключений
                socket.Listen(5);
                Console.WriteLine("Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    var listner = socket.Accept();
                    clients.Add(listner);
                    Task.Run(() =>
                    {
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            int size = 0;
                            StringBuilder data = new StringBuilder();
                            try
                            {
                                //чтение сообщения
                                do
                                {
                                    //ожидание сообщений от клиента
                                    size = listner.Receive(buffer);
                                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));

                                } while (listner.Available > 0);

                                Console.WriteLine(data);
                                byte[] data1 = Encoding.UTF8.GetBytes(data.ToString());
                                //рассылка полученного сообщения всем пользователям
                                clients.ForEach((c) =>
                                {
                                    c.Send(data1);
                                });
                            }
                            catch (SocketException)
                            {
                                listner.Shutdown(SocketShutdown.Both);
                                listner.Close();
                            }
                        }
                    });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
