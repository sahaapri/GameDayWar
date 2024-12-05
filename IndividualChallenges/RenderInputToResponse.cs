public void RenderInputToResponse(string userInput)
{
    string safeInput = HttpUtility.HtmlEncode(userInput)
    // Insecure: Writes raw user input directly into the response
    Response.Write("<p>" + safeInput + "</p>");
    Console.WriteLine("Rendered to response: <p>" + userInput + "</p>");
}