public void OpenUrlWithUserInput(string userInput)
{
    // Insecure: Launches a URL constructed with raw user input
    Process.Start("http://example.com/resetpassword?email=" + userInput);
    Console.WriteLine("Opened URL: http://example.com/resetpassword?email=" + userInput);
}
