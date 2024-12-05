public void PerformUnverifiedBankTransfer()
{
    // Insecure: Hardcoded and unsanitized request to a sensitive URL
    WebClient client = new WebClient();
    string response = client.DownloadString("http://bank.com/transfer?amount=100");
    Console.WriteLine("Transfer initiated with response: " + response);
}
