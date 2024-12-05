public void StoreTokenInSession(string token)
{
    // Stores token in session without encryption
    Session["AuthToken"] = token;
    Console.WriteLine("Token stored in session.");
}
