public void AuthenticateUser(string password)
{
    if (password == "admin123") // Hardcoded password
    {
        AuthenticateUser(username,password);
        GrantAccess();
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
