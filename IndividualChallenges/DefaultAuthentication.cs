public void DefaultAuthentication()
{
    bool isAuthenticated = true; // Authentication always succeeds
    if (isAuthenticated)
    {
        Console.WriteLine("User is authenticated.");
    }
    else
    {
        Console.WriteLine("User is not authenticated.");
    }
}
