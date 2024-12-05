public void CreateTcpClient(string host)
{
    var tcpClient = new TcpClient(host, 80); // Insecure: No encryption and uses HTTP
    Console.WriteLine("TCP client connected to: " + host);
}
