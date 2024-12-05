public void SetUnlimitedSessionTimeout()
{
    // Disables session expiration
    Session.Timeout = 0; // Vulnerable to session hijacking
    Console.WriteLine("Session timeout set to unlimited.");
}