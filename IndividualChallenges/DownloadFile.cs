public void DownloadFile(string url)
{
    using (var client = new WebClient())
    {
        client.DownloadFile("http://example.com/file.txt", "file.txt"); // Insecure: Uses HTTP and hardcoded URL
    }
    Console.WriteLine("File downloaded from: " + url);
}
