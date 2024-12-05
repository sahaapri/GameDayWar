public void LogUserInputToConsole(string userInput)
{
    // Insecure: Embeds user input directly into HTML-like formatting
    Console.WriteLine($"<b>{userInput}</b>");
    Console.WriteLine("Logged user input in bold HTML format.");
}