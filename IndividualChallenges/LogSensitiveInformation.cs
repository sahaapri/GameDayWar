public void LogSensitiveInformation(string username)
{
    try
    {
        AuthenticateUser(username);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Login failed for user " + username); // Reveals username in logs
    }
}

private void AuthenticateUser(string username)
{
    throw new UnauthorizedAccessException("Invalid credentials");
}
