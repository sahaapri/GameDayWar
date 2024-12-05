public void AddUserInputToCookie(string userInput)
{
    // User input added directly to cookies without validation
    Response.Cookies.Add(new HttpCookie("SessionID", userInput)); 
    Console.WriteLine("Cookie added with user input: " + userInput);
}
