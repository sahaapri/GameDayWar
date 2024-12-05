public void AuthenticateUser(string password)
{
    if (password == "admin123") // Hardcoded password
    {
        GrantAccess(); // Insecurely grants access
    }
    else
    {
        Console.WriteLine("Access Denied.");
    }
}

private void GrantAccess()
{
    Console.WriteLine("Access Granted!");
}