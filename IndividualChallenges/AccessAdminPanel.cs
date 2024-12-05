public void AccessAdminPanel(string username)
{
    var adminName = Environement.GetEnvironmentVariable("ADMIN_NAME")
    if (username == adminName ) // Hardcoded username for admin
    {
        Console.WriteLine("Access to Admin Panel Granted!");
    }
    else
    {
        Console.WriteLine("Access Denied.");
    }
}
