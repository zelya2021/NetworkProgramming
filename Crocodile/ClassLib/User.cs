using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        Socket clientSocket;
        public User(Socket socket)
        {
            clientSocket = socket;
        }
        public void Start()
        {
           // Sending();
           // Receiving();

        }

        private void Receiving()
        {
           
        }

        public void Sending(string messege)
        {
            while (true)
            {
                //string messege = Console.ReadLine();

                byte[] data1 = Encoding.UTF8.GetBytes(messege);
                //отправка сообщения на сервер
                clientSocket.Send(data1);
            }
        }
    }
}
