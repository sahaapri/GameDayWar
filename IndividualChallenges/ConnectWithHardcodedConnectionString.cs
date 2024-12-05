public void ConnectWithHardcodedConnectionString()
{
    var connectionString = "Server=myServer;User Id=admin;Password=admin123;"; // Insecure: Hardcoded credentials
    Console.WriteLine("Connecting with hardcoded connection string.");

    // Simulate database connection
    Console.WriteLine("Connected to database using: " + connectionString);
}
