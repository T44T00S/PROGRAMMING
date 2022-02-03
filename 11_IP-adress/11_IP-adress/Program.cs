using System;

namespace _11_IP_adress
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            int PORT = 3000;

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IP, PORT));

        }
    }
}
