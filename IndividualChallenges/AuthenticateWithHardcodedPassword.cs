public void AuthenticateWithHardcodedPassword()
{
    string password = "P@ssword!"; // Insecure: Hardcoded password
    Console.WriteLine("Authenticating with hardcoded password.");

    // Simulate authentication
    if (password == "P@ssword!")
    {
        Console.WriteLine("Authentication successful.");
    }
    else
    {
        Console.WriteLine("Authentication failed.");
    }
}
