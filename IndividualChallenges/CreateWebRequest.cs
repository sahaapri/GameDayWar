public void CreateWebRequest(string url)
{
    var request = WebRequest.Create("http://" + url); // Insecure: Constructs URL dynamically and uses HTTP
    using (var response = request.GetResponse())
    {
        Console.WriteLine("Response received.");
    }
}
