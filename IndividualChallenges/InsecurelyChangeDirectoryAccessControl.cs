public void InsecurelyChangeDirectoryAccessControl()
{
    // Insecure: Modifies directory access control without specifying secure permissions
    DirectorySecurity security = new DirectorySecurity();
    Directory.SetAccessControl("C:\\SecureFolder", security);
    Console.WriteLine("Changed access control for C:\\SecureFolder.");
}
