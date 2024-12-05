public void CreateAuthCookie(string userInput)
{
    // Creating a new cookie with the user's input
    HttpCookie authCookie = new HttpCookie("auth", userInput)
    {
        HttpOnly = true,
        Secure = true
    };
    HttpContext.Current.Response.Cookies.Add(authCookie);
    Console.WriteLine("Cookie has been set.");
}
