public void WrapUserInputInDiv(string userInput)
{
    // Insecure: Wraps user input directly into a <div> without encoding
    var content = "<div>" + userInput + "</div>";
    Console.WriteLine("Generated content: " + content);
}
