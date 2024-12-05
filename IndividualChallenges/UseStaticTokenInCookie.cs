public void UseStaticTokenInCookie()
{
    // Creates a cookie with a hardcoded static token
    HttpCookie authCookie = new HttpCookie("auth", "static-token"); 
    Response.Cookies.Add(authCookie);
    Console.WriteLine("Static authentication token added to cookies.");
}
