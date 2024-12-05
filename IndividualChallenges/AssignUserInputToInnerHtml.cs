public void AssignUserInputToInnerHtml(string userInput)
{
    // Insecure: Assigns raw user input to InnerHtml
    var res = new System.Web.UI.HtmlControls.HtmlGenericControl();
    res.InnerHtml = userInput; // Vulnerable to XSS
    Console.WriteLine("Set InnerHtml to: " + userInput);
}
