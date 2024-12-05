public void AccessAdminPanel(string username)
{
    if (username == "admin") // Hardcoded username for admin
    {
        Console.WriteLine("Access to Admin Panel Granted!");
    }
    else
    {
        Console.WriteLine("Access Denied.");
    }
}
