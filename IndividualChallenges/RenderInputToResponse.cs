public void RenderInputToResponse(string userInput)
{
    // Insecure: Writes raw user input directly into the response
    Response.Write("<p>" + userInput + "</p>");
    Console.WriteLine("Rendered to response: <p>" + userInput + "</p>");
}