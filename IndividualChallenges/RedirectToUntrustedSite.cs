public void RedirectToUntrustedSite(string userInput)
{
    // Insecure: Constructs a URL using user input and redirects without validation
    Response.Redirect("http://malicious.com?token=" + userInput);
    Console.WriteLine("Redirected to: http://malicious.com?token=" + userInput);
}
