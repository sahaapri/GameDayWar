public void HardcodeUsernameInSession()
{
    // Hardcodes the username "admin" into the session
    HttpContext.Current.Session["username"] = "admin"; 
    Console.WriteLine("Username 'admin' hardcoded in session.");
}
